const router = require("express").Router();
const name_pattern = /[A-őA-Ő0-9:,'.-\s]*[^\\|€÷×\[\]ł$¤<ˇ^˘°˛~>#&@{}();?_*+/]/; //kicsit lehet szigorú regex
const Movie = require("../models/movie.model");
const request = require("request");

router.route("/").get((req, res) => {
  Movie.find((err, result) => {
    if (err) {
      console.log(`Error1: ${err}`);
      return;
    }

    if (result == " ") {
      res.json({ success: false, message: "üres lista" });
    } else {
      res.json({ success: true, movies: result });
    }
  });
});

router.route("/:id").get((req, res) => {
  Movie.findById(req.params.id)
    .then(Movies => res.json(Movies))
    .catch(err => res.status(400).json(`Error: ${err}`));
});
router.route("/delete/:id").post((req, res) => {
  request.post(
    "http://localhost:5000/users/verify",
    {
      json: {
        username: req.body.Username
      }
    },
    (err, req_res) => {
      if (err) {
        console.log(`Error1: ${err}`);
        return;
      }

      if (req_res.body.success) {
        const id = req.params.id;
        Movie.find({ id: id }, (err_, doc1) => {
          if (err_) {
            console.log(`Error_: ${err_}`);
            return;
          }
          if (doc1 !=" ") {
            Movie.deleteOne({ id: id }, (err2, dinfo) => {
              if (err2) {
                console.log(`Error1: ${err2}`);
                return;
              }
              res.json({
                success: true,
                message: `The Movie Deleted!`
              });
              return;
            });
          } else {
            res.json({
              success: false,
              message: `The Movie doesn't exist!`
            });
            return;
          }
        });
      } else {
        res.json({
          success: false,
          message: `You have no access to this operation!`
        });
      }
    }
  );
});

router.route("/update").post((req, res) => {
  request.post(
    "http://localhost:5000/users/verify",
    {
      json: {
        username: req.body.Username
      }
    },
    (err_, req_res) => {
      if (err_) {
        console.log(`Error_: ${err_}`);
      }
      if (req_res.body.success) {
        let id = req.body.Id;
        let title = req.body.Name;
        let imdb = parseFloat(req.body.Imdb_points);
        let rdate = new Date(req.body.Creation_date);
        let mlength = parseInt(req.body.Length_in_minutes);
        let director = req.body.Director;
        let writer = req.body.Writer;
        let stars = req.body.Stars.trim();

        Movie.find({ id: id }, (err, doc1) => {
          if (err) {
            console.log(`Error1: ${err}`);
            return;
          }
          if (doc1 == " ") {
            res.json({
              success: false,
              message: "Movie doesn't exists!"
            });
            return;
          } else {
            // regex alapján kigyűjteni a megadott stringből azt amit el kell fogadni.

            let title_regexing = title.match(name_pattern).map(c => c.trim());
            title_regexing.map(a =>
              a == ""
                ? title_regexing.splice(title_regexing.indexOf(a), 1)
                : a.trim()
            );

            if (title_regexing.length < 1) {
              res.json({
                success: false,
                message:
                  "Title must be at least 1 chachter excluding special ones!"
              });
              return;
            }

            if (imdb < 0 || imdb > 10) {
              res.json({
                success: false,
                message: "IMDB Score closed interval: [0.0,10.0]"
              });
              return;
            }

            if (rdate.getFullYear() < 1900) {
              res.json({
                success: false,
                message: "Release date must be greater than 1899.12.31!"
              });
              return;
            }

            if (mlength < 1 || mlength > 51420) {
              //https://en.wikipedia.org/wiki/List_of_longest_films
              res.json({
                success: false,
                message:
                  "Length can't be lower than zero and there is no film which longer than 51420 minutes!"
              });
              return;
            }

            let director_regexing = director
              .match(name_pattern)
              .map(c => c.trim());
            director_regexing.map(a =>
              a == ""
                ? director_regexing.splice(director_regexing.indexOf(a), 1)
                : a.trim()
            );

            if (director_regexing < 1) {
              res.json({
                success: false,
                message: "Director is empty!"
              });
              return;
            }

            let writer_regexing = writer.match(name_pattern).map(c => c.trim());
            writer_regexing.map(a =>
              a == ""
                ? writer_regexing.splice(writer_regexing.indexOf(a), 1)
                : a.trim()
            );

            if (writer_regexing < 1) {
              res.json({
                success: false,
                message: "Writer is empty!"
              });
              return;
            }

            let stars_regexing = stars.match(name_pattern).map(c => c.trim());
            stars_regexing.map(a =>
              a == ""
                ? stars_regexing.splice(stars_regexing.indexOf(a), 1)
                : a.trim()
            );

            if (stars_regexing < 1) {
              res.json({
                success: false,
                message: "Stars is empty!"
              });
              return;
            }
            const newMovie = {
              name: title_regexing.toString(),
              creation_date: rdate,
              imdb_points: imdb,
              length_in_minutes: mlength,
              director: director_regexing.toString(),
              writer: writer_regexing.toString(),
              stars: stars_regexing.toString()
            };
            Movie.findOne({ id: id }, (err, doc1) => {
              if (err) {
                console.log(`Error1: ${err}`);
                return;
              }
              if (doc1) {
                doc1.updateOne(newMovie, (err2, mdoc) => {
                  if (err2) {
                    console.log(`Error2: ${err2}`);
                    res.json({ success: false, message: `Server Error!` });
                    return;
                  }

                  res.json({
                    success: true,
                    message: `The Movie: ${doc1.name} Updated!`
                  });
                  return;
                });
              }
            });
          }
        });
      } else {
        res.json({
          success: false,
          message: `You have no access to this operation!`
        });
      }
    }
  );
});

router.route("/add").post((req, res) => {
  request.post(
    "http://localhost:5000/users/verify",
    {
      json: {
        username: req.body.Username
      }
    },
    (err_, req_res) => {
      if (err_) {
        console.log(`Error_: ${err_}`);
      }
      if (req_res.body.success) {
        let id = req.body.Id;
        let title = req.body.Name;
        let imdb = parseFloat(req.body.Imdb_points);
        let rdate = new Date(req.body.Creation_date);
        let mlength = parseInt(req.body.Length_in_minutes);
        let director = req.body.Director;
        let writer = req.body.Writer;
        let stars = req.body.Stars.trim();

        Movie.find({ id: id }, (err, doc1) => {
          if (err) {
            console.log(`Error1: ${err}`);
            return;
          }
          if (doc1 == " ") {
            res.json({
              success: false,
              message: "Movie already exists!"
            });

            console.log(doc1);
            return false;
          } else {
            // regex alapján kigyűjteni a megadott stringből azt amit el kell fogadni.

            let title_regexing = title.match(name_pattern).map(c => c.trim());
            title_regexing.map(a =>
              a == ""
                ? title_regexing.splice(title_regexing.indexOf(a), 1)
                : a.trim()
            );

            if (title_regexing.length < 1) {
              res.json({
                success: false,
                message:
                  "Title must be at least 1 chachter excluding special ones!"
              });
              return;
            }

            if (imdb < 0 || imdb > 10) {
              res.json({
                success: false,
                message: "IMDB Score closed interval: [0.0,10.0]"
              });
              return;
            }

            if (rdate.getFullYear() < 1900) {
              res.json({
                success: false,
                message: "Release date must be greater than 1899.12.31!"
              });
              return;
            }

            if (mlength < 1 || mlength > 51420) {
              //https://en.wikipedia.org/wiki/List_of_longest_films
              res.json({
                success: false,
                message:
                  "Length can't be lower than zero and there is no film which longer than 51420 minutes!"
              });
              return;
            }

            let director_regexing = director
              .match(name_pattern)
              .map(c => c.trim());
            director_regexing.map(a =>
              a == ""
                ? director_regexing.splice(director_regexing.indexOf(a), 1)
                : a.trim()
            );

            if (director_regexing < 1) {
              res.json({
                success: false,
                message: "Director is empty!"
              });
              return;
            }

            let writer_regexing = writer.match(name_pattern).map(c => c.trim());
            writer_regexing.map(a =>
              a == ""
                ? writer_regexing.splice(writer_regexing.indexOf(a), 1)
                : a.trim()
            );

            if (writer_regexing < 1) {
              res.json({
                success: false,
                message: "Writer is empty!"
              });
              return;
            }

            let stars_regexing = stars.match(name_pattern).map(c => c.trim());
            stars_regexing.map(a =>
              a == ""
                ? stars_regexing.splice(stars_regexing.indexOf(a), 1)
                : a.trim()
            );

            if (stars_regexing < 1) {
              res.json({
                success: false,
                message: "Stars is empty!"
              });
              return;
            }
            const newMovie = new Movie({
              id: id,
              name: title_regexing.toString(),
              creation_date: rdate,
              imdb_points: imdb,
              length_in_minutes: mlength,
              director: director_regexing.toString(),
              writer: writer_regexing.toString(),
              stars: stars_regexing.toString()
            });

            newMovie.save((err2, mdoc) => {
              if (err2) {
                console.log(`Error2: ${err2}`);
                res.json({ success: false, message: `Server Error!` });
                return;
              }

              res.json({
                success: true,
                message: `The Movie: ${mdoc.name} Inserted!`
              });
              return;
            });
          }
        });
      } else {
        res.json({
          success: false,
          message: `You have no access to this operation!`
        });
      }
    }
  );
});
module.exports = router;

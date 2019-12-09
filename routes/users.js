const router = require("express").Router();
const bcrypt = require("bcrypt");

const salt = 10;

const User = require("../models/user.model");

router.route("/").get((req, res) => {
  User.find()
    .then(Users => res.json(Users))
    .catch(err => res.status(400).json(`Error: ${err}`));
});

router.route("/add").post((req, res) => {
  let username = req.body.Username;
  let password = req.body.Password;
  let regdate = Date.now();
  let lastlogin = Date.now();
  let level = 0;

  /**
   *
   * Level:
   *  1 - Admin
   *  0 - Normal
   */
  User.exists({ username: username }, async (err, doc) => {
    if (err) {
      console.log(`Error1: ${err}`);
      return;
    }
    if (doc) {
      res.json({
        success: false,
        message: "User already exists!"
      });
      return;
    }
  });
  if (username.length < 4) {
    res.json({
      success: false,
      message: "Username length minimum 4 charachters!"
    });
    return;
  }
  if (password.length === 0) {
    res.json({
      success: false,
      message: "Password length must be greater than 0!"
    });
    return;
  }

  bcrypt.genSalt(salt, async (err, gotSalt) => {
    if (err) {
      console.log(`Error2: ${err}`);
      return;
    }
    await bcrypt.hash(password, gotSalt, async (err2, hash) => {
      if (err2) {
        console.log(`Error3: ${err2}`);
        return;
      }
      let pw = await hash;
      const newUser = new User({
        username: username,
        password: pw,
        regdate: regdate,
        lastlogin: regdate
      });
      newUser.save((err3, result) => {
        if (err3) {
          console.log(`Error4: ${err3}`);
          return;
        }
        res.json({
          success: true,
          message: `${result.username} successfully registered!`
        });
      });
    });
  });
});

router.route("/login").post((req, res) => {
  let username = req.body.Username;
  let password = req.body.Password;
  let lastlogin = Date.now();
  if (username.length < 4) {
    res.json({
      success: false,
      message: "Username length minimum 4 charachters!"
    });
    return;
  }
  if (password.length === 0) {
    res.json({
      success: false,
      message: "Password length must be greater than 0!"
    });
    return;
  }
  User.findOne({ username: username }, (err2, result) => {
    if (err2) {
      console.log(`Error: ${err2}`);
      return;
    }
    if (result === null) {
      res.json({
        success: false,
        message: "User doesn't exist!"
      });
      return;
    }
    bcrypt.compare(password, result.password, (err3, bcrypt_doc) => {
      if (err3) {
        console.log(`Error: ${err3}`);
        return;
      }
      if (bcrypt_doc) {
        result.updateOne(
          {
            lastlogin: lastlogin
          },
          (err5, update_doc) => {
            if (err5) {
              console.log(`Error: ${err5}`);
              return;
            }
            res.json({
              success: true,
              message: "Successfully logged in!",
              username: result.username
            });
          }
        );
      } else {
        res.json({
          success: false,
          message: "Wrong credentials!"
        });
      }
    });
  });
});

router.route("/verify").post((req, res) => {
  const username = req.body.username;
  User.findOne({ username: username }, async (err, findone_doc) => {
    if (err) {
      console.log(`Error: ${err}`);
      return;
    }
    if (findone_doc === null) {
      res.json({
        success: false,
        message: "Server error1!"
      });
      return;
    }

    const userLevel = await findone_doc.level;

    if (userLevel == 1) {
      res.json({
        success: true,
        level: userLevel
      });
      return;
    } else {
      res.json({
        success: faslse,
        message: "You don't have permission!"
      });
      return;
    }
  });
});
module.exports = router;

namespace Movies
{
    partial class Movie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.creationdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.imdb = new System.Windows.Forms.NumericUpDown();
            this.length = new System.Windows.Forms.NumericUpDown();
            this.director = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.writer = new System.Windows.Forms.TextBox();
            this.stars = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.modosit = new System.Windows.Forms.Button();
            this.felvisz = new System.Windows.Forms.Button();
            this.torol = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.listaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.label1.Location = new System.Drawing.Point(231, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(88, 256);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(200, 20);
            this.title.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "IMDb";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Release date";
            // 
            // creationdate
            // 
            this.creationdate.Location = new System.Drawing.Point(88, 338);
            this.creationdate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.creationdate.MinDate = new System.DateTime(1899, 12, 31, 0, 0, 0, 0);
            this.creationdate.Name = "creationdate";
            this.creationdate.Size = new System.Drawing.Size(200, 20);
            this.creationdate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Director";
            // 
            // imdb
            // 
            this.imdb.Location = new System.Drawing.Point(88, 311);
            this.imdb.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.imdb.Name = "imdb";
            this.imdb.Size = new System.Drawing.Size(200, 20);
            this.imdb.TabIndex = 11;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(88, 282);
            this.length.Maximum = new decimal(new int[] {
            51420,
            0,
            0,
            0});
            this.length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(200, 20);
            this.length.TabIndex = 12;
            this.length.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // director
            // 
            this.director.Location = new System.Drawing.Point(88, 365);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(200, 20);
            this.director.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Writer";
            // 
            // writer
            // 
            this.writer.Location = new System.Drawing.Point(88, 391);
            this.writer.Name = "writer";
            this.writer.Size = new System.Drawing.Size(200, 20);
            this.writer.TabIndex = 15;
            // 
            // stars
            // 
            this.stars.Location = new System.Drawing.Point(88, 418);
            this.stars.Name = "stars";
            this.stars.Size = new System.Drawing.Size(200, 20);
            this.stars.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Stars";
            // 
            // modosit
            // 
            this.modosit.Location = new System.Drawing.Point(425, 263);
            this.modosit.Name = "modosit";
            this.modosit.Size = new System.Drawing.Size(75, 23);
            this.modosit.TabIndex = 18;
            this.modosit.Text = "Módosít";
            this.modosit.UseVisualStyleBackColor = true;
            this.modosit.Click += new System.EventHandler(this.modosit_Click);
            // 
            // felvisz
            // 
            this.felvisz.Location = new System.Drawing.Point(425, 233);
            this.felvisz.Name = "felvisz";
            this.felvisz.Size = new System.Drawing.Size(75, 23);
            this.felvisz.TabIndex = 19;
            this.felvisz.Text = "Felvisz";
            this.felvisz.UseVisualStyleBackColor = true;
            this.felvisz.Click += new System.EventHandler(this.felvisz_Click);
            // 
            // torol
            // 
            this.torol.Location = new System.Drawing.Point(425, 292);
            this.torol.Name = "torol";
            this.torol.Size = new System.Drawing.Size(75, 23);
            this.torol.TabIndex = 20;
            this.torol.Text = "Töröl";
            this.torol.UseVisualStyleBackColor = true;
            this.torol.Click += new System.EventHandler(this.torol_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(12, 68);
            this.lista.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(537, 134);
            this.lista.TabIndex = 21;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(88, 230);
            this.id.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.id.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(200, 20);
            this.id.TabIndex = 22;
            this.id.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "ID";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(331, 345);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 13);
            this.info.TabIndex = 24;
            // 
            // listaz
            // 
            this.listaz.Location = new System.Drawing.Point(425, 322);
            this.listaz.Name = "listaz";
            this.listaz.Size = new System.Drawing.Size(75, 23);
            this.listaz.TabIndex = 25;
            this.listaz.Text = "Lista";
            this.listaz.UseVisualStyleBackColor = true;
            this.listaz.Click += new System.EventHandler(this.listaz_Click);
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.listaz);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.id);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.torol);
            this.Controls.Add(this.felvisz);
            this.Controls.Add(this.modosit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stars);
            this.Controls.Add(this.writer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.director);
            this.Controls.Add(this.length);
            this.Controls.Add(this.imdb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.creationdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Movie";
            this.Text = "Movie";
            ((System.ComponentModel.ISupportInitialize)(this.imdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker creationdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown imdb;
        private System.Windows.Forms.NumericUpDown length;
        private System.Windows.Forms.TextBox director;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox writer;
        private System.Windows.Forms.TextBox stars;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button modosit;
        private System.Windows.Forms.Button felvisz;
        private System.Windows.Forms.Button torol;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.NumericUpDown id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button listaz;
    }
}
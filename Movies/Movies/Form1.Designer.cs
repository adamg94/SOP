namespace Movies
{
    partial class Form1
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
            this.felhNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jelszo = new System.Windows.Forms.TextBox();
            this.belepes = new System.Windows.Forms.Button();
            this.regisztracio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(76, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Belépés";
            // 
            // felhNev
            // 
            this.felhNev.Location = new System.Drawing.Point(12, 170);
            this.felhNev.Name = "felhNev";
            this.felhNev.Size = new System.Drawing.Size(207, 20);
            this.felhNev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Felhasználónév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.label3.Location = new System.Drawing.Point(12, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jelszó:";
            // 
            // jelszo
            // 
            this.jelszo.Location = new System.Drawing.Point(12, 253);
            this.jelszo.Name = "jelszo";
            this.jelszo.PasswordChar = '¤';
            this.jelszo.Size = new System.Drawing.Size(207, 20);
            this.jelszo.TabIndex = 4;
            // 
            // belepes
            // 
            this.belepes.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.belepes.Location = new System.Drawing.Point(12, 291);
            this.belepes.Name = "belepes";
            this.belepes.Size = new System.Drawing.Size(203, 28);
            this.belepes.TabIndex = 5;
            this.belepes.Text = "Belépés";
            this.belepes.UseVisualStyleBackColor = true;
            this.belepes.Click += new System.EventHandler(this.belepes_Click);
            // 
            // regisztracio
            // 
            this.regisztracio.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.regisztracio.Location = new System.Drawing.Point(12, 409);
            this.regisztracio.Name = "regisztracio";
            this.regisztracio.Size = new System.Drawing.Size(203, 29);
            this.regisztracio.TabIndex = 6;
            this.regisztracio.Text = "Regisztráció";
            this.regisztracio.UseVisualStyleBackColor = true;
            this.regisztracio.Click += new System.EventHandler(this.regisztracio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.regisztracio);
            this.Controls.Add(this.belepes);
            this.Controls.Add(this.jelszo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.felhNev);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Belépés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox felhNev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jelszo;
        private System.Windows.Forms.Button belepes;
        private System.Windows.Forms.Button regisztracio;
        private System.Windows.Forms.Label label4;
    }
}


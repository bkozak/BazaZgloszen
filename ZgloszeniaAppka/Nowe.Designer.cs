namespace ZgloszeniaAppka
{
    partial class Nowe
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
            this.tytul_btn = new System.Windows.Forms.TextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.opis_btn = new System.Windows.Forms.TextBox();
            this.uzytkownik_btn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tytul_btn
            // 
            this.tytul_btn.Location = new System.Drawing.Point(85, 12);
            this.tytul_btn.Name = "tytul_btn";
            this.tytul_btn.Size = new System.Drawing.Size(175, 20);
            this.tytul_btn.TabIndex = 0;
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(298, 12);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 73);
            this.ok_btn.TabIndex = 1;
            this.ok_btn.Text = "button1";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // opis_btn
            // 
            this.opis_btn.Location = new System.Drawing.Point(85, 38);
            this.opis_btn.Multiline = true;
            this.opis_btn.Name = "opis_btn";
            this.opis_btn.Size = new System.Drawing.Size(175, 74);
            this.opis_btn.TabIndex = 2;
            // 
            // uzytkownik_btn
            // 
            this.uzytkownik_btn.Location = new System.Drawing.Point(85, 118);
            this.uzytkownik_btn.Name = "uzytkownik_btn";
            this.uzytkownik_btn.Size = new System.Drawing.Size(175, 20);
            this.uzytkownik_btn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tytuł";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Opis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Użytkownik";
            // 
            // Nowe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 151);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uzytkownik_btn);
            this.Controls.Add(this.opis_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.tytul_btn);
            this.Name = "Nowe";
            this.Text = "Nowe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tytul_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.TextBox opis_btn;
        private System.Windows.Forms.TextBox uzytkownik_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
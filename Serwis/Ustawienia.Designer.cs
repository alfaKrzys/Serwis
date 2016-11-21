namespace Serwis
{
    partial class Ustawienia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ustawienia));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_host = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nazwaBazy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_haslo = new System.Windows.Forms.TextBox();
            this.b_Zapisz = new System.Windows.Forms.Button();
            this.b_Testuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Host:";
            // 
            // tb_host
            // 
            this.tb_host.Location = new System.Drawing.Point(50, 12);
            this.tb_host.Name = "tb_host";
            this.tb_host.Size = new System.Drawing.Size(135, 20);
            this.tb_host.TabIndex = 0;
            this.tb_host.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_host_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Naza bazy:";
            // 
            // tb_nazwaBazy
            // 
            this.tb_nazwaBazy.Location = new System.Drawing.Point(258, 12);
            this.tb_nazwaBazy.Name = "tb_nazwaBazy";
            this.tb_nazwaBazy.Size = new System.Drawing.Size(135, 20);
            this.tb_nazwaBazy.TabIndex = 1;
            this.tb_nazwaBazy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_host_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Login:";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(50, 38);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(135, 20);
            this.tb_login.TabIndex = 2;
            this.tb_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_host_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hasło:";
            // 
            // tb_haslo
            // 
            this.tb_haslo.Location = new System.Drawing.Point(258, 38);
            this.tb_haslo.Name = "tb_haslo";
            this.tb_haslo.PasswordChar = '·';
            this.tb_haslo.Size = new System.Drawing.Size(135, 20);
            this.tb_haslo.TabIndex = 3;
            this.tb_haslo.UseSystemPasswordChar = true;
            this.tb_haslo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_host_KeyDown);
            // 
            // b_Zapisz
            // 
            this.b_Zapisz.Location = new System.Drawing.Point(316, 65);
            this.b_Zapisz.Name = "b_Zapisz";
            this.b_Zapisz.Size = new System.Drawing.Size(75, 23);
            this.b_Zapisz.TabIndex = 5;
            this.b_Zapisz.Text = "Zapisz";
            this.b_Zapisz.UseVisualStyleBackColor = true;
            this.b_Zapisz.Click += new System.EventHandler(this.b_Zapisz_Click);
            // 
            // b_Testuj
            // 
            this.b_Testuj.Location = new System.Drawing.Point(235, 65);
            this.b_Testuj.Name = "b_Testuj";
            this.b_Testuj.Size = new System.Drawing.Size(75, 23);
            this.b_Testuj.TabIndex = 4;
            this.b_Testuj.Text = "Testuj";
            this.b_Testuj.UseVisualStyleBackColor = true;
            this.b_Testuj.Click += new System.EventHandler(this.b_Testuj_Click);
            // 
            // Ustawienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 102);
            this.Controls.Add(this.b_Testuj);
            this.Controls.Add(this.b_Zapisz);
            this.Controls.Add(this.tb_haslo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nazwaBazy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_host);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(419, 140);
            this.MinimumSize = new System.Drawing.Size(419, 140);
            this.Name = "Ustawienia";
            this.ShowInTaskbar = false;
            this.Text = "Ustawienia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ustawienia_FormClosed);
            this.Load += new System.EventHandler(this.Ustawienia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_host;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nazwaBazy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_haslo;
        private System.Windows.Forms.Button b_Zapisz;
        private System.Windows.Forms.Button b_Testuj;
    }
}
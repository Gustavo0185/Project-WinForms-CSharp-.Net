namespace PayrollTech
{
    partial class frmLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLimparLogin = new System.Windows.Forms.Button();
            this.btCadastre = new System.Windows.Forms.Button();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.btEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PayrollTech.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 512);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btLimparLogin
            // 
            this.btLimparLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btLimparLogin.Location = new System.Drawing.Point(277, 374);
            this.btLimparLogin.Name = "btLimparLogin";
            this.btLimparLogin.Size = new System.Drawing.Size(107, 32);
            this.btLimparLogin.TabIndex = 15;
            this.btLimparLogin.Text = "Limpar";
            this.btLimparLogin.UseVisualStyleBackColor = false;
            this.btLimparLogin.Click += new System.EventHandler(this.btLimparLogin_Click);
            // 
            // btCadastre
            // 
            this.btCadastre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCadastre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btCadastre.Location = new System.Drawing.Point(205, 412);
            this.btCadastre.Name = "btCadastre";
            this.btCadastre.Size = new System.Drawing.Size(117, 39);
            this.btCadastre.TabIndex = 14;
            this.btCadastre.Text = "Cadasre-se";
            this.btCadastre.UseVisualStyleBackColor = false;
            this.btCadastre.Click += new System.EventHandler(this.btCadastre_Click);
            // 
            // tbSenha
            // 
            this.tbSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSenha.Location = new System.Drawing.Point(147, 325);
            this.tbSenha.Multiline = true;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(237, 28);
            this.tbSenha.TabIndex = 13;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(45, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(45, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Usuario:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(147, 276);
            this.tbUsuario.Multiline = true;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(237, 28);
            this.tbUsuario.TabIndex = 10;
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btEntrar.Location = new System.Drawing.Point(147, 374);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(107, 32);
            this.btEntrar.TabIndex = 9;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(215, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Login";
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(498, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLimparLogin);
            this.Controls.Add(this.btCadastre);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btLimparLogin;
        private System.Windows.Forms.Button btCadastre;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Label label1;
    }
}
namespace PayrollTech
{
    partial class frmLoginCadastro
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
            this.btVoltarL = new System.Windows.Forms.Button();
            this.tbSenhaC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsuarioC = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PayrollTech.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 512);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btVoltarL
            // 
            this.btVoltarL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btVoltarL.Location = new System.Drawing.Point(366, 441);
            this.btVoltarL.Name = "btVoltarL";
            this.btVoltarL.Size = new System.Drawing.Size(107, 30);
            this.btVoltarL.TabIndex = 19;
            this.btVoltarL.Text = "Voltar";
            this.btVoltarL.UseVisualStyleBackColor = false;
            this.btVoltarL.Click += new System.EventHandler(this.btVoltarL_Click);
            // 
            // tbSenhaC
            // 
            this.tbSenhaC.Location = new System.Drawing.Point(136, 356);
            this.tbSenhaC.Multiline = true;
            this.tbSenhaC.Name = "tbSenhaC";
            this.tbSenhaC.Size = new System.Drawing.Size(244, 26);
            this.tbSenhaC.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(46, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(46, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(146, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cadastre-se";
            // 
            // tbUsuarioC
            // 
            this.tbUsuarioC.Location = new System.Drawing.Point(136, 294);
            this.tbUsuarioC.Multiline = true;
            this.tbUsuarioC.Name = "tbUsuarioC";
            this.tbUsuarioC.Size = new System.Drawing.Size(244, 26);
            this.tbUsuarioC.TabIndex = 14;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btCadastrar.Location = new System.Drawing.Point(196, 401);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(119, 35);
            this.btCadastrar.TabIndex = 13;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // frmLoginCadastro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(497, 497);
            this.Controls.Add(this.btVoltarL);
            this.Controls.Add(this.tbSenhaC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUsuarioC);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmLoginCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoginCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btVoltarL;
        private System.Windows.Forms.TextBox tbSenhaC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsuarioC;
        private System.Windows.Forms.Button btCadastrar;
    }
}
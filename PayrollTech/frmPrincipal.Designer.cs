namespace PayrollTech
{
    partial class frmPrincipal
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
            this.cbC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cbFunc = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodigoP = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folha De Pagamento";
            // 
            // cbC
            // 
            this.cbC.DisplayMember = "Cargo";
            this.cbC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbC.FormattingEnabled = true;
            this.cbC.Location = new System.Drawing.Point(129, 154);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(172, 21);
            this.cbC.TabIndex = 3;
            this.cbC.ValueMember = "Salario";
            this.cbC.SelectedIndexChanged += new System.EventHandler(this.cbC_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Funcionario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Horas extras:";
            // 
            // tbHE
            // 
            this.tbHE.Location = new System.Drawing.Point(193, 193);
            this.tbHE.Name = "tbHE";
            this.tbHE.Size = new System.Drawing.Size(242, 20);
            this.tbHE.TabIndex = 9;
            this.tbHE.TextChanged += new System.EventHandler(this.tbHE_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Extrato";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "Adicionar Novo Cargo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(264, 391);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 27);
            this.button4.TabIndex = 15;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbFunc
            // 
            this.cbFunc.BackColor = System.Drawing.SystemColors.Window;
            this.cbFunc.DisplayMember = "Nome";
            this.cbFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFunc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFunc.FormattingEnabled = true;
            this.cbFunc.Location = new System.Drawing.Point(193, 116);
            this.cbFunc.Name = "cbFunc";
            this.cbFunc.Size = new System.Drawing.Size(205, 21);
            this.cbFunc.TabIndex = 16;
            this.cbFunc.ValueMember = "Nome";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(249, 276);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 35);
            this.button5.TabIndex = 17;
            this.button5.Text = "Cadastrar Novo Funcionario";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Codigo Extrato:";
            // 
            // tbCodigoP
            // 
            this.tbCodigoP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbCodigoP.Enabled = false;
            this.tbCodigoP.Location = new System.Drawing.Point(213, 80);
            this.tbCodigoP.Name = "tbCodigoP";
            this.tbCodigoP.Size = new System.Drawing.Size(185, 20);
            this.tbCodigoP.TabIndex = 19;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(249, 235);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(158, 35);
            this.btPesquisar.TabIndex = 20;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PayrollTech.Properties.Resources.Design_sem_nome__5_;
            this.pictureBox1.Location = new System.Drawing.Point(-643, -312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1367, 768);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(653, 456);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbCodigoP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cbFunc);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbHE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cbFunc;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodigoP;
        private System.Windows.Forms.Button btPesquisar;
    }
}
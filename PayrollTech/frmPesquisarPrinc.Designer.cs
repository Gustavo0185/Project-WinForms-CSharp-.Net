namespace PayrollTech
{
    partial class frmPesquisarPrinc
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgEx = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlHr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgEx
            // 
            this.dgEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Cargo,
            this.SalaB,
            this.VlHr,
            this.ImpR,
            this.Inss,
            this.SalaL});
            this.dgEx.Location = new System.Drawing.Point(28, 35);
            this.dgEx.Name = "dgEx";
            this.dgEx.Size = new System.Drawing.Size(605, 150);
            this.dgEx.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PayrollTech.Properties.Resources.Design_sem_nome__5_;
            this.pictureBox1.Location = new System.Drawing.Point(-642, -311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1367, 768);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            // 
            // SalaB
            // 
            this.SalaB.DataPropertyName = "SalaB";
            this.SalaB.HeaderText = "Salario Bruto";
            this.SalaB.Name = "SalaB";
            // 
            // VlHr
            // 
            this.VlHr.DataPropertyName = "VlHr";
            this.VlHr.HeaderText = "Vl Hora Extra";
            this.VlHr.Name = "VlHr";
            // 
            // ImpR
            // 
            this.ImpR.DataPropertyName = "ImpR";
            this.ImpR.HeaderText = "Desc Imposto de Renda";
            this.ImpR.Name = "ImpR";
            // 
            // Inss
            // 
            this.Inss.DataPropertyName = "Inss";
            this.Inss.HeaderText = "Desconto INSS";
            this.Inss.Name = "Inss";
            // 
            // SalaL
            // 
            this.SalaL.DataPropertyName = "SalaL";
            this.SalaL.HeaderText = "Salario Liquido";
            this.SalaL.Name = "SalaL";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmPesquisarPrinc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(652, 456);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgEx);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmPesquisarPrinc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPesquisarPrinc";
            this.Load += new System.EventHandler(this.frmPesquisarPrinc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgEx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaB;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlHr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inss;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaL;
        private System.Windows.Forms.Button button3;
    }
}
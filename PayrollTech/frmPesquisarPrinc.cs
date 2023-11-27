using cldal;
using clmodel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollTech
{
    public partial class frmPesquisarPrinc : Form
    {
        public frmPesquisarPrinc()
        {
            InitializeComponent();
        }

        public ExtratoModel Ex;
        public ExtratoDal ExDal;

        private void carregarGrid()
        {
            dgEx.DataSource = ExDal.listarTodosArray();
        }

        private void selecionarItem()
        {
            int i = 0;

            i = dgEx.CurrentRow.Index;
            Ex.Codigo = int.Parse(dgEx[0, i].Value.ToString());
            Ex.Nome = dgEx[1, i].Value.ToString();
            Ex.Cargo = dgEx[2, i].Value.ToString();
            Ex.SalaB = decimal.Parse(dgEx[3, i].Value.ToString());
            Ex.VlHr = decimal.Parse(dgEx[4, i].Value.ToString());
            Ex.ImpR = decimal.Parse(dgEx[5, i].Value.ToString());
            Ex.Inss = decimal.Parse(dgEx[6, i].Value.ToString());
            Ex.SalaL = decimal.Parse(dgEx[7, i].Value.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.selecionarItem();
            this.Close();
        }

        private void frmPesquisarPrinc_Load(object sender, EventArgs e)
        {
            this.Ex = new ExtratoModel();
            this.ExDal = new ExtratoDal();
            this.carregarGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Ex.Codigo = 0;
            this.Close();
        }
    }
}

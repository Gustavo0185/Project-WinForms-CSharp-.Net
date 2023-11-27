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
    public partial class frmCargoPesquisar : Form
    {
        public frmCargoPesquisar()
        {
            InitializeComponent();
        }

        public CargoModel C;
        public CargoDal CDal;

        private void carregarGrid()
        {
            dgCargo.DataSource = CDal.listarTodosArray();
        }

        private void selecionarItem()
        {
            int i = 0;

            i = dgCargo.CurrentRow.Index;
            C.Codigo = int.Parse(dgCargo[0, i].Value.ToString());
            C.Cargo = dgCargo[1, i].Value.ToString();
            C.Salario = decimal.Parse(dgCargo[2, i].Value.ToString());

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.selecionarItem();
            this.Close();
        }

        private void frmCargoPesquisar_Load(object sender, EventArgs e)
        {
            this.C = new CargoModel();
            this.CDal = new CargoDal();
            this.carregarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.C.Codigo = 0;
            this.Close();
        }
    }
}

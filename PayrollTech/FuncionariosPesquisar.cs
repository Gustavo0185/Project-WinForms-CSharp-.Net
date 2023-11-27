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
    public partial class FuncionariosPesquisar : Form
    {
        public FuncionariosPesquisar()
        {
            InitializeComponent();
        }

        public FuncionariosModel Func;
        public FuncionarioDal FuncDal;

        private void carregarGrid()
        {
            dgFun.DataSource = FuncDal.listarTodosArray();
        }

        private void selecionarItem()
        {
            int i = 0;

            i = dgFun.CurrentRow.Index;
            Func.Codigo = int.Parse(dgFun[0, i].Value.ToString());
            Func.Nome = dgFun[1, i].Value.ToString();
            Func.Idade = int.Parse(dgFun[2, i].Value.ToString());
            Func.Cpf = long.Parse(dgFun[3, i].Value.ToString());
            Func.Pis = long.Parse(dgFun[4, i].Value.ToString());
            Func.Sexo = dgFun[5, i].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.selecionarItem();
            this.Close();
        }

        private void FuncionariosPesquisar_Load(object sender, EventArgs e)
        {
            this.Func = new FuncionariosModel();
            this.FuncDal = new FuncionarioDal();
            this.carregarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Func.Codigo = 0;
            this.Close();
        }

        private void dgFun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

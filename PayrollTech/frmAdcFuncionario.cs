using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using clmodel;
using cldal;

namespace PayrollTech
{
    public partial class frmAdcFuncionario : Form
    {
        public frmAdcFuncionario()
        {
            InitializeComponent();
        }

        public FuncionariosModel Func;
        public FuncionarioDal FuncDal;

        private void LimparTela()
        {
            tbNomeFun.Clear();
            tbIdadeFun.Clear();
            tbCpf.Clear();
            tbPis.Clear();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncionariosModel Fun = new FuncionariosModel();
            FuncionarioDal FunDal = new FuncionarioDal();

            try
            {
                if (string.IsNullOrWhiteSpace(tbNomeFun.Text))
                {
                    MessageBox.Show("Os campos não podem estar em branco.");
                }
                else
                {
                    Fun.Codigo = 0;
                    Fun.Nome = tbNomeFun.Text.Trim();
                    Fun.Idade = int.Parse(tbIdadeFun.Text.Trim());
                    Fun.Cpf = long.Parse(tbCpf.Text.Trim());
                    Fun.Pis = long.Parse(tbPis.Text.Trim());
                    Fun.Sexo = cbSexo.Text.Trim();

                    FunDal.inserir(Fun);
                    MessageBox.Show("Registro inserido com sucesso!");
                    LimparTela();
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FuncionarioDal FunDal = new FuncionarioDal();


            try
            {
                if (tbCodigo.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Selecione um registro para ser removido!");
                }
                else
                {
                    FunDal.excluir(int.Parse(tbCodigo.Text.Trim()));
                    MessageBox.Show("Registro Excluido com sucesso!");
                    LimparTela();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            FuncionariosPesquisar frm2 = new FuncionariosPesquisar();
            frm2.ShowDialog();

            if (frm2.Func.Codigo > 0)
            {
                tbCodigo.Text = frm2.Func.Codigo.ToString();
                tbNomeFun.Text = frm2.Func.Codigo.ToString();
                tbIdadeFun.Text = frm2.Func.Idade.ToString();
                tbCpf.Text = frm2.Func.Cpf.ToString();
                tbPis.Text = frm2.Func.Pis.ToString();
                cbSexo.Text = frm2.Func.Sexo.ToString();


            }
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbPis_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIdadeFun_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNomeFun_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
            
        }
    }
}

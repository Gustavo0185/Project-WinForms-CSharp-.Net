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
    public partial class frmAdcCargo : Form
    {
        public frmAdcCargo()
        {
            InitializeComponent();
        }

        private void LimparTela()
        {
            tbNome.Clear();
            tbSalario.Clear();
            tbCodigo.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargoModel Car = new CargoModel();
            CargoDal CarDal = new CargoDal();

            try
            {

                Car.Codigo = 0;
                Car.Cargo = tbNome.Text.Trim();
                Car.Salario = decimal.Parse(tbSalario.Text.Trim());

                CarDal.inserir(Car);
                MessageBox.Show("Registro inserido com sucesso!");
                LimparTela();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargoDal CDal = new CargoDal();


            try
            {
                if (tbCodigo.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Selecione um registro para ser removido!");
                }
                else
                {
                    CDal.excluir(int.Parse(tbCodigo.Text.Trim()));
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
            frmCargoPesquisar frm4= new frmCargoPesquisar();
            frm4.ShowDialog();

            if (frm4.C.Codigo > 0)
            {
                tbCodigo.Text = frm4.C.Codigo.ToString();
                tbNome.Text = frm4.C.Cargo.ToString();
                tbSalario.Text = frm4.C.Salario.ToString();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
            
        }
    }
}

using cldal;
using clmodel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PayrollTech
{


    public partial class frmPrincipal : Form
    {

       

        private FuncionarioDal FunDal;
        private CargoDal CDal;

        private void carregarCombos()
        {
            cbFunc.DataSource = FunDal.listarTodosArray();
            cbC.DataSource = CDal.listarTodosArray();
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Descontos()
        {
         


        }


       

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAdcFuncionario frm = new frmAdcFuncionario();          
            frm.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAdcCargo frm1 = new frmAdcCargo();
            frm1.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string NomeF = cbFunc.SelectedValue.ToString();
            string SalaF = cbC.SelectedValue.ToString();
            string Cargo = cbC.Text;
            if (string.IsNullOrEmpty(tbHE.Text))
            {

                MessageBox.Show("Preencha os campos vazios antes de continuar.");
            }
            else
            {
                double Vdia = int.Parse(SalaF) / 30;

                double VLHora = Vdia / 8;

                double VHE = VLHora * 1.50;

                double HE = VHE * double.Parse(tbHE.Text);

                double SalaB = double.Parse(SalaF) + HE;

                double salarioBruto = SalaB;

                double impostoRenda = CalcularImpostoRenda(salarioBruto);

                double descontoINSS = CalcularDescontoINSS(salarioBruto);

                double SalaLiq = SalaB - (impostoRenda + descontoINSS);

                DialogResult resultado = MessageBox.Show($"Nome: {NomeF:C}\n\nCargo: {Cargo:C}\n\nSalario Bruto: {SalaB:C}\n\nValor Horas Extras: {HE:C}\n\nImposto de Renda: {impostoRenda:C}\n\nDesconto INSS: {descontoINSS:C}\n\nSalario Liquido: {SalaLiq:C}\n\n\n Clique em OK para Salvar \n Clique em Cancel para Refazer", "Preview Extrato", MessageBoxButtons.OKCancel);

                if (resultado == DialogResult.OK)
                {
                    ExtratoModel Car = new ExtratoModel();
                    ExtratoDal CarDal = new ExtratoDal();

                    try
                    {

                        Car.Codigo = 0;
                        Car.Nome = cbFunc.Text;
                        Car.Cargo = cbC.Text;
                        Car.SalaB = (decimal)HE;
                        Car.VlHr = (decimal)SalaB;
                        Car.ImpR= (decimal)impostoRenda;
                        Car.Inss = (decimal)descontoINSS;
                        Car.SalaL = (decimal)SalaLiq;
                        



                        CarDal.inserir(Car);
                        MessageBox.Show("Registro inserido com sucesso!");



                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                }
                else if (resultado == DialogResult.Cancel)
                {

                }



            }
        }

        private double CalcularImpostoRenda(double salarioBruto)
        {
            if (salarioBruto <= 1903.98)
                return 0.0;
            else if (salarioBruto <= 2826.65)
                return salarioBruto * 0.075;
            else if (salarioBruto <= 3751.05)
                return salarioBruto * 0.15;
            else if (salarioBruto <= 4664.68)
                return salarioBruto * 0.225;
            else
                return salarioBruto * 0.275;
        }

        private double CalcularDescontoINSS(double salarioBruto)
        {
            if (salarioBruto <= 1320.0)
                return salarioBruto * 0.075;
            else if (salarioBruto <= 2571.29)
                return salarioBruto * 0.09;
            else if (salarioBruto <= 3856.94)
                return salarioBruto * 0.12;
            else
                return salarioBruto * 0.14;
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            FunDal = new FuncionarioDal();
            CDal = new CargoDal();
            carregarCombos();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void cbC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbHE_TextChanged(object sender, EventArgs e)
        {

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarPrinc frm6 = new frmPesquisarPrinc();
            frm6.ShowDialog();
           
        }

        private void btRemover_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string NomeF = cbFunc.SelectedValue.ToString();
                string SalaF = cbC.SelectedValue.ToString();
                string Cargo = cbC.Text;
                double Vdia = int.Parse(SalaF) / 30;

                double VLHora = Vdia / 8;

                double VHE = VLHora * 1.50;

                double HE = VHE * double.Parse(tbHE.Text);

                double SalaB = double.Parse(SalaF) + HE;

                double salarioBruto = SalaB;

                double impostoRenda = CalcularImpostoRenda(salarioBruto);

                double descontoINSS = CalcularDescontoINSS(salarioBruto);

                double SalaLiq = SalaB - (impostoRenda + descontoINSS);




                StreamWriter sw = new StreamWriter("C:\\Users\\gusta\\OneDrive\\Área de Trabalho\\PayrollTech - Desktop\\Extratos\\Extrato.txt");


                sw.WriteLine("Estrato Folha de Pagamento");
                sw.WriteLine(" ");

                sw.WriteLine("Nome Do funcionario:{0}", NomeF);
                sw.WriteLine("Cargo:{0}", Cargo);
                sw.WriteLine("Salario Bruto: {0}", SalaB);
                sw.WriteLine("Valor Total Horas Extras: {0}", HE);
                sw.WriteLine("Imposto De Renda: {0}", impostoRenda);
                sw.WriteLine("Desconto INSS: {0}", descontoINSS);
                sw.WriteLine("Salario Liquido{0}", SalaLiq);
                sw.Close();

                MessageBox.Show(" Extrato Criado com Sucesso Veririque a pasta ( Extratos )");

            }
            catch
            {
                MessageBox.Show(" Exclua ou mova o extrato existente para criar um novo");
            }
        }




    }
}

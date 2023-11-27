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
    public partial class frmLoginCadastro : Form
    {
        public frmLoginCadastro()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            LoginModel login = new LoginModel();
            LoginDal loginDal = new LoginDal();

            if (string.IsNullOrEmpty(tbUsuarioC.Text))
            {
                MessageBox.Show("A caixa de texto está vazia!");
            }

            else
            {
                login.Usuario = tbUsuarioC.Text.Trim();
                login.Senha = tbSenhaC.Text.Trim();

                loginDal.inserirU(login);
                MessageBox.Show("Cadastro Feito com sucesso!");
                tbSenhaC.Clear();
                tbUsuarioC.Clear();
            }
        }

        private void btVoltarL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

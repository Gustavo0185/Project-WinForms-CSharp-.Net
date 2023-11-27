using cldal;
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
    public partial class frmLogin : Form
    {
        private LoginDal loginDal = new LoginDal();
        public string tbUsuario1;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            string usuario1 = tbUsuario.Text;
            string senha1 = tbSenha.Text;

            bool achou = loginDal.ObterUsriario(usuario1, senha1);

            if (!achou)
            {
                MessageBox.Show("Não existe este usuario.");
                return;
            }
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void btLimparLogin_Click(object sender, EventArgs e)
        {

             tbSenha.Clear();
             tbUsuario.Clear();
            
        }

        private void btCadastre_Click(object sender, EventArgs e)
        {
            frmLoginCadastro frm = new frmLoginCadastro();
            frm.ShowDialog();
        }
    }
}

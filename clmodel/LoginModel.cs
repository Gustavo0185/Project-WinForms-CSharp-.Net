using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace clmodel
{
    public class LoginModel
    {

        private string _usuario;
        private string _senha;
        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }




    }
}


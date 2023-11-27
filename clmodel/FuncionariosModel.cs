using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace clmodel
{
    public class FuncionariosModel
    {
        private int _codigo;
        private string _nome;
        private int _idade;
        private long _cpf;
        private long _pis;
        private string _sexo;
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }

        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        public long Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public long Pis
        {
            get { return _pis; }
            set { _pis = value; }
        }
        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

    }
}

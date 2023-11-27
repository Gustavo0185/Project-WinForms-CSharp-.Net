using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace clmodel
{
    public class CargoModel
    {
        private int _codigo;
        private string _cargo;
        private decimal _salario;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }

        }
        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }
        public decimal Salario
        {
            get { return _salario; }
            set { _salario = value; }
        }      

    }
}

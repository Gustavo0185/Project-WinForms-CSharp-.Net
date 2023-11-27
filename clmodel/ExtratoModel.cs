using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace clmodel
{
    public class ExtratoModel
    {
        private int _codigo;
        private string _nome;   
        private string _cargo;
        private decimal _salaB;
        private decimal _vlhr;
        private decimal _impr;
        private decimal _inss;
        private decimal _salal;

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
        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        public decimal SalaB
        {
            get { return _salaB; }
            set { _salaB = value; }
        }

        public decimal VlHr
        {
            get { return _vlhr; } 
            set { _vlhr = value; }
        }

        public decimal ImpR
        {
            get { return _impr; } 
            set { _impr = value; }
        }

        public decimal Inss
        {
            get { return _inss; }
            set { _inss = value; }
        }

        public decimal SalaL
        {
            get { return _salal; }
            set { _salal = value; }
        }

    }
}

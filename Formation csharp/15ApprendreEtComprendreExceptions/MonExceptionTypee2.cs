using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15ApprendreEtComprendreExceptions
{
    public class MonExceptionTypee2 : Exception
    {
        public MonExceptionTypee2() : base() { }
        public MonExceptionTypee2(string message) : base(message) { }
        public MonExceptionTypee2(string message, Exception ex) : base(message, ex) { }

        public int MaValeur
        {
            get { return (int)this.Data["MaValeur"]; }
            set { this.Data["MaValeur"] = value; }
        }
    }
}

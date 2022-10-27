using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
     public class validador
    {
      public string txtValido;
      public string txtaValidar;



        public bool Asertar()
        {
            if (txtValido == txtaValidar)
                return true;
            else
                return false;
        }

    }
}

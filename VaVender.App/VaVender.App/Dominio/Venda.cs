using System;
using System.Collections.Generic;
using System.Text;
using VaVender.App.Dominio.Base;

namespace VaVender.App.Dominio
{
    public class Venda : BaseDominio
    {
        public Cliente Cliente { get; set; }
        
    }
}

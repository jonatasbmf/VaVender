using System;
using System.Collections.Generic;
using System.Text;
using VaVender.App.Dominio.Base;

namespace VaVender.App.Dominio
{
    public class Telefone : BaseDominio
    {
        public int ClienteId { get; set; }
        public int NumeroTelefone { get; set; }

    }
}

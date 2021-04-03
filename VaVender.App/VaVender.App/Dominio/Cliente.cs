using System;
using System.Collections.Generic;
using System.Text;
using VaVender.App.Dominio.Base;

namespace VaVender.App.Dominio
{
    public class Cliente : BaseDominio
    {
        public Enum TipoCliente { get; set; }
        public int CpfCnpj { get; set; }
        public int RgIE { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public Telefone Telefone { get; set; }
        public DateTime DataInclusao { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using VaVender.App.View;

namespace VaVender.App.ModelView
{
    class DetalheVendaModelView
    {
        public bool isReadOnly { get; set; }
        public bool isEnabled { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotalVenda { get; set; }
        public string ValorFormatado { get { return string.Format("R$ {0:F2}", ValorTotalVenda); } }
        public DetalheVendaModelView()
        {

        }
        public DetalheVendaModelView( testeVenda testeVenda)
        {
            isReadOnly = testeVenda.Id == 0;
            isEnabled = !isReadOnly;
            NomeCliente = testeVenda.NomeCliente;
            DataVenda = testeVenda.DataVenda;
            ValorTotalVenda = testeVenda.ValorTotalVenda;
        }
    }
}

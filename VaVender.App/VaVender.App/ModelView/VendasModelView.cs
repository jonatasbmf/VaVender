using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using VaVender.App.ModelView.Base;
using VaVender.App.View;
using Xamarin.Forms;

namespace VaVender.App.ModelView
{
    class  VendasModelView : BaseModelView
    {
        public ICommand NovaVendaCommand { get; set; }
        public List<testeVenda> ListaDeVendas { get; set; }

        public VendasModelView()
        {
            var listaVendas = new List<testeVenda>
            {
              new testeVenda {Id = 10, NomeCliente = "Jonatas Freitas", ValorTotalVenda = 255 },
              new testeVenda {Id = 10, NomeCliente = "Tiago Freitas", ValorTotalVenda = 355 },
              new testeVenda { Id = 10, NomeCliente = "Narceli Freitas", ValorTotalVenda = 265 },
              new testeVenda { Id = 10, NomeCliente = "Marcos Freitas", ValorTotalVenda = 215 },
              new testeVenda { Id = 10, NomeCliente = "Norma Freitas", ValorTotalVenda = 295 },
              new testeVenda { Id = 10, NomeCliente = "Narcizo Freitas", ValorTotalVenda = 275 },
              new testeVenda { Id = 10, NomeCliente = "Rafaela Freitas", ValorTotalVenda = 115 },
              new testeVenda { Id = 10, NomeCliente = "Sarah Freitas", ValorTotalVenda = 145 },
            };

            ListaDeVendas = listaVendas.OrderBy(l => l.NomeCliente).ToList();
           
            NovaVendaCommand = new Command(() =>
            {
                Application.Current.MainPage.Navigation.PushAsync(new DetalheVendaView());
            });
        }

        public List<testeVenda> RetornoConsulta(string e)
        {
            var sugestao = new List<testeVenda>();
            if (e.Length >= 1)
                return ListaDeVendas.Where(c => c.NomeCliente.Contains(e.Trim())).ToList();
            else
                return ListaDeVendas;
        }

        public async void VendaSelecionada(testeVenda sender)
        {            
           await Application.Current.MainPage.Navigation.PushAsync(new DetalheVendaView( sender ));
        }

    }
}

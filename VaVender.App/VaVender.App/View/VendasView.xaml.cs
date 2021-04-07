using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaVender.App.Dominio;
using VaVender.App.ModelView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VaVender.App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VendasView : ContentPage
    {
        VendasModelView _vendasModelView;
        public VendasView()
        {
            InitializeComponent();
            this._vendasModelView = new VendasModelView();
            this.BindingContext = _vendasModelView;
            listview.ItemsSource = _vendasModelView.ListaDeVendas;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listview.ItemsSource = _vendasModelView.RetornoConsulta(BuscarPor.Text);
        }

        private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            _vendasModelView.VendaSelecionada(e.SelectedItem as testeVenda);
        }
    }

    public class testeVenda
    {
        public testeVenda()
        {
            DataVenda = DateTime.Today;
        }
        public string DataFormatada
        {
            get { return DataVenda.ToString("dd/MM/yyyy"); }
        }
        public string VendaFormatada
        {
            get { return string.Format("R$ {0:F2}", ValorTotalVenda); }
        }
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotalVenda { get; set; }
    }
}
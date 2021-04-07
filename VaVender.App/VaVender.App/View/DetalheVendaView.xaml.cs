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
    public partial class DetalheVendaView : ContentPage
    {
        public DetalheVendaView()
        {
            InitializeComponent();
            this.BindingContext = new DetalheVendaModelView();
        }
        public DetalheVendaView(testeVenda venda)
        {
            InitializeComponent();
            this.BindingContext = new DetalheVendaModelView(venda);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaVender.App.ModelView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VaVender.App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VendasView : ContentPage
    {
        public VendasView()
        {
            InitializeComponent();
            this.BindingContext = new VendasModelView();

            listview.ItemsSource = new List<Venda>
            {
              new Venda { Nome="Palmeiras", Pontos=69},
              new Venda { Nome="Flamengo", Pontos=67},
              new Venda { Nome="Santos", Pontos=64},
              new Venda { Nome="Atletico", Pontos=62 },
              new Venda { Nome="Botafogo", Pontos=59 }
            };
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VaVender.App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalView : TabbedPage
    {
        public PrincipalView()
        {
            InitializeComponent();
            this.Children.Add(new HomeView());
            this.Children.Add(new VendasView());
            this.Children.Add(new CadastroView());
            this.Children.Add(new RelatoriosView());
            this.Children.Add(new SobreView());
        }
    }
}
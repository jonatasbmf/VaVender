using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using VaVender.App.ModelView.Base;

namespace VaVender.App.ModelView
{
    class VendasModelView : BaseModelView
    {
        public ICommand NovaVenda { get; set; }
        public VendasModelView()
        {

        }
    }
}

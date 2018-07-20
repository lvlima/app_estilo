using System;
using System.Collections.Generic;
using app_estilo.Paginas;

using Xamarin.Forms;

namespace app_estilo.Menu
{
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void GoPagina1(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ImplicitStylePage());
            IsPresented = false;
        }

        private void GoPagina2(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ExplictStylePage());
            IsPresented = false;
        }

        private void GoPagina3(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new GlobalStylePage());
            IsPresented = false;
        }

        private void GoPagina4(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new InheritStylePage());
            IsPresented = false;
        }

        private void GoPagina5(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new DynamicStylePage());
            IsPresented = false;
        }

    }
}

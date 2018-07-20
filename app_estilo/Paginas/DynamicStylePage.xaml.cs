using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace app_estilo.Paginas
{
    public partial class DynamicStylePage : ContentPage
    {
        public DynamicStylePage()
        {
            InitializeComponent();
        }

        private void ActionMudarCor(object sender, EventArgs args)
        {
            this.Resources["lblColor"] = Color.DeepPink;
            this.Resources["lbl"] = this.Resources["lblNew"];
        }
    }
}

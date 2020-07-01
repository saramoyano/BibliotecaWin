using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP.View
{
   
    public sealed partial class GeneroPage : Page
    {
        public GeneroViewModel generoViewModel;
        public GeneroPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            generoViewModel = new GeneroViewModel();
        }

        private void ListaGeneros_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var gen = (Model.Genero)listaGeneros.SelectedItem;
            Frame.Navigate(typeof(View.LibrosPage), gen);
        }
    }
}

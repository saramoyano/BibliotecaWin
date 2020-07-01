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
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class LibrosPage : Page
    {
        public LibrosPageViewModel librosPageViewModel;
        public LibrosPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter != null)
            {
                if (e.Parameter.GetType().Equals(typeof(Model.Clasificacion)))
                {
                    librosPageViewModel = new LibrosPageViewModel((Model.Clasificacion)e.Parameter);
                }
                else
                {
                    librosPageViewModel = new LibrosPageViewModel((Model.Genero)e.Parameter);
                }
               
            }
            else
            {
                librosPageViewModel = new LibrosPageViewModel();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {

            if (fvLista.SelectedIndex > 0)
            {
                fvLista.SelectedIndex --;
            }
        }

        private void Button_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            if (listaLibros.SelectedIndex < librosPageViewModel.Libros.Count -1)
            {
                listaLibros.SelectedIndex++;
            }
        }

        private void ListaLibros_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ScrollViewer scrollViewer = listaLibros.Parent as ScrollViewer;
            if (scrollViewer != null)
            {
                var container = listaLibros.ContainerFromItem(listaLibros.SelectedItem);
                var item = container as ListViewItem;
                var objTransf = item.TransformToVisual(listaLibros);
                Point point = objTransf.TransformPoint(new Point(0, 0));

                scrollViewer.ChangeView(point.X, 0, 1);
            }

        }

        private void Button_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace UWP.View
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string _salt;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NvMenuPpal_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItem != null)
            {
                NavigationViewItem nvi = (NavigationViewItem)args.SelectedItem;
                if (nvi.Tag.ToString() == "catalogo")
                {
                    this.ContentFrame.Navigate(typeof(LibrosPage), null,  new EntranceNavigationTransitionInfo());
                }
                else if (nvi.Tag.ToString() == "filtro")
                {
                    this.ContentFrame.Navigate(typeof(ClasificacionPage), null,  new DrillInNavigationTransitionInfo());
                }
                else if (nvi.Tag.ToString() == "genero")
                {
                    this.ContentFrame.Navigate(typeof(GeneroPage), null, new DrillInNavigationTransitionInfo());
                }
            }
        }

        

        private async void NavigationViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {

            MyUserControl1 user = new MyUserControl1();
            ContentDialog contentDialog = new ContentDialog
            {
                Content = user,
                Title = "Salir",
                PrimaryButtonText = "Cerrar",
                CloseButtonText = "Cancelar",
                DefaultButton = ContentDialogButton.Primary
            };
            var result = await contentDialog.ShowAsync();


            if (result == ContentDialogResult.Primary)

               _salt = Datos.LogicaAdministrador.CalcularSalt("12345678Z", user.Pass);
            {
                if (Datos.LogicaAdministrador.GetInstance().ComprobarAdmin(_salt))
                {
                    Application.Current.Exit();
                }
            }
            

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(LibrosPage), null, new EntranceNavigationTransitionInfo());
        }
    }
}

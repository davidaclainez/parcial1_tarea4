using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnEnviarInformacion_Clicked(object sender, EventArgs e)
        {
            var payloadModel = new Model
            {
                Nombre = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                Edad = txtEdad.Text,
                Correo = txtCorreo.Text
            } ;

            Page page = new SecondPage();
            page.BindingContext = payloadModel;
            Navigation.PushAsync(page);
        } 
    }

    class Model
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Edad { get; set; }
        public string Correo { get; set; }
    }
}

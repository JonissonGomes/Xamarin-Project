using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_Project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Mostrar(object sender, EventArgs e){

            var Username = username.Text;
            response.Text = "Bem vindo, " + username.Text + "!";
        }

        void Limpar(object sender, EventArgs e) {

            username.Text = " ";
            response.Text = " ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Profile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Me : ContentView
    {
        public Me()
        {
            InitializeComponent();
        }
        public const uint AnimationSpeed = 200;

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
          await  me.FadeTo(0, 0,Easing.SinOut);
        }
    }
}
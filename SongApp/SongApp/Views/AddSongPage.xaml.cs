using SongApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SongApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddSongPage : ContentPage
    {
        public AddSongPage()
        {
            InitializeComponent();
            BindingContext = new AddNewSongViewModel(this.Navigation);          
        }
    }
}

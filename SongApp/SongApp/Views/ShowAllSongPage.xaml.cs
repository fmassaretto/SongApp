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
    public partial class ShowAllSongPage : ContentPage
    {
        public ShowAllSongPage()
        {
            InitializeComponent();
            BindingContext = new ShowAllSongsViewModel();
        }
    }
}

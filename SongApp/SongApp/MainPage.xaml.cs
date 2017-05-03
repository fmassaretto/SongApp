using SongApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SongApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        public void OnShowAllSongsClicked(object sender, EventArgs e)
        {
            Navigation?.PushAsync(new ShowAllSongPage());
        }

        public void OnAddSongClicked(object sender, EventArgs e)
        {
            Navigation?.PushAsync(new AddSongPage());
        }
    }
}

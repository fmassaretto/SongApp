using SongApp.Models;
using SongApp.ViewModels;

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

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem;

            var song = (Song)item;
            Navigation.PushAsync(new DetailsSongPage(song));
        }
    }
}

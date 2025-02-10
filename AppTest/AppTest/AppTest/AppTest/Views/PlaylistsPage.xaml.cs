using AppTest.Models;
using AppTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaylistsPage : ContentPage
    {

        public PlaylistsPage()
        {
            BindingContext = new PlaylistsPageViewModel(new PageService());
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        void OnAddPlaylist(object sender, System.EventArgs e)
        {
            (BindingContext as PlaylistsPageViewModel).AddPlayList();
        }

        async void OnPlaylistSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            await (BindingContext as PlaylistsPageViewModel).SelectPlaylist(e.SelectedItem as PlaylistViewModel).ConfigureAwait(false);
        }
    }
}
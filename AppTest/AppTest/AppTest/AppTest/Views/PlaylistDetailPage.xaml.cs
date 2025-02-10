using AppTest.Models;
using AppTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaylistDetailPage : ContentPage
    {

        public PlaylistDetailPage(Playlist playlist)
        {
            BindingContext = new PlaylistDetailPageViewModel(new PageService(), playlist);

            InitializeComponent();
        }
    }
}
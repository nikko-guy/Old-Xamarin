using AppTest.Models;
using AppTest.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace AppTest.ViewModels
{
    class PlaylistsPageViewModel:BaseViewModel
    {
        private PlaylistViewModel _selectedPlaylist;
        private readonly IPageService _pageService;
        public ObservableCollection<PlaylistViewModel> Playlists { get; private set; } = new ObservableCollection<PlaylistViewModel>();
        public PlaylistViewModel SelectedPlaylist
        {
            get{ return _selectedPlaylist; }
            set{ setValue(ref _selectedPlaylist, value); }
        }

        public PlaylistsPageViewModel(IPageService pageService)
        {
            _pageService = pageService;
        }

        public void AddPlayList()
        {
            var newPlaylist = "Playlist " + (Playlists.Count + 1);
            Playlists.Add(new PlaylistViewModel { Title = newPlaylist });
        }
        public async Task SelectPlaylist(PlaylistViewModel playlist)
        {
            if (playlist == null) return;
            playlist.IsFavorite = !playlist.IsFavorite;
            SelectedPlaylist = null;

            await _pageService.PushAsync (new PlaylistDetailPage(playlist.toPlaylist())).ConfigureAwait(false);
        }
    }
}

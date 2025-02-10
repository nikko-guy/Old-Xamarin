using AppTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppTest.ViewModels
{
    class PlaylistDetailPageViewModel
    {
        public Playlist Playlist { get; set; }
        private readonly IPageService _pageService;

        public PlaylistDetailPageViewModel(IPageService pageService, Playlist playlist)
        {
            _pageService = pageService;
            Playlist = playlist;
        }
    }
}

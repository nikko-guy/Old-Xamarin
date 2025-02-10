using AppTest.Models;
using System.Drawing;

namespace AppTest.ViewModels
{
    class PlaylistViewModel : BaseViewModel
    {
        public string Title { get; set; }

        private bool _isFavorite;
        public bool IsFavorite
        {
            get { return _isFavorite; }
            set
            {
                setValue(ref _isFavorite, value);
                OnPropertyChanged(nameof(Color));
            }
        }

        public Color Color
        {
            get { return IsFavorite ? Color.Pink : Color.Black; }
        }
        public Playlist toPlaylist()
        {
            return new Playlist { Title = Title, IsFavorite = IsFavorite };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearnWPF.ViewModels
{
    public class YoutubeViewersViewModel : ViewModelBase
    {
        public YoutubeViewersListingViewModel YoutubeViewersListingViewModel { get; }
        public YoutubeViewersDetailsViewModel YoutubeViewersDetailsViewModel { get; }
        public ICommand AddYoutubeViewersCommand { get; }

        public YoutubeViewersViewModel()
        {
            YoutubeViewersListingViewModel = new YoutubeViewersListingViewModel();
            YoutubeViewersDetailsViewModel = new YoutubeViewersDetailsViewModel();
        }

    }
}

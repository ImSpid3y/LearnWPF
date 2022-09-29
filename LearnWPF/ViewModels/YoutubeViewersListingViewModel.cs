using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWPF.ViewModels
{
    public class YoutubeViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YoutubeViewersListingItemViewModel> _youtubeViewersListingItemsViewModels;

        IEnumerable<YoutubeViewersListingItemViewModel> YoutubeViewersListingItemViewModels => _youtubeViewersListingItemsViewModels;

        public YoutubeViewersListingViewModel()
        {
            _youtubeViewersListingItemsViewModels = new ObservableCollection<YoutubeViewersListingItemViewModel>();
            _youtubeViewersListingItemsViewModels.Add(new YoutubeViewersListingItemViewModel("Sourav"));
            _youtubeViewersListingItemsViewModels.Add(new YoutubeViewersListingItemViewModel("Srikanta"));
            _youtubeViewersListingItemsViewModels.Add(new YoutubeViewersListingItemViewModel("Sambhu"));
        }
    }
}

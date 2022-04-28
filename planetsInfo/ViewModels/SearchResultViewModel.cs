using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetsInfo.ViewModels
{
    public class SearchResultViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private BE.Search.Item ItemModel;


        public string title
        {
            get
            {
                if (!HasContent)
                {
                    return null;
                }
                return ItemModel.data.First().title;
            }
            set
            {
                ItemModel.data.First().title = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("title"));
                }
            }
        }

        public string nasa_id
        {
            get
            {
                if (!HasContent)
                {
                    return null;
                }
                return ItemModel.data.First().nasa_id;
            }
            set
            {
                ItemModel.data.First().nasa_id = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("nasa_id"));
                }
            }
        }

        public DateTime date_created
        {
            get
            {
                if (!HasContent)
                {
                    return DateTime.Now;
                }
                return ItemModel.data.First().date_created;
            }
            set
            {
                ItemModel.data.First().date_created = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("date_created"));
                }
            }
        }

        public string description
        {
            get
            {
                if (!HasContent)
                {
                    return null;
                }
                return ItemModel.data.First().description;
            }
            set
            {
                ItemModel.data.First().description = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("description"));
                }
            }
        }

        public string location
        {
            get
            {
                if (!HasContent)
                {
                    return null;
                }
                return ItemModel.data.First().location;
            }
            set
            {
                ItemModel.data.First().location = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("location"));
                }
            }
        }

        public string imgUri
        {
            get
            {
                if (!HasContent)
                {
                    return null;
                }
                return ItemModel.links.First().href;
            }
            set
            {
                ItemModel.links.First().href = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("imgUri"));
                }
            }
        }
        public bool HasContent { get; set; }
        public SearchResultViewModel(BE.Search.Item item = null)
        {
            if (item == null)
            {
                HasContent = false;
                return;
            }
            HasContent = true;
            ItemModel = item;
        }
    }
}

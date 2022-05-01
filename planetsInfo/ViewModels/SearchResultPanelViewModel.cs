using planetsInfo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetsInfo.ViewModels
{
    public class SearchResultPanelViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        SearchResultPanelModel model;

        public ObservableCollection<BE.SearchItem> ObjectId
        {
            get => new ObservableCollection<BE.SearchItem>(model.Items);
        }

        public string Image
        {
            get => "https://firebasestorage.googleapis.com/v0/b/planets-9419d.appspot.com/o/themes%2FNEO.png?alt=media&token=d1d04f2e-52fc-4e42-b077-187bbf389bf3";
        }

        //string selectedItemId;
        //public string SelectedItemId
        //{
        //    get => selectedItemId;
        //    set
        //    {
        //        selectedItemId = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedItemId)));
        //            PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedItem)));
        //        }
        //    }
        //}

        //public SearchResultViewModel SelectedItem
        //{
        //    get
        //    {
        //        if (selectedItemId == null)
        //        {
        //            return new SearchResultViewModel();
        //        }
        //        return new SearchResultViewModel(model.Items.First(I => I.data.First().nasa_id == selectedItemId));
        //    }
        //}

        public SearchResultPanelViewModel(string search = "moon")
        {
            model = new SearchResultPanelModel();
            Task loader = Task.Factory.StartNew(() => model.LoadData(search));
            loader.ContinueWith((t) =>
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(""));
                }
            });
        }
    }
}

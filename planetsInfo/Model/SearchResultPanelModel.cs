using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetsInfo.Model
{
    class SearchResultPanelModel
    {
        public ObservableCollection<BE.Search.Item> Items;
        public BL.BLClass BLClass;
        public SearchResultPanelModel(string search)
        {
            BLClass = new BL.BLClass();
            Items = new ObservableCollection<BE.Search.Item>(BLClass.SearchPlanet(search));
        }
    }
}

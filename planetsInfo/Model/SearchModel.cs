using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetsInfo.Model
{
    class SearchModel
    {
        ObservableCollection<BE.Search.Item> items;
        public ObservableCollection<BE.Search.Item> Items
        {
            get
            {
                if (items == null)
                    items = new ObservableCollection<BE.Search.Item>();
                return items;
            }
        }
        public BL.BLClass BLClass;
        public SearchModel()
        {
            BLClass = BL.BLClass.Instance;
        }

        public void LoadData(string search)
        {
            //items = new ObservableCollection<BE.Search.Item>(BLClass.SearchPlanet(search));
        }
    }
}

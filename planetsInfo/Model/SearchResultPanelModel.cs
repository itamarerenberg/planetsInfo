﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetsInfo.Model
{
    class SearchResultPanelModel
    {
        ObservableCollection<BE.SearchItem> items;
        public ObservableCollection<BE.SearchItem> Items
        {
            get
            {
                if (items == null)
                    items = new ObservableCollection<BE.SearchItem>();
                return items;
            }
        }

        
        public BL.BLClass BLClass;
        public SearchResultPanelModel()
        {
            BLClass = BL.BLClass.Instance;
        }

        public void LoadData(string search)
        {

            items = new ObservableCollection<BE.SearchItem>(BLClass.SearchPlanet(search));
        }
    }
}

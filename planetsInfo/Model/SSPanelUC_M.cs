﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetsInfo.Model
{
    class SSPanelUC_M
    {
        BL.BLClass source;
        public ObservableCollection<BE.SSPanel> planets;


        public SSPanelUC_M()
        {
            source = BL.BLClass.Instance;
        }

        public void LoadData()
        {
            planets = new ObservableCollection<BE.SSPanel>(source.GetSSPlanets());
           
            
        }
    }
}

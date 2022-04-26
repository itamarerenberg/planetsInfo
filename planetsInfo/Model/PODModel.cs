using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace planetsInfo
{
    class PODModel
    {
        public BE.POD POD = new POD();
        public BL.BLClass source;
        public string ImgUri { get => POD.hdurl; set => POD.hdurl = value; }
        public string Description { get => POD.explanation; set => POD.explanation = value; }
        public string Date { get => POD.date; set => POD.date = value; }
        public string Title { get => POD.title; set => POD.title = value; }
        //public DateTime DateTime { get; set; } = DateTime.Now;
        public PODModel()
        {
            source = BL.BLClass.Instance;
        }
        
        public void LoadData(DateTime? date = null)
        {
            POD = source.GetPOD(date);
        }
    }
}

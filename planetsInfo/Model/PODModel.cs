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
        public BL.BLClass BLClass = new BL.BLClass();
        public string ImgUri { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        //public DateTime DateTime { get; set; } = DateTime.Now;
        public PODModel()
        {
            POD = BLClass.GetPOD(DateTime.Now);
            ImgUri = POD.hdurl;
            Description = POD.explanation;
            Date = POD.date;
            Title = POD.title;
            //DateTime = DateTime.ParseExact(POD.date, "yyyy-MM-dd",
            //    CultureInfo.InvariantCulture);

        }
        
    }
}

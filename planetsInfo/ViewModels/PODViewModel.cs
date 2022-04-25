using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetsInfo
{
    public class PODViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private PODModel PODModel;
        public string ImgUri {
            get { return PODModel.ImgUri; }
            set { 
                PODModel.ImgUri = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ImgUri"));
                }
            }
        }
        public string Description
        {
            get { return PODModel.Description; }
            set
            {
                PODModel.Description = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Description"));
                }
            }
        }
        public string Date
        {
            get { return PODModel.Date; }
            set
            {
                PODModel.Date = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Date"));
                }
            }
        }
        public string Title
        {
            get { return PODModel.Title; }
            set
            {
                PODModel.Title = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Title"));
                }
            }
        }

        
        //public DateTime DateTime
        //{
        //    get { return PODModel.DateTime; }
        //    set
        //    {
        //        PODModel.DateTime = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
        //        }
        //    }
        //}
        public PODViewModel()
        {
            PODModel = new PODModel();
        }
    }
}

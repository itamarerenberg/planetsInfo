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

        private PODModel model;

        public string ImageUri
        {
            get => "https://firebasestorage.googleapis.com/v0/b/planets-9419d.appspot.com/o/themes%2FESA_root_pillars.png?alt=media&token=fb981519-c395-40a4-a0cb-decfa0171efd";
        }

        public string ImgUri {
            get { return model.ImgUri; }
            set { 
                model.ImgUri = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ImgUri"));
                }
            }
        }
        public string Description
        {
            get { return model.Description; }
            set
            {
                model.Description = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Description"));
                }
            }
        }
        public string Date
        {
            get { return model.Date; }
            set
            {
                model.Date = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Date"));
                }
            }
        }
        public string Title
        {
            get { return model.Title; }
            set
            {
                model.Title = value;
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
            model = new PODModel();
            Task loader = Task.Factory.StartNew(() => model.LoadData());
            loader.ContinueWith((t) =>
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(""));//all properties has changed
            });
        }
    }
}

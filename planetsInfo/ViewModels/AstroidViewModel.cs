using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetsInfo
{
    public class AstroidViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private AstroidModel AstroidModel;

        public string id
        {
            get { return AstroidModel.id; }
            set
            {
                AstroidModel.id = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("id"));
                }
            }
        }

        public string neo_reference_id
        {
            get { return AstroidModel.neo_reference_id; }
            set
            {
                AstroidModel.neo_reference_id = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("neo_reference_id"));
                }
            }
        }

        public string name
        {
            get { return AstroidModel.name; }
            set
            {
                AstroidModel.name = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("name"));
                }
            }
        }

        public string nasa_jpl_url
        {
            get { return AstroidModel.nasa_jpl_url; }
            set
            {
                AstroidModel.nasa_jpl_url = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("nasa_jpl_url"));
                }
            }
        }

        public double absolute_magnitude_h
        {
            get { return AstroidModel.absolute_magnitude_h; }
            set
            {
                AstroidModel.absolute_magnitude_h = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("absolute_magnitude_h"));
                }
            }
        }

        public double estimated_diameter_min
        {
            get { return AstroidModel.estimated_diameter_min; }
            set
            {
                AstroidModel.estimated_diameter_min = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("estimated_diameter_min"));
                }
            }
        }

        public double estimated_diameter_max
        {
            get { return AstroidModel.estimated_diameter_max; }
            set
            {
                AstroidModel.estimated_diameter_max = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("estimated_diameter_max"));
                }
            }
        }

        public bool is_potentially_hazardous_asteroid
        {
            get { return AstroidModel.is_potentially_hazardous_asteroid; }
            set
            {
                AstroidModel.is_potentially_hazardous_asteroid = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("is_potentially_hazardous_asteroid"));
                }
            }
        }

        public bool is_sentry_object
        {
            get { return AstroidModel.is_sentry_object; }
            set
            {
                AstroidModel.is_sentry_object = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("is_sentry_object"));
                }
            }
        }

        public AstroidViewModel()
        {
            AstroidModel = new AstroidModel();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using planetsInfo.Model;

namespace planetsInfo.ViewModel
{
    class PlanetInfo_UC_VM : INotifyPropertyChanged
    {
        PlanetInfo_UC_M Model
        {
            get;
            set;
        }

        #region properties
        public string Name
        {
            get
            {
                return Model.Name;
            }
            set
            {
                Model.Name = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
        public string GeneralInfo
        {
            get
            {
                return Model.GeneralInfo;
            }
            set
            {
                Model.GeneralInfo = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(GeneralInfo)));
            }
        }
        public string Category
        {
            get
            {
                return Model.Category;
            }
            set
            {
                Model.Category = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Category)));
            }
        }
        public string Location
        {
            get
            {
                return Model.Location;
            }
            set
            {
                Model.Location = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Location)));
            }
        }
        public string AvgDistanceFromSun
        {
            get
            {
                return Model.AvgDistanceFromSun;
            }
            set
            {
                Model.AvgDistanceFromSun = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(AvgDistanceFromSun)));
            }
        }
        public string OrbitalPeriod
        {
            get
            {
                return Model.OrbitalPeriod;
            }
            set
            {
                Model.OrbitalPeriod = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(OrbitalPeriod)));
            }
        }
        public string AvgOrbitalSpeed
        {
            get
            {
                return Model.AvgOrbitalSpeed;
            }
            set
            {
                Model.AvgOrbitalSpeed = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(AvgOrbitalSpeed)));
            }
        }
        public string Inclination
        {
            get
            {
                return Model.Inclination;
            }
            set
            {
                Model.Inclination = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Inclination)));
            }
        }
        public string Satellites
        {
            get
            {
                return Model.Satellites;
            }
            set
            {
                Model.Satellites = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Satellites)));
            }
        }
        public string Radius
        {
            get
            {
                return Model.Radius;
            }
            set
            {
                Model.Radius = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Radius)));
            }
        }
        public string SurfaceArea
        {
            get
            {
                return Model.SurfaceArea;
            }
            set
            {
                Model.SurfaceArea = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(SurfaceArea)));
            }
        }
        public string Mass
        {
            get
            {
                return Model.Mass;
            }
            set
            {
                Model.Mass = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Mass)));
            }
        }
        public string Density
        {
            get
            {
                return Model.Density;
            }
            set
            {
                Model.Density = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Density)));
            }
        }
        public string RotationPeriod
        {
            get
            {
                return Model.RotationPeriod;
            }
            set
            {
                Model.RotationPeriod = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(RotationPeriod)));
            }
        }
        public string RotationSpeed
        {
            get
            {
                return Model.RotationSpeed;
            }
            set
            {
                Model.RotationSpeed = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(RotationSpeed)));
            }
        }
        public string AxialTilt
        {
            get
            {
                return Model.AxialTilt;
            }
            set
            {
                Model.AxialTilt = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(AxialTilt)));
            }
        }
        public string AvgSurfaceTemp
        {
            get
            {
                return Model.AvgSurfaceTemp;
            }
            set
            {
                Model.AxialTilt = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(AvgSurfaceTemp)));
            }
        }
        public string ImageUrl
        {
            get
            {
                return Model.ImageUrl;
            }
            set
            {
                Model.ImageUrl = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(ImageUrl)));
            }
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public PlanetInfo_UC_VM(string planetName)
        {
            Model = new PlanetInfo_UC_M();
            Task loader = Task.Factory.StartNew(()=> Model.LoadData(planetName));
            loader.ContinueWith((t) =>
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(""));//all properties has changed
            });
        }
    }
}

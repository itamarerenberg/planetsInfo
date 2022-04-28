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
        PlanetInfo_UC_M model
        {
            get;
            set;
        }

        #region properties
        bool loading;
        string loadingMassege = "loading...";
        public string Name
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.Name;
            }
            set
            {
                model.Name = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
        public string GeneralInfo
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.GeneralInfo;
            }
            set
            {
                model.GeneralInfo = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(GeneralInfo)));
            }
        }
        public string Category
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.Category;
            }
            set
            {
                model.Category = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Category)));
            }
        }
        public string Location
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.Location;
            }
            set
            {
                model.Location = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Location)));
            }
        }
        public string AvgDistanceFromSun
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.AvgDistanceFromSun;
            }
            set
            {
                model.AvgDistanceFromSun = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(AvgDistanceFromSun)));
            }
        }
        public string OrbitalPeriod
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.OrbitalPeriod;
            }
            set
            {
                model.OrbitalPeriod = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(OrbitalPeriod)));
            }
        }
        public string AvgOrbitalSpeed
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.AvgOrbitalSpeed;
            }
            set
            {
                model.AvgOrbitalSpeed = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(AvgOrbitalSpeed)));
            }
        }
        public string Inclination
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.Inclination;
            }
            set
            {
                model.Inclination = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Inclination)));
            }
        }
        public string Satellites
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.Satellites;
            }
            set
            {
                model.Satellites = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Satellites)));
            }
        }
        public string Radius
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.Radius;
            }
            set
            {
                model.Radius = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Radius)));
            }
        }
        public string SurfaceArea
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.SurfaceArea;
            }
            set
            {
                model.SurfaceArea = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(SurfaceArea)));
            }
        }
        public string Mass
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.Mass;
            }
            set
            {
                model.Mass = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Mass)));
            }
        }
        public string Density
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.Density;
            }
            set
            {
                model.Density = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Density)));
            }
        }
        public string RotationPeriod
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.RotationPeriod;
            }
            set
            {
                model.RotationPeriod = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(RotationPeriod)));
            }
        }
        public string RotationSpeed
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.RotationSpeed;
            }
            set
            {
                model.RotationSpeed = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(RotationSpeed)));
            }
        }
        public string AxialTilt
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.AxialTilt;
            }
            set
            {
                model.AxialTilt = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(AxialTilt)));
            }
        }
        public string AvgSurfaceTemp
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.AvgSurfaceTemp;
            }
            set
            {
                model.AxialTilt = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(AvgSurfaceTemp)));
            }
        }
        public string ImageUrl
        {
            get
            {
                if (loading || !HasContent)
                    return loadingMassege;
                return model.ImageUrl;
            }
            set
            {
                model.ImageUrl = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(ImageUrl)));
            }
        }
        bool hasContent;
        public bool HasContent 
        {
            get => hasContent;
            set { hasContent = value; }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public PlanetInfo_UC_VM(string planetName = null)
        {
            if (planetName == null)
            {
                HasContent = false;
                return;
            }
            HasContent = true;
            model = new PlanetInfo_UC_M();
            loading = true;
            Task loader = Task.Factory.StartNew(()=> model.LoadData(planetName));
            loader.ContinueWith((t) =>
            {
                loading = false;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(""));//all properties has changed
            });
        }
    }
}

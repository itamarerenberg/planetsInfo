using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace planetsInfo.Model
{
    class PlanetInfo_UC_M
    {
        private BL.BLClass source;
        private BE.Planet data;
        public BE.Planet Data
        {
            get;
            set;
        }
        public string Name { get => data.Name; set => data.Name = value; }
        public string GeneralInfo { get => data.GeneralInfo; set => data.GeneralInfo = value; }
        public string Category { get => data.Category; set => data.Category = value; }
        public string Location { get => data.Location; set => data.Location = value; }
        public string AvgDistanceFromSun { get => data.AvgDistanceFromSun; set => data.AvgDistanceFromSun = value; }
        public string OrbitalPeriod { get => data.OrbitalPeriod; set => data.OrbitalPeriod = value; }
        public string AvgOrbitalSpeed { get => data.AvgOrbitalSpeed; set => data.AvgOrbitalSpeed = value; }
        public string Inclination { get => data.Inclination; set => data.Inclination = value; }
        public string Satellites { get => data.Satellites; set => data.Satellites = value; }
        public string Radius { get => data.Radius; set => data.Radius = value; }
        public string SurfaceArea { get => data.SurfaceArea; set => data.SurfaceArea = value; }
        public string Mass { get => data.Mass; set => data.Mass = value; }
        public string Density { get => data.Density; set => data.Density = value; }
        public string RotationPeriod { get => data.RotationPeriod; set => data.RotationPeriod = value; }
        public string RotationSpeed { get => data.RotationSpeed; set => data.RotationSpeed = value; }
        public string AxialTilt { get => data.AxialTilt; set => data.AxialTilt = value; }
        public string AvgSurfaceTemp { get => data.AvgSurfaceTemp; set => data.AvgSurfaceTemp = value; }
        public string ImageUrl { get => data.ImageUrl; set => data.ImageUrl = value; }

        public PlanetInfo_UC_M()
        {
            source = BL.BLClass.Instance;
        }

        public void LoadData(string planet_name)
        {
            data = source.GetPlanet(planet_name);
        }
    }
}

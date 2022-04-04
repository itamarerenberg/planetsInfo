﻿using BE;
using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    /// <summary>
    /// logical operations
    /// </summary>
    public class BLClass
    {
        DLClass dlc;
        public BLClass()
        {
            dlc = new DLClass();
        }
        //picture of the day by immaga
        public BE.POD PoD(DateTime? date = null)
        {
            return dlc.GetPOD((DateTime)date);
        }

        public IEnumerable<Planet> GetAllPlanets()
        {
            return dlc.Get8Planets();
        }
        public Planet GetPlanetInfo(string pname)
        {
            List<Planet> planets = dlc.Get8Planets();
            foreach (var planet in planets)
            {
                if (planet.Name == pname)
                {
                    return planet;
                }
            }
            return null;
        }

        public PlanetInfo SearchByImage(string imUrl)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PlanetInfo> qurey(DateTime from, DateTime until, float diameter=0, bool isDengerous=false)
        {
            throw new NotImplementedException();
        }
    }
}

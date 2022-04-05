using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var dlc = new DLClass();
            //string a = $"New Moon. By the modern definition, New Moon occurs when the Moon and Sun are at the same geocentric ecliptic longitude. The part of the Moon facing us is completely in shadow then. Pictured here is the traditional New Moon, the earliest visible waxing crescent, which signals the start of a new month in many lunar and lunisolar calendars.  This marks the first time that accurate shadows at this level of detail are possible in such a computer simulation. The shadows are based on the global elevation map being developed from measurements by the Lunar Orbiter Laser Altimeter (LOLA) aboard the Lunar Reconnaissance Orbiter (LRO). LOLA has already taken more than 10 times as many elevation measurements as all previous missions combined.  The Moon always keeps the same face to us, but not exactly the same face. Because of the tilt and shape of its orbit, we see the Moon from slightly different angles over the course of a month. When a month is compressed into 12 seconds, as it is in this animation, our changing view of the Moon makes it look like it's wobbling. This wobble is called libration.  The word comes from the Latin for &quot;balance scale&quot; (as does the name of the zodiac constellation Libra) and refers to the way such a scale tips up and down on alternating sides. The sub-Earth point gives the amount of libration in longitude and latitude. The sub-Earth point is also the apparent center of the Moon's disk and the location on the Moon where the Earth is directly overhead.  The Moon is subject to other motions as well. It appears to roll back and forth around the sub-Earth point. The roll angle is given by the position angle of the axis, which is the angle of the Moon's north pole relative to celestial north. The Moon also approaches and recedes from us, appearing to grow and shrink. The two extremes, called perigee (near) and apogee (far), differ by more than 10%.  The most noticed monthly variation in the Moon's appearance is the cycle of phases, caused by the changing angle of the Sun as the Moon orbits the Earth. The cycle begins with the waxing (growing) crescent Moon visible in the west just after sunset. By first quarter, the Moon is high in the sky at sunset and sets around midnight. The full Moon rises at sunset and is high in the sky at midnight. The third quarter Moon is often surprisingly conspicuous in the daylit western sky long after sunrise.  Celestial north is up in these images, corresponding to the view from the northern hemisphere. The descriptions of the print resolution stills also assume a northern hemisphere orientation. To adjust for southern hemisphere views, rotate the images 180 degrees, and substitute &quot;north&quot; for &quot;south&quot; in the descriptions.  Credit: <a href=\"http://svs.gsfc.nasa.gov/index.html\" rel=\"nofollow\">NASA/Goddard Space Flight Center Scientific Visualization Studio</a>  <b><a href=\"http://www.nasa.gov/centers/goddard/home/index.html\" rel=\"nofollow\">NASA Goddard Space Flight Center</a></b> enables NASA’s mission through four scientific endeavors: Earth Science, Heliophysics, Solar System Exploration, and Astrophysics. Goddard plays a leading role in NASA’s accomplishments by contributing compelling scientific knowledge to advance the Agency’s mission.  <b>Follow us on <a href=\"http://twitter.com/NASA_GoddardPix\" rel=\"nofollow\">Twitter</a></b>  <b>Join us on <a href=\"http://www.facebook.com/pages/Greenbelt-MD/NASA-Goddard/395013845897?ref=tsd\" rel=\"nofollow\">Facebook</a></b>  <b>Find us on <a href=\"http://web.stagram.com/n/nasagoddard/?vm=grid\" rel=\"nofollow\">Instagram</a></b>";
            //Console.WriteLine(a.Length);
            DateTime s = new DateTime(1999, 12, 1);
            DateTime e = new DateTime(2020, 12, 1);
            var a = dlc.GetNearEarthAstroid(s, e);
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //dlc.GetSearchResult("moon");
            Console.ReadKey();
        }
    }
}

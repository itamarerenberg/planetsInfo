using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace planetsInfo.Model
{
    class AstroidPanelUC_M
    {
        BL.BLClass source;
        public Task<List<BE.Astroid>> astroidsLoder;
        private ObservableCollection<BE.Astroid> astroids;

        public ObservableCollection<BE.Astroid> Astroids
        {
            get
            {
                if (astroids == null)
                    astroids = new ObservableCollection<BE.Astroid>();
                return astroids;
            }
            set
            {
                astroids = value;
            }
        }

        public AstroidPanelUC_M()
        {
            source = BL.BLClass.Instance;
        }

        public void LoadData(DateTime from, DateTime until, float min, float max, bool? isDengerous)
        {
            astroids = new ObservableCollection<BE.Astroid>(source.GetNearEarthAstroid(from, until, min, max, isDengerous));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetsInfo.Model
{
    class AstroidPanelUC_M
    {
        BL.BLClass source;
        public ObservableCollection<BE.Astroid> Astroids;

        public AstroidPanelUC_M(DateTime from, DateTime until, float min, float max, bool? isDengerous)
        {
            source = new BL.BLClass();
            Astroids = new ObservableCollection<BE.Astroid>(source.qurey(from, until, min, max, isDengerous));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetsInfo
{
    class NEOModel
    {
        public ObservableCollection<BE.Astroid> astroids = new ObservableCollection<BE.Astroid>();
        BL.BLClass BLClass = BL.BLClass.Instance;
        public NEOModel()
        {
            //astroids = BLClass.qurey();
        }
    }
}

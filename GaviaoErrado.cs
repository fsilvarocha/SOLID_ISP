using SOLID_ISP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ISP
{
    public class GaviaoErrado : IAveErrado
    {
        public void Bicar()
        {
            //implementa algo
            throw new NotImplementedException();
        }

        public void Voar()
        {
            //implementa algo
            throw new NotImplementedException();
        }
    }
}

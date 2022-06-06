using SOLID_ISP.Interface;
using System;

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
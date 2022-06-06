using SOLID_ISP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ISP
{
    public class GalinhaErrado : IAveErrado
    {
        public void Bicar()
        {
            //implementa algo
            throw new NotImplementedException();
        }
        //fere o principio, pq apesar de ser uma ave, galinha nao voa, e com isso nao deveria ter esse método, pra não forçar a fazer algo q nao fazem
        public void Voar()
        {
            throw new NotImplementedException();
        }
    }
}

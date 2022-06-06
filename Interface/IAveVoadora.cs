using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ISP.Interface
{
    public interface IAveVoadora : IAveCerta
    {
        void Voar();
    }
}

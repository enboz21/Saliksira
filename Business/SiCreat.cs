using Core;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    internal class SiCreat : ICreat<Randevular>
    {
        public Randevular Create(Randevular data)
        {
            if(data.RandevuDurumu == 0)
            {
                data.RandevuDurumu = 1;
            }
            return data;
        }
    }
}

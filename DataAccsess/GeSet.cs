using DataAccsess.abstrack;
using DataAccsess.Interface;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess
{
    public class GeSet : DataBaseAc<Cin>, IGeSet
    {
        public GeSet(AContext context) : base(context)
        {
        }


    }
}

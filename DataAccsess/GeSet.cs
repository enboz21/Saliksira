using DataAccsess.abstrack;
using DataAccsess.Interface;
using Entity;

namespace DataAccsess
{
    public class GeSet : DataBaseAc<Cin>, IGeSet
    {
        public GeSet(AContext context) : base(context)
        {
        }


    }
}

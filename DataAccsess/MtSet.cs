using DataAccsess.abstrack;
using DataAccsess.Interface;
using Entity;

namespace DataAccsess
{
    public class MtSet : DataBaseAc<Durum>, IMtSet
    {
        public MtSet(AContext context) : base(context)
        {
        }
    }
}

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
    public class MtSet : DataBaseAc<Durum>, IMtSet
    {
        public MtSet(AContext context) : base(context)
        {
        }
    }
}

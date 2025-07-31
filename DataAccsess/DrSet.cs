using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess
{
    internal class DrSet : DataBaseAc<Doktorlar>
    {
        public DrSet(AContext context) : base(context)
        {
        }
    }
}

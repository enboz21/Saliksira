using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess
{
    public class PatientQuery
    {
        public static async Task<List<Hastalar>> GetAllPatients() 
        {
            AContext ac = new AContext();
            return await ac.Hastalars.ToListAsync();
        }
    }
}

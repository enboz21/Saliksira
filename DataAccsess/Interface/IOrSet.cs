using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Interface
{
    public interface IOrSet : IDataSet<Randevular>
    {
        Task<List<Randevular>> GetAll();
        Task<List<Randevular>> GetByName(string name);
        Task<Randevular> GetByHId(int hId);
    }
}

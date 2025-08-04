using Business.abstrack;
using Business.@interface;
using Core;
using DataAccsess.Interface;
using Entity;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class GeSer : ServiceBase<Cin>, IGeSer
    {
        private readonly IGeSet _geSet;
        public GeSer(IGeSet dataSet) : base(dataSet)
        {
            _geSet = dataSet;
        }

        public async Task<List<GeDTO>> GetAll()
        {
            var TEMP = await _dataSet.GetAll();

            return TEMP.Select(x => new GeDTO
            {
                Id = x.Id,
                cins = x.Cinsiyet
            }).ToList();
        }
    }
}

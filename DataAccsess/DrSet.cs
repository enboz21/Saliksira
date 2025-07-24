using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess
{
    public class DrSet : IDataSet<Doktorlar>
    {
        private readonly AContext _con;
        public DrSet(AContext context)
        {
            _con = context;
        }

        public List<Doktorlar> GetAll()
        {
            return _con.Doktorlars.ToListAsync().Result;
        }

        public Doktorlar GetById(int Id)
        {
            return _con.Doktorlars.FindAsync(Id).Result;
        }

        public void Save(Doktorlar Data)
        {
            if (Data == null)
                throw new ArgumentNullException(nameof(Data));
            _con.Doktorlars.AddAsync(Data);
            _con.SaveChangesAsync();
        }
        /*public async Task Save(Doktorlar Data)
{
   if (Data == null)
       throw new ArgumentNullException(nameof(Data));
   await _con.Doktorlars.AddAsync(Data);
   await _con.SaveChangesAsync();
}
public async Task<List<Doktorlar>> GetAll()
{
   return await _con.Doktorlars.ToListAsync();
}
public async Task<Doktorlar> GetById(int Id)
{

   return await _con.Doktorlars.FindAsync(Id);
}*/
    }

    public class  DrCreat
    {
        public Doktorlar creat(String name,String Lname, String expertise,String ph,bool active)
        {
            return new Doktorlar()
            {
                Ad = name,
                Soyad = Lname,
                UzmanlikAlani = expertise,
                TelefonNumarasi = ph,
                AktifMi = active
            };
        }
    }

    public class DrService 
    {
        private readonly DrCreat _drCreat;
        private readonly IDataSet<Doktorlar> _drSet;
        public DrService(DrCreat drCreat, IDataSet<Doktorlar> drSet)
        {
            _drCreat = drCreat;
            _drSet = drSet;
        }
        public void AddDoctor(String name, String Lname, String expertise, String ph, bool active)
        {
            var doctor = _drCreat.creat(name, Lname, expertise, ph, active);
            _drSet.Save(doctor);
        }
        public void AddDoctor(Doktorlar data)
        {
            _drSet.Save(data);
        }

        public List<Doktorlar> GetAllDoctors()
        {
             return _drSet.GetAll();
            
        }
        public Doktorlar GetDoctorById(int id)
        {
            return _drSet.GetById(id);
        }


    }

}

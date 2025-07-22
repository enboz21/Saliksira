using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task Save(Doktorlar Data)
        {
            if (Data == null)
                throw new ArgumentNullException(nameof(Data));
            await _con.Doktorlars.AddAsync(Data);
            await _con.SaveChangesAsync();
        }
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
        public async Task AddDoctor(String name, String Lname, String expertise, String ph, bool active)
        {
            var doctor = _drCreat.creat(name, Lname, expertise, ph, active);
            await _drSet.Save(doctor);
        }
    }

}

using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccsess
{
    public class PatientsSet : IDataSet<Hastalar>
    {
        private readonly AContext _con;
        public PatientsSet(AContext context)
        {
            _con = context;
        }

        public List<Hastalar> GetAll()
        {
            return _con.Hastalars.ToListAsync().Result;
        }

        public Hastalar GetById(int Id)
        {
            return _con.Hastalars.FindAsync(Id).Result;
        }

        public void Save(Hastalar Data)
        {
            if (Data == null)
                throw new ArgumentNullException(nameof(Data));
             _con.Hastalars.AddAsync(Data);
             _con.SaveChangesAsync();
        }

        /*public  async Task<List<Hastalar>> GetAll()
        {
            return await _con.Hastalars.ToListAsync();
        }

        public async Task<Hastalar> GetById(int Id)
        {
            return await _con.Hastalars.FindAsync(Id);
        }

        public async Task Save(Hastalar Data)
        {
            if (Data == null)
                throw new ArgumentNullException(nameof(Data));
            await _con.Hastalars.AddAsync(Data);
            await _con.SaveChangesAsync();
        }*/
    }
    public class patientsCreat
    {
        public Hastalar creat(String name, String Lname, String TC, DateOnly dob, String gender, String ph, String adress, bool foreign)
        {
            return new Hastalar()
            {
                Ad = name,
                Soyad = Lname,
                TckimlikNo = TC,
                DogumTarihi = dob,
                Cinsiyet = gender,
                TelefonNumarasi = ph,
                Adres = adress,
                YabanciMi = foreign
            };
        }
    }
    public class PatientsService
    {
        private readonly patientsCreat _patientsCreat;
        private readonly IDataSet<Hastalar> _patientsSet;
        public PatientsService(patientsCreat patientsCreat, IDataSet<Hastalar> patientsSet)
        {
            _patientsCreat = patientsCreat;
            _patientsSet = patientsSet;
        }
        public void AddPatient(String name, String Lname, String TC, DateOnly dob, String gender, String ph, String adress, bool foreign)
        {
            var patient = _patientsCreat.creat(name, Lname, TC, dob, gender, ph, adress, foreign);
             _patientsSet.Save(patient);
        }
        public void AddPatient(Hastalar data)
        {
             _patientsSet.Save(data);
        }

        public List<Hastalar> GetAllPatients()
        {
            return _patientsSet.GetAll();
        }
        public Hastalar GetPatientById(int id)
        {
            return _patientsSet.GetById(id);
        }
    }
}

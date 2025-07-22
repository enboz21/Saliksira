using Entity;
using System;
using System.Linq;

namespace DataAccsess
{
    public class PatientsSet : IDataSet<Hastalar>
    {
        private readonly AContext _con;
        public PatientsSet(AContext context)
        {
            _con = context;
        }

        public async Task Save(Hastalar Data)
        {
            if (Data == null)
                throw new ArgumentNullException(nameof(Data));
            await _con.Hastalars.AddAsync(Data);
            await _con.SaveChangesAsync();
        }
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
        public async Task AddPatient(String name, String Lname, String TC, DateOnly dob, String gender, String ph, String adress, bool foreign)
        {
            var patient = _patientsCreat.creat(name, Lname, TC, dob, gender, ph, adress, foreign);
            await _patientsSet.Save(patient);
        }
    }
}

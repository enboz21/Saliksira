using Entity;
using DataAccsess;
using System.Threading.Tasks;

namespace Business
{
    public class DrBus : IDrServiceBus<Doktorlar>
    {

        /*static AContext context = new AContext();
        private static DrCreat drCreat = new DrCreat();
        private static IDataSet<Doktorlar> drSet = new DrSet(context);*/

        private readonly DrCreat _drCreat;
        private readonly IDataSet<Doktorlar> _drSet;

        private readonly DrService _drS;

        public DrBus()
        {
            AContext context = new AContext();
            _drCreat = new DrCreat();
            _drSet = new DrSet(context);
            _drS= new DrService(_drCreat, _drSet);
        }

        public void AddDoctor(string name, string Lname, string expertise, string ph, bool active)
        {
            _drS.AddDoctor(name, Lname, expertise, ph, active);
        }

        public void AddDoctor(Doktorlar data)
        {
            _drS.AddDoctor(data);
        }

        public async Task<List<Doktorlar>> GetAllDoctors()
        {
            return await _drS.GetAllDoctors();
        }

        public async Task<Doktorlar> GetDoctorById(int id)
        {
            Doktorlar doctor = await _drS.GetDoctorById(id);

            if (doctor != null)
            {
                return doctor;
            }
            throw new ArgumentNullException(nameof(doctor), "Doctor not found");
        }






        /*public async Task AddDoctor(string name, string Lname, string expertise, string ph, bool active)
        {
            
            await _drS.AddDoctor(name, Lname, expertise, ph, active);
        }
        public async Task AddDoctor(Doktorlar data)
        {
            await _drS.AddDoctor(data);
        }

        public Task<List<Doktorlar>> GetAllDoctors()
        {
           return _drS.GetAllDoctors();
        }

        public Task<Doktorlar> GetDoctorById(int id)
        {
            Task<Doktorlar> doctor =  _drS.GetDoctorById(id);

            if (doctor != null)
            {
                return doctor;
            }
            throw new ArgumentNullException(nameof(doctor), "Doctor not found");

        }*/
    }
}

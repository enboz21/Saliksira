using DataAccsess;
using Entity;

namespace Business
{
    public class PtBus : IPtServiceBus<Hastalar>
    {
        private readonly patientsCreat _ptCreat;
        private readonly IDataSet<Hastalar> _ptSet;
        private readonly PatientsService _ptS;

        public PtBus()
        {
            AContext context = new AContext();
            _ptCreat = new patientsCreat();
            _ptSet = new PatientsSet(context);
            _ptS = new PatientsService(_ptCreat, _ptSet);
        }

        public void AddPt(string name, string Lname, string TC, DateOnly dob, string gender, string ph, string adress)
        {
            _ptS.AddPatient(name, Lname, TC, dob, gender, ph, adress);
        }

        public void AddPt(Hastalar data)
        {
            _ptS.AddPatient(data);
        }

        public async Task<List<Hastalar>> GetAllPts()
        {
            return await _ptS.GetAllPatients();
        }

        public async Task<Hastalar> GetPtById(int id)
        {
            Hastalar pt =  await _ptS.GetPatientById(id);

            if (pt != null)
            {
                return  pt;
            }
            throw new ArgumentNullException(nameof(pt), "Doctor not found");
        }


    }
}

using DataAccsess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void AddPt(string name, string Lname, string TC, DateOnly dob, string gender, string ph, string adress, bool foreign)
        {
            _ptS.AddPatient(name, Lname, TC, dob, gender, ph, adress, foreign);
        }

        public void AddPt(Hastalar data)
        {
            _ptS.AddPatient(data);
        }

        public List<Hastalar> GetAllPts()
        {
            return _ptS.GetAllPatients();
        }

        public Hastalar GetPtById(int id)
        {
            Hastalar pt = _ptS.GetPatientById(id);

            if (pt != null)
            {
                return  pt;
            }
            throw new ArgumentNullException(nameof(pt), "Doctor not found");
        }



        /*public async Task AddPt(string name, string Lname, string TC, DateOnly dob, string gender, string ph, string adress, bool foreign)
        {
            await _ptS.AddPatient(name, Lname, TC, dob, gender, ph, adress, foreign);
        }

        public async Task AddPt(Hastalar data)
        {
            await _ptS.AddPatient(data);
        }

        public Task<List<Hastalar>> GetAllPts()
        {
            return _ptS.GetAllPatients();
        }

        public async Task<Hastalar> GetPtById(int id)
        {
            Task<Hastalar> pt = _ptS.GetPatientById(id);

            if (pt != null)
            {
                return await pt;
            }
            throw new ArgumentNullException(nameof(pt), "Doctor not found");

        }*/


    }
}

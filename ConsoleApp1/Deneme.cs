using Business;
using DataAccsess;
using Entity;
using Newtonsoft.Json;
using System.Numerics;
using System.Threading.Tasks;
using System.Xml;
public class Deneme
{
      
    public static async Task Main(string[] args)
    {
        /*var patients = await PatientQuery.GetAllPatients();
        foreach (var patient in patients)
        {
            Console.WriteLine($"Ad: {patient.Ad}, Soyad: {patient.Soyad}, TC: {patient.TckimlikNo}, " +
                              $"Doðum Tarihi: {patient.DogumTarihi}, Cinsiyet: {patient.Cinsiyet}, " +
                              $"Telefon: {patient.TelefonNumarasi}, Adres: {patient.Adres}, Yabancý mý: {patient.YabanciMi}");
        }
        Console.ReadLine();*/

        AContext ac = new AContext();
        DrCreat drCreat = new DrCreat();
        IDataSet<Doktorlar> drSet = new DrSet(ac);
        DrService drS = new DrService(drCreat, drSet);

        /*DrBus DrBus = new DrBus();
        await DrBus.AddDoctor("Ali", "Veli", "Cardiology", "1234567890", true);

        
        Task<List<Doktorlar>> doctors = drS.GetAllDoctors();
        foreach (var doctor in await doctors)
        {
            Console.WriteLine($"Ad: {doctor.Ad}, Soyad: {doctor.Soyad}, Uzmanlýk Alaný: {doctor.UzmanlikAlani}, " +
                              $"Telefon: {doctor.TelefonNumarasi}, Aktif Mi: {doctor.AktifMi}");
        }

        Console.WriteLine("Doktorlar Listesi:", doctors );
        Console.ReadLine();*/

        DrBus drbus = new DrBus();
        PtBus ptc = new PtBus();

        /*Doktorlar doctor = await drbus.GetDoctorById(1);
        Console.WriteLine($"Ad: {doctor.Ad}, Soyad: {doctor.Soyad}, Uzmanlýk Alaný: {doctor.UzmanlikAlani}, " +
                             $"Telefon: {doctor.TelefonNumarasi}, Aktif Mi: {doctor.AktifMi}");
        Console.ReadLine();*/
        string jsonOutput = JsonConvert.SerializeObject(await ptc.GetPtById(1), Newtonsoft.Json.Formatting.Indented);
        Console.WriteLine(jsonOutput);
        Console.ReadLine();
    }
}
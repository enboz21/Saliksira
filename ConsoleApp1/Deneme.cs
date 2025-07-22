using Entity;
using DataAccsess;
using System.Threading.Tasks;

public class Deneme
{
    public static async Task Main(string[] args)
    {
        var patients = await PatientQuery.GetAllPatients();
        foreach (var patient in patients)
        {
            Console.WriteLine($"Ad: {patient.Ad}, Soyad: {patient.Soyad}, TC: {patient.TckimlikNo}, " +
                              $"Do�um Tarihi: {patient.DogumTarihi}, Cinsiyet: {patient.Cinsiyet}, " +
                              $"Telefon: {patient.TelefonNumarasi}, Adres: {patient.Adres}, Yabanc� m�: {patient.YabanciMi}");
        }
        Console.ReadLine();
    }
}
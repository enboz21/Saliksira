# Sağlık Sıra Sistemi

Sağlık Sıra Sistemi, staj sürecinde çalışılan şirketin talebi üzerine geliştirilmiş, sağlık ocaklarında **lokal olarak** sıra yönetimi, denetimi ve doktorlar için hasta sırası takibini kolaylaştıran kapsamlı bir yazılımdır. Bu sistem, sağlık kuruluşlarının günlük iş akışını optimize ederek bekleme sürelerini azaltmayı ve hem hastalar hem de sağlık çalışanları için daha düzenli ve verimli bir ortam sağlamayı hedefler.

## 🚀 Özellikler

* **Sıra Yönetimi:** Hastaların sisteme kolayca kaydedilmesini ve onlara hızlıca sıra verilmesini sağlar, böylece bekleme süreleri optimize edilir.

* **Sıra Denetimi:** Oluşturulan sıraların anlık takibi ve yönetimi.

* **Doktor Takibi:** Doktorların kendi hasta sıralarını kolayca görmesi ve yönetmesi.

* **Lokal Çalışma:** Sağlık ocağı içinde bağımsız ve güvenli bir şekilde çalışabilme yeteneği.

## 🛠️ Teknolojiler

Bu sistem iki ana bileşenden oluşmaktadır: **Kullanıcı Arayüzü (Frontend)** ve **Web API (Backend)**.

### Kullanıcı Arayüzü (Frontend)

* **C#:** Uygulama mantığı ve işlevselliği için.

* **DevExpress:** Zengin ve kullanıcı dostu arayüz tasarımı için.

### Web API (Backend)

* **C#:** Tüm backend mantığı ve veri işleme süreçleri için.

* **.NET Framework:** Belirli modüller ve entegrasyonlar için.

* **.NET Core:** Modern, platformlar arası uyumluluk ve yüksek performans için.

* **Entity Framework:** Veritabanı ile etkileşim için ORM (Object-Relational Mapping) aracı olarak.

### Veritabanı

* **SQL Server:** Güvenilir ve ölçeklenebilir veri depolama için.

## ⚙️ Kurulum Talimatları

Sistemi kendi ortamınızda çalıştırmak için aşağıdaki adımları izlemeniz gerekmektedir.

### 1. Web API Kurulumu

Web API'nin bir sunucuya kurulması gerekmektedir. **IIS (Internet Information Services)** kullanılması tavsiye edilir.

1. **Veritabanı Yedeği:** Proje klasöründe bulunan `Veritabanı` dizini içerisinde veritabanının yedeği (`.bak` dosyası) bulunmaktadır. Bu yedeği SQL Server'ınıza restore ederek veritabanını kurabilirsiniz.

2. **Veritabanı Bağlantı Ayarları:** Web API'nin veritabanına doğru şekilde bağlanabilmesi için `appsettings.json` dosyasını kendi sunucu ayarlarınıza göre düzenlemeniz gerekmektedir. Dosyanın içeriği aşağıdaki gibi olmalıdır, `ConnectionStrings` altındaki değerleri kendi SQL Server bilgilerinizle güncelleyin:

```json
{
"ConnectionStrings": {
"DefaultConnection": "Server=SUNUCU_ADINIZ;Database=VERITABANI_ADINIZ;TrustServerCertificate=True;User Id=KULLANICI_ADINIZ;Password=SIFRENIZ;"
},
"Logging": {
"LogLevel": {
"Default": "Information",
"Microsoft.AspNetCore": "Warning"
}
},
"AllowedHosts": "*"
}
```
3. **Yayınlama:** Web API projesini Visual Studio üzerinden veya tercih ettiğiniz bir yöntemle IIS ya da başka bir web sunucusuna yayınlayın.

4. **Çalıştırma:** Web API'nin sunucunuzda çalıştığından emin olun.

### 2. Kullanıcı Arayüzü Kurulumu

Kullanıcı arayüzünün Web API ile doğru şekilde iletişim kurabilmesi için API adresinin belirtilmesi gerekmektedir.

1. **`BaseUrl.txt` Dosyası:** Arayüz uygulamasının çalıştığı dizinde `BaseUrl.txt` adında bir dosya oluşturun.

* Bu dosyanın içine Web API'nizin IP adresi ve portunu yazın. Örneğin: `https://localhost:44352/api/`

* Eğer dosya yoksa ve programı ilk kez çalıştırırsanız, program otomatik olarak varsayılan `https://localhost:44352/api/` değeriyle dosyayı oluşturacaktır. Ancak, Web API'yi sunucuya kurduysanız, uygulamanın doğru çalışması için bu dosyadaki URL'i kendi API adresinizle güncellemeniz gerekmektedir.

## 💡 Kullanım

Sistem, sağlık ocağı personeli ve doktorlar tarafından kolayca kullanılabilir:

* **Hasta Kaydı ve Sıra Oluşturma:** Yeni hastaların sisteme kaydı ve onlara sıra verilmesi.

* **Sıra Takibi:** Bekleyen hastaların ve aktif sıraların anlık olarak görüntülenmesi.

* **Doktor Paneli:** Doktorların kendi muayene odalarından sıradaki hastalarını görmesi ve çağırması.

* **Denetim ve Raporlama:** Sıra akışının genel denetimi ve gerektiğinde raporlama imkanı.

## 🤝 Katkıda Bulunma

Bu projeyi daha da geliştirmek için her türlü katkıya açığız! Eğer bir hata bulursanız veya yeni bir özellik eklemek isterseniz, lütfen bir "issue" açmaktan veya bir "pull request" göndermekten çekinmeyin.

## 📄 Lisans

Bu proje, [MIT Lisansı](https://opensource.org/licenses/MIT) altında lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakınız.
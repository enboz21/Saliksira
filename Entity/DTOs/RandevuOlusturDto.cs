using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
        public class RandevuOlusturDto
        {
            // JSON'dan gelen isimlerle eşleşmeli
            [Required(ErrorMessage = "Hasta ID zorunludur.")]
            public int HastaId { get; set; } // JSON'daki "hastaId"

            [Required(ErrorMessage = "Doktor ID zorunludur.")]
            public int DoktorId { get; set; } // JSON'daki "doktorId"

            [Required(ErrorMessage = "Randevu Durumu ID zorunludur.")]
            // JSON'daki "randevuDurumu" ile eşleşmesi için adını aynen bırakıyorum.
            // Eğer JSON'da "randevuDurumuId" gönderseydiniz daha uygun olurdu.
            public byte RandevuDurumu { get; set; } // JSON'daki "randevuDurumu"
                                                    // Randevular'daki RandevuDurumu byte olduğu için burada da byte olmalı
                                                    // ... diğer randevu detayları (örn: RandevuTarihi, RandevuSaati)
                                                    // public DateTime RandevuTarihi { get; set; }
                                                    // public TimeSpan RandevuSaati { get; set; }
        }
    }

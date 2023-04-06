using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numara_Cevirme_Uygulaması
{
    public class SehirKod
    {
        public string SehirAdi { get; set; }
        public int TelefonKodu { get; set; }



    }
    public class StaticVariables
    {
        public static List<SehirKod> sehirList = new List<SehirKod>
        {
            new SehirKod{ SehirAdi = "Adana", TelefonKodu = 322},
            new SehirKod{ SehirAdi = "Kırıkkale", TelefonKodu = 318},
            new SehirKod{ SehirAdi = "Adıyaman", TelefonKodu = 416},
            new SehirKod{ SehirAdi = "Kırklareli", TelefonKodu = 288},
            new SehirKod{ SehirAdi = "Afyon", TelefonKodu = 272},
            new SehirKod{ SehirAdi = "Kırşehir", TelefonKodu = 386},
            new SehirKod{ SehirAdi = "Ağrı", TelefonKodu = 472},
            new SehirKod{ SehirAdi = "Kilis", TelefonKodu = 348},
            new SehirKod{ SehirAdi = "Aksaray", TelefonKodu = 382},
            new SehirKod{ SehirAdi = "K.Maraş", TelefonKodu = 344},
            new SehirKod{ SehirAdi = "Amasya", TelefonKodu = 358},
            new SehirKod{ SehirAdi = "Kocaeli", TelefonKodu = 262},
            new SehirKod{ SehirAdi = "Ankara", TelefonKodu = 312},
            new SehirKod{ SehirAdi = "Konya", TelefonKodu = 332},
            new SehirKod{ SehirAdi = "Antalya", TelefonKodu = 242},
            new SehirKod{ SehirAdi = "Kütahya", TelefonKodu = 274},
            new SehirKod{ SehirAdi = "Ardahan", TelefonKodu = 478},
            new SehirKod{ SehirAdi = "Malatya", TelefonKodu = 422},
            new SehirKod{ SehirAdi = "Artvin", TelefonKodu = 466},
            new SehirKod{ SehirAdi = "Manisa", TelefonKodu = 236},
            new SehirKod{ SehirAdi = "Aydın", TelefonKodu = 256},
            new SehirKod{ SehirAdi = "Mardin", TelefonKodu = 482},
            new SehirKod{ SehirAdi = "Balıkesir", TelefonKodu = 266},
            new SehirKod{ SehirAdi = "Muğla", TelefonKodu = 252},
            new SehirKod{ SehirAdi = "Bartın", TelefonKodu = 378},
            new SehirKod{ SehirAdi = "Muş", TelefonKodu = 436},
            new SehirKod{ SehirAdi = "Batman", TelefonKodu = 488},
            new SehirKod{ SehirAdi = "Nevşehir", TelefonKodu = 384},
            new SehirKod{ SehirAdi = "Bayburt", TelefonKodu = 458},
            new SehirKod{ SehirAdi = "Niğde", TelefonKodu = 388},
            new SehirKod{ SehirAdi = "Bilecik", TelefonKodu = 228},
            new SehirKod{ SehirAdi = "Ordu", TelefonKodu = 452},
            new SehirKod{ SehirAdi = "Bingöl", TelefonKodu = 426},
            new SehirKod{ SehirAdi = "Osmaniye", TelefonKodu = 328},
            new SehirKod{ SehirAdi = "Bitlis", TelefonKodu = 434},
            new SehirKod{ SehirAdi = "Rize", TelefonKodu = 464},
            new SehirKod{ SehirAdi = "Bolu", TelefonKodu = 374},
            new SehirKod{ SehirAdi = "Sakarya", TelefonKodu = 264},
            new SehirKod{ SehirAdi = "Burdur", TelefonKodu = 248},
            new SehirKod{ SehirAdi = "Samsun", TelefonKodu = 362},
            new SehirKod{ SehirAdi = "Bursa", TelefonKodu = 224},
            new SehirKod{ SehirAdi = "Siirt", TelefonKodu = 484},
            new SehirKod{ SehirAdi = "Çanakkale", TelefonKodu = 286},
            new SehirKod{ SehirAdi = "Sinop", TelefonKodu = 368},
            new SehirKod{ SehirAdi = "Çankırı", TelefonKodu = 376},
            new SehirKod{ SehirAdi = "Sivas", TelefonKodu = 346},
            new SehirKod{ SehirAdi = "Çorum", TelefonKodu = 364},
            new SehirKod{ SehirAdi = "Şanlıurfa", TelefonKodu = 414},
            new SehirKod{ SehirAdi = "Denizli", TelefonKodu = 258},
            new SehirKod{ SehirAdi = "Şırnak", TelefonKodu = 486},
            new SehirKod{ SehirAdi = "Diyarbakır", TelefonKodu = 412},
            new SehirKod{ SehirAdi = "Tekirdağ", TelefonKodu = 282},
            new SehirKod{ SehirAdi = "Düzce", TelefonKodu = 380},
            new SehirKod{ SehirAdi = "Tokat", TelefonKodu = 356},
            new SehirKod{ SehirAdi = "Edirne", TelefonKodu = 284},
            new SehirKod{ SehirAdi = "Trabzon", TelefonKodu = 462},
            new SehirKod{ SehirAdi = "Elazığ", TelefonKodu = 424},
            new SehirKod{ SehirAdi = "Tunceli", TelefonKodu = 428},
            new SehirKod{ SehirAdi = "Erzincan", TelefonKodu = 446},
            new SehirKod{ SehirAdi = "Uşak", TelefonKodu = 276},
            new SehirKod{ SehirAdi = "Erzurum", TelefonKodu = 442},
            new SehirKod{ SehirAdi = "Van", TelefonKodu = 432},
            new SehirKod{ SehirAdi = "Eskişehir", TelefonKodu = 222},
            new SehirKod{ SehirAdi = "Yalova", TelefonKodu = 226},
            new SehirKod{ SehirAdi = "Gaziantep", TelefonKodu = 342},
            new SehirKod{ SehirAdi = "Yozgat", TelefonKodu = 354},
            new SehirKod{ SehirAdi = "Giresun", TelefonKodu = 454},
            new SehirKod{ SehirAdi = "Zonguldak", TelefonKodu = 372},
            new SehirKod{ SehirAdi = "Gümüşhane", TelefonKodu = 456},
            new SehirKod{ SehirAdi = "K.K.T.C", TelefonKodu = 392},
            new SehirKod{ SehirAdi = "Hakkari", TelefonKodu = 438},
            new SehirKod{ SehirAdi = "Turkcell-GSM", TelefonKodu = 532},
            new SehirKod{ SehirAdi = "Turkcell-GSM", TelefonKodu = 533},
            new SehirKod{ SehirAdi = "Hatay", TelefonKodu = 326},
            new SehirKod{ SehirAdi = "Telsim-GSM", TelefonKodu = 542},
            new SehirKod{ SehirAdi = "Telsim-GSM", TelefonKodu = 543},
            new SehirKod{ SehirAdi = "Iğdır", TelefonKodu = 476},
            new SehirKod{ SehirAdi = "Mobil – 1", TelefonKodu = 522},
            new SehirKod{ SehirAdi = "Isparta", TelefonKodu = 246},
            new SehirKod{ SehirAdi = "Çağrı – 1", TelefonKodu = 512},
            new SehirKod{ SehirAdi = "İçel", TelefonKodu = 324},
            new SehirKod{ SehirAdi = "Ücretsiz hatlar", TelefonKodu = 800},
            new SehirKod{ SehirAdi = "İstanbul (Avr)", TelefonKodu = 212},
            new SehirKod{ SehirAdi = "ISS Telefon", TelefonKodu = 822},
            new SehirKod{ SehirAdi = "İstanbul (And", TelefonKodu = 216},
            new SehirKod{ SehirAdi = "Mesaj Servisleri", TelefonKodu = 900},
            new SehirKod{ SehirAdi = "İzmir", TelefonKodu = 232},
            new SehirKod{ SehirAdi = "Karabük", TelefonKodu = 370},
            new SehirKod{ SehirAdi = "Karaman", TelefonKodu = 338},
            new SehirKod{ SehirAdi = "Kars", TelefonKodu = 474},
            new SehirKod{ SehirAdi = "Kastamonu", TelefonKodu = 366},
            new SehirKod{ SehirAdi = "Kayseri", TelefonKodu = 352}

        };
    }
}

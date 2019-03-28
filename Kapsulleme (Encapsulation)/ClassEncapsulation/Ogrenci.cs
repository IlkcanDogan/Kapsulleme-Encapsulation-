using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEncapsulation
{
    class Ogrenci
    {

        /* Kapsülleme (encapsulation)
         * Amaç ==> Field'ın dışarıdan gelen veri bozulmalarına karşı korunmasıdır. Field,
         * private olarak işaretlenir. Yani dışarıdan doğrudan erişim engellenir. Field'a ait
         * property public yapılarak o field'a property üzerinden erişim sağlanır.
         */
        string ad_; //Field

        /*
         * Full property. Kısayolu --> propfull yazıp tab tab
         * 
         * Her property oluşturduğumuzda GET ve SET metotları otomatik olarak gelir.
         * İhtiyaçlarımıza göre GET ve SET metotlarını düzenleriz. Şöyle ki, Field ile işler yapıp
         * ekranda göstermek istemiyorsak GET metodunu yazmayız. Dışarıdan Field'a veri girilmesini
         * istemiyorsak de SET metodunu yazmayız. 
         */
        public string ad
        {
            get
            {
                return ad_;
            }
            set
            {
                if (value == "") // Ad girilmezse otomatik olarak ad'a girilmedi yazacak.
                    ad_ = "Girilmedi";
                else // Ad girilirse, girilen değeri ad Field'a verecek
                    ad_ = value;
            }
        }

        //-----------------------------------------------------------------------------------------//
        private double vize_;
        public double vize
        {
            get
            {
                return vize_;
            }
            set
            {
                if (value > 100 || value < 0) // Vize değerini 0 ile 100 arasında girilmesi için koşul koyduk.
                    vize_ = 0;
                else
                    vize_ = value;
            }
        }
        //-----------------------------------------------------------------------------------------//
        private double final_;
        public double final
        {
            get
            {
                return final_;
            }
            set
            {
                if (value > 100 || value < 0)
                    final_ = 0;
                else
                    final_ = value;
            }
        }
        //-----------------------------------------------------------------------------------------//
        private double ortalama_;
        public double ortalama
        {
            get // SET metotdunu yazmadı çünkü dışarıdan ortalama verisi girilmeyecek. Vize ve final notları girildiğinde hesaplama yapıp GET metodu ile ortalama döndürecek.
            {
                return vize * 0.4 + final * 0.6;
            }
        }
        //-----------------------------------------------------------------------------------------//
        private string uyruk_ = "Türkiye Cumhuriyeti";
        public string uyruk
        {
            get
            {
                return uyruk_;
            }
            //SET metodunu kaldırarak Field'ı sadece okunabilir yaptık (read only).
        }
        //-----------------------------------------------------------------------------------------//
        private DateTime dogumTarihi_;
        public DateTime dogumTarihi
        {
            set
            {
                if (value >= DateTime.Now)
                    dogumTarihi_ = DateTime.Now;
                else
                    dogumTarihi_ = value;
            }
        }
        //-----------------------------------------------------------------------------------------//
        private int yas_;
        public int yas
        {
            get
            {
                return (int)(DateTime.Now - dogumTarihi_).TotalDays / 365;
            }
        }
        //-----------------------------------------------------------------------------------------//
        public bool cinsiyet { get; set; } // Auto Property
        /*
         * Auto Property ==> Field'ı içinde olan property'dir. Faydası Field'ı yazmamış (oluşturmamış) oluruz 
         * ve böylelikle PRIVATE olan Field kabalığından kurtuluruz.
         * Field içerisinde arka planda otomatik olarak oluşturulur. (BACKING FIELD). 
         * Auto Property içerisindeki GET ve SET metotları normal property ile aynı görevleri görürler.
         * Tek farkları Auto property içerisinde kod olmaz. Eğer yazarsak Auto Property özelliğini kaybetmiş
         * normal property haline getirmiş oluruz ki burada doğru şekilde yazmamız gerekir. Eğer Auto Property'yi 
         * READ ONLY veya WRITE ONLY yapmak istersek yani GET'i veya SET'i kullanmak istemiyorsak o özelliğin başına
         * Private anahtar sözcüğünü yazarız.
         */
        //-----------------------------------------------------------------------------------------//
        public string ulke { get; private set; }
        //-----------------------------------------------------------------------------------------//
        public string basari()
        {
            if (ortalama < 50)
                return "Başarısız. Ortalama: " + ortalama;
            else
                return "Başarılı. Ortalama: " + ortalama;


        }
    }
}

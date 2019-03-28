using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEncapsulation
{
    class Bilgisayar
    {
        string Marka_;
        public string Marka 
        {
            get 
            {
                return Marka_;
            }
            set
            {
                if(value == null)
                    Marka_ = "None";
                else
                    Marka_ = value;
            }
        }

        string Model_;
        public string Model
        {  
            get
            { 
                return Model_;
            } 
            set
            {
                if(value == null)
                    Model_ = "None";
                else
                    Model_ = value;
            }
        }
        
        float Ram_ ; 
        public float Ram 
        {
            get
            {
                return Ram_;
            }
            set
            {  
                if(value < 0.0 || value > 9.9)
                    Ram_ = 0;
                else
                    Ram_ = value;
            }
        }

       float Islemci_;
       public float Islemci
       {
           get
           { 
               return Islemci_;
           }
           set
           {
              if(value == null)
                  Islemci_ = 0;
              else
                  Islemci_ = value;
           }
       }

       DateTime Kontrol_Tarih_;
       public DateTime Kontrol_Tarih //READ ONLY Yapmak için SET metodunu kullanmadım.
       {
            get
            {
                return Kontrol_Tarih_ = DateTime.Now;
            }
       }
	}   
}

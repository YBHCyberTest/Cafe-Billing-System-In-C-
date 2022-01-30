using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproje
{
    class İcecek
    {
        protected string İcecekAdi;
        protected double İcecekFiyati;
        protected int SecilenAdet;

        public İcecek(string icecekAdi,double icecekFiyati,int secilenAdet )
        {
            this.İcecekAdi = icecekAdi;
            this.İcecekFiyati = icecekFiyati;
            this.SecilenAdet = secilenAdet;
        }
        public void Set_SecilenAdet(int secilenAdet)
        {
            this.SecilenAdet = secilenAdet;
        }
        public int Get_SecilenAdet()
        {
            return this.SecilenAdet;
        }
        public string Get_Name()
        {
            return this.İcecekAdi;
        }
        public double Get_Fiyat()
        {
            return this.İcecekFiyati;
        }
        public double İcecekBelirletHespla (string icecek_Ad)
        {
            if(İcecekAdi == "su")
            {
                return this.İcecekFiyati * SecilenAdet;
            }
            else if(İcecekAdi == "çay")
            {
                return this.İcecekFiyati * SecilenAdet;
            }
            else if(İcecekAdi == "mayve suyu")
            {
                return this.İcecekFiyati * SecilenAdet;
            }
            else if(İcecekAdi == "Türk kahvesi")
            {
                return this.İcecekFiyati * SecilenAdet;
            }
            else
            {
                return 0;
            }
        }
    }
}

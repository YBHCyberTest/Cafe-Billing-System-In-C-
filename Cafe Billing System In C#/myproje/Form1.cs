using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myproje
{
    public partial class Form1 : Form
    {
        
        İcecek su = new Su("Su", 1.50, 0);
        İcecek cay = new Cay("Cay",2, 0);
        İcecek mayveSuyu = new Mayve_Suyu("mayve Suyu", 3, 0);
        İcecek turkkavesi = new Turk_Kahvesi ("Tur kahvesi", 4, 0);


        int a=0;
        int b=0;
        int c=0;
        int d=0;
        double resualt;
        bool hesap=false;





        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(NUpDownSU.Value);
            b = Convert.ToInt32(NUpDownCay.Value);
            c = Convert.ToInt32(NUpDownMayveSU.Value);
            d = Convert.ToInt32(NUpDownHahve.Value);




            if (NUpDownSU.Value != 0)
            {
          
                LisBoxİcecek.Items.Add(labelSU.Text);
                LisBoxAdet.Items.Add(NUpDownSU.Value);
                NUpDownSU.Value = 0;

            }
            if (NUpDownCay.Value != 0)
            {
                LisBoxİcecek.Items.Add(labelCay.Text);
                LisBoxAdet.Items.Add(NUpDownCay.Value);
                NUpDownCay.Value = 0;
            }
            if (NUpDownMayveSU.Value != 0)
            {
                LisBoxİcecek.Items.Add(labelMayveSU.Text);
                LisBoxAdet.Items.Add(NUpDownMayveSU.Value);

                NUpDownMayveSU.Value = 0;
            }
            if (NUpDownHahve.Value != 0)
            {
                LisBoxİcecek.Items.Add(labelKahve.Text);
                LisBoxAdet.Items.Add(NUpDownHahve.Value);

                NUpDownHahve.Value = 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
           /* 
           SUM += (a * 1.50) + (b * 2) + (c * 3) + (d * 4);

            if(SUM != 0 && hesap==false)
            {
                LBF.Items.Add(SUM);

                a = 0;
                b = 0;
                c = 0;
                d = 0;
                hesap = true;

            }
            else
            {
                return;
            }
           */
                      
                        İcecek su = new Su("Su", 1.50, 0);
                        İcecek cay = new Cay("Cay", 2, 0);
                        İcecek mayveSuyu = new Mayve_Suyu("mayve Suyu", 3, 0);
                        İcecek turkkavesi = new Turk_Kahvesi("Tur kahvesi", 4, 0);
                      
                        su.Set_SecilenAdet(Convert.ToInt32(a));
                        su.Get_SecilenAdet();
                        cay.Set_SecilenAdet(Convert.ToInt32(b));
                        cay.Get_SecilenAdet();
                        mayveSuyu.Set_SecilenAdet(Convert.ToInt32(c));
                        mayveSuyu.Get_SecilenAdet();
                        turkkavesi.Set_SecilenAdet(Convert.ToInt32(d));
                        turkkavesi.Get_SecilenAdet();

                          resualt += (resualt +(su.Get_SecilenAdet() * su.Get_Fiyat() + cay.Get_SecilenAdet() * cay.Get_Fiyat() +
                            mayveSuyu.Get_SecilenAdet() * mayveSuyu.Get_Fiyat() + turkkavesi.Get_SecilenAdet() * turkkavesi.Get_Fiyat()));
                          if(resualt != 0 && hesap==false)
                          {
                           LisBoxFatura.Items.Add(resualt+ "TL");

                           a = 0;
                           b = 0;
                           c = 0;
                           d = 0;
                           hesap = true;
                         }
                        else
                        {
                         return;
                        }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fatura.SepeteTemizle(LisBoxİcecek, LisBoxAdet, LisBoxFatura);
            resualt = 0;

             a = 0;
             b = 0;
             c = 0;
             d = 0;
            hesap = false;

        }

        private void LBF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LBD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labT_Click(object sender, EventArgs e)
        {

        }

        private void LisBoxİcecek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

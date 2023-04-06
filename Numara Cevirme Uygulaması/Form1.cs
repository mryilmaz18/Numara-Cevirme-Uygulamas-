using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Numara_Cevirme_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool PhoneControl(string telefon_no)
        {
            return (telefon_no.StartsWith("5") || telefon_no.StartsWith("05") || telefon_no.StartsWith("905") || telefon_no.StartsWith("+905"));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "";
            var fileDialog = new OpenFileDialog();
            var r = fileDialog.ShowDialog();
            if (r == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
            }
            String[] Musteri = File.ReadAllLines(filePath);
           


            for (int i = 0; i < Musteri.Count(); i++)
            {
                string telefon_no = Musteri[i].Trim().Replace(" ", "");
                if (PhoneControl(telefon_no))
                {
                    telefon_no += "  Cep Telefonu";
                }
                else
                {
                    int baslangickod = int.Parse((telefon_no.StartsWith("0")) ? telefon_no.Substring(1, 3) : telefon_no.Substring(0, 3));
                    SehirKod kod = StaticVariables.sehirList.FirstOrDefault(x => x.TelefonKodu == baslangickod);
                    telefon_no += (kod != null) ? ("   Sabit Telefon  -  " + kod.SehirAdi) : "   HATALI";
                   
                }
                Numara_Listesi.Items.Add(telefon_no);
            }

        }
    }
}

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

namespace RegisztracioAlkalmazas
{
    public partial class RegAlkForm : Form
    {
        public RegAlkForm()
        {
            InitializeComponent();
        }

        private void ÚjhobbiTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void HozzáadB_Click(object sender, EventArgs e)
        {
            if (!ÚjhobbiTB.Text.Equals(""))
            {
                this.HobbiLB.Items.Add(ÚjhobbiTB.Text);
            }

        }

        private void MentésB_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("regalk.txt"))
            {

                if (!NévTB.Text.Equals(""))
                {
                    sw.Write(NévTB.Text + ";");
                }
                NévTB.Text = "";
                sw.Write(SzülDTP.Value + ";");
                if (FérfiRadio.Checked)
                {
                    sw.Write("Férfi;");
                }
                FérfiRadio.Checked = false;
                if (NőRádió.Checked)
                {
                    sw.Write("Nő;");
                }
                NőRádió.Checked = false;
                sw.Write(HobbiLB.SelectedItem);
                sw.WriteLine();
                for (int i = 0; i < HobbiLB.Items.Count-1; i++)
                {
                    sw.Write(HobbiLB.Items[i] + ";"); 
                }
                sw.Write(HobbiLB.Items[HobbiLB.Items.Count-1]);
                HobbiLB.Items.Clear();
                ÚjhobbiTB.Text = "";

            }
        }

        private void BetöltésB_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("regalk.txt"))
            {
                List<string> list = new List<string>();
                string sor = sr.ReadLine();
                string lista = sr.ReadLine();
                string []data = sor.Split(';');
                string [] hobbik = lista.Split(';');
                string név = data[0];
                string szüldatum = data[1];
                string nem = data[2];
                string hobbi = data[3];

                NévTB.Text = név;
                SzülDTP.Value = Convert.ToDateTime(szüldatum);
                if (nem == "férfi")
                {
                    FérfiRadio.Checked = true;
                }
                if (nem == "nő")
                {
                    NőRádió.Checked = true;
                }
                for (int i = 0; i < hobbik.Count(); i++)
                {
                    HobbiLB.Items.Add(hobbik[i]);
                }
                ÚjhobbiTB.Text = hobbi;

            }

        }
    }
}

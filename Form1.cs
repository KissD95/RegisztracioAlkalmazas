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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonHozzaad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUjHobbi.Text))
            {
                MessageBox.Show("Meg kell adnia egy új hobbit", "Hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNev.Focus();
                return;
            }
            else if (listBoxHobbik.Items.Contains(textBoxUjHobbi.Text))
            {
                MessageBox.Show("A megadott hobbi már a listában van", "Hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNev.Focus();
                return;
            }
            else
            {
                listBoxHobbik.Items.Add(textBoxUjHobbi.Text);
                textBoxUjHobbi.Text = "";
            }

        }

        private void TextBoxUjHobbi_TextChanged(object sender, EventArgs e)
        {
            textBoxUjHobbi.CharacterCasing = CharacterCasing.Upper;
        }

        private void ButtonMentes_Click(object sender, EventArgs e)
        {
            string nev = textBoxNev.Text.Trim();
            string nem;
            if (radioButtonFerfi.Checked)
            {
                nem = "Férfi";
            }else
            {
                nem = "Nő";
            }
            string szuldatum = dateTimePickerSzul.Value.ToString();
            string hobbi = listBoxHobbik.SelectedItem.ToString();
            var dateTime = DateTime.Parse(szuldatum);
            var ember = new Emberek(nev, nem, szuldatum, hobbi);

            

            if (string.IsNullOrWhiteSpace(textBoxNev.Text))
            {
                MessageBox.Show("Név kitöltése kötelező", "Hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNev.Focus();
                return;
            }
            else if (dateTime>DateTime.Today)
            {
                MessageBox.Show("A születési idő nem lehet a jövőben");
            }else
            {
                var result = saveFileDialog1.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    using (var sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        sw.WriteLine(String.Format("{0};{1};{2};{3}",
                            nev, nem, szuldatum, hobbi));
                    }
                    MessageBox.Show("Sikeres mentés");
                }

                catch (IOException)
                {
                    MessageBox.Show("Hiba a kiíráskor");
                }
                textBoxNev.Text = "";
                dateTimePickerSzul.ResetText();
            }


        }

        private void ButtonBetoltes_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK)
            {
                MessageBox.Show("Nem választott ki fájlt, nem fog betöltődni.");
                return;
            }
            try
            {
                using (var sr = new StreamReader(openFileDialog1.FileName))
                {
                   
                    while (!sr.EndOfStream)
                    {
                        string[] sor = sr.ReadLine().Split(';');
                        string nev = sor[0];
                        string nem = sor[1];
                        string szuldatum= sor[2];
                        string hobbi = sor[3];
                        var ember = new Emberek(nev, nem, szuldatum, hobbi);

                        textBoxNev.Text = nev;
                       
                        var dateTime = DateTime.Parse(szuldatum);
                        dateTimePickerSzul.Value = dateTime;
                        if (!(listBoxHobbik.Items.Contains(hobbi)))
                        {
                            listBoxHobbik.Items.Add(hobbi);
                            listBoxHobbik.SelectedItem = hobbi;
                        }else
                        {
                            listBoxHobbik.SelectedItem = hobbi;
                        }
                        
                     
                    }
                    MessageBox.Show("Sikeres beolvasás!");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Hiba a fájl megnyitása során");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a fájl feldolgozása közben");
            }
        }
    }
}

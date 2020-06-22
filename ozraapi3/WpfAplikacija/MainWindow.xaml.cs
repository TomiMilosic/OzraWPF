using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AutoFixture;
using System.Net.Http.Headers;

namespace WpfAplikacija
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Admin> Admins = new List<Admin>();
        public List<Uporabnik> uporabniks = new List<Uporabnik>();
        public MainWindow()
        {
            InitializeComponent();
            IzbiraJezika.Items.Add("Slovenščina");
            IzbiraJezika.Items.Add("English");
        }

        public async void PridobiUporabnika()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage respone = await client.GetAsync("https://localhost:44321/Sportniki/admin");
            //admin
            if (respone.IsSuccessStatusCode)
            {
                string temp = await respone.Content.ReadAsStringAsync();
                Admins = JsonConvert.DeserializeObject<List<Admin>>(temp);
            }




            HttpClient client1 = new HttpClient();
            HttpResponseMessage respone1 = await client1.GetAsync("https://localhost:44321/Sportniki/uporabniki");
            //admin
            if (respone1.IsSuccessStatusCode)
            {
                string temp = await respone1.Content.ReadAsStringAsync();
                uporabniks = JsonConvert.DeserializeObject<List<Uporabnik>>(temp);
            }




        }

        private void PrijavaBtn_Click(object sender, RoutedEventArgs e)
        {
            PridobiUporabnika();

            if (!string.IsNullOrEmpty(UporabniskoImeTxb.Text) && !string.IsNullOrEmpty(GesloTxb.Text) && IzbiraJezika.SelectedIndex > -1)
            {
                foreach (var item in Admins)
                {
                    if (item.UporabniskoIme == UporabniskoImeTxb.Text && item.Geslo == GesloTxb.Text)
                    {
                        if (IzbiraJezika.SelectedIndex==0)
                        {
                            PrijavljenUporabnik prijavljenUporabnik = new PrijavljenUporabnik(item.UporabniskoIme);//dodaj ime tukaj noter
                            Evidenca(item.id.ToString());
                            prijavljenUporabnik.ShowDialog();
                        }

                        if (IzbiraJezika.SelectedIndex==1)
                        {
                            EN_PrijavljenUporabnik prijavljenUporabnik = new EN_PrijavljenUporabnik(item.UporabniskoIme);//dodaj ime tukaj noter
                            Evidenca(item.id.ToString());
                            prijavljenUporabnik.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Napaka! Napolni vsa polja");
            }
        }

        private async void Evidenca(string text)
        {
            HttpClient client = new HttpClient();
            JsonConvert.SerializeObject(text);
            var json = JsonConvert.SerializeObject(text, Formatting.Indented);
            var stringContent = new StringContent(json);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage message = await client.PostAsync("https://localhost:44321/Sportniki/evidenca/", stringContent);//link
        }

        private void PrijavaBtn_Copy_Click(object sender, RoutedEventArgs e)
        {
            PridobiUporabnika();

            if (!string.IsNullOrEmpty(Uporabnik_UporabniskoImeTxb.Text) && !string.IsNullOrEmpty(Uporabnik_GesloTxb.Text) && IzbiraJezika.SelectedIndex > -1)
            {
                foreach (var item in uporabniks)
                {
                    if (item.UporabiskoIme == Uporabnik_GesloTxb.Text && item.Geslo == Uporabnik_GesloTxb.Text)
                    {
                        if (IzbiraJezika.SelectedIndex==0)
                        {
                            Prijavljen prijavljenUporabnik = new Prijavljen(item);//dodaj ime tukaj noter
                            prijavljenUporabnik.ShowDialog();
                        }

                        if (IzbiraJezika.SelectedIndex==1)
                        {
                            EN_Prijavljen prijavljenUporabnik = new EN_Prijavljen(item);//dodaj ime tukaj noter
                            prijavljenUporabnik.ShowDialog();
                        }



                    }
                }
            }
            else
            {
                MessageBox.Show("Napaka! Napolni vsa polja");
            }
        }

        private void IzbiraJezika_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(IzbiraJezika.SelectedItem.ToString());

            if (IzbiraJezika.SelectedIndex == 1)
            {
                AdminLabel.Content = "Admin: ";
                UporabnikiLabel.Content = "User: ";
                UporabniskoImelabel2.Content = "Username: ";
                UporabiksoImelabel.Content = "Username: ";
                GesloLabelLabel.Content = "Password";
                GesloLabel.Content = "Password: ";
                PrijavaBtn.Content = "Admin login";
                PrijavaBtn_Copy.Content = "User login";
                jeziklabel.Content = "Language: ";
            }

            if (IzbiraJezika.SelectedIndex == 0)
            {
                AdminLabel.Content = "Admin: ";
                UporabnikiLabel.Content = "Uporabnik: ";
                UporabniskoImelabel2.Content = "Uporabnisko ime: ";
                UporabiksoImelabel.Content = "Uporabnisko ime: ";
                GesloLabelLabel.Content = "Geslo: ";
                GesloLabel.Content = "Geslo: ";
                PrijavaBtn.Content = "Prijava admin";
                PrijavaBtn_Copy.Content = "Prijava uporabnik: ";
                jeziklabel.Content = "Jezik: ";
            }
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAplikacija
{
    /// <summary>
    /// Interaction logic for Dogodki.xaml
    /// </summary>
    public partial class EN_Dogodki : Window
    {

        public List<Dogodek> dogodki { get; set; }
        public Dogodek dogodek{ get; set; }
        public EN_Dogodki()
        {
            InitializeComponent();
            PridobiVseDogodke();
        }

        private async void PridobiVseDogodke()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44321/Sportniki/dogodek");//Link Get all dogodek

            if (response.IsSuccessStatusCode)
            {
                var temp = await response.Content.ReadAsStringAsync();
                dogodki = JsonConvert.DeserializeObject<List<Dogodek>>(temp);
            }

            foreach (var item in dogodki)
            {
                SeznamDogodtkov.Items.Add(item.Id + " " + item.naziv + " " + item.cas);
            }
        }

        private void SeznamDogodtkov_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            foreach (var item in dogodki)
            {
                if (item.Id == PridobiID(SeznamDogodtkov.SelectedItem.ToString()))
                {
                    dogodek = item;
                }
            }
            var id = dogodek.Id;


            if (id > 0)
            {
                IDdogodkatxb.Text = dogodek.Id.ToString();
                Nazivdogodkatxb.Text = dogodek.naziv;
                casdogodkatxb.Text = dogodek.cas.ToString();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private int PridobiID(string besedilo)
        {
            string id = "";//pozi na vecmestne st

            foreach (var item in besedilo)
            {
                if (char.IsDigit(item))
                {
                    id = id + item;
                }

                if (!char.IsDigit(item))
                {
                    break;
                }
            }
            return Convert.ToInt32(id);
        }

        private void DodajDogodek_Click(object sender, RoutedEventArgs e)
        {
            var flag = true;
            Dogodek dogodek = new Dogodek();
            var stevilo = 0;
            if (int.TryParse(IDdogodkatxb.Text, out stevilo))
            {
                dogodek.Id = stevilo;
                flag = true;
            }
            else
            {
                flag = false;
            }

            dogodek.naziv= Nazivdogodkatxb.Text;
            dogodek.cas = Convert.ToInt32(casdogodkatxb.Text);

            if (flag == true)
            {
                PosljiDogodek(dogodek);
                MessageBox.Show("Event addded!");
            }
            else
            {
                MessageBox.Show("Event Not added!");
            }
        }

        private  void PosljiDogodek(Dogodek dogodek)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(dogodek);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var result=  client.PostAsync(@"https://localhost:44321/Sportniki/dogodek/"+dogodek.naziv+"/"+dogodek.cas, content).Result;
            }

        }

        private void UrediDogodekBtn_Click(object sender, RoutedEventArgs e)
        {
            var flag = true;
            Dogodek dogodek = new Dogodek();
            var stevilo = 0;
            if (int.TryParse(IDdogodkatxb.Text, out stevilo))
            {
                dogodek.Id = stevilo;
                flag = true;
            }
            else
            {
                flag = false;
            }

            dogodek.naziv = Nazivdogodkatxb.Text;
            dogodek.cas = Convert.ToInt32(casdogodkatxb.Text);

            if (flag == true)
            {
                UrediDogodek(dogodek);
                MessageBox.Show("Event updated!");
            }
            else
            {
                MessageBox.Show("Event Not updated!");
            }
        }

        private  void UrediDogodek(Dogodek dogodek)
        {

            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(dogodek);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var result = client.PutAsync(@"https://localhost:44321/Sportniki/dogodek/"+dogodek.Id+"/"+dogodek.naziv + "/" + dogodek.cas, content).Result;
            }


        }

        private void IzbrisiDogodekbtn_Click(object sender, RoutedEventArgs e)
        {
            int stevilo = 0;
            if (int.TryParse(IDdogodkatxb.Text, out stevilo))
            {
                brisiDogodek(IDdogodkatxb.Text);
                MessageBox.Show("Event deleted!");
            }
            else
            {
                MessageBox.Show("Event Not deleted");
            }
        }

        private async void brisiDogodek(string text)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.DeleteAsync("https://localhost:44321/Sportniki/dogodek/" + text);//link
        }
    }
}

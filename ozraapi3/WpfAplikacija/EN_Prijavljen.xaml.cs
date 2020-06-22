using Newtonsoft.Json;
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
using System.Windows.Shapes;

namespace WpfAplikacija
{
    /// <summary>
    /// Interaction logic for Prijavljen.xaml
    /// </summary>
    public partial class EN_Prijavljen : Window
    {
        public EN_Prijavljen()
        {
            InitializeComponent();
        }
        public EN_Prijavljen(Uporabnik uporabnik)
        {
            PridobiPodatke();
            InitializeComponent();
        }
        List<Dogodek> dogodki = new List<Dogodek>();
        List<Sportnik> sportniks = new List<Sportnik>();
        List<PrijavaNaDogodek> PrijavaNaDogodeks = new List<PrijavaNaDogodek>();
        
        private async void PridobiPodatke()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44321/Sportniki/dogodek");

            if (response.IsSuccessStatusCode)
            {
                var temp = await response.Content.ReadAsStringAsync();
                dogodki = JsonConvert.DeserializeObject<List<Dogodek>>(temp);
            }

            foreach (var item in dogodki)
            {
                SeznamDogdkov.Items.Add(item.Id + " " + item.naziv + " " + item.cas);
            }

            HttpClient client1 = new HttpClient();
            HttpResponseMessage response1 = await client1.GetAsync("https://localhost:44321/Sportniki");

            if (response1.IsSuccessStatusCode)
            {
                var temp = await response1.Content.ReadAsStringAsync();
                sportniks = JsonConvert.DeserializeObject<List<Sportnik>>(temp);
            }

            foreach (var item in sportniks)
            {
                SeznamSportnikov.Items.Add(item.id + " " + item.Name + " " + item.Points);
            }


            HttpClient client2 = new HttpClient();
            HttpResponseMessage response2 = await client2.GetAsync("https://localhost:44321/Sportniki/prijava");

            if (response2.IsSuccessStatusCode)
            {
                var temp = await response2.Content.ReadAsStringAsync();
                PrijavaNaDogodeks = JsonConvert.DeserializeObject<List<PrijavaNaDogodek>>(temp);
            }

            foreach (var item in PrijavaNaDogodeks)
            {
                PrijavaNaDogodekSeznam.Items.Add(item.SportnikId + " / " + item.DogodekId);
            }
        }

       

        private void IskanjeSportnika_TextChanged(object sender, TextChangedEventArgs e)
        {
            SeznamSportnikov.Items.Clear();

            foreach (var item in sportniks)
            {
                if (item.Name.Contains(IskanjeSportnika.Text))
                {
                    SeznamSportnikov.Items.Add(item.id + " " + item.Name + " " + item.Points);
                }
            }

            SeznamSportnikov.Items.Refresh();
        }

        private void IskanjeDogodka_TextChanged(object sender, TextChangedEventArgs e)
        {
            SeznamDogdkov.Items.Clear();

            foreach (var item in dogodki)
            {
                if (item.naziv.Contains(IskanjeDogodka.Text))
                {
                    SeznamDogdkov.Items.Add(item.Id + " " + item.naziv + " " + item.cas);
                }
            }

            SeznamDogdkov.Items.Refresh();
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
    }
}

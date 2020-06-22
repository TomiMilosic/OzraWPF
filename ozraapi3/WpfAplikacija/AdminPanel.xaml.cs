using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public List<Admin> admins { get; set; }
        public Admin admin { get; set; }
        public AdminPanel()
        {

            InitializeComponent();
            ProdobiAdmine();

        }

        private async void ProdobiAdmine()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44321/Sportniki/admin");

            if (response.IsSuccessStatusCode)
            {
                var temp = await response.Content.ReadAsStringAsync();
                admins = JsonConvert.DeserializeObject<List<Admin>>(temp);
            }

            foreach (var item in admins)
            {
                SeznamAdminov.Items.Add(item.id + " " + item.UporabniskoIme + " " + item.Geslo);
            }
        }

       

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           

            foreach (var item in admins)
            {
                if (item.id== PridobiID(SeznamAdminov.SelectedItem.ToString()))
                {
                    admin = item;
                }
            }
            var id = admin.id;


            if (id > 0)
            {
                idtxb.Text = admin.id.ToString();
                UporabniskoImetxb.Text = admin.UporabniskoIme;
                GesloTxb.Text = admin.Geslo;
            }
            else
            {
                MessageBox.Show("napaka");
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

        private void DodajAdminabtn_Click(object sender, RoutedEventArgs e)
        {
            var flag = true;
            Admin admin = new Admin();
            var stevilo = 0;
            if (int.TryParse(idtxb.Text, out stevilo))
            {
                admin.id = stevilo;
                flag = true;
            }
            else
            {
                flag = false;
            }

            admin.UporabniskoIme = UporabniskoImetxb.Text;
            admin.Geslo = GesloTxb.Text;

            if (flag == true)
            {
                PosljiSAdmina(admin);
                MessageBox.Show("Admin je posodobljen!");
            }
            else
            {
                MessageBox.Show("Admin Ni posodobljen!");
            }
        }


        private void PosljiSAdmina(Admin admin)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(admin);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var result = client.PostAsync(@"https://localhost:44321/Sportniki/admin/"+ admin.UporabniskoIme+ "/" + admin.Geslo, content).Result;
            }
        }




        private void PosodobiAdminabtn_Click(object sender, RoutedEventArgs e)
        {

            var flag = true;
            Admin admin = new Admin();
            var stevilo = 0;
            if (int.TryParse(idtxb.Text, out stevilo))
            {
                admin.id = stevilo;
                flag = true;
            }
            else
            {
                flag = false;
            }

            admin.UporabniskoIme = UporabniskoImetxb.Text;
            admin.Geslo = GesloTxb.Text;

            if (flag==true)
            {
                PoosodoviAdmina(admin);
                MessageBox.Show("Admin je posodobljen!");
            }
            else
            {
                MessageBox.Show("Admin Ni posodobljen!");
            }


        }

        private void PoosodoviAdmina(Admin admin)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(admin);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var result = client.PutAsync(@"https://localhost:44321/Sportniki/admin/" + admin.id + "/" + admin.UporabniskoIme + "/" + admin.Geslo, content).Result;
            }
        }

        private void IzbrisiAdminabtn_Click(object sender, RoutedEventArgs e)
        {
            int stevilo = 0;
            if (int.TryParse(idtxb.Text, out stevilo))
            {
                brisiAdmina(idtxb.Text);
                MessageBox.Show("Admin odstranjen!");
            }
            else
            {
                MessageBox.Show("Admin NI odstranjen");
            }
        }

        private async void brisiAdmina(string text)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.DeleteAsync("https://localhost:44321/Sportniki/admin/" + text);//link
        }
    }
}

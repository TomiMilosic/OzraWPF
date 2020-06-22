using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for PrijavljenUporabnik.xaml
    /// </summary>
    public partial class EN_PrijavljenUporabnik : Window
    {
        List<Sportnik> sportniks = new List<Sportnik>();

        public EN_PrijavljenUporabnik(string ImePrijavljenega)
        {
            InitializeComponent();
            PridobiPodatke();
            
        }

        public async void  PridobiPodatke()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44321/Sportniki");
            if (response.IsSuccessStatusCode)
            {
                var temp= await response.Content.ReadAsStringAsync();
                sportniks= JsonConvert.DeserializeObject<List<Sportnik>>(temp);
            }
            foreach (var item in sportniks)
            {
                ListViewIgralcev.Items.Add(item.id+" "+item.Name);
            }
        }

        private void IskanjeTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListViewIgralcev.Items.Clear();

            foreach (var item in sportniks)
            {
                if (item.Name.Contains(IskanjeTxb.Text))
                {
                    ListViewIgralcev.Items.Add(item.id + " " + item.Name);
                }
            }

            ListViewIgralcev.Items.Refresh();
            
        }

        private void ListViewIgralcev_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (ListViewIgralcev.SelectedItem !=null)
            {
                PodrobnostiSportnika.Text = ListViewIgralcev.SelectedItem.ToString();
            }
            else
            {
                PodrobnostiSportnika.Text = "Prazno!";
                ListViewIgralcev.Items.Clear();

                foreach (var item in sportniks)
                {
                        ListViewIgralcev.Items.Add(item.id + " " + item.Name); 
                }
            }
            
        }

        private int PridobiID(string besedilo)
        {
            string id = "";//pozi na vecmestne st
            
            foreach (var item in besedilo)
            {
                if (char.IsDigit(item))
                {
                    id = id+item;
                }

                if (!char.IsDigit(item))
                {
                    break;
                }
            }
            return Convert.ToInt32(id);
        }

        private void ListViewIgralcev_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int id = PridobiID(ListViewIgralcev.SelectedItem.ToString());

            if (id>0)
            {
                foreach (var item in sportniks)
                {
                    if (item.id==id)
                    {
                        EN_EnSportnik enSportnik = new EN_EnSportnik(item);
                        enSportnik.ShowDialog();
                    }
                }

            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void DodajSportnika_Click(object sender, RoutedEventArgs e)
        {
            EN_EnSportnik enSportnik = new EN_EnSportnik();
            enSportnik.ShowDialog();
        }

        private void AdminBtn_Click(object sender, RoutedEventArgs e)
        {
            EN_AdminPanel admin = new EN_AdminPanel();
            admin.ShowDialog();
        }

        private void Dogodkibtn_Click(object sender, RoutedEventArgs e)
        {
            EN_Dogodki dogodki = new EN_Dogodki();
            dogodki.ShowDialog();
        }

        private void DodavanjeSportnikaDogdka_Click(object sender, RoutedEventArgs e)
        {
            EN_DodavanjeSportnikaNaDogodek dodavanje = new EN_DodavanjeSportnikaNaDogodek();
            dodavanje.ShowDialog();
        }
    }
}

using Fare;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Lifetime;
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
    /// Interaction logic for EnSportnik.xaml
    /// </summary>
    public partial class EN_EnSportnik : Window
    {
        public EN_EnSportnik()
        {
            InitializeComponent();
        }

        public EN_EnSportnik(Sportnik sportnik)
        {
            InitializeComponent();
            Idsportnika.Text = sportnik.id.ToString();
            RankSportnikaTxb.Text = sportnik.Rank.ToString();
            nameTxb.Text = sportnik.Name;
            GenderRankSportnikatxb.Text = sportnik.GenderRank;
            DivRankTxb.Text = sportnik.DivRank.ToString();
            Agetxb.Text = sportnik.Age.ToString();
            AgeCategoryTxb.Text = sportnik.AgeCategory;
            StateTxb.Text = sportnik.State;
            CountryTxb.Text = sportnik.Country;
            ProfessionTxb.Text = sportnik.Profession;
            PointsTxb.Text = sportnik.Points.ToString();
            Swimtxb.Text = sportnik.Swim;
            SwimDistancetxb.Text = sportnik.SwimDistance.ToString();
            t1txb.Text = sportnik.T1;
            Biketxb.Text = sportnik.Bike;
            BikeDistanceTxb.Text = sportnik.BikeDistance.ToString();
            t2txb.Text = sportnik.T2;
            Runtxb.Text = sportnik.Run;
            RunDistancetxb.Text = sportnik.RunDistance.ToString();
            Overalltxb.Text = sportnik.Overall;
            Finishtxb.Text = sportnik.Finish;
            OverallTriTxb.Text = sportnik.OverAllTri.ToString();
            CommentTxb.Text = sportnik.Comment;

            

        }


        private void DodajSportnika_Click(object sender, RoutedEventArgs e)
        {
            Sportnik sportnik = new Sportnik();
            bool flag = true;
            int stevilo = 0;
            float floatstevilo = 0;
            if (int.TryParse(Idsportnika.Text, out stevilo))
            {
                sportnik.id = stevilo;
            }
            else
            {
                flag = false;
            };
            if (int.TryParse(RankSportnikaTxb.Text, out stevilo))
            {
                sportnik.Rank = stevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.Name = nameTxb.Text;
            sportnik.GenderRank = GenderRankSportnikatxb.Text;
            if (int.TryParse(DivRankTxb.Text, out stevilo))
            {
                sportnik.DivRank = stevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.OverallRank = OverallRanktxb.Text;
            if (int.TryParse(BibTxb.Text, out stevilo))
            {
                sportnik.Bib = stevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.Division = DivisionTxb.Text;
            if (int.TryParse(Agetxb.Text, out stevilo))
            {
                sportnik.Age = stevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.AgeCategory = AgeCategoryTxb.Text;
            sportnik.State = StateTxb.Text;
            sportnik.Country = CountryTxb.Text;
            sportnik.Profession = ProfessionTxb.Text;
            if (int.TryParse(PointsTxb.Text, out stevilo))
            {
                sportnik.Points = stevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.Swim = Swimtxb.Text;
            if (float.TryParse(SwimDistancetxb.Text, out floatstevilo))
            {
                sportnik.SwimDistance = floatstevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.T1 = t1txb.Text;
            sportnik.Bike = Biketxb.Text;
            if (float.TryParse(BikeDistanceTxb.Text, out floatstevilo))
            {
                sportnik.BikeDistance = floatstevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.T2 = t2txb.Text;
            sportnik.Run = Runtxb.Text;
            if (float.TryParse(RunDistancetxb.Text, out floatstevilo))
            {
                sportnik.RunDistance = floatstevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.Overall = Overalltxb.Text;
            sportnik.Finish = Finishtxb.Text;
            if (int.TryParse(OverallTriTxb.Text, out stevilo))
            {
                sportnik.OverAllTri = stevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.Comment = CommentTxb.Text;

            if (flag == true)
            {
                PosljiSportnika(sportnik);
            }
            else
            {
                MessageBox.Show("Error!");
            }

            if (flag==true)
            {
                PosljiSportnika(sportnik);
                MessageBox.Show("Athlete added!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

            



        }

        private void PosljiSportnika(Sportnik sportnik)
        {


                                                                                                                                                                                                                                                                                          //https://localhost:44321/Sportniki?Rank=12&Name=asd&GenderRank=asd&DivRank=asd&OverallRank=asd&Bib=asd&Division=asd&Age=asd&AgeCategory=asd&State=as&Country=asd&Profession=asd&Points=asd&Swim=asd&SwimDistance=as&T1=sda&Bike=sad&BikeDistance=asd&T2=asd&Run=asd&RunDistance=ads&Overall=ads&Finish=dsa&OverAllTri=asd&Comment=asd
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(sportnik);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var result = client.PostAsync(@"https://localhost:44321/Sportniki?" +"Rank="+sportnik.Rank + "&" +"Name="+sportnik.Name + "&" +"GenderRank="+ sportnik.GenderRank + "&" +"DivRank="+ sportnik.DivRank + "&"+"OverallRank=" + sportnik.OverallRank + "&" +"Bib="+ sportnik.Bib + "&"+"Division=" + sportnik.Division + "&"+"Age=" + sportnik.Age + "&"+"AgeCategory=" + sportnik.AgeCategory + "&"+"State=" + sportnik.State + "&"+"Country=" + sportnik.Country + "&"+"Profession=" + sportnik.Profession + "&"+"Points=" + sportnik.Points + "&"+"Swim=" + sportnik.Swim + "&"+"SwimDistance=" + sportnik.SwimDistance + "&"+"T1=" + sportnik.T1 + "&"+"Bike=" + sportnik.Bike + "&"+"BikeDistance=" + sportnik.BikeDistance + "&"+"T2=" + sportnik.T2 + "&"+"Run=" + sportnik.Run + "&"+"RunDistance" + sportnik.RunDistance + "&"+"Overall=" + sportnik.Overall + "&"+"Finish=" + sportnik.Finish + "&"+"OverAllTri=" + sportnik.OverAllTri + "&"+"Comment" + sportnik.Comment, content).Result;
            }
            

            //preveri!!!
            //doaj meesege box ce kaj ni vreu?
        }

        private void PoosodobiSportnikaBtn_Click(object sender, RoutedEventArgs e)
        {
            Sportnik sportnik = new Sportnik();
            bool flag = true;
            int stevilo = 0;
            float floatstevilo = 0;
            if (int.TryParse(Idsportnika.Text, out stevilo))
            {
                sportnik.id = stevilo;
            }
            else
            {
                flag = false;
            };
            if (int.TryParse(RankSportnikaTxb.Text, out stevilo))
            {
                sportnik.Rank = stevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.Name = nameTxb.Text;
            sportnik.GenderRank = GenderRankSportnikatxb.Text;
            if (int.TryParse(DivRankTxb.Text, out stevilo))
            {
                sportnik.DivRank = stevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.OverallRank = OverallRanktxb.Text;
            if (int.TryParse(BibTxb.Text, out stevilo))
            {
                sportnik.Bib = stevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.Division = DivisionTxb.Text;
            if (int.TryParse(Agetxb.Text, out stevilo))
            {
                sportnik.Age = stevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.AgeCategory = AgeCategoryTxb.Text;
            sportnik.State = StateTxb.Text;
            sportnik.Country = CountryTxb.Text;
            sportnik.Profession = ProfessionTxb.Text;
            if (int.TryParse(PointsTxb.Text, out stevilo))
            {
                sportnik.Points = stevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.Swim = Swimtxb.Text;
            if (float.TryParse(SwimDistancetxb.Text, out floatstevilo))
            {
                sportnik.SwimDistance = floatstevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.T1 = t1txb.Text;
            sportnik.Bike = Biketxb.Text;
            if (float.TryParse(BikeDistanceTxb.Text, out floatstevilo))
            {
                sportnik.BikeDistance = floatstevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.T2 = t2txb.Text;
            sportnik.Run = Runtxb.Text;
            if (float.TryParse(RunDistancetxb.Text, out floatstevilo))
            {
                sportnik.RunDistance = floatstevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.Overall = Overalltxb.Text;
            sportnik.Finish = Finishtxb.Text;
            if (int.TryParse(OverallTriTxb.Text, out stevilo))
            {
                sportnik.OverAllTri = stevilo;
            }
            else
            {
                flag = false;
            }
            sportnik.Comment = CommentTxb.Text;

            if (flag==true)
            {
                PoosodoviSportnika(sportnik);
                MessageBox.Show("Athlete updated!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            
        }

        private void PoosodoviSportnika(Sportnik sportnik)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(sportnik);
                var content = new StringContent(json, Encoding.UTF8, "application/json");


                var result = client.PutAsync(@"https://localhost:44321/Sportniki?" + "Rank=" + sportnik.Rank + "&" + "Id=" + sportnik.id+ "&" + "Name=" + sportnik.Name + "&" + "GenderRank=" + sportnik.GenderRank + "&" + "DivRank=" + sportnik.DivRank + "&" + "OverallRank=" + sportnik.OverallRank + "&" + "Bib=" + sportnik.Bib + "&" + "Division=" + sportnik.Division + "&" + "Age=" + sportnik.Age + "&" + "AgeCategory=" + sportnik.AgeCategory + "&" + "State=" + sportnik.State + "&" + "Country=" + sportnik.Country + "&" + "Profession=" + sportnik.Profession + "&" + "Points=" + sportnik.Points + "&" + "Swim=" + sportnik.Swim + "&" + "SwimDistance=" + sportnik.SwimDistance + "&" + "T1=" + sportnik.T1 + "&" + "Bike=" + sportnik.Bike + "&" + "BikeDistance=" + sportnik.BikeDistance + "&" + "T2=" + sportnik.T2 + "&" + "Run=" + sportnik.Run + "&" + "RunDistance" + sportnik.RunDistance + "&" + "Overall=" + sportnik.Overall + "&" + "Finish=" + sportnik.Finish + "&" + "OverAllTri=" + sportnik.OverAllTri + "&" + "Comment" + sportnik.Comment, content).Result;
            }
        }

        private void brisiSportnikaBtn_Click(object sender, RoutedEventArgs e)
        {
            int stevilo = 0;
            if (int.TryParse(Idsportnika.Text, out stevilo))
            {
                brisiSportnika(Idsportnika.Text);
                MessageBox.Show("Athlete deleted!");
            }
            else
            {
                MessageBox.Show("Athlete Not deleted!");
            }
           
        }

        private async void brisiSportnika(string text)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage message = await client.DeleteAsync("https://localhost:44321/Sportniki/" + text);

            //preveri!
        }
    }
}

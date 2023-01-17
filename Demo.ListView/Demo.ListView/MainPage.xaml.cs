using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Xml.Serialization;
using Demo.ListView.DataModels;

namespace Demo.ListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            List<Student> list = new List<Student>
            {
               new Student{Name="sai", Status="Enrolled", ImageUrl="https://tinyurl.com/cdj6xfz8"},
               new Student{Name="Lakshman", Status="Enrolled", ImageUrl="https://tinyurl.com/cdj6xfz8"},
               new Student{Name="Ram", Status="Enrolled", ImageUrl="https://tinyurl.com/cdj6xfz8"}

            };
            myListView.ItemsSource = list;
        }

        private async void myListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var student = e.SelectedItem as Student;
           
            await DisplayAlert("Selected",$"{student.Name}\n {student.Status}", "ok");
            
            await Navigation.PushAsync(new StudentInfoPage(student.Name));
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentInfoPage : ContentPage
    {
        public StudentInfoPage()
        {
        }

        public StudentInfoPage(string name)
        {
            InitializeComponent();
            lblName.Text = name;
        }
    }
}
﻿using GeoTwitter.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoTwitter
{
    public partial class MainTabbedPage 
    {
        public MainTabbedPage()
        {
            InitializeComponent();
            this.Children.Add(new TweetsPage());
            BindingContext = new MainTabbedViewModel();
        }
    }
}

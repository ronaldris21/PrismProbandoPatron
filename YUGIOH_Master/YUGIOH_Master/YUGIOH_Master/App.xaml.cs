﻿using DLToolkit.Forms.Controls;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YUGIOH_Master.Services;
using YUGIOH_Master.Views;

namespace YUGIOH_Master
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            FlowListView.Init();
            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
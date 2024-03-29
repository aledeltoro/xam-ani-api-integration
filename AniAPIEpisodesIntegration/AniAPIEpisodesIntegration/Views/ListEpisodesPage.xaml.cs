﻿using AniAPIEpisodesIntegration.Models;
using AniAPIEpisodesIntegration.Services;
using AniAPIEpisodesIntegration.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AniAPIEpisodesIntegration.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListEpisodesPage : ContentPage
    {
        public ListEpisodesPage(ObservableCollection<Episode> episodesList)
        {
            InitializeComponent();
            BindingContext = new ListEpisodesViewModel(episodesList, new DisplayAlertService());
        }
    }
}
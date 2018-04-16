﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDailyBugle.Services;
using Xamarin.Forms;
using TheDailyBugle.Models;


namespace TheDailyBugle
{
	public partial class MainPage : ContentPage
	{
        private readonly IComicParserService _comicParserService;
		public MainPage()
		{
			InitializeComponent();

            _comicParserService = new ComicParserService();
            _comicParserService.GetComics(0, 0);
        }
	}
}

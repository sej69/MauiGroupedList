﻿using MauiGrouping.Pages;

namespace MauiGrouping;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

		Shell.Current.GoToAsync($"{nameof(AnimalsPage)}");
	}
}


﻿using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace TodoList;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}
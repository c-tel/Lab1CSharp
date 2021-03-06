﻿using Lab1Telizhenko.Views;
using Lab1Telizhenko.Windows;
using System;

namespace Lab1Telizhenko.Models
{
    public enum Modes
    {
        Welcome, Main
    }

    public class NavigationModel
    {
        private Storage _storage;
        private ContentWindow _contentWindow;
        private WelcomeView _welcomeView;
        private MainView _mainView;

        public NavigationModel(Storage storage, ContentWindow contentWindow)
        {
            _storage = storage;
            _contentWindow = contentWindow;
            _welcomeView = new WelcomeView(storage);
            _mainView = new MainView(storage);
        }

        public void Navigate(Modes mode)
        {
            switch(mode)
            {
                case Modes.Welcome:
                    _contentWindow.ContentControl.Content = _welcomeView;
                    break;
                case Modes.Main:
                    _contentWindow.ContentControl.Content = _mainView;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode));
            }
        }
    }
}

using Lab1Telizhenko.Managers;
using System;

namespace Lab1Telizhenko.Models
{
    public class MainModel
    {
        private Storage _storage;
        public event Action<UserData> UserDataChanged;

        public MainModel(Storage storage)
        {
            _storage = storage;
            _storage.UserDataChanged += OnUserDataChanged;
        }

        private void OnUserDataChanged(UserData userData)
        {
            UserDataChanged?.Invoke(userData);
        }

        internal void Back()
        {
            NavigationManager.Instance.Navigate(Modes.Welcome);
        }
    }
}

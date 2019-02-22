using System;

namespace Lab1Telizhenko.Models
{
    public class Storage
    {
        public event Action<UserData> UserDataChanged;

        public UserData CurrentUserData { get; private set; }

        public void SetUserData(UserData nextData)
        {
            CurrentUserData = nextData;
            UserDataChanged?.Invoke(CurrentUserData);
        }

    }
}

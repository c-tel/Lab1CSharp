using Lab1Telizhenko.Managers;
using System;
using System.Windows;

namespace Lab1Telizhenko.Models
{
    public class WelcomeModel
    {
        private Storage _storage;

        public WelcomeModel(Storage storage)
        {
            _storage = storage;
        }

        public void SubmitDateOfBirth(DateTime dateOfBirth)
        {
            var now = DateTime.Now;
            var age = now.Year - dateOfBirth.Year;
            if (dateOfBirth > now.AddYears(-age))
                --age;
            if (!AgeValid(age))
            {
                MessageBox.Show("Invalid date given!");
                return;
            }
            var userData = new UserData
            {
                Age = age,
                WestZodiac = CalculateWest(dateOfBirth),
                ChineeseZodiac = CalculateChineese(dateOfBirth),
                HasBirthday = dateOfBirth.Day == now.Day && dateOfBirth.Month == now.Month
            };
            _storage.SetUserData(userData);
            NavigationManager.Instance.Navigate(Modes.Main);
        }

        private bool AgeValid(int age)
        {
            return age >= 0 && age < 135;
        }

        private WestZodiac CalculateWest(DateTime date)
        {
            if ((date.Month == 3 && date.Day >= 21) || (date.Month == 4 && date.Day <= 20))
                return WestZodiac.Aries;
            else
            if ((date.Month == 4 && date.Day >= 21) || (date.Month == 5 && date.Day <= 20))
                return WestZodiac.Taurus;
            else
            if ((date.Month == 5 && date.Day >= 21) || (date.Month == 6 && date.Day <= 21))
                return WestZodiac.Gemini;
            else
            if ((date.Month == 6 && date.Day >= 22) || (date.Month == 7 && date.Day <= 22))
                return WestZodiac.Canser;
            else
            if ((date.Month == 7 && date.Day >= 23) || (date.Month == 8 && date.Day <= 23))
                return WestZodiac.Leo;
            else
            if ((date.Month == 8 && date.Day >= 24) || (date.Month == 9 && date.Day <= 23))
                return WestZodiac.Virgo;
            else
            if ((date.Month == 9 && date.Day >= 24) || (date.Month == 10 && date.Day <= 22))
                return WestZodiac.Libra;
            else
            if ((date.Month == 10 && date.Day >= 23) || (date.Month == 11 && date.Day <= 22))
                return WestZodiac.Scorpio;
            else
            if ((date.Month == 11 && date.Day >= 23) || (date.Month == 12 && date.Day <= 21))
                return WestZodiac.Sagittarius;
            else
            if ((date.Month == 12 && date.Day >= 22) || (date.Month == 1 && date.Day <= 20))
                return WestZodiac.Capricorn;
            else
            if ((date.Month == 1 && date.Day >= 21) || (date.Month == 2 && date.Day <= 19))
                return WestZodiac.Aquarius;
            else
                return WestZodiac.Pisces;
        }

        private ChineeseZodiac CalculateChineese(DateTime date)
        {
            var descriptor = (date.Year % 12) - 4;
            if(descriptor < 0)
            {
                descriptor = 12 + descriptor;
            }

            return (ChineeseZodiac)descriptor;
        }
    }
}

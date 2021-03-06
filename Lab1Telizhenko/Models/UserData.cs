﻿namespace Lab1Telizhenko.Models
{
    public enum WestZodiac
    {
        Aries, Taurus, Gemini, Canser,
        Leo, Virgo, Libra, Scorpio,
        Sagittarius, Capricorn, Aquarius, Pisces
    }

    public enum ChineeseZodiac
    {
        Rat, Ox, Tiger, Rabbit,
        Dragon, Snake, Horse, Sheep,
        Monkey, Rooster, Dog, Pig
    }

    public class UserData
    {
        public int Age { get; set; }
        public WestZodiac WestZodiac { get; set; }
        public ChineeseZodiac ChineeseZodiac { get; set; }
        public bool HasBirthday { get; set; }
    }
}

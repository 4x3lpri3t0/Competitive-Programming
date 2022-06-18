using System;


public class Time
{
    public string whatTime(int seconds)
    {
        string res;

        int secondsInAnHour = 60 * 60;
        int secondsInAMinute = 60;

        int hours = 0;

        while (seconds >= secondsInAnHour)
        {
            seconds -= secondsInAnHour;
            hours++;
        }

        int minutes = 0;

        while (seconds >= secondsInAMinute)
        {
            seconds -= secondsInAMinute;
            minutes++;
        }

        res = string.Format("{0}:{1}:{2}", hours, minutes, seconds);

        return res;
    }

    public static void NotMain(String[] args) { }

}
//How to find the angle between hour and minute hands of a clock at any given time? 
//The user will input the hour and minute of the time and the method should give the angle between the hour hand and minute hand at that given time.

//input: 9 30, output: The angle between hour hand and minute hand is 105 degrees
//input: 13 30, output: The angle between hour hand and minute hand is 135 degrees

using System;
class AngleOfTheTime
{
    static void Main(string[] args)
    {
        Console.Write("Enter the hour (0-23): ");
        int hour = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the minute (0-59): ");
        int minute = Convert.ToInt32(Console.ReadLine());
        double angle = CalculateClockAngle(hour, minute);
        Console.WriteLine("The angle between hour hand and minute hand is " + angle + " degrees");
    }
    static double CalculateClockAngle(int hour, int minute)
    {
        // Convert hour to 12-hour format
        hour = hour % 12;
        // Calculate angles of hour and minute hands from 12 o'clock position
        double hourAngle = (hour * 30) + (minute * 0.5);
        double minuteAngle = minute * 6;
        // Calculate the absolute difference between the angles
        double angle = Math.Abs(hourAngle - minuteAngle);
        // If the angle is greater than 180 degrees, subtract it from 360 degrees to get the smaller angle
        if (angle > 180)
        {
            angle = 360 - angle;
        }
        return angle;
    }
}
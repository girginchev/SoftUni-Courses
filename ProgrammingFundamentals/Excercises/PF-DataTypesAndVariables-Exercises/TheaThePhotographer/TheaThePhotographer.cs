namespace TheaThePhotographer
{
    using System;
    class TheaThePhotographer
    {
        static void Main()
        {
            var pictures = long.Parse(Console.ReadLine());
            var filterTime = long.Parse(Console.ReadLine());
            var filterFactor = long.Parse(Console.ReadLine());
            var uploadTime = long.Parse(Console.ReadLine());

            long filterSeconds = pictures * filterTime;
            long goodPictures = (long)Math.Ceiling(pictures * filterFactor / 100.0);
            long totalSeconds = (goodPictures * uploadTime) + filterSeconds;

            //var totalTime = new TimeSpan(0, 0, totalSeconds);
            //Console.WriteLine(totalTime.ToString(@"d\:hh\:mm\:ss"));

            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",time.Days,time.Hours,time.Minutes,time.Seconds);


        }
    }
}

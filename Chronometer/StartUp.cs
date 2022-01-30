
namespace Chronometer
{
    public class StartUp
    {
        static void Main()
        {
            Console.WriteLine("Write \"start\" and press Enter to run the timer.");
            var chronometer = new Chronometer();
            string line;
            while ((line = Console.ReadLine()) != "exit")
            {
                Console.WriteLine("Write \"lap\" to split the Lap.");
                if (line?.ToLower() == "start")
                {
                    Task.Run(() => chronometer.Start());
                }
                else if (line?.ToLower() == "stop")
                { chronometer.Stop(); }
                else if (line?.ToLower() == "lap")
                { Console.WriteLine(chronometer.Lap()); }
                else if (line.ToLower() == "laps")
                {
                    if (chronometer.Laps.Count == 0)
                    {
                        Console.WriteLine("Laps: no laps");
                    }
                    else
                    {
                        var count = 0;
                        Console.WriteLine("Laps: ");
                        foreach (var item in chronometer.Laps)
                        {
                            Console.WriteLine($"{count + 1}. {chronometer.Laps[count]}");
                            count++;
                        }
                    }
                }
                else if (line.ToLower() == "reset")
                {
                    chronometer.Reset();
                }
                else if (line.ToLower() == "time")
                {
                    Console.WriteLine(chronometer.GetTime);
                }
                else { Console.WriteLine("Wrong command. Try again."); }

            }
            chronometer.Start();
            
        }
    }
}

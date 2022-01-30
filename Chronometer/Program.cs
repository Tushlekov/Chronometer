// See https://aka.ms/new-console-template for more information

public interface IChronometer
{ 
    string GetTime { get; } 
    List<string> Laps { get; }
    void Start();
    void Stop();
    string Lap();
    void Reset();
}
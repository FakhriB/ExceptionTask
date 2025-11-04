using ExceptionTask;

class Program
{
    static void Main(string[] args)
    {
        var schedule = new MeetingSchedule();

        try
        {
            schedule.SetMeeting("Ferid", new DateTime(2025, 11, 4, 10, 0, 0), new DateTime(2025, 11, 4, 11, 0, 0));
            schedule.SetMeeting("Aysel", new DateTime(2025, 11, 4, 10, 30, 0), new DateTime(2025, 11, 4, 11, 30, 0)); 
        }
        catch (ReservedDateIntervalException ex)
        {
            Console.WriteLine("Rezerv xətası: " + ex.Message);
        }
        catch (WrongDateIntervalException ex)
        {
            Console.WriteLine("Tarix xətası: " + ex.Message);
        }

        try
        {
            schedule.SetMeeting("Murad", new DateTime(2025, 11, 4, 12, 0, 0), new DateTime(2025, 11, 4, 11, 0, 0)); 
        }
        catch (Exception ex)
        {
            Console.WriteLine("Xəta: " + ex.Message);
        }

        schedule.SetMeeting("Leyla", new DateTime(2025, 11, 4, 11, 30, 0), new DateTime(2025, 11, 4, 12, 30, 0));

        schedule.PrintMeetings();
    }
}

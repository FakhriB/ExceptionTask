internal class MeetingSchedule
{
    private Meeting[] meetings = new Meeting[10];
    private int count = 0;

    public void SetMeeting(string fullName, DateTime from, DateTime to) 
    {
        if (from >= to)
            throw new WrongDateException();

        meetings[count++] = new Meeting
        {
            FullName = fullName,
            FromDate = from,
            ToDate = to
        };
    }

    public void PrintMeetings()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(meetings[i]);
        }
    }
}

public class Meeting
{
    public string FullName { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }

    public override string ToString()
    {
        return $"{FullName}: {FromDate:g} - {ToDate:g}";
    }
}

internal class WrongDateException : Exception  
{
    public WrongDateException() : base("Başlama tarixi bitmə tarixindən böyük və ya bərabər ola bilməz") { }
}

namespace ExceptionTask;

internal class Meeting
{
    public string FullName { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }

    public Meeting(string fullname, DateTime from, DateTime to)
    {
        FullName = fullname;
        FromDate = from;
        ToDate = to;
    }
}
 



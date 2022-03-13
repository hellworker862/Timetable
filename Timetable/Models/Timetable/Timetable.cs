namespace Timetable.Models.Timetable
{
    public class Timetable
    {
        public string DayOfWeek { get; init; }
        public Column[] Columns { get; init; }
        public string Date { get; init; }
        public bool IsSDO { get; init; }
    }
}

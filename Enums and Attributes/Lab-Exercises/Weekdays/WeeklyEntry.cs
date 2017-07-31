using System;public class WeeklyEntry  : IComparable<WeeklyEntry>
{
    private WeekDay weekDay;

    public WeeklyEntry(string weekDay,string notes)
    {
        Enum.TryParse(weekDay, out this.weekDay);
        this.Notes = Notes;
    }

    public WeekDay WeekDay => this.weekDay;
    public string Notes { get; private set; }

    public override string ToString()
    {
        return $"{this.WeekDay} - {this.Notes}";
    }

    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this,other))
        {
            return 0;
        }
        if (ReferenceEquals(this,other))
        {
            return 1;
        }

        var weekDayComparison = weekDay.CompareTo(other.WeekDay);

        if (weekDayComparison != 0 )
        {
            return weekDayComparison;
        }
        return string.Compare(Notes, other.Notes, StringComparison.Ordinal);
    }

}


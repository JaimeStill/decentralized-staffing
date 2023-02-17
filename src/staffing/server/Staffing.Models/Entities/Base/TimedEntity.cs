using Staffing.Models.Core;

namespace Staffing.Models.Entities;

public abstract class TimedEntity : Entity
{
    public int Years { get; set; }
    public int Months { get; set; }
    public int Days { get; set; }
    public int Hours { get; set; }
    public int Minutes { get; set; }

    public string SetDueDate() => JsDateEncoder.JsDate(
        DateTime.Now
            .AddYears(Years)
            .AddMonths(Months)
            .AddDays(Days)
            .AddHours(Hours)
            .AddMinutes(Minutes)
    );
}
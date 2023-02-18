using Soc.Api.Core;

namespace Soc.Api.Schema;

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
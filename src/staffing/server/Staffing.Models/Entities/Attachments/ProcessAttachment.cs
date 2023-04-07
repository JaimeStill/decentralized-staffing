namespace Staffing.Models.Entities;

public class ProcessAttachment : Attachment
{
    public int ProcessId { get; set; }

    public Process? Process { get; set; }
}
namespace Staffing.Models.Entities;

public class Role : UrlEntity
{
    public string Description { get; set; }

    public IEnumerable<Process> Processes { get; set; }
    public IEnumerable<ProcessT> ProcessTs { get; set; }
    public IEnumerable<Review> Reviews { get; set; }
    public IEnumerable<ReviewT> ReviewTs { get; set; }
    public IEnumerable<UserRole> Users { get; set; }
}
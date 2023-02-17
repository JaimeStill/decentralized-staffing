namespace Staffing.Models.Entities;

public class Registration : KeyEntity
{
    public IEnumerable<Token> Tokens { get; set; }
}
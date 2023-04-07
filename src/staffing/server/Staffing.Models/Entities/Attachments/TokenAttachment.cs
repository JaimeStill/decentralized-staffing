namespace Staffing.Models.Entities;

public class TokenAttachment : Attachment
{
    public int TokenId { get; set; }

    public Token? Token { get; set; }
}
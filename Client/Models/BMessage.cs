using System;

namespace MessageClient.Models
{
  public class BMessage
  {
    public int BMessageId { get; set; }
    public string Message { get; set; }
    public DateTime Posted { get; set; }
    public int GroupId { get; set; }

  }
}
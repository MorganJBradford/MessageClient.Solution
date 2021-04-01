using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MessageClient.Models
{
  public class BMessage
  {
    public int BMessageId { get; set; }
    public string Message { get; set; }
    public DateTime Posted { get; set; }
    public int GroupId { get; set; }

    public static List<BMessage> GetBMessage()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<BMessage> messageList = JsonConvert.DeserializeObject<List<BMessage>>(jsonResponse.ToString());
    }

    public static BMessage GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      BMessage message = JsonConvert.DeserializeObject<BMessage>(jsonResponse.ToString());
    }

  }
}
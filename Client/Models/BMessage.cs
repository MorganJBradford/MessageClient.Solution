using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Client.Models
{
  public class BMessage
  {
    public int BMessageId { get; set; }
    public string Message { get; set; }
    public DateTime Posted { get; set; }
    public string Topic { get; set; }

    public static List<BMessage> GetBMessage()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<BMessage> messageList = JsonConvert.DeserializeObject<List<BMessage>>(jsonResponse.ToString());
      return messageList;
    }

    public static BMessage GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      BMessage message = JsonConvert.DeserializeObject<BMessage>(jsonResponse.ToString());
      return message;
    }

    public static void Post(BMessage message)
    {
      string jsonBMessage = JsonConvert.SerializeObject(message);
      var apiCallTask = ApiHelper.Post(jsonBMessage);
    }

    public static void Put(BMessage message)
    {
      string jsonBMessage = JsonConvert.SerializeObject(message);
      var apiCallTask = ApiHelper.Put(message.BMessageId, jsonBMessage);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }

  }
}
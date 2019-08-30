using System;

public class Tweet : ITwitterAction
{
    public DateTime created_At {get; set;}
    public string tweetID {get; set;}
    public string userID { get; set; }
    public string tweet_Content {get; set;}
    public string type { get; set; }
    public int like_Count {get; set;}
    public int comments_Count {get; set;}
    public int repost_Count {get; set;}
    public bool deleted{get; set;}
    public int sequenceNumber{ get; set;}

}
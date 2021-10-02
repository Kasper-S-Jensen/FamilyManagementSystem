using System;

namespace S3Ex07Client
{
    public class Message
    {
        public string Text { get; set; }
        public DateTime Time { get; set; }

        public Message(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return "Message: " + Text + " at: " + DateTime.Now;
        }
    }
}
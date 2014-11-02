namespace _12.MongoDBAndDotNet.DatabaseModels
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    using System;

    public class Message
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }

        public User User { get; set; }

        public override string ToString()
        {
            return string.Format("{0}:{1}{2}{1}Date: {3}{1}", this.User.Username, Environment.NewLine, this.Text, this.Date);
        }
    }
}

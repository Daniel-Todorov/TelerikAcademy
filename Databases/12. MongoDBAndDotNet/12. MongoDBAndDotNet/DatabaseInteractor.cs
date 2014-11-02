namespace _12.MongoDBAndDotNet
{
    using _12.MongoDBAndDotNet.DatabaseModels;
    using MongoDB.Driver;
    using MongoDB.Driver.Builders;
    using System;
    using System.Collections.ObjectModel;

    public class DatabaseInteractor
    {
        private const string DatabaseHost = "mongodb://superman:superman@ds033750.mongolab.com:33750/chat";
        private const string DatabaseName = "chat";
        private const int NumberOfMessagesToDisplay = 10;

        public DatabaseInteractor()
        {
            this.Database = GetDatabase();
        }

        public MongoDatabase Database { get; set; }

        public void AddPost(string text, string username)
        {
            User user = new User() { Username = username };
            Message newMessage = new Message() { Text = text, Date = DateTime.Now, User = user };

            var messageCollection = this.Database.GetCollection<Message>(DatabaseName);
            messageCollection.Insert(newMessage);
        }

        public ObservableCollection<Message> GetPosts()
        {
            var messageCollection = this.Database.GetCollection<Message>(DatabaseName)
                                                 .Find(Query.Null)
                                                 .SetSortOrder(SortBy.Descending("Date"))
                                                 .SetLimit(NumberOfMessagesToDisplay);

            return new ObservableCollection<Message>(messageCollection);
        }

        private MongoDatabase GetDatabase()
        {
            var client = new MongoClient(DatabaseHost);
            var server = client.GetServer();
            var newDatabase = server.GetDatabase(DatabaseName);

            return newDatabase;
        }
    }
}

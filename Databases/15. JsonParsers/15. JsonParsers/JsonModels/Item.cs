namespace _15.JsonParsers.JsonModels
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Item
    {
        public string Title { get; set; }

        public string Link { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        [JsonIgnore]
        public Guid Guid { get; set; }

        public string PubDate { get; set; }
    }
}

namespace _01.CarSearcher.Models
{
    using System;
    using System.Collections.Generic;

    public class Producer
    {
        public Producer(string name, IEnumerable<string> models)
            :this()
        {
            this.Models = models;
            this.Name = name;
        }

        public Producer()
        {
            this.Models = new List<string>();
        }

        public string Name { get; set; }

        public IEnumerable<string> Models { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.ChatCanal.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime DateSent { get; set; }

        public string SenderName { get; set; }
    }
}

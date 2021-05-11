using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWebApp.Shared
{
    public class Message
    {
        public int Id { get; set; }
        public string SenderUsername { get; set; }
        public string ReceiverUsername { get; set; }
        public int MessageOrder { get; set; } 
        public DateTime DateMessageSent { get; set; } = DateTime.Now;

    }

}
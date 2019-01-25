using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot.Logic
{
    public class SimpleBotUser
    {
        public string Reply(SimpleMessage message)
        {
            var usrId = message.Id;
            return $"{message.User} disse '{message.Text}";
        }

    }
}
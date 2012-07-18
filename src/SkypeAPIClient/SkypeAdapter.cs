using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SKYPE4COMLib;

namespace SkypeAPIClient
{
    /// <summary>
    /// Serves as a proxy to Skype API.
    /// </summary>
    public class SkypeAdapter
    {
        public void send_message(string username, string message)
        {
            var user = new User();
            
            var users = new UserCollection {user};

            var chat = new Chat();
            // chat.AddMembers(users);
            chat.SendMessage(message);
        }

    }
}

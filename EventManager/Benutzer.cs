﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    public class Benutzer
    {
        int BenutzerId;
        string Username;
        string Email;
        List<Event> RegisteredEvents;
        public string FullInfo
        {
            get { return $"ID: {BenutzerId}|".PadRight(10,' ') + $" Username: {Username}|".PadRight(20, ' ') + $" Email {Email}";}
        }
    }
}

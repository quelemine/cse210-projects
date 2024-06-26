using System;
using System.Collections.Generic;
using System.IO;

using System;

namespace JournalApp
{
    public class Entry
    {
        public DateTime Date;
        public string Prompt;
        public string Response;

        public Entry(DateTime date, string prompt, string response)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
        }
    }
}

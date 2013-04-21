namespace CSharpCodeFormatting.Events
{
    using System;
    using System.Linq;
    using System.Text;
    
    internal static class Messages
    {
        public static readonly StringBuilder OutputMessage = new StringBuilder();

        // Event Methods
        public static void EventAdded()
        {
            OutputMessage.Append("Event added\n");
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                OutputMessage.AppendFormat("{0} events deleted\n", x);
            }
        }

        public static void NoEventsFound()
        {
            OutputMessage.Append("No events found\n");
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                OutputMessage.Append(eventToPrint + "\n");
            }
        }
    }
}

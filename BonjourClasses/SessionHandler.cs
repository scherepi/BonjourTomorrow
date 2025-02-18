using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BonjourClasses;

namespace BonjourClasses
{
    public static class SessionHandler
    {
        public static Session currentSession = null;
        public static DataHandler dh = null;
        private static uint nextID = 0;
        public static void startSession()
        {
            if (dh != null) { 
                currentSession = new Session(dh.getQuickQuestions());
            } else
            {
                Console.WriteLine("No access to data. Please pass the handler.");
            }
            
        }
        public static void startSession(Topic t)
        {
            currentSession = new Session(t);
        }
        public static void passHandler(DataHandler dh)
        {
            SessionHandler.dh = dh;
        }
        public static uint getNextID()
        {
            uint current = nextID;
            nextID++;
            return current;
        }

    }
}

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
            Console.WriteLine("Starting new session with no arguments");
            if (dh != null) { 
                currentSession = new Session(dh.getQuickQuestions());
            } else
            {
                Console.WriteLine("No access to data. Please pass the handler.");
            }
            
        }
        public static void startSession(Topic t)
        {
            Console.WriteLine("Starting new session for topic " + t.getName());
            currentSession = new Session(t);
        }
        public static void exitSession() {
            Console.WriteLine("Exiting session.");
            currentSession = null;
        }
        public static void reportCorrect()
        {
            Console.WriteLine("Question answered correctly.");
            currentSession.incrementCorrect();
        }
        public static Question getNextQuestion()
        {
            Console.WriteLine("Retrieving next question in session.");
            if (currentSession != null)
            {
                return currentSession.getNextQuestion();
            }
            else
            {
                return null;
            }
        }
        public static String getSessionProgress()
        {
            Console.WriteLine("Returning session progress " + currentSession.getProgress());
            return currentSession.getProgress();
        }
        public static void passHandler(DataHandler dh)
        {
            Console.WriteLine("SessionHandler receiving DataHandler.");
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

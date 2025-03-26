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
        public static Session currentSession = null;    // The current session to be handled.
        public static DataHandler dh = null;            // The program's DataHandler.
        public static ProgressHandler ph = null;        // The program's ProgressHandler.
        public static String lastSessionResults = "";   // The results of the last session.
        public static void startSession()
        {
            // Starts a new session with no arguments, using the DataHandler's getQuickQuestions method.
            Console.WriteLine("Starting new session with no arguments");
            if (dh != null) { 
                currentSession = new Session(dh.getQuickQuestions());
            } else
            {
                Console.WriteLine("No access to data. Please pass the handler.");
            }
            
        }

        public static void startQuestion(String questionID)
        {
            // Starts a new session with a given question ID.
            Console.WriteLine("Asking DataHandler for the question with ID " + questionID);
            Question q = dh.getQuestion(questionID);
            Console.WriteLine((q == null) ? "Failed to find question." : "Found question.");
            currentSession = new Session(q);
            Console.WriteLine("Session started with question " + questionID);
        }

        public static void startQuestion(Question q)
        {
            // Starts a new session with a given question object.
            Console.WriteLine("Starting new session with question " + q.getID());
            currentSession = new Session(q);
        }

        public static void startSession(String topicString)
        {
            // Starts a new session with a given topic name.
            Console.WriteLine("Asking DataHandler for the topic with name " + topicString);
            Topic topic = dh.getTopic(topicString);
            Console.WriteLine((topic == null) ? "Failed to find topic." : "Found topic.");
            startSession(topic);
            Console.WriteLine("Session started with topic " + topicString);
        }
        public static void startSession(Topic t)
        {
            // Starts a new session with a given topic object, populating the session with questions of that topic.
            Console.WriteLine("Starting new session for topic " + t.getName());
            currentSession = new Session(t);
        }
        public static void exitSession() {
            // Exits the current session.
            // TODO: Save functionality?
            Console.WriteLine("Exiting session.");
            lastSessionResults = currentSession.getDigest();
            currentSession = null;
        }
        public static void reportCorrect(Question q)
        {
            // Reports a question as answered correctly.
            ph.reportCorrect(q);
            Console.WriteLine("Question answered correctly.");
            currentSession.incrementCorrect();
        }

        public static void reportIncorrect(Question q)
        {
            ph.reportIncorrect(q);
            Console.WriteLine("Question answered incorrectly.");
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
        public static void passHandlers(DataHandler dh, ProgressHandler ph)
        {
            // This is how we get access to the DataHandler, since we're a static class without constructors.
            Console.WriteLine("SessionHandler receiving DataHandler and ProgressHandler.");
            SessionHandler.dh = dh;
            SessionHandler.ph = ph;
        }

        public static String getLastSessionResults()
        {
            // Returns the results of the last session.
            Console.WriteLine("Returning last session results: " + lastSessionResults);
            return lastSessionResults;
        }
    }
}

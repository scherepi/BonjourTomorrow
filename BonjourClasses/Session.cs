using System.Collections.Generic;
using BonjourClasses;

namespace BonjourClasses
{
    public class Session
    {
        private Queue<Question> sessionQuestions;   // Holds the questions for the session.
        private int currentQuestion;                // Tracks the current question.
        private int totalQuestions;                 // Total number of questions the session begins with.
        private int currentCorrect;                 // How many questions the user has answered correctly for the current session.
        public Session(Topic t)     // This constructor allows you to start a session where all the questions are of a given topic.
        {
            this.sessionQuestions = new Queue<Question>();
            foreach (Question q in t.getQuestions())
            {
                this.sessionQuestions.Enqueue(q);   // Queues are a perfect collection for this application, where we wanna pull our questions one at a time.
            }
            this.currentQuestion = 0;
            this.totalQuestions = this.sessionQuestions.Count;
            this.currentCorrect = 0;
        }
        
        public Session(List<Question> sessionQuestions) // This constructor allows you to start a session with a given list of questions.
        {
            this.sessionQuestions = new Queue<Question>(sessionQuestions);
            this.currentQuestion = 0;
            this.totalQuestions = this.sessionQuestions.Count;
            this.currentCorrect = 0;
        }
        public Question getNextQuestion()
            {
                if (this.currentQuestion < this.totalQuestions) // If there are still questions left in the session:
                {
                    this.currentQuestion++; // Increment the current question.
                    return this.sessionQuestions.Dequeue(); // Return the next question in the queue.
                }
                else
                {
                    return null; // Otherwise, we'll return null to indicate that the session is over. This is handled when called. Maybe we should use an Exception?
                }
            }
        public void incrementCorrect() // Very simple.
        {
            this.currentCorrect++;
        }
        public string getProgress() // Returns the current progress, ex. 3/20.
        {
            return this.currentQuestion + "/" + this.totalQuestions;
        }
    }
    
}

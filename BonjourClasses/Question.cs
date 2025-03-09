using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BonjourClasses
{
    public class Question
    {
        public LinkedList<Answer> answers;  // Stores the related answers
        public Answer correctAnswer;        // Stores the correct answer specifically (DEPRECATED?)
        public String text;                 // The question text.
        public String questionID;             // A unique identifier for the question, assigned by the SessionHandler
        public double difficulty;           // A double representing the difficulty of the question.
        public (int, int) prevAttempts;     // Holds the previous attempts for the question.

        public Question(String text, double difficulty, LinkedList<Answer> answers, Answer correctAnswer)
        {
            this.text = text;
            this.questionID = ; // Grab the next available unique id from our static SessionHandler.
            this.difficulty = difficulty;
            this.answers = answers;
            this.correctAnswer = correctAnswer;
            this.prevAttempts = (0, 0);
        }
        public bool submitAnswer(Answer a)
        {
            return (a.Equals(this.correctAnswer));
        }
        public LinkedList<Answer> getAnswers() {
            return this.answers;
        }
        public String getText() 
        {
            return this.text;
        }
        public uint getID()
        {
            return this.questionID;
        }   
        public double getDifficulty()
        {
            return this.difficulty;
        }
    }
}

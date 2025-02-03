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
        public LinkedList<Answer> answers;
        public Answer correctAnswer;
        public String text;
        public uint questionID;
        public double difficulty;
        public (int, int) prevAttempts;

        public bool submitAnswer(Answer a)
        {
            return (a.Equals(this.correctAnswer));
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

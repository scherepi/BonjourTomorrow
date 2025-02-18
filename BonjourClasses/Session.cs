using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonjourClasses
{
    public class Session
    {
        private Queue<Question> sessionQuestions;
        private int currentQuestion;
        private int totalQuestions;
        private int currentCorrect;
        public Session(Topic t) 
        {
            this.sessionQuestions = new Queue<Question>();
            foreach (Question q in t.getQuestions())
            {
                this.sessionQuestions.Enqueue(q);
            }
            this.currentQuestion = 0;
            this.totalQuestions = this.sessionQuestions.Count;
            this.currentCorrect = 0;
        }
        public Question getNextQuestion()
        {
            if (this.currentQuestion < this.totalQuestions)
            {
                this.currentQuestion++;
                return this.sessionQuestions.Dequeue();
            }
            else
            {
                return null;
            }
        }
        public void submitAnswer(Answer a)
        {
            if (a.getParent().submitAnswer(a))
            {
                this.currentCorrect++;
            }
        }
    }
}

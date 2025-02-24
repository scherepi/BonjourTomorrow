using System.Collections.Generic;
using BonjourClasses;

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
        
        public Session(List<Question> sessionQuestions)
        {
            this.sessionQuestions = new Queue<Question>(sessionQuestions);
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
        public void incrementCorrect()
        {
            this.currentCorrect++;
        }
        public string getProgress()
        {
            return this.currentCorrect + "/" + this.totalQuestions;
        }
    }
    
}

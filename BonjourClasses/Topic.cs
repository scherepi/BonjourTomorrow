using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonjourClasses
{
    public class Topic
    {
        public String name;
        public Dictionary<Question, double> Questions;
        public int QuestionCount;

        public String getName()
        {
            return this.name;
        }
        public LinkedList<Question> getQuestions()
        {
            //TODO: review this implementation
            return new LinkedList<Question>(this.Questions.Keys);
        }
        public int getQuestionCount() 
        {
            return this.QuestionCount;
        }
        public Question presentQuestion(double difficulty)
        {
            // TODO: implement using closest value algorithm
            return null;
        }
        public Topic(String name, String data) {
            //TODO: implement constructor with file data
            this.name = name;
            this.Questions = new Dictionary<Question, double>();

        }
    }
}

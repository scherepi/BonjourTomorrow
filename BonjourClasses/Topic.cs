using System;
using System.Collections.Generic;
using System.IO;
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
            StringReader sr = new StringReader(data);
            String nextLine;
            while ((nextLine = sr.ReadLine()) != null)
            {
                String questionText = nextLine.Split(']')[0].Substring(1);
                String[] answers = nextLine.Split(']')[1].Split(')')[0].Substring(2).Split(',');
                LinkedList<Answer> answerList = new LinkedList<Answer>();
                Answer correct;
                foreach (String a in answers) 
                { 
                    if (a.Contains("*")) 
                    {
                        answerList.AddLast(new Answer(a.Substring(1)));
                        correct = new Answer(a.Substring(1), true);
                    }
                    else
                    {
                        answerList.AddLast(new Answer(a, false));
                    }
                }
                this.Questons.Add(new Question(questionText, answerList, correctAnswer));
            }
            
        }
    }
}

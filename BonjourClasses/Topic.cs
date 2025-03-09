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
        public String name;                             // The name for this topic.
        public Dictionary<Question, double> Questions;  // The questions for this topic, with their respective difficulties.
        public int QuestionCount;                       // The number of questions available in this topic.

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
            // Grab our topic name first
            this.name = name;
            this.Questions = new Dictionary<Question, double>(); // Init the dictionary
            StringReader sr = new StringReader(data); // Use a StringReader to read the data provided!
            String nextLine;
            // For every line (question) in our provided data string:
            while ((nextLine = sr.ReadLine()) != null)
            {
                Console.WriteLine(nextLine);
                String questionText = nextLine.Split(']')[0].Substring(1); // First, the actual question text is what's in the square brackets.
                String[] answers = nextLine.Split(']')[1].Split(')')[0].Substring(2).Split(','); // The string with all the answers is gonna be within the parentheses, we can break it up into each one.
                LinkedList<Answer> answerList = new LinkedList<Answer>(); // Init our answer list
                Answer correct = null;
                foreach (String a in answers) // For every answer in our little chunk of them provided:
                { 
                    if (a.Contains("*")) // If the answer has an asterisk at the end, then it's the correct one!
                    {
                        answerList.AddLast(new Answer(a.Trim().Substring(0, a.Trim().Length - 1), true)); // We'll still add it to the answer list, but we also wanna separate it as the correct one.
                        correct = new Answer(a.Trim().Substring(0, a.Trim().Length - 1), true);
                    }
                    else
                    {
                        answerList.AddLast(new Answer(a.Trim(), false));
                    }
                }
                double difficulty = double.Parse(nextLine.Split('|')[1].Trim().Split(' ')[0].Trim());
                // Debug...
                //Console.WriteLine(nextLine.Split('|')[1].Trim());
                String questionID = nextLine.Split('|')[1].Trim().Split(' ')[1].Trim();
                this.Questions.Add(new Question(questionText, difficulty, questionID, answerList, correct), difficulty);
            }
            Console.WriteLine("Initialized topic " + this.name + " with " + this.Questions.Count + " questions.");
            
        }
    }
}

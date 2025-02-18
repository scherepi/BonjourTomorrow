using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonjourClasses
{
    public class Answer
    {
        public String text;
        public bool Correct;

        public Answer(String text, bool isCorrect)
        {
            this.text = text;
            this.Correct = isCorrect;
        }

        public String getText()
        {
            return this.text;
        }
        public bool isCorrect()
        {
            return this.Correct;
        }
    }
}

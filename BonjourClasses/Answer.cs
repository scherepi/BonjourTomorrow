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

        public Answer(String text)
        {
            this.text = text;
        }

        public String getText()
        {
            return this.text;
        }
    }
}

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
        public Question associatedQuestion;

        public String getText()
        {
            return this.text;
        }
        public Question getParent()
        {
            return this.associatedQuestion;
        }
    }
}

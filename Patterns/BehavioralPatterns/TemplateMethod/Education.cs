using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BehavioralPatterns.TemplateMethod
{
    abstract class Education
    {

        public void Learn()
        {
            Enter();
            Study();
            PassExams();
            GetDocument();
        }
        public abstract void Enter();
        public abstract void Study();
        public virtual void PassExams()
        {
            Console.WriteLine("Сдаем выпускные экзамены");
        }
        public abstract void GetDocument();
    }
}

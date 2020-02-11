using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.AlgorithmLogic
{
    //Клас за следваща и предишна стъпка
    class CStep
    {
        public Step NextStep { get; set; }
        public Step PrevStep { get; set; }

        //Конструктор с параметри Следващата и предишна стъпка
        public CStep(Step NextStep_, Step PrevStep_)
        {
            NextStep = NextStep_;
            PrevStep = PrevStep_;
        }

        //Празен контруктор за създаване на следваща и предишна стъпка
        public CStep()
        {
            NextStep = new Step();
            PrevStep = new Step();
        }
    }
}


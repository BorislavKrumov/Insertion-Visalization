using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.AlgorithmLogic
{
    class Step
    {
        //Списък с отправни точки
        public List<int> Highlight { get; set; }
        
        //Стринг Съобщение
        public string Message { get; set; }
        //Стринг Команда
        public string Command { get; set; }

        //Стринг за прикачване на имена
        public List<string> AttachNames { get; set; }
        //Стринг Прикачен към
        public List<int> AttachTo { get; set; }
        //Списък редове
        public List<int> Rows { get; set; }
        //Списък за имена на променливи
        public List<string> VariableNames { get; set; }
        //Списък със стойност
        public List<string> Values { get; set; }
        //Списък за индексите на променливите
        public List<int> VariableIndexes { get; set; }
        //Списък за блок индексите
        public List <int> HighlightenedBlockIndexes { get; set; }
        //Списък за Лейбъл индексите
        public List <int> HighlightenedLabelIndexes { get; set; }
        //Списък за индексите в таблицата
        public List<int> HighlightedTableIndexes { get; set; }
      
        //Променлива разделител
        public int Delimiter;
        //Бууля за разделите - Ъпдейтва стойностите
        public bool UsedelimForUpdateInit;
        //Списък за Допълнителният брояч на стойности
        public List<int> ExtraCountValues { get; set; }
        //Списък за допълнителни спомагателни стойности
        public List<int> ExtraAuxiliaryValues { get; set; }

        //Структура от няколко части, два инта;
        public Tuple<int,int> Swit { get; set; }

        //Празен конструктор зарежда списъците и останалите неща от Класа 
        public Step()
        {
            Highlight = new List<int>();
            Message = "";
            Command = "";
            AttachNames = null;
            AttachTo = null;
            Rows = null;
            VariableNames = null;
            Values = null;
            VariableNames = null;
            VariableIndexes = null;
            HighlightenedBlockIndexes = null;
            HighlightenedLabelIndexes = null;
            HighlightedTableIndexes = null;

            Swit = new Tuple<int, int>(-1, -1);
            //разделител
            Delimiter = -1;
            UsedelimForUpdateInit = false;
        }


        //Клонинг конструктор когато стойността е различна от Null
        public Step Clone()
        {
            Step newStep = new Step();
            newStep.Highlight = Highlight;
            newStep.Message = Message;
            newStep.Command = Command;


            if (AttachNames != null)
                newStep.AttachNames = AttachNames.ToList<string>();
            if (AttachTo != null)
                newStep.AttachTo = AttachTo.ToList<int>();
            if (Rows != null)
                newStep.Rows = Rows.ToList<int>();
            if (VariableNames != null)
                newStep.VariableNames = VariableNames.ToList<string>();
            if (VariableIndexes != null)
                newStep.VariableIndexes = VariableIndexes.ToList<int>();
            if (Values != null)
                newStep.Values = Values.ToList<string>();
            if (HighlightenedBlockIndexes != null)
                newStep.HighlightenedBlockIndexes = HighlightenedBlockIndexes.ToList<int>();
            if (HighlightenedLabelIndexes != null)
                newStep.HighlightenedLabelIndexes = HighlightenedLabelIndexes.ToList<int>();
            if (HighlightedTableIndexes != null)
                newStep.HighlightedTableIndexes = HighlightedTableIndexes.ToList<int>();
            newStep.Swit = Swit;
            newStep.Delimiter = Delimiter;
            newStep.UsedelimForUpdateInit = UsedelimForUpdateInit;
            return newStep;




        }





    }
}

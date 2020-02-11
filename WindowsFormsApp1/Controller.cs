using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.AlgorithmLogic;
using WindowsFormsApp1.Lists;


namespace WindowsFormsApp1
{
    class Controller
    {
        //Списък от Блокове
        public ListOfBlocks List;
        //Списък за прикачване
        public AttachmentList attachmentList;

        public Form1 Form;
        //Списък за стъпки
        public List<CStep> Steps;

        
        //Констуктор с параметър Windows Form
        public Controller(Form1 form)
        {
            Form = form;
            Steps = new List<CStep>();
        }
        


//Метод Сортиране чрез вмъкване по стъпки
        internal void InsertionSort()
        {
///Insertion sort Stepping algorithm
///Алгоритъм по стъпки

            CStep cstep = new CStep();
            Step step = new Step();
            step.Highlight = new List<int>() { 1 };
            //Стъпка 1
            step.Message = "Получаваме като параметър масив от елементи и неговата дължина.";
            //Команди за инциализиране и изчистване
            step.Command = "Init|THClear";
            //Име на променливата за масивa в DataGridView-a
            step.VariableNames = new List<string>() { "arr" };
            //взима стойноста на листа,колко елемента има в него
            step.Values = new List<string>() { List.IntegerElements.Count().ToString() };
            step.VariableIndexes = new List<int>() { 0 };
            cstep.NextStep = step;
            step = step.Clone();
            step.Command = "!Init|THClear";
            step.VariableIndexes = new List<int> { 2, 1 };
            cstep.PrevStep = step;
            Steps.Add(cstep);

            //Инциализиране на aux,poz
            //Стъпка 2 Декларация на променливи aux , poz
            cstep = new CStep();
            step = new Step();
            step.Highlight = new List<int>() { 3 };
            step.Message = "Декларираме две променливи:\n-'aux' която ще използваме за запаметяване на елемента в позиция i, докато преминаваме през масива\n-'poz' - друга спомагателна променлива " +
                "кoято ще използваме, за да можем да местим обекти отляво на позицията, в позицията 'i'";
            step.Command = "Detach|!Init|THClear";
            step.AttachNames = new List<string>() { "i" };
            step.VariableIndexes = new List<int>() { 3 };
            cstep.PrevStep = step;
            step = step.Clone();
            step.VariableNames = new List<string>() { "aux", "poz" };
            step.Values = new List<string>() { "-", "-" };
            step.VariableIndexes = new List<int> { 1, 2 };
            step.Command = "Init|THClear";
            cstep.NextStep = step;
            Steps.Add(cstep);

            int aux, poz = -1;

            //Инциализиране във for цикъла

            cstep = new CStep();
            step = new Step();
            step.Highlight = new List<int>() { 5 };
            step.Message = "Нека започнем да разглеждаме масива. За това използваме индекс 'i' който започва от втората позиция до последната позиция в реда, така при всяка стъпка ще спестяваме " +
                "елемент на позицията 'i' в променливата 'aux' и ще преместваме всички елементи отляво, които са по-големи (в случая) от този елемент с позиция отдясно " +
                "(ако 'i' започне от първата позиция, тогава няма да имаме елементи отляво). При среща с по-малък елемент от този, който запазваме в 'aux' ще го вмъкнем в " +
                "'aux' пред този елемент (всички други елементи, по-големи от 'aux' ще бъдат преместени в по-правилна позиция, затова правим място за 'aux' пред първия " +
                "елемент по-малък от 'aux'). Ако всички елементи са по-големи от 'aux', тогава няма да срещнем елемент който е по-малък от случая, когато след преместване на всички елементи " +
                "по-големи с позиция отляво, 'aux' ще бъде вмъкнат на първа позиция в масива.";
            step.Command = "Update|THClear|Highlight";
            step.HighlightenedBlockIndexes = new List<int>();
            step.VariableIndexes = new List<int>() { 1 };
            //заражда стойност "-" на poz и aux
            step.Values = new List<string>() { "-" };
            cstep.PrevStep = step;
            step = step.Clone();
            step.Command = "Attach|Init|THCLear";
            step.AttachNames = new List<string>() { "i" };
            step.AttachTo = new List<int>() { 1 };
            step.Rows = new List<int>() { 2 };
            step.VariableIndexes = new List<int>() { 3 };
            step.VariableNames = new List<string>() { "i" };
            //Зарежда стойност 1 на i
            step.Values = new List<string>() { "1" };
            cstep.NextStep = step;
            Steps.Add(cstep);

            for (int i = 1; i < List.IntegerElements.Count; i++)
            {
                //Инциализиране в aux

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 7 };
                step.Message = "Запазваме елемента от позицията 'i' в 'aux' защото, когато преместваме елементите по-големи от този отляво от него с позиция надясно, стойността на елемента от позицията 'i' ще бъде загубена.";
                step.Command = "Update|THighlight|Highlight";
                step.HighlightenedBlockIndexes = new List<int>() { i };
                step.HighlightedTableIndexes = new List<int>() { 1 };
                step.AttachNames = new List<string>() { "poz" };
                if (poz == -1)
                {
                    step.Command += "|Detach";
                    //Зарежда - 
                    step.Values = new List<string>() { "-" };
                }
                else
                {
                    step.Command += "|Attach";
                    step.AttachTo = new List<int>() { poz };
                    step.Rows = new List<int>() { 3 };
                    step.Values = new List<string>() { poz.ToString() };
                }
                step.VariableIndexes = new List<int>() { 2 };

                cstep.PrevStep = step;
                step = step.Clone();
                step.Command = "Update|THighlight|Highlight";
                step.VariableIndexes = new List<int>() { 1 };
                step.Values = new List<string>() { List.IntegerElements[i].ToString() };
                cstep.NextStep = step;
                Steps.Add(cstep);

                aux = List.IntegerElements[i];

                //Инциализиране в poz

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 8 };
                step.Message = "Инициализираме променливата 'poz' c 'i' по този начин ние го използваме за препращане към елементите отляво на елемента от позицията 'i'. ";
                step.Command = "Highlight|!AEHighlight|THClear|IHighlight";
                step.HighlightenedBlockIndexes = new List<int>();
                step.HighlightenedLabelIndexes = new List<int>();
                step.AttachNames = new List<string>() { "poz" };
                cstep.PrevStep = step;
                step = step.Clone();
                step.Command = "Attach|Update|THClear|Highlight";
                step.AttachTo = new List<int>() { i };
                step.Rows = new List<int>() { 3 };
                step.VariableIndexes = new List<int>() { 2 };
                step.Values = new List<string>() { i.ToString() };
                cstep.NextStep = step;
                Steps.Add(cstep);

                poz = i;

                // Инциализиране в while 

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 10 };
                step.Message = "Тъй като по-горе инициализирахме 'poz' в 'i' и 'i' никога не става 0, 'poz' винаги ще бъде по-голяма от '0' при първото въвеждане по време на итерация на цикъла. Второто условие обаче може да е вярно или не. Сравняваме елемента на позиция 'poz-1' с 'aux'.\nПонастоящем:\narr[poz-1] = " + List.IntegerElements[poz - 1] + "\naux = " + aux;
                step.Command = "AEHighlight|Highlight|IHighlight|THighlight";
                step.HighlightedTableIndexes = new List<int>() { 1 };
                step.AttachNames = new List<string>() { "poz" };
                step.HighlightenedBlockIndexes = new List<int>() { poz - 1 };
                step.HighlightenedLabelIndexes = new List<int>() { 0 };
                cstep.NextStep = step;
                step = step.Clone();
                step.Command = "AEHighlight|Highlight|IHighlight|BlockOverwrite|THighlight";
                step.Swit = new Tuple<int, int>(poz, List.IntegerElements[poz]);
                cstep.PrevStep = step;
                Steps.Add(cstep);

                while (poz > 0 && List.IntegerElements[poz - 1] > aux)
                {
                    // arr[poz] = arr[poz-1] 

                    cstep = new CStep();
                    step = new Step();
                    step.Highlight = new List<int>() { 12 };
                    step.Message = "Тъй като елементът в позиция 'poz -1' е по-голям от елемента, който запазихме в 'aux', преместваме този елемент в дясна позиция.";
                    step.Command = "!AEHighlight|Highlight|BlockOverwrite|IHighlight|THClear";
                    step.HighlightenedLabelIndexes = new List<int>();
                    step.AttachNames = new List<string>() { "poz" };
                    step.HighlightenedBlockIndexes = new List<int>() { poz, poz - 1 };
                    step.Swit = new Tuple<int, int>(poz, List.IntegerElements[poz - 1]);
                    cstep.NextStep = step;
                    step = step.Clone();
                    step.Command = "Update|Highlight|Attach|THClear";
                    step.AttachTo = new List<int>() { poz };
                    step.Rows = new List<int>() { 3 };
                    step.Values = new List<string>() { poz.ToString() };
                    step.VariableIndexes = new List<int>() { 2 };
                    cstep.PrevStep = step;
                    Steps.Add(cstep);
                    List.IntegerElements[poz] = List.IntegerElements[poz - 1];

                    // poz-- 

                    cstep = new CStep();
                    step = new Step();
                    step.Highlight = new List<int>() { 13 };
                    step.Message = "След това преместваме 'poz' с позиция вляво, за да извършим нова проверка.";
                    step.Command = "Attach|Update|Highlight|THClear";
                    step.AttachNames = new List<string>() { "poz" };
                    step.AttachTo = new List<int>() { poz - 1 };
                    step.Rows = new List<int>() { 3 };
                    step.HighlightenedBlockIndexes = new List<int>();
                    step.VariableIndexes = new List<int>() { 2 };
                    step.Values = new List<string>() { (poz - 1).ToString() };
                    cstep.NextStep = step;
                    step = step.Clone();
                    step.Command = "!AEHighlight|IHighlight|THClear";

                    if (poz != 0)
                        step.Command += "|Highlight";

                    step.HighlightenedLabelIndexes = new List<int>();
                    cstep.PrevStep = step;

                    Steps.Add(cstep);

                    poz--;


                    //условно while
                    // conditional while 

                    cstep = new CStep();
                    step = new Step();
                    step.Highlight = new List<int>() { 10 };
                    ;

                    if (poz == 0)
                    {
                        step.Message = "'poz' приема позиция 0, което означава, че всички елементи отляво на записаните в 'aux' са по-големи от този.";
                        step.Command = "AEHighlight|IHighlight|THClear";
                    }
                    else
                    {
                        step.Message = "Тъй като 'poz' все още не е достигнал позиция 0, сравняваме елемента от позиция 'poz-1' с 'aux'.\nПонастоящем:\narr[poz-1] = " + List.IntegerElements[poz - 1] + "\naux = " + aux;
                        if (List.IntegerElements[poz - 1] > aux)
                            step.Message += "\nТъй като arr[poz-1] е по-голям от aux";
                        step.Command = "AEHighlight|Highlight|IHighlight|THighlight";
                        step.HighlightedTableIndexes = new List<int>() { 1 };
                        step.HighlightenedBlockIndexes = new List<int>() { poz - 1 };
                    }

                    step.AttachNames = new List<string>() { "poz" };
                    step.HighlightenedLabelIndexes = new List<int>() { 0 };
                    cstep.NextStep = step;
                    step = step.Clone();
                    if (poz == 0)
                    {
                        step.Command = "AEHighlight|IHighlight|BlockOverwrite|THClear|Highlight";
                        step.HighlightenedBlockIndexes = new List<int>();
                    }
                    else
                        step.Command = "AEHighlight|Highlight|IHighlight|BlockOverwrite|THighlight";
                    step.Swit = new Tuple<int, int>(poz, List.IntegerElements[poz]);
                    cstep.PrevStep = step;
                    Steps.Add(cstep);
                }

                // arr[poz] = aux

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 16 };

                if (poz == 0)
                    step.Message = "Поставяме елементът 'aux' в позиция 0.";
                else
                    step.Message = "Тъй като елементът в позиция 'poz-1' беше по-малък от 'aux', ние вмъкнахме 'aux' вдясно от този елемент (в позиция 'poz').";
                step.Command = "Attach|Update|Highlight|THighlight";
                step.AttachNames = new List<string>() { "i" };
                step.AttachTo = new List<int>() { i };
                step.Rows = new List<int>() { 2 };
                step.VariableIndexes = new List<int>() { 3 };
                step.Values = new List<string>() { i.ToString() };
                step.HighlightenedBlockIndexes = new List<int>() { poz };
                step.HighlightedTableIndexes = new List<int>() { 1 };
                cstep.PrevStep = step;
                step = step.Clone();
                step.Command = "!AEHighlight|Highlight|BlockOverwrite|IHighlight|THighlight";
                step.HighlightedTableIndexes = new List<int>() { 1 };
                step.HighlightenedLabelIndexes = new List<int>();
                step.AttachNames = new List<string>() { "poz" };
                step.HighlightenedBlockIndexes = new List<int>() { poz };
                step.Swit = new Tuple<int, int>(poz, aux);
                cstep.NextStep = step;
                Steps.Add(cstep);

                List.IntegerElements[poz] = aux;

                //i++ in for 

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 5 };
                step.Message = "Увеличаваме 'i'-тата стойност .\ni = " + (i + 1).ToString() + "\narr = " + List.IntegerElements.Count.ToString() + "\n";

                if (i + 1 < List.IntegerElements.Count)
                    step.Message += "Все още не сме стигнали до последния елемент, така че започваме нова итерация.";
                else
                    step.Message += "i-тата  стойност e елемент извън масива, така че за да завършваме итерациите и излизаме от цикъла.";

                step.Command = "Attach|Update|Highlight|THClear";
                step.AttachNames = new List<string>() { "i" };
                step.AttachTo = new List<int>() { i + 1 };
                step.Rows = new List<int>() { 2 };
                step.VariableIndexes = new List<int>() { 3 };
                step.Values = new List<string>() { (i + 1).ToString() };
                step.HighlightenedBlockIndexes = new List<int>();
                cstep.NextStep = step;
                step = step.Clone();

                if (i + 1 == List.IntegerElements.Count)
                {
                    step.Command = "Attach|Init|THClear";
                    step.AttachNames = new List<string>() { "i", "poz" };
                    step.AttachTo = new List<int>() { i + 1, poz };
                    step.Rows = new List<int>() { 2, 3 };
                    step.VariableNames = new List<string>() { "aux", "poz", "i" };
                    step.VariableIndexes = new List<int>() { 1, 2, 3 };
                    step.Values = new List<string>() { aux.ToString(), poz.ToString(), (i + 1).ToString() };
                }
                else
                {
                    step.Command = "Highlight|Update|THClear";
                    step.HighlightenedBlockIndexes = new List<int>();
                    step.VariableIndexes = new List<int>() { 1 };
                    step.Values = new List<string>() { aux.ToString() };
                }
                cstep.PrevStep = step;
                Steps.Add(cstep);

                List.IntegerElements[poz] = aux;
            }

//Стъпка край на алгоритъма
            step = new Step();
            step.Highlight = new List<int>() { 18 };
            step.Message = "Най-накрая! Масива е сортиран.";
            step.Command = "!Init|Detach|THClear";
            step.VariableIndexes = new List<int>() { 3, 2, 1 };
            step.AttachNames = new List<string>() { "i", "poz" };
            Steps.Add(new CStep(step, null));
        }



        //Списък за стрингове
        private List<int> ListFromString(string List)
        {
            //Добавя стринга List в масив от sList като използва разделителя " " за да разграничи елементите
            string[] sList = List.Split(' ');
            List<int> iList = new List<int>();

            foreach (string s in sList)
                //Изпълнява се цикъла доката не обходи всички елементи в масиц sList и ги добавя в iList
                iList.Add(Convert.ToInt32(s));
//Връща списъка с добавените елементи в него
            return iList;
        }

        //Метод за добяваме за прикачване на елемент
        public void addAE(AttachmentElement AE)
        {
            attachmentList.add(AE);
        }
        
        //Метод за нов списък
        public void newList(string list)
        {
            //Присвоява стойностите от ListFromString
            List = new ListOfBlocks(ListFromString(list));
            attachmentList = new AttachmentList();
            Steps = new List<CStep>();
        }

        //Генерира произволен списък
        public List<int> generateRandomList()
        {
            List<int> randomList = new List<int>();
            Random r = new Random();
            int len, number;
            //Задава колко да е дълъг листа от 2 до 11;
            len = r.Next(2, 11);

            do
            {
                number = r.Next(1, 99);

                while (randomList.Contains(number))
                    number = r.Next(1, 99);

                randomList.Add(number);

            } while (randomList.Count < len);

            return randomList;
        }





       
        //Буля дали list е валиден
        public bool Valid(string list)
        {
            string[] elemente = list.Split(' ');

            if (elemente.Length < 2 || elemente.Length > 10)
                return false;

            foreach (string split in elemente)
            {
                int value;
                if (!int.TryParse(split, out value))
                    return false;
                if (int.Parse(split) < 0 || int.Parse(split) > 99)
                    return false;
            }
            return true;
        }

    }
}

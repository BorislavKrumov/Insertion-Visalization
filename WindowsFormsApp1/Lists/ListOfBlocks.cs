using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.AlgorithmLogic;

namespace WindowsFormsApp1.Lists
{
    //Клас Списък от Блокове
    class ListOfBlocks
    {
        //Списък с Визуалните елементи
        public List<SortingElement> VisualElements { get; private set; }
        //Списък с Числа на Елементите
        public List<int> IntegerElements { get; private set; }

        //Метод генериране на Визуалните Елементи
        public void generateVisualElements()
        {
            //Създава списък от Визуални елементи
            VisualElements = new List<SortingElement>();
            //Обхожда елементите в Списък с Числа Елементи
            foreach(int element in IntegerElements)
            {

                SortingElement SE = new SortingElement(element);
                //Добавя в списъка с Визуални елементи от списъка от Числа Елементи
                VisualElements.Add(SE);
            }
        }



        //Конструктор с параметър ListOfBlocks
        public ListOfBlocks(List<int> list)
        {
            //Използва list и присвоява стойностите от списъка list в IntegerElements
            IntegerElements = list;
            //Генерира Визуалните Елементи
            generateVisualElements();
        }



        //Метод за изчистване
        public void Clear()
        {
           //Изпразва списъка с Визуални елементи
            VisualElements = null;
            //Изпразва списъка с Числа елементи
            IntegerElements = null;
        }
    }
}

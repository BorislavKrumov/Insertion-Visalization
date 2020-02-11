using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.AlgorithmLogic;
namespace WindowsFormsApp1.Lists
{
    /// <summary>
    /// Списък на прикачените елементи
    /// </summary>
    class AttachmentList
    {
       //Списък от прикачени елементи
        public List<AttachmentElement> List { get; private set; }

        //Конструктор без параметри задаващ нов списък
        public AttachmentList()
        {
            List = new List<AttachmentElement>();

        }

        //Метод за добавяне на елемент към списък
        public void add(AttachmentElement Ea)
        {
            List.Add(Ea);
        }
        //Метод за изтриване на елемент към списък
         public void remove(int index)
        {
            List.RemoveAt(index);
        }

        //Метод за индексиране по име (стойност)
        public int getIndexByName(string name)
        {
            for(int i = 0; i < List.Count; i++)
            
                if (List[i].Value == name)
                    return i;
                return -1;
            
        }

        //Конструктор с параметър този списък
        public AttachmentElement this[int index]
        {
            get 
            {
                if (index >= 0 && index < List.Count)
                    return List[index];
                else return null;
            }

            set
            {
                if (index >= 0 && index < List.Count)
                    List[index] = value;
            }

        }


        //Метод за изчистване на списъка
        public void Clear()
        {
            List = null;
        }


    }
}

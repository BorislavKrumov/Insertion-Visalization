using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1.AlgorithmLogic
{
   

    class SortingElement
    {
        public PictureBox Block { get; private set; }
        public Label Value { get; private set; }
        
        public Point Location { get { return Block.Location; } set { Block.Location = value; } }
         
        public int IntegerValue { get; private set; }
        //Конструктор за Сортиране на елемент
        public SortingElement(int chislo)
        {
            IntegerValue = chislo;

            //Създаваа PictureBox с числото
            Block = new PictureBox();
            Block.BackColor = System.Drawing.Color.Red;
            Block.Location = new Point(0, 0);
            Block.Size = new System.Drawing.Size(40, 40);
            //Създава Label за стойността на числото в PictureBox-a
            Value = new Label();
            Value.AutoSize = true;
            Value.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (chislo > 10)
            {
                
                Value.Location = new Point(2, 4);
            }
            else
                Value.Location = new Point(9, 4);

            Value.Size = new Size(25, 30);


            if (chislo == -1)
                Value.Text = "-";
            else
                Value.Text = chislo.ToString();
            Value.BackColor = Color.Transparent;
            //Добавя числото в PictureBox Control
            Block.Controls.Add(Value);


        }
        //метод за промяна на число
        public void ChangeValue(int chislo)
        {
            if (chislo == -1)
            {
                Value.Text = "-";
            }
            else
                Value.Text = chislo.ToString();
            IntegerValue = chislo;

            if (chislo >= 10)
                //Задава кординатите на точката
                Value.Location = new Point(2, 4);
            else
                //Задава предварителните кординати на точката
                Value.Location = new Point(9, 4);
        }

        //Освобождава ресурсите Label(текст)стойност,Picturebox Block(квадратите с числата)
        public void Dispose()
        {
            Value.Dispose();
            Block.Controls.Clear();
            Block.Dispose();
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.AlgorithmLogic
{
    class AttachmentElement
    {
        //Лейбъл Елемент
        public Label Attachment { get; private set; }
        //Стрийнг Стойност
        public string Value { get; private set; }

        //Локация на елемента
        public Point Location { get; private set; }

        public AttachmentElement(string val)
        {
            Location = new Point(0, 0);
            Attachment = new Label();
            Attachment.AutoSize = true;
            Attachment.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            Attachment.Size = new System.Drawing.Size(25, 30);
            Attachment.Text = val.ToString();
            Attachment.BackColor = Color.Transparent;
            Value = val;



        }

        //Задава локация на елемента спрямо редицата в която се намира
        public void setLocation (Point elementLocation,int row)
        {
            //Кофти настроен нуждае се от промяна
            Attachment.Location = new Point(elementLocation.X + 17 - Value.Length * 7, elementLocation.Y + row * 40);
            Location = elementLocation;
        }
        
        //Метод за задаване като масив
        public void setAsArrayName(Point elementLocation)
        {
            Attachment.Location = new Point(elementLocation.X - 35, elementLocation.Y + 5);

        }
        

        //Освобождава ресурса Label Attachment
        public void Dispose()
        {
            Attachment.Dispose();
        }

    }
}

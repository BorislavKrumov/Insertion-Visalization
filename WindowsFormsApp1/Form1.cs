using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.AlgorithmLogic;
using WindowsFormsApp1.Lists;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Controller ctrl;
        private int Step;
        private string CurrentStep;
        private int SortIndex;

        public Form1()
        {
            InitializeComponent();
            ctrl = new Controller(this);
            SortIndex = -1;
        }
        //Функция сортирай
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (SortIndex != -1)
                Reset();
            ctrl.newList(textList.Text);

            SortIndex = 1;
            btnNext.Enabled = true;
            initAlgorithm();
        }
        //Изпълнява Алгоритъма
        private void initAlgorithm()
        {


            for (int i = 0; i < ctrl.List.VisualElements.Count; i++)
            {
                panelAnimation.Controls.Add(ctrl.List.VisualElements[i].Block);
                ctrl.List.VisualElements[i].Value.BringToFront();
                ctrl.List.VisualElements[i].Location = new Point((panelAnimation.Width - (40 * ctrl.List.VisualElements.Count + 12 * (ctrl.List.VisualElements.Count - 1))) / 2 + i * (ctrl.List.VisualElements[i].Block.Width + 12), 100 + ctrl.List.VisualElements[i].Location.Y);

                AttachmentElement EA = new AttachmentElement(i.ToString());
                //Добавя елемент с колонка и стойност
                ctrl.attachmentList.add(EA);
                panelAnimation.Controls.Add(EA.Attachment);
                //Задава локацията на EA attachment element
                EA.setLocation(ctrl.List.VisualElements[i].Block.Location, 1);
            }
            //S e лейбъла който показва масива от числата
            AttachmentElement AE = new AttachmentElement("S");
            ctrl.attachmentList.add(AE);
            panelAnimation.Controls.Add(AE.Attachment);
            AE.setAsArrayName(ctrl.List.VisualElements[0].Block.Location);
            //Прочита алгоритъма от файл InsertionSort.txt
            codeDesription.Text = System.IO.File.ReadAllText(@".\InsertionSort.txt");
            //Изпълнява метод InsertionSort от Controller
            ctrl.InsertionSort();

            

        }
            private void Reset()
        {
            panelAnimation.Controls.Clear();
            variableDataGridView.Rows.Clear();
            codeDesription.Clear();
            DescriptionBox.Clear();
            btnPrevious.Enabled = false;
            btnNext.Enabled = true;

            ctrl.newList(textList.Text);
        }

        private void NewListBtn_Click(object sender, EventArgs e)
        {
            textList.Clear();
            textList.Enabled = true;
            SaveBtn.Enabled = true;
            ModifyBtn.Enabled = false;
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            ModifyBtn.Enabled = false;
            textList.Enabled = true;
            SaveBtn.Enabled = true;
        }

        private void GenarateRandomListBtn_Click(object sender, EventArgs e)
        {
            textList.Clear();
            SaveBtn.Enabled = false;
            NewListBtn.Enabled = true;
            textList.Enabled = false;
            ModifyBtn.Enabled = true;

            List<int> numbers = ctrl.generateRandomList();

            for (int i = 0; i < numbers.Count; i++)
                if (i < numbers.Count - 1)
                    textList.Text += numbers[i] + " ";
                else
                    textList.Text += numbers[i];
        }



        //Stepping 
        private void btnNext_Click(object sender, EventArgs e)
        {
            //Увеличава стъпка с една повече
            Step++;
            CurrentStep = "next";
            //Изпълнява стъпка следваща
            executeStep();
            btnPrevious.Enabled = true;
            if (Step == ctrl.Steps.Count)
                btnNext.Enabled = false;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Step--;
            CurrentStep = "prev";
            executeStep();
            btnNext.Enabled = true;
            if (Step == 1)
                btnPrevious.Enabled = false;
        }



        //Функция за изпълнения на алгоритъма стъпка по стъпка

        public void Highlight(List<int> listOfIndexes)
        {
            //Изчиства codeDescription(Прозореца с кода за алгоритъма)
            codeDesription.Clear();
            //Прочита файла "Insertion sort"
            System.IO.StreamReader file = new System.IO.StreamReader(@".\" + "InsertionSort" + ".txt");
            string line;
            int index = 1;

            while ((line = file.ReadLine()) != null)
            {
                if (listOfIndexes.Contains(index))
                {
                    codeDesription.SelectionColor = Color.Black;
                    codeDesription.SelectionBackColor = Color.Gold;
                    codeDesription.AppendText(line + "\n");
                }
                //Слиза с един реед по надолу в алгоритъма
                else
                {
                    codeDesription.SelectionColor = Color.White;
                    codeDesription.SelectionBackColor = codeDesription.BackColor;
                    codeDesription.AppendText(line + "\n");
                }
                codeDesription.Refresh();
                index++;
            }

            file.Close();
        }
        /// <summary>
        /// Функция за изпълняване на Стъпка
        /// </summary>
        private void executeStep()
        {
            CStep cstep = ctrl.Steps[Step - 1];
            Step step = null;

            if (CurrentStep == "next")
                step = cstep.NextStep;
            else
                step = cstep.PrevStep;

            Highlight(step.Highlight);
            DescriptionBox.Text = "Стъпка " + Step + ":\n\n" + step.Message;
            //Foreach цикъл за Командите които се разделят с "|"
            foreach (string command in step.Command.Split('|'))
                //След като обходи командите влиза в switch стейтмънта, спрямо различната команда влиза в различните кейсове
                switch (command)
                {
                    //Кейс Join

                    case "Attach":
                        int limit;
                        if (step.Delimiter == -1 || step.UsedelimForUpdateInit)
                            limit = step.AttachNames.Count;
                        else
                            limit = step.Delimiter;

                        for (int i = 0; i < limit; i++)
                        {
                            int index = ctrl.attachmentList.getIndexByName(step.AttachNames[i]);
                            if (index == -1)
                            {
                                AttachmentElement EA_ = new AttachmentElement(step.AttachNames[i]);
                                ctrl.addAE(EA_);

                                if (step.AttachTo[i] == ctrl.List.IntegerElements.Count)
                                {
                                    Point l = new Point(ctrl.List.VisualElements[step.AttachTo[i] - 1].Block.Location.X + 52, ctrl.List.VisualElements[step.AttachTo[i] - 1].Block.Location.Y);
                                    EA_.setLocation(l, step.Rows[i]);
                                }
                                else
                                    EA_.setLocation(ctrl.List.VisualElements[step.AttachTo[i]].Block.Location, step.Rows[i]);
                                panelAnimation.Controls.Add(EA_.Attachment);
                            }
                            else
                            {
                                if (step.AttachTo[i] == ctrl.List.IntegerElements.Count)
                                {
                                    Point l = new Point(ctrl.List.VisualElements[step.AttachTo[i] - 1].Block.Location.X + 52, ctrl.List.VisualElements[step.AttachTo[i] - 1].Block.Location.Y);
                                    ctrl.attachmentList[ctrl.attachmentList.getIndexByName(step.AttachNames[i])].setLocation(l, step.Rows[i]);
                                }
                                else
                                    ctrl.attachmentList[ctrl.attachmentList.getIndexByName(step.AttachNames[i])].setLocation(ctrl.List.VisualElements[step.AttachTo[i]].Block.Location, step.Rows[i]);
                            }

                        }
                        break;
                        //Премахва I-тата и Poz label
                    case "Detach":
                        if (step.Delimiter == -1 || step.UsedelimForUpdateInit)
                            limit = 0;
                        else
                            limit = step.Delimiter;

                        for (int i = limit; i < step.AttachNames.Count; i++)
                        {
                            int index = ctrl.attachmentList.getIndexByName(step.AttachNames[i]);

                            if (index != -1)
                            {
                                panelAnimation.Controls.Remove(ctrl.attachmentList[index].Attachment);
                                ctrl.attachmentList[index].Dispose();
                                ctrl.attachmentList.remove(index);
                            }
                        }
                        break;
                        //Инциализира променлива и стойност редовете, т.де инциализира стойностите на поле variableDataGridView
                    case "Init":
 
                        if (step.Delimiter == -1)
                            limit = step.VariableIndexes.Count();
                        else
                            limit = step.Delimiter;

                        for (int i = 0; i < limit; i++)
                        {
                            variableDataGridView.Rows.Add();
                            variableDataGridView.Rows[step.VariableIndexes[i]].Cells[0].Value = step.VariableNames[i];
                            variableDataGridView.Rows[step.VariableIndexes[i]].Cells[1].Value = step.Values[i];
                        }
                        break;
                        //Трие определени редове от variableDataGridView
                    case "!Init":
                        if (step.Delimiter == -1)
                            limit = 0;
                        else
                            limit = step.Delimiter;

                        for (int i = limit; i < step.VariableIndexes.Count(); i++)
                            variableDataGridView.Rows.RemoveAt(step.VariableIndexes[i]);
                        break;
                        //Обновява стойностите в dataGridview
                    case "Update":

                        if (step.Delimiter == -1)
                            limit = step.VariableIndexes.Count();
                        else
                            limit = step.Delimiter;

                        if (step.UsedelimForUpdateInit)
                            for (int i = limit; i < step.VariableIndexes.Count(); i++)
                                variableDataGridView.Rows[step.VariableIndexes[i]].Cells[1].Value = step.Values[i];
                        else
                            for (int i = 0; i < limit; i++)
                                variableDataGridView.Rows[step.VariableIndexes[i]].Cells[1].Value = step.Values[i];
                        break;
                        //Кейс за оцветяване на числата
                    case "Highlight":
                        for (int i = 0; i < ctrl.List.VisualElements.Count; i++)
                            if (step.HighlightenedBlockIndexes.Contains(i))
                                //Eлемента който е селектиран остава червен 
                                ctrl.List.VisualElements[i].Block.BackColor = Color.Red;
                            else
                                //Елементите които не са селектирани остават оранжеви;
                                ctrl.List.VisualElements[i].Block.BackColor = Color.Orange;
                        break;
                        //Размества двете стоийности които са избрани спрямо тяхната позиция
                    case "Swap":

                        SortingElement aux = ctrl.List.VisualElements[step.Swit.Item1];
                        ctrl.List.VisualElements[step.Swit.Item1] = ctrl.List.VisualElements[step.Swit.Item2];
                        ctrl.List.VisualElements[step.Swit.Item2] = aux;
                        Point auxLoc = ctrl.List.VisualElements[step.Swit.Item1].Location;
                        ctrl.List.VisualElements[step.Swit.Item1].Location = ctrl.List.VisualElements[step.Swit.Item2].Location;
                        ctrl.List.VisualElements[step.Swit.Item2].Location = auxLoc;
                        break;

                    case "IHighlight":
                        for (int i = 0; i < ctrl.List.IntegerElements.Count; i++)
                            if (step.HighlightenedLabelIndexes.Contains(i))
                                //Оцветява на коя позиция мести число
                                ctrl.attachmentList[i].Attachment.ForeColor = Color.Red;
                            else
                                //всички останали позиции са в черно
                                ctrl.attachmentList[i].Attachment.ForeColor = Color.Black;
                        break;
                        //оцветява елемента позиция 'poz' в червено когато се използва
                    case "AEHighlight":
                        for (int i = 0; i < step.AttachNames.Count; i++)
                        {
                            int index = ctrl.attachmentList.getIndexByName(step.AttachNames[i]);

                            if (index != -1)
                                ctrl.attachmentList[index].Attachment.ForeColor = Color.Red;
                        }
                        break;
                        //Оцветява отново елемента 'poz'в черно когато се премине на следващия елемент
                    case "!AEHighlight":
                        for (int i = 0; i < step.AttachNames.Count; i++)
                        {
                            int index = ctrl.attachmentList.getIndexByName(step.AttachNames[i]);

                            if (index != -1)
                                ctrl.attachmentList[index].Attachment.ForeColor = Color.Black;
                        }
                        break;
                        //Кейс за пренаписване на стойностите на блокчетата от стойности, Разменя стойностите на swit item1 и swit item2
                    case "BlockOverwrite":
                        ctrl.List.VisualElements[step.Swit.Item1].ChangeValue(step.Swit.Item2);
                        break;
                    case "THighlight":
                        for (int i = 0; i < variableDataGridView.Rows.Count; i++)
                            if (step.HighlightedTableIndexes.Contains(i))
                            {
                               //Вдига флаг selected на редовете
                                variableDataGridView.Rows[i].Selected = true;
                            }

                        break;
                        //Изчиства DataGridView
                    case "THClear":
                        variableDataGridView.ClearSelection();
                        break;
                }
        }

        private void variableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ctrl.Valid(textList.Text))
            {
                textList.Enabled = false;
                SaveBtn.Enabled = false;
                ModifyBtn.Enabled = true;
             }
            else
                MessageBox.Show("Невалидни стойности!\n\nВалиден низ съдържа:\n- минимум 2 и максимум 10 цели елемента в обхвата [0, 99]\n- елементите ще бъдат разделени с интервал ' '\n\nНапример:\n5 2 4 3 1\nили\n23 15 19 24 59 37", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void panelAnimation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void codeDesription_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

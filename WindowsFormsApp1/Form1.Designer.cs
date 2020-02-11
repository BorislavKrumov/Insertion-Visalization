namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelAnimation = new System.Windows.Forms.Panel();
            this.variableDataGridView = new System.Windows.Forms.DataGridView();
            this.Variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.codeDesription = new System.Windows.Forms.RichTextBox();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GenarateRandomListBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.NewListBtn = new System.Windows.Forms.Button();
            this.textList = new System.Windows.Forms.TextBox();
            this.ListTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.variableDataGridView)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAnimation
            // 
            this.panelAnimation.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelAnimation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAnimation.Location = new System.Drawing.Point(12, 12);
            this.panelAnimation.Name = "panelAnimation";
            this.panelAnimation.Size = new System.Drawing.Size(487, 263);
            this.panelAnimation.TabIndex = 0;
            this.panelAnimation.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAnimation_Paint);
            // 
            // variableDataGridView
            // 
            this.variableDataGridView.AllowUserToAddRows = false;
            this.variableDataGridView.AllowUserToDeleteRows = false;
            this.variableDataGridView.AllowUserToResizeColumns = false;
            this.variableDataGridView.AllowUserToResizeRows = false;
            this.variableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.variableDataGridView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.variableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.variableDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.variableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.variableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.variableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Variable,
            this.tovar});
            this.variableDataGridView.EnableHeadersVisualStyles = false;
            this.variableDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.variableDataGridView.Location = new System.Drawing.Point(505, 12);
            this.variableDataGridView.Name = "variableDataGridView";
            this.variableDataGridView.ReadOnly = true;
            this.variableDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.variableDataGridView.RowHeadersVisible = false;
            this.variableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.variableDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.variableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.variableDataGridView.Size = new System.Drawing.Size(246, 263);
            this.variableDataGridView.TabIndex = 1;
            this.variableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.variableDataGridView_CellContentClick);
            // 
            // Variable
            // 
            this.Variable.HeaderText = "Променлива";
            this.Variable.Name = "Variable";
            this.Variable.ReadOnly = true;
            this.Variable.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tovar
            // 
            this.tovar.HeaderText = "Стойност";
            this.tovar.Name = "tovar";
            this.tovar.ReadOnly = true;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.SystemColors.Window;
            this.DescriptionBox.Location = new System.Drawing.Point(12, 281);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ReadOnly = true;
            this.DescriptionBox.Size = new System.Drawing.Size(739, 169);
            this.DescriptionBox.TabIndex = 2;
            this.DescriptionBox.Text = "";
            this.DescriptionBox.TextChanged += new System.EventHandler(this.DescriptionBox_TextChanged);
            // 
            // codeDesription
            // 
            this.codeDesription.BackColor = System.Drawing.SystemColors.WindowText;
            this.codeDesription.ForeColor = System.Drawing.SystemColors.Window;
            this.codeDesription.Location = new System.Drawing.Point(757, 8);
            this.codeDesription.Name = "codeDesription";
            this.codeDesription.ReadOnly = true;
            this.codeDesription.Size = new System.Drawing.Size(315, 442);
            this.codeDesription.TabIndex = 0;
            this.codeDesription.Text = "";
            this.codeDesription.TextChanged += new System.EventHandler(this.codeDesription_TextChanged);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControl.Controls.Add(this.btnSort);
            this.panelControl.Controls.Add(this.btnNext);
            this.panelControl.Controls.Add(this.btnPrevious);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.GenarateRandomListBtn);
            this.panelControl.Controls.Add(this.SaveBtn);
            this.panelControl.Controls.Add(this.ModifyBtn);
            this.panelControl.Controls.Add(this.NewListBtn);
            this.panelControl.Controls.Add(this.textList);
            this.panelControl.Controls.Add(this.ListTitle);
            this.panelControl.Location = new System.Drawing.Point(12, 456);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(690, 134);
            this.panelControl.TabIndex = 4;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSort.Location = new System.Drawing.Point(492, 0);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(195, 129);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "Сортирай";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnNext.Location = new System.Drawing.Point(187, 23);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(185, 37);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Следваща Стъпка";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPrevious.Location = new System.Drawing.Point(3, 23);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(178, 37);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Предишна Стъпка";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Етапи на развитие на алгоритъма:";
            // 
            // GenarateRandomListBtn
            // 
            this.GenarateRandomListBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GenarateRandomListBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.GenarateRandomListBtn.Location = new System.Drawing.Point(311, 94);
            this.GenarateRandomListBtn.Name = "GenarateRandomListBtn";
            this.GenarateRandomListBtn.Size = new System.Drawing.Size(139, 37);
            this.GenarateRandomListBtn.TabIndex = 5;
            this.GenarateRandomListBtn.Text = "Генерирай произволен списък";
            this.GenarateRandomListBtn.UseVisualStyleBackColor = false;
            this.GenarateRandomListBtn.Click += new System.EventHandler(this.GenarateRandomListBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SaveBtn.Location = new System.Drawing.Point(207, 94);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(98, 37);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Запази";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ModifyBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ModifyBtn.Location = new System.Drawing.Point(103, 94);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(98, 37);
            this.ModifyBtn.TabIndex = 3;
            this.ModifyBtn.Text = "Редактирай";
            this.ModifyBtn.UseVisualStyleBackColor = false;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // NewListBtn
            // 
            this.NewListBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.NewListBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.NewListBtn.Location = new System.Drawing.Point(-1, 94);
            this.NewListBtn.Name = "NewListBtn";
            this.NewListBtn.Size = new System.Drawing.Size(98, 37);
            this.NewListBtn.TabIndex = 2;
            this.NewListBtn.Text = "Нов Списък";
            this.NewListBtn.UseVisualStyleBackColor = false;
            this.NewListBtn.Click += new System.EventHandler(this.NewListBtn_Click);
            // 
            // textList
            // 
            this.textList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textList.Location = new System.Drawing.Point(76, 69);
            this.textList.Name = "textList";
            this.textList.Size = new System.Drawing.Size(410, 26);
            this.textList.TabIndex = 1;
            // 
            // ListTitle
            // 
            this.ListTitle.AutoSize = true;
            this.ListTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ListTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.ListTitle.Location = new System.Drawing.Point(3, 69);
            this.ListTitle.Name = "ListTitle";
            this.ListTitle.Size = new System.Drawing.Size(67, 22);
            this.ListTitle.TabIndex = 0;
            this.ListTitle.Text = "Списък";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 659);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.codeDesription);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.variableDataGridView);
            this.Controls.Add(this.panelAnimation);
            this.Name = "Form1";
            this.Text = "Insertion Sort Visualization";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.variableDataGridView)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAnimation;
        private System.Windows.Forms.DataGridView variableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variable;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovar;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.RichTextBox codeDesription;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.Button NewListBtn;
        private System.Windows.Forms.TextBox textList;
        private System.Windows.Forms.Label ListTitle;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenarateRandomListBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}


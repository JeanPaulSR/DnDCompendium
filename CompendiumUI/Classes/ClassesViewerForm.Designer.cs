namespace CompendiumUI
{
    partial class ClassesViewerForm
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
            components = new System.ComponentModel.Container();
            Button ClassViewerCreateClass;
            Button ClassViewerEditClass;
            Button ClassViewerDeleteClass;
            contextMenuStrip1 = new ContextMenuStrip(components);
            ClassesFormTable = new DataGridView();
            Classes = new DataGridViewTextBoxColumn();
            SourceID = new DataGridViewTextBoxColumn();
            ClassViewerCreateClass = new Button();
            ClassViewerEditClass = new Button();
            ClassViewerDeleteClass = new Button();
            ((System.ComponentModel.ISupportInitialize)ClassesFormTable).BeginInit();
            SuspendLayout();
            // 
            // ClassViewerCreateClass
            // 
            ClassViewerCreateClass.Location = new Point(12, 12);
            ClassViewerCreateClass.Name = "ClassViewerCreateClass";
            ClassViewerCreateClass.Size = new Size(193, 53);
            ClassViewerCreateClass.TabIndex = 8;
            ClassViewerCreateClass.Text = "Create Class";
            ClassViewerCreateClass.UseVisualStyleBackColor = true;
            // 
            // ClassViewerEditClass
            // 
            ClassViewerEditClass.Location = new Point(12, 71);
            ClassViewerEditClass.Name = "ClassViewerEditClass";
            ClassViewerEditClass.Size = new Size(193, 53);
            ClassViewerEditClass.TabIndex = 9;
            ClassViewerEditClass.Text = "Edit Class";
            ClassViewerEditClass.UseVisualStyleBackColor = true;
            // 
            // ClassViewerDeleteClass
            // 
            ClassViewerDeleteClass.Location = new Point(12, 130);
            ClassViewerDeleteClass.Name = "ClassViewerDeleteClass";
            ClassViewerDeleteClass.Size = new Size(193, 53);
            ClassViewerDeleteClass.TabIndex = 10;
            ClassViewerDeleteClass.Text = "Delete Class";
            ClassViewerDeleteClass.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ClassesFormTable
            // 
            ClassesFormTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClassesFormTable.BackgroundColor = SystemColors.Window;
            ClassesFormTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClassesFormTable.Columns.AddRange(new DataGridViewColumn[] { Classes, SourceID });
            ClassesFormTable.Location = new Point(211, 12);
            ClassesFormTable.Name = "ClassesFormTable";
            ClassesFormTable.RowHeadersVisible = false;
            ClassesFormTable.ScrollBars = ScrollBars.Vertical;
            ClassesFormTable.Size = new Size(310, 308);
            ClassesFormTable.TabIndex = 2;
            // 
            // Classes
            // 
            Classes.HeaderText = "Classes";
            Classes.Name = "Classes";
            // 
            // SourceID
            // 
            SourceID.HeaderText = "Source";
            SourceID.Name = "SourceID";
            // 
            // ClassViewerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(533, 332);
            Controls.Add(ClassViewerDeleteClass);
            Controls.Add(ClassViewerEditClass);
            Controls.Add(ClassViewerCreateClass);
            Controls.Add(ClassesFormTable);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ClassViewerForm";
            Text = "Classes";
            ((System.ComponentModel.ISupportInitialize)ClassesFormTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView ClassesFormTable;
        private DataGridViewTextBoxColumn Classes;
        private DataGridViewTextBoxColumn SourceID;
    }
}
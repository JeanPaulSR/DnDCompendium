
using System.Collections.Generic;
using System.Windows.Forms;
using CompendiumLibrary;
using CompendiumLibrary.Classes;
using CompendiumLibrary.src.Classes;
using CompendiumLibrary.src.Items;
using CompendiumLibrary.src.UniversalTraits;

namespace CompendiumUI.Classes
{
    partial class ClassViewerForm
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
            ClassViewerName = new Label();
            ClassTableGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ClassTableGridView).BeginInit();
            SuspendLayout();
            // 
            // ClassViewerName
            // 
            ClassViewerName.AutoSize = true;
            ClassViewerName.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClassViewerName.Location = new Point(13, 542);
            ClassViewerName.Name = "ClassViewerName";
            ClassViewerName.Size = new Size(84, 32);
            ClassViewerName.TabIndex = 1;
            ClassViewerName.Text = "Class";
            // 
            // ClassTableGridView
            // 
            ClassTableGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClassTableGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClassTableGridView.Location = new Point(12, 12);
            ClassTableGridView.Name = "ClassTableGridView";
            ClassTableGridView.Size = new Size(780, 150);
            ClassTableGridView.TabIndex = 2;
            // 
            // ClassViewerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(804, 766);
            Controls.Add(ClassTableGridView);
            Controls.Add(ClassViewerName);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(820, 805);
            Name = "ClassViewerForm";
            Text = "ClassViewerForm";
            ((System.ComponentModel.ISupportInitialize)ClassTableGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ClassViewerName;
        private Label classBaseStructure1;
        private DataGridView ClassTableGridView;
    }

}
namespace CompendiumUI
{
    partial class CompendiumViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button CompendiumViewerBackground;
            Button CompendiumViewerRace;
            Button CompendiumViewerSpell;
            Button CompendiumViewerFeat;
            Button CompendiumViewerItem;
            Button CompendiumViewerCreateCompendium;
            Button CompendiumViewerEditCompendium;
            Button CompendiumViewerDeleteCompendium;
            Button CompendiumViewerOpenCompendium;
            Button CompendiumViewerBestiary;
            CompendiumViewerClass = new Button();
            CompendiumViewerTable = new DataGridView();
            Compendium = new DataGridViewTextBoxColumn();
            SourceId = new DataGridViewTextBoxColumn();
            CompendiumViewerBackground = new Button();
            CompendiumViewerRace = new Button();
            CompendiumViewerSpell = new Button();
            CompendiumViewerFeat = new Button();
            CompendiumViewerItem = new Button();
            CompendiumViewerCreateCompendium = new Button();
            CompendiumViewerEditCompendium = new Button();
            CompendiumViewerDeleteCompendium = new Button();
            CompendiumViewerOpenCompendium = new Button();
            CompendiumViewerBestiary = new Button();
            ((System.ComponentModel.ISupportInitialize)CompendiumViewerTable).BeginInit();
            SuspendLayout();
            // 
            // CompendiumViewerBackground
            // 
            CompendiumViewerBackground.Location = new Point(32, 96);
            CompendiumViewerBackground.Name = "CompendiumViewerBackground";
            CompendiumViewerBackground.Size = new Size(117, 53);
            CompendiumViewerBackground.TabIndex = 1;
            CompendiumViewerBackground.Text = "Background";
            CompendiumViewerBackground.UseVisualStyleBackColor = true;
            // 
            // CompendiumViewerRace
            // 
            CompendiumViewerRace.Location = new Point(155, 32);
            CompendiumViewerRace.Name = "CompendiumViewerRace";
            CompendiumViewerRace.Size = new Size(117, 53);
            CompendiumViewerRace.TabIndex = 2;
            CompendiumViewerRace.Text = "Race";
            CompendiumViewerRace.UseVisualStyleBackColor = true;
            // 
            // CompendiumViewerSpell
            // 
            CompendiumViewerSpell.Location = new Point(155, 96);
            CompendiumViewerSpell.Name = "CompendiumViewerSpell";
            CompendiumViewerSpell.Size = new Size(117, 53);
            CompendiumViewerSpell.TabIndex = 3;
            CompendiumViewerSpell.Text = "Spell";
            CompendiumViewerSpell.UseVisualStyleBackColor = true;
            // 
            // CompendiumViewerFeat
            // 
            CompendiumViewerFeat.Location = new Point(32, 160);
            CompendiumViewerFeat.Name = "CompendiumViewerFeat";
            CompendiumViewerFeat.Size = new Size(117, 53);
            CompendiumViewerFeat.TabIndex = 4;
            CompendiumViewerFeat.Text = "Feat";
            CompendiumViewerFeat.UseVisualStyleBackColor = true;
            // 
            // CompendiumViewerItem
            // 
            CompendiumViewerItem.Location = new Point(155, 160);
            CompendiumViewerItem.Name = "CompendiumViewerItem";
            CompendiumViewerItem.Size = new Size(117, 53);
            CompendiumViewerItem.TabIndex = 5;
            CompendiumViewerItem.Text = "Item";
            CompendiumViewerItem.UseVisualStyleBackColor = true;
            // 
            // CompendiumViewerCreateCompendium
            // 
            CompendiumViewerCreateCompendium.Location = new Point(287, 32);
            CompendiumViewerCreateCompendium.Name = "CompendiumViewerCreateCompendium";
            CompendiumViewerCreateCompendium.Size = new Size(193, 53);
            CompendiumViewerCreateCompendium.TabIndex = 7;
            CompendiumViewerCreateCompendium.Text = "Create Compendium";
            CompendiumViewerCreateCompendium.UseVisualStyleBackColor = true;
            // 
            // CompendiumViewerEditCompendium
            // 
            CompendiumViewerEditCompendium.Location = new Point(287, 96);
            CompendiumViewerEditCompendium.Name = "CompendiumViewerEditCompendium";
            CompendiumViewerEditCompendium.Size = new Size(193, 53);
            CompendiumViewerEditCompendium.TabIndex = 8;
            CompendiumViewerEditCompendium.Text = "Edit Compendium";
            CompendiumViewerEditCompendium.UseVisualStyleBackColor = true;
            CompendiumViewerEditCompendium.Click += CompendiumViewerEditCompendium_Click;
            // 
            // CompendiumViewerDeleteCompendium
            // 
            CompendiumViewerDeleteCompendium.Location = new Point(287, 160);
            CompendiumViewerDeleteCompendium.Name = "CompendiumViewerDeleteCompendium";
            CompendiumViewerDeleteCompendium.Size = new Size(193, 53);
            CompendiumViewerDeleteCompendium.TabIndex = 9;
            CompendiumViewerDeleteCompendium.Text = "Delete Compendium";
            CompendiumViewerDeleteCompendium.UseVisualStyleBackColor = true;
            // 
            // CompendiumViewerOpenCompendium
            // 
            CompendiumViewerOpenCompendium.Location = new Point(287, 219);
            CompendiumViewerOpenCompendium.Name = "CompendiumViewerOpenCompendium";
            CompendiumViewerOpenCompendium.Size = new Size(193, 53);
            CompendiumViewerOpenCompendium.TabIndex = 10;
            CompendiumViewerOpenCompendium.Text = "Open Compendium";
            CompendiumViewerOpenCompendium.UseVisualStyleBackColor = true;
            // 
            // CompendiumViewerBestiary
            // 
            CompendiumViewerBestiary.Location = new Point(102, 219);
            CompendiumViewerBestiary.Name = "CompendiumViewerBestiary";
            CompendiumViewerBestiary.Size = new Size(117, 53);
            CompendiumViewerBestiary.TabIndex = 12;
            CompendiumViewerBestiary.Text = "Bestiary";
            CompendiumViewerBestiary.UseVisualStyleBackColor = true;
            // 
            // CompendiumViewerClass
            // 
            CompendiumViewerClass.Location = new Point(32, 32);
            CompendiumViewerClass.Name = "CompendiumViewerClass";
            CompendiumViewerClass.Size = new Size(117, 53);
            CompendiumViewerClass.TabIndex = 0;
            CompendiumViewerClass.Text = "Class";
            CompendiumViewerClass.UseVisualStyleBackColor = true;
            // 
            // CompendiumViewerTable
            // 
            CompendiumViewerTable.AllowUserToAddRows = false;
            CompendiumViewerTable.AllowUserToDeleteRows = false;
            CompendiumViewerTable.AllowUserToResizeColumns = false;
            CompendiumViewerTable.AllowUserToResizeRows = false;
            CompendiumViewerTable.BackgroundColor = SystemColors.ControlLightLight;
            CompendiumViewerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CompendiumViewerTable.Columns.AddRange(new DataGridViewColumn[] { Compendium, SourceId });
            CompendiumViewerTable.Location = new Point(522, 32);
            CompendiumViewerTable.Name = "CompendiumViewerTable";
            CompendiumViewerTable.ReadOnly = true;
            CompendiumViewerTable.RowHeadersVisible = false;
            CompendiumViewerTable.Size = new Size(318, 240);
            CompendiumViewerTable.TabIndex = 6;
            CompendiumViewerTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Compendium
            // 
            Compendium.FillWeight = 123.809525F;
            Compendium.HeaderText = "Compendium Name";
            Compendium.Name = "Compendium";
            Compendium.ReadOnly = true;
            Compendium.Width = 195;
            // 
            // SourceId
            // 
            SourceId.FillWeight = 76.1904755F;
            SourceId.HeaderText = "Source Id";
            SourceId.Name = "SourceId";
            SourceId.ReadOnly = true;
            SourceId.Width = 120;
            // 
            // CompendiumViewerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(854, 296);
            Controls.Add(CompendiumViewerBestiary);
            Controls.Add(CompendiumViewerOpenCompendium);
            Controls.Add(CompendiumViewerDeleteCompendium);
            Controls.Add(CompendiumViewerEditCompendium);
            Controls.Add(CompendiumViewerCreateCompendium);
            Controls.Add(CompendiumViewerTable);
            Controls.Add(CompendiumViewerItem);
            Controls.Add(CompendiumViewerFeat);
            Controls.Add(CompendiumViewerSpell);
            Controls.Add(CompendiumViewerRace);
            Controls.Add(CompendiumViewerBackground);
            Controls.Add(CompendiumViewerClass);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "CompendiumViewerForm";
            Text = "Compendium";
            ((System.ComponentModel.ISupportInitialize)CompendiumViewerTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CompendiumViewerClass;
        private DataGridView CompendiumViewerTable;
        private DataGridViewTextBoxColumn Compendium;
        private DataGridViewTextBoxColumn SourceId;
    }
}

namespace DominionRandomizer_SeanMedina
{
    partial class DominionRandomizer
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
            this.UI_DGV_CardList = new System.Windows.Forms.DataGridView();
            this.UI_Button_FullList = new System.Windows.Forms.Button();
            this.UI_GroupBox_Filter = new System.Windows.Forms.GroupBox();
            this.UI_RadioButton_FilterType_Potion = new System.Windows.Forms.RadioButton();
            this.UI_RadioButton_FilterType_Cost = new System.Windows.Forms.RadioButton();
            this.UI_RadioButton_FilterType_Type = new System.Windows.Forms.RadioButton();
            this.UI_RadioButton_FilterType_Set = new System.Windows.Forms.RadioButton();
            this.UI_ComboBox_FilterValue = new System.Windows.Forms.ComboBox();
            this.UI_Button_SearchByFilter = new System.Windows.Forms.Button();
            this.UI_TextBox_SearchTextFilter = new System.Windows.Forms.TextBox();
            this.UI_Button_SearchByText = new System.Windows.Forms.Button();
            this.UI_GroupBox_RandomizerSets = new System.Windows.Forms.GroupBox();
            this.UI_Button_Randomize = new System.Windows.Forms.Button();
            this.UI_CheckBox_RandomizerSet_Promo = new System.Windows.Forms.CheckBox();
            this.UI_CheckBox_RandomizerSet_Adventures = new System.Windows.Forms.CheckBox();
            this.UI_CheckBox_RandomizerSet_Guilds = new System.Windows.Forms.CheckBox();
            this.UI_CheckBox_RandomizerSet_Hinterlands = new System.Windows.Forms.CheckBox();
            this.UI_CheckBox_RandomizerSet_Prosperity = new System.Windows.Forms.CheckBox();
            this.UI_CheckBox_RandomizerSet_Alchemy = new System.Windows.Forms.CheckBox();
            this.UI_CheckBox_RandomizerSet_Seaside = new System.Windows.Forms.CheckBox();
            this.UI_CheckBox_RandomizerSet_Intrigue = new System.Windows.Forms.CheckBox();
            this.UI_CheckBox_RandomizerSet_Base = new System.Windows.Forms.CheckBox();
            this.UI_CheckBox_RandomizerSet_DarkAges = new System.Windows.Forms.CheckBox();
            this.UI_CheckBox_RandomizerSet_Cornucopia = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.UI_DGV_CardList)).BeginInit();
            this.UI_GroupBox_Filter.SuspendLayout();
            this.UI_GroupBox_RandomizerSets.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_DGV_CardList
            // 
            this.UI_DGV_CardList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_DGV_CardList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UI_DGV_CardList.Location = new System.Drawing.Point(12, 12);
            this.UI_DGV_CardList.Name = "UI_DGV_CardList";
            this.UI_DGV_CardList.Size = new System.Drawing.Size(688, 468);
            this.UI_DGV_CardList.TabIndex = 0;
            // 
            // UI_Button_FullList
            // 
            this.UI_Button_FullList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Button_FullList.Location = new System.Drawing.Point(739, 12);
            this.UI_Button_FullList.Name = "UI_Button_FullList";
            this.UI_Button_FullList.Size = new System.Drawing.Size(121, 28);
            this.UI_Button_FullList.TabIndex = 1;
            this.UI_Button_FullList.Text = "Full List";
            this.UI_Button_FullList.UseVisualStyleBackColor = true;
            this.UI_Button_FullList.Click += new System.EventHandler(this.UI_Button_FullList_Click);
            // 
            // UI_GroupBox_Filter
            // 
            this.UI_GroupBox_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_GroupBox_Filter.Controls.Add(this.UI_RadioButton_FilterType_Potion);
            this.UI_GroupBox_Filter.Controls.Add(this.UI_RadioButton_FilterType_Cost);
            this.UI_GroupBox_Filter.Controls.Add(this.UI_RadioButton_FilterType_Type);
            this.UI_GroupBox_Filter.Controls.Add(this.UI_RadioButton_FilterType_Set);
            this.UI_GroupBox_Filter.Location = new System.Drawing.Point(712, 46);
            this.UI_GroupBox_Filter.Name = "UI_GroupBox_Filter";
            this.UI_GroupBox_Filter.Size = new System.Drawing.Size(174, 74);
            this.UI_GroupBox_Filter.TabIndex = 2;
            this.UI_GroupBox_Filter.TabStop = false;
            this.UI_GroupBox_Filter.Text = "Filter Type";
            // 
            // UI_RadioButton_FilterType_Potion
            // 
            this.UI_RadioButton_FilterType_Potion.AutoSize = true;
            this.UI_RadioButton_FilterType_Potion.Location = new System.Drawing.Point(72, 42);
            this.UI_RadioButton_FilterType_Potion.Name = "UI_RadioButton_FilterType_Potion";
            this.UI_RadioButton_FilterType_Potion.Size = new System.Drawing.Size(55, 17);
            this.UI_RadioButton_FilterType_Potion.TabIndex = 3;
            this.UI_RadioButton_FilterType_Potion.Text = "Potion";
            this.UI_RadioButton_FilterType_Potion.UseVisualStyleBackColor = true;
            // 
            // UI_RadioButton_FilterType_Cost
            // 
            this.UI_RadioButton_FilterType_Cost.AutoSize = true;
            this.UI_RadioButton_FilterType_Cost.Location = new System.Drawing.Point(72, 19);
            this.UI_RadioButton_FilterType_Cost.Name = "UI_RadioButton_FilterType_Cost";
            this.UI_RadioButton_FilterType_Cost.Size = new System.Drawing.Size(46, 17);
            this.UI_RadioButton_FilterType_Cost.TabIndex = 2;
            this.UI_RadioButton_FilterType_Cost.Text = "Cost";
            this.UI_RadioButton_FilterType_Cost.UseVisualStyleBackColor = true;
            // 
            // UI_RadioButton_FilterType_Type
            // 
            this.UI_RadioButton_FilterType_Type.AutoSize = true;
            this.UI_RadioButton_FilterType_Type.Location = new System.Drawing.Point(6, 42);
            this.UI_RadioButton_FilterType_Type.Name = "UI_RadioButton_FilterType_Type";
            this.UI_RadioButton_FilterType_Type.Size = new System.Drawing.Size(49, 17);
            this.UI_RadioButton_FilterType_Type.TabIndex = 1;
            this.UI_RadioButton_FilterType_Type.Text = "Type";
            this.UI_RadioButton_FilterType_Type.UseVisualStyleBackColor = true;
            // 
            // UI_RadioButton_FilterType_Set
            // 
            this.UI_RadioButton_FilterType_Set.AutoSize = true;
            this.UI_RadioButton_FilterType_Set.Checked = true;
            this.UI_RadioButton_FilterType_Set.Location = new System.Drawing.Point(6, 19);
            this.UI_RadioButton_FilterType_Set.Name = "UI_RadioButton_FilterType_Set";
            this.UI_RadioButton_FilterType_Set.Size = new System.Drawing.Size(41, 17);
            this.UI_RadioButton_FilterType_Set.TabIndex = 0;
            this.UI_RadioButton_FilterType_Set.TabStop = true;
            this.UI_RadioButton_FilterType_Set.Text = "Set";
            this.UI_RadioButton_FilterType_Set.UseVisualStyleBackColor = true;
            // 
            // UI_ComboBox_FilterValue
            // 
            this.UI_ComboBox_FilterValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_ComboBox_FilterValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UI_ComboBox_FilterValue.FormattingEnabled = true;
            this.UI_ComboBox_FilterValue.Location = new System.Drawing.Point(739, 136);
            this.UI_ComboBox_FilterValue.Name = "UI_ComboBox_FilterValue";
            this.UI_ComboBox_FilterValue.Size = new System.Drawing.Size(121, 21);
            this.UI_ComboBox_FilterValue.TabIndex = 3;
            // 
            // UI_Button_SearchByFilter
            // 
            this.UI_Button_SearchByFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Button_SearchByFilter.Location = new System.Drawing.Point(739, 163);
            this.UI_Button_SearchByFilter.Name = "UI_Button_SearchByFilter";
            this.UI_Button_SearchByFilter.Size = new System.Drawing.Size(121, 28);
            this.UI_Button_SearchByFilter.TabIndex = 4;
            this.UI_Button_SearchByFilter.Text = "Search by Filter";
            this.UI_Button_SearchByFilter.UseVisualStyleBackColor = true;
            this.UI_Button_SearchByFilter.Click += new System.EventHandler(this.UI_Button_SearchByFilter_Click);
            // 
            // UI_TextBox_SearchTextFilter
            // 
            this.UI_TextBox_SearchTextFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_TextBox_SearchTextFilter.Location = new System.Drawing.Point(739, 208);
            this.UI_TextBox_SearchTextFilter.Name = "UI_TextBox_SearchTextFilter";
            this.UI_TextBox_SearchTextFilter.Size = new System.Drawing.Size(124, 20);
            this.UI_TextBox_SearchTextFilter.TabIndex = 5;
            // 
            // UI_Button_SearchByText
            // 
            this.UI_Button_SearchByText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Button_SearchByText.Location = new System.Drawing.Point(739, 234);
            this.UI_Button_SearchByText.Name = "UI_Button_SearchByText";
            this.UI_Button_SearchByText.Size = new System.Drawing.Size(124, 28);
            this.UI_Button_SearchByText.TabIndex = 6;
            this.UI_Button_SearchByText.Text = "Search by Text";
            this.UI_Button_SearchByText.UseVisualStyleBackColor = true;
            this.UI_Button_SearchByText.Click += new System.EventHandler(this.UI_Button_SearchByText_Click);
            // 
            // UI_GroupBox_RandomizerSets
            // 
            this.UI_GroupBox_RandomizerSets.Controls.Add(this.UI_CheckBox_RandomizerSet_Adventures);
            this.UI_GroupBox_RandomizerSets.Controls.Add(this.UI_CheckBox_RandomizerSet_Guilds);
            this.UI_GroupBox_RandomizerSets.Controls.Add(this.UI_CheckBox_RandomizerSet_DarkAges);
            this.UI_GroupBox_RandomizerSets.Controls.Add(this.UI_CheckBox_RandomizerSet_Cornucopia);
            this.UI_GroupBox_RandomizerSets.Controls.Add(this.UI_CheckBox_RandomizerSet_Hinterlands);
            this.UI_GroupBox_RandomizerSets.Controls.Add(this.UI_CheckBox_RandomizerSet_Prosperity);
            this.UI_GroupBox_RandomizerSets.Controls.Add(this.UI_CheckBox_RandomizerSet_Alchemy);
            this.UI_GroupBox_RandomizerSets.Controls.Add(this.UI_CheckBox_RandomizerSet_Seaside);
            this.UI_GroupBox_RandomizerSets.Controls.Add(this.UI_CheckBox_RandomizerSet_Intrigue);
            this.UI_GroupBox_RandomizerSets.Controls.Add(this.UI_CheckBox_RandomizerSet_Base);
            this.UI_GroupBox_RandomizerSets.Controls.Add(this.UI_CheckBox_RandomizerSet_Promo);
            this.UI_GroupBox_RandomizerSets.Location = new System.Drawing.Point(712, 282);
            this.UI_GroupBox_RandomizerSets.Name = "UI_GroupBox_RandomizerSets";
            this.UI_GroupBox_RandomizerSets.Size = new System.Drawing.Size(174, 166);
            this.UI_GroupBox_RandomizerSets.TabIndex = 7;
            this.UI_GroupBox_RandomizerSets.TabStop = false;
            this.UI_GroupBox_RandomizerSets.Text = "Randomizer Sets";
            // 
            // UI_Button_Randomize
            // 
            this.UI_Button_Randomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Button_Randomize.Location = new System.Drawing.Point(739, 454);
            this.UI_Button_Randomize.Name = "UI_Button_Randomize";
            this.UI_Button_Randomize.Size = new System.Drawing.Size(124, 28);
            this.UI_Button_Randomize.TabIndex = 8;
            this.UI_Button_Randomize.Text = "Randomize!";
            this.UI_Button_Randomize.UseVisualStyleBackColor = true;
            this.UI_Button_Randomize.Click += new System.EventHandler(this.UI_Button_Randomize_Click);
            // 
            // UI_CheckBox_RandomizerSet_Promo
            // 
            this.UI_CheckBox_RandomizerSet_Promo.AutoSize = true;
            this.UI_CheckBox_RandomizerSet_Promo.Location = new System.Drawing.Point(6, 20);
            this.UI_CheckBox_RandomizerSet_Promo.Name = "UI_CheckBox_RandomizerSet_Promo";
            this.UI_CheckBox_RandomizerSet_Promo.Size = new System.Drawing.Size(56, 17);
            this.UI_CheckBox_RandomizerSet_Promo.TabIndex = 9;
            this.UI_CheckBox_RandomizerSet_Promo.Text = "Promo";
            this.UI_CheckBox_RandomizerSet_Promo.UseVisualStyleBackColor = true;
            // 
            // UI_CheckBox_RandomizerSet_Adventures
            // 
            this.UI_CheckBox_RandomizerSet_Adventures.AutoSize = true;
            this.UI_CheckBox_RandomizerSet_Adventures.Location = new System.Drawing.Point(78, 134);
            this.UI_CheckBox_RandomizerSet_Adventures.Name = "UI_CheckBox_RandomizerSet_Adventures";
            this.UI_CheckBox_RandomizerSet_Adventures.Size = new System.Drawing.Size(80, 17);
            this.UI_CheckBox_RandomizerSet_Adventures.TabIndex = 10;
            this.UI_CheckBox_RandomizerSet_Adventures.Text = "Adventures";
            this.UI_CheckBox_RandomizerSet_Adventures.UseVisualStyleBackColor = true;
            // 
            // UI_CheckBox_RandomizerSet_Guilds
            // 
            this.UI_CheckBox_RandomizerSet_Guilds.AutoSize = true;
            this.UI_CheckBox_RandomizerSet_Guilds.Location = new System.Drawing.Point(78, 111);
            this.UI_CheckBox_RandomizerSet_Guilds.Name = "UI_CheckBox_RandomizerSet_Guilds";
            this.UI_CheckBox_RandomizerSet_Guilds.Size = new System.Drawing.Size(55, 17);
            this.UI_CheckBox_RandomizerSet_Guilds.TabIndex = 11;
            this.UI_CheckBox_RandomizerSet_Guilds.Text = "Guilds";
            this.UI_CheckBox_RandomizerSet_Guilds.UseVisualStyleBackColor = true;
            // 
            // UI_CheckBox_RandomizerSet_Hinterlands
            // 
            this.UI_CheckBox_RandomizerSet_Hinterlands.AutoSize = true;
            this.UI_CheckBox_RandomizerSet_Hinterlands.Location = new System.Drawing.Point(78, 65);
            this.UI_CheckBox_RandomizerSet_Hinterlands.Name = "UI_CheckBox_RandomizerSet_Hinterlands";
            this.UI_CheckBox_RandomizerSet_Hinterlands.Size = new System.Drawing.Size(79, 17);
            this.UI_CheckBox_RandomizerSet_Hinterlands.TabIndex = 12;
            this.UI_CheckBox_RandomizerSet_Hinterlands.Text = "Hinterlands";
            this.UI_CheckBox_RandomizerSet_Hinterlands.UseVisualStyleBackColor = true;
            // 
            // UI_CheckBox_RandomizerSet_Prosperity
            // 
            this.UI_CheckBox_RandomizerSet_Prosperity.AutoSize = true;
            this.UI_CheckBox_RandomizerSet_Prosperity.Location = new System.Drawing.Point(78, 19);
            this.UI_CheckBox_RandomizerSet_Prosperity.Name = "UI_CheckBox_RandomizerSet_Prosperity";
            this.UI_CheckBox_RandomizerSet_Prosperity.Size = new System.Drawing.Size(72, 17);
            this.UI_CheckBox_RandomizerSet_Prosperity.TabIndex = 13;
            this.UI_CheckBox_RandomizerSet_Prosperity.Text = "Prosperity";
            this.UI_CheckBox_RandomizerSet_Prosperity.UseVisualStyleBackColor = true;
            // 
            // UI_CheckBox_RandomizerSet_Alchemy
            // 
            this.UI_CheckBox_RandomizerSet_Alchemy.AutoSize = true;
            this.UI_CheckBox_RandomizerSet_Alchemy.Location = new System.Drawing.Point(6, 111);
            this.UI_CheckBox_RandomizerSet_Alchemy.Name = "UI_CheckBox_RandomizerSet_Alchemy";
            this.UI_CheckBox_RandomizerSet_Alchemy.Size = new System.Drawing.Size(66, 17);
            this.UI_CheckBox_RandomizerSet_Alchemy.TabIndex = 14;
            this.UI_CheckBox_RandomizerSet_Alchemy.Text = "Alchemy";
            this.UI_CheckBox_RandomizerSet_Alchemy.UseVisualStyleBackColor = true;
            // 
            // UI_CheckBox_RandomizerSet_Seaside
            // 
            this.UI_CheckBox_RandomizerSet_Seaside.AutoSize = true;
            this.UI_CheckBox_RandomizerSet_Seaside.Location = new System.Drawing.Point(6, 88);
            this.UI_CheckBox_RandomizerSet_Seaside.Name = "UI_CheckBox_RandomizerSet_Seaside";
            this.UI_CheckBox_RandomizerSet_Seaside.Size = new System.Drawing.Size(64, 17);
            this.UI_CheckBox_RandomizerSet_Seaside.TabIndex = 15;
            this.UI_CheckBox_RandomizerSet_Seaside.Text = "Seaside";
            this.UI_CheckBox_RandomizerSet_Seaside.UseVisualStyleBackColor = true;
            // 
            // UI_CheckBox_RandomizerSet_Intrigue
            // 
            this.UI_CheckBox_RandomizerSet_Intrigue.AutoSize = true;
            this.UI_CheckBox_RandomizerSet_Intrigue.Location = new System.Drawing.Point(6, 65);
            this.UI_CheckBox_RandomizerSet_Intrigue.Name = "UI_CheckBox_RandomizerSet_Intrigue";
            this.UI_CheckBox_RandomizerSet_Intrigue.Size = new System.Drawing.Size(61, 17);
            this.UI_CheckBox_RandomizerSet_Intrigue.TabIndex = 16;
            this.UI_CheckBox_RandomizerSet_Intrigue.Text = "Intrigue";
            this.UI_CheckBox_RandomizerSet_Intrigue.UseVisualStyleBackColor = true;
            // 
            // UI_CheckBox_RandomizerSet_Base
            // 
            this.UI_CheckBox_RandomizerSet_Base.AutoSize = true;
            this.UI_CheckBox_RandomizerSet_Base.Location = new System.Drawing.Point(6, 42);
            this.UI_CheckBox_RandomizerSet_Base.Name = "UI_CheckBox_RandomizerSet_Base";
            this.UI_CheckBox_RandomizerSet_Base.Size = new System.Drawing.Size(50, 17);
            this.UI_CheckBox_RandomizerSet_Base.TabIndex = 17;
            this.UI_CheckBox_RandomizerSet_Base.Text = "Base";
            this.UI_CheckBox_RandomizerSet_Base.UseVisualStyleBackColor = true;
            // 
            // UI_CheckBox_RandomizerSet_DarkAges
            // 
            this.UI_CheckBox_RandomizerSet_DarkAges.AutoSize = true;
            this.UI_CheckBox_RandomizerSet_DarkAges.Location = new System.Drawing.Point(78, 88);
            this.UI_CheckBox_RandomizerSet_DarkAges.Name = "UI_CheckBox_RandomizerSet_DarkAges";
            this.UI_CheckBox_RandomizerSet_DarkAges.Size = new System.Drawing.Size(76, 17);
            this.UI_CheckBox_RandomizerSet_DarkAges.TabIndex = 18;
            this.UI_CheckBox_RandomizerSet_DarkAges.Text = "Dark Ages";
            this.UI_CheckBox_RandomizerSet_DarkAges.UseVisualStyleBackColor = true;
            // 
            // UI_CheckBox_RandomizerSet_Cornucopia
            // 
            this.UI_CheckBox_RandomizerSet_Cornucopia.AutoSize = true;
            this.UI_CheckBox_RandomizerSet_Cornucopia.Location = new System.Drawing.Point(78, 42);
            this.UI_CheckBox_RandomizerSet_Cornucopia.Name = "UI_CheckBox_RandomizerSet_Cornucopia";
            this.UI_CheckBox_RandomizerSet_Cornucopia.Size = new System.Drawing.Size(80, 17);
            this.UI_CheckBox_RandomizerSet_Cornucopia.TabIndex = 19;
            this.UI_CheckBox_RandomizerSet_Cornucopia.Text = "Cornucopia";
            this.UI_CheckBox_RandomizerSet_Cornucopia.UseVisualStyleBackColor = true;
            // 
            // DominionRandomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 492);
            this.Controls.Add(this.UI_Button_Randomize);
            this.Controls.Add(this.UI_GroupBox_RandomizerSets);
            this.Controls.Add(this.UI_Button_SearchByText);
            this.Controls.Add(this.UI_TextBox_SearchTextFilter);
            this.Controls.Add(this.UI_Button_SearchByFilter);
            this.Controls.Add(this.UI_ComboBox_FilterValue);
            this.Controls.Add(this.UI_GroupBox_Filter);
            this.Controls.Add(this.UI_Button_FullList);
            this.Controls.Add(this.UI_DGV_CardList);
            this.Name = "DominionRandomizer";
            this.Text = "Dominion Randomizer";
            this.Load += new System.EventHandler(this.DominionRandomizer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UI_DGV_CardList)).EndInit();
            this.UI_GroupBox_Filter.ResumeLayout(false);
            this.UI_GroupBox_Filter.PerformLayout();
            this.UI_GroupBox_RandomizerSets.ResumeLayout(false);
            this.UI_GroupBox_RandomizerSets.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UI_DGV_CardList;
        private System.Windows.Forms.Button UI_Button_FullList;
        private System.Windows.Forms.GroupBox UI_GroupBox_Filter;
        private System.Windows.Forms.RadioButton UI_RadioButton_FilterType_Set;
        private System.Windows.Forms.RadioButton UI_RadioButton_FilterType_Potion;
        private System.Windows.Forms.RadioButton UI_RadioButton_FilterType_Cost;
        private System.Windows.Forms.RadioButton UI_RadioButton_FilterType_Type;
        private System.Windows.Forms.ComboBox UI_ComboBox_FilterValue;
        private System.Windows.Forms.Button UI_Button_SearchByFilter;
        private System.Windows.Forms.TextBox UI_TextBox_SearchTextFilter;
        private System.Windows.Forms.Button UI_Button_SearchByText;
        private System.Windows.Forms.GroupBox UI_GroupBox_RandomizerSets;
        private System.Windows.Forms.Button UI_Button_Randomize;
        private System.Windows.Forms.CheckBox UI_CheckBox_RandomizerSet_Prosperity;
        private System.Windows.Forms.CheckBox UI_CheckBox_RandomizerSet_Alchemy;
        private System.Windows.Forms.CheckBox UI_CheckBox_RandomizerSet_Seaside;
        private System.Windows.Forms.CheckBox UI_CheckBox_RandomizerSet_Intrigue;
        private System.Windows.Forms.CheckBox UI_CheckBox_RandomizerSet_Base;
        private System.Windows.Forms.CheckBox UI_CheckBox_RandomizerSet_Promo;
        private System.Windows.Forms.CheckBox UI_CheckBox_RandomizerSet_Adventures;
        private System.Windows.Forms.CheckBox UI_CheckBox_RandomizerSet_Guilds;
        private System.Windows.Forms.CheckBox UI_CheckBox_RandomizerSet_Hinterlands;
        private System.Windows.Forms.CheckBox UI_CheckBox_RandomizerSet_DarkAges;
        private System.Windows.Forms.CheckBox UI_CheckBox_RandomizerSet_Cornucopia;
    }
}


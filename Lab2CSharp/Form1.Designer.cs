namespace Lab2CSharp
{
    partial class Form1
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
            this.TextBoxNameFactory = new System.Windows.Forms.TextBox();
            this.TextBoxAmountOfDepartments = new System.Windows.Forms.TextBox();
            this.TextBoxSalaryMaster = new System.Windows.Forms.TextBox();
            this.TextBoxSalaryWorker = new System.Windows.Forms.TextBox();
            this.TextBoxMoneyGivingMaster = new System.Windows.Forms.TextBox();
            this.TextBoxMoneyGivingWorker = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelAmountOfDepartments = new System.Windows.Forms.Label();
            this.LabelAmountOfMasters = new System.Windows.Forms.Label();
            this.LabelSalaryMaster = new System.Windows.Forms.Label();
            this.LabelSalaryWorker = new System.Windows.Forms.Label();
            this.LabelMoneyGivingMaster = new System.Windows.Forms.Label();
            this.TextBoxAmountOfMasters = new System.Windows.Forms.TextBox();
            this.LabelMoneyGivesWorker = new System.Windows.Forms.Label();
            this.AddFactoryBtn = new System.Windows.Forms.Button();
            this.ComboBoxCurrentSelectedFactory = new System.Windows.Forms.ComboBox();
            this.TextBoxAmountOfWorkersToChange = new System.Windows.Forms.TextBox();
            this.HireWorkerBtn = new System.Windows.Forms.Button();
            this.FireWorkerBtn = new System.Windows.Forms.Button();
            this.FireMasterBtn = new System.Windows.Forms.Button();
            this.HireMasterBtn = new System.Windows.Forms.Button();
            this.TextBoxAmountOfMastersToChange = new System.Windows.Forms.TextBox();
            this.LabelWorkerChange = new System.Windows.Forms.Label();
            this.LabelMasterChange = new System.Windows.Forms.Label();
            this.ComboBoxSecondaryFactory = new System.Windows.Forms.ComboBox();
            this.LabelCurrentSelected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CompareBtn = new System.Windows.Forms.Button();
            this.AddToSelectedBtn = new System.Windows.Forms.Button();
            this.CalculateRevenueBtn = new System.Windows.Forms.Button();
            this.TextBoxMoneyInput = new System.Windows.Forms.TextBox();
            this.LabelMoneyInput = new System.Windows.Forms.Label();
            this.ShowFullInfoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxNameFactory
            // 
            this.TextBoxNameFactory.Location = new System.Drawing.Point(51, 80);
            this.TextBoxNameFactory.Name = "TextBoxNameFactory";
            this.TextBoxNameFactory.Size = new System.Drawing.Size(125, 27);
            this.TextBoxNameFactory.TabIndex = 0;
            // 
            // TextBoxAmountOfDepartments
            // 
            this.TextBoxAmountOfDepartments.Location = new System.Drawing.Point(51, 113);
            this.TextBoxAmountOfDepartments.Name = "TextBoxAmountOfDepartments";
            this.TextBoxAmountOfDepartments.Size = new System.Drawing.Size(125, 27);
            this.TextBoxAmountOfDepartments.TabIndex = 1;
            // 
            // TextBoxSalaryMaster
            // 
            this.TextBoxSalaryMaster.Location = new System.Drawing.Point(51, 179);
            this.TextBoxSalaryMaster.Name = "TextBoxSalaryMaster";
            this.TextBoxSalaryMaster.Size = new System.Drawing.Size(125, 27);
            this.TextBoxSalaryMaster.TabIndex = 2;
            // 
            // TextBoxSalaryWorker
            // 
            this.TextBoxSalaryWorker.Location = new System.Drawing.Point(51, 212);
            this.TextBoxSalaryWorker.Name = "TextBoxSalaryWorker";
            this.TextBoxSalaryWorker.Size = new System.Drawing.Size(125, 27);
            this.TextBoxSalaryWorker.TabIndex = 3;
            // 
            // TextBoxMoneyGivingMaster
            // 
            this.TextBoxMoneyGivingMaster.Location = new System.Drawing.Point(51, 249);
            this.TextBoxMoneyGivingMaster.Name = "TextBoxMoneyGivingMaster";
            this.TextBoxMoneyGivingMaster.Size = new System.Drawing.Size(125, 27);
            this.TextBoxMoneyGivingMaster.TabIndex = 4;
            // 
            // TextBoxMoneyGivingWorker
            // 
            this.TextBoxMoneyGivingWorker.Location = new System.Drawing.Point(51, 287);
            this.TextBoxMoneyGivingWorker.Name = "TextBoxMoneyGivingWorker";
            this.TextBoxMoneyGivingWorker.Size = new System.Drawing.Size(125, 27);
            this.TextBoxMoneyGivingWorker.TabIndex = 5;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(228, 80);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(49, 20);
            this.LabelName.TabIndex = 6;
            this.LabelName.Text = "Name";
            // 
            // LabelAmountOfDepartments
            // 
            this.LabelAmountOfDepartments.AutoSize = true;
            this.LabelAmountOfDepartments.Location = new System.Drawing.Point(228, 113);
            this.LabelAmountOfDepartments.Name = "LabelAmountOfDepartments";
            this.LabelAmountOfDepartments.Size = new System.Drawing.Size(172, 20);
            this.LabelAmountOfDepartments.TabIndex = 7;
            this.LabelAmountOfDepartments.Text = "Amount Of Departments";
            // 
            // LabelAmountOfMasters
            // 
            this.LabelAmountOfMasters.AutoSize = true;
            this.LabelAmountOfMasters.Location = new System.Drawing.Point(228, 146);
            this.LabelAmountOfMasters.Name = "LabelAmountOfMasters";
            this.LabelAmountOfMasters.Size = new System.Drawing.Size(135, 20);
            this.LabelAmountOfMasters.TabIndex = 8;
            this.LabelAmountOfMasters.Text = "Amount of masters";
            // 
            // LabelSalaryMaster
            // 
            this.LabelSalaryMaster.AutoSize = true;
            this.LabelSalaryMaster.Location = new System.Drawing.Point(228, 179);
            this.LabelSalaryMaster.Name = "LabelSalaryMaster";
            this.LabelSalaryMaster.Size = new System.Drawing.Size(98, 20);
            this.LabelSalaryMaster.TabIndex = 9;
            this.LabelSalaryMaster.Text = "Salary Master";
            // 
            // LabelSalaryWorker
            // 
            this.LabelSalaryWorker.AutoSize = true;
            this.LabelSalaryWorker.Location = new System.Drawing.Point(228, 215);
            this.LabelSalaryWorker.Name = "LabelSalaryWorker";
            this.LabelSalaryWorker.Size = new System.Drawing.Size(100, 20);
            this.LabelSalaryWorker.TabIndex = 10;
            this.LabelSalaryWorker.Text = "Salary Worker";
            // 
            // LabelMoneyGivingMaster
            // 
            this.LabelMoneyGivingMaster.AutoSize = true;
            this.LabelMoneyGivingMaster.Location = new System.Drawing.Point(228, 252);
            this.LabelMoneyGivingMaster.Name = "LabelMoneyGivingMaster";
            this.LabelMoneyGivingMaster.Size = new System.Drawing.Size(216, 20);
            this.LabelMoneyGivingMaster.TabIndex = 11;
            this.LabelMoneyGivingMaster.Text = "Amount of money master gives";
            // 
            // TextBoxAmountOfMasters
            // 
            this.TextBoxAmountOfMasters.Location = new System.Drawing.Point(51, 146);
            this.TextBoxAmountOfMasters.Name = "TextBoxAmountOfMasters";
            this.TextBoxAmountOfMasters.Size = new System.Drawing.Size(125, 27);
            this.TextBoxAmountOfMasters.TabIndex = 12;
            // 
            // LabelMoneyGivesWorker
            // 
            this.LabelMoneyGivesWorker.AutoSize = true;
            this.LabelMoneyGivesWorker.Location = new System.Drawing.Point(228, 290);
            this.LabelMoneyGivesWorker.Name = "LabelMoneyGivesWorker";
            this.LabelMoneyGivesWorker.Size = new System.Drawing.Size(216, 20);
            this.LabelMoneyGivesWorker.TabIndex = 13;
            this.LabelMoneyGivesWorker.Text = "Amount of money worker gives";
            // 
            // AddFactoryBtn
            // 
            this.AddFactoryBtn.Location = new System.Drawing.Point(51, 331);
            this.AddFactoryBtn.Name = "AddFactoryBtn";
            this.AddFactoryBtn.Size = new System.Drawing.Size(94, 29);
            this.AddFactoryBtn.TabIndex = 14;
            this.AddFactoryBtn.Text = "Add Factory";
            this.AddFactoryBtn.UseVisualStyleBackColor = true;
            this.AddFactoryBtn.Click += new System.EventHandler(this.AddFactoryBtn_Click);
            // 
            // ComboBoxCurrentSelectedFactory
            // 
            this.ComboBoxCurrentSelectedFactory.FormattingEnabled = true;
            this.ComboBoxCurrentSelectedFactory.Location = new System.Drawing.Point(612, 56);
            this.ComboBoxCurrentSelectedFactory.Name = "ComboBoxCurrentSelectedFactory";
            this.ComboBoxCurrentSelectedFactory.Size = new System.Drawing.Size(151, 28);
            this.ComboBoxCurrentSelectedFactory.TabIndex = 15;
            // 
            // TextBoxAmountOfWorkersToChange
            // 
            this.TextBoxAmountOfWorkersToChange.Location = new System.Drawing.Point(521, 222);
            this.TextBoxAmountOfWorkersToChange.Name = "TextBoxAmountOfWorkersToChange";
            this.TextBoxAmountOfWorkersToChange.Size = new System.Drawing.Size(125, 27);
            this.TextBoxAmountOfWorkersToChange.TabIndex = 16;
            // 
            // HireWorkerBtn
            // 
            this.HireWorkerBtn.Location = new System.Drawing.Point(621, 265);
            this.HireWorkerBtn.Name = "HireWorkerBtn";
            this.HireWorkerBtn.Size = new System.Drawing.Size(94, 29);
            this.HireWorkerBtn.TabIndex = 17;
            this.HireWorkerBtn.Text = "Hire";
            this.HireWorkerBtn.UseVisualStyleBackColor = true;
            this.HireWorkerBtn.Click += new System.EventHandler(this.HireWorkerBtn_Click);
            // 
            // FireWorkerBtn
            // 
            this.FireWorkerBtn.Location = new System.Drawing.Point(521, 265);
            this.FireWorkerBtn.Name = "FireWorkerBtn";
            this.FireWorkerBtn.Size = new System.Drawing.Size(94, 29);
            this.FireWorkerBtn.TabIndex = 18;
            this.FireWorkerBtn.Text = "Fire";
            this.FireWorkerBtn.UseVisualStyleBackColor = true;
            this.FireWorkerBtn.Click += new System.EventHandler(this.FireWorkerBtn_Click);
            // 
            // FireMasterBtn
            // 
            this.FireMasterBtn.Location = new System.Drawing.Point(521, 374);
            this.FireMasterBtn.Name = "FireMasterBtn";
            this.FireMasterBtn.Size = new System.Drawing.Size(94, 29);
            this.FireMasterBtn.TabIndex = 21;
            this.FireMasterBtn.Text = "Fire";
            this.FireMasterBtn.UseVisualStyleBackColor = true;
            this.FireMasterBtn.Click += new System.EventHandler(this.FireMasterBtn_Click);
            // 
            // HireMasterBtn
            // 
            this.HireMasterBtn.Location = new System.Drawing.Point(621, 374);
            this.HireMasterBtn.Name = "HireMasterBtn";
            this.HireMasterBtn.Size = new System.Drawing.Size(94, 29);
            this.HireMasterBtn.TabIndex = 20;
            this.HireMasterBtn.Text = "Hire";
            this.HireMasterBtn.UseVisualStyleBackColor = true;
            this.HireMasterBtn.Click += new System.EventHandler(this.HireMasterBtn_Click);
            // 
            // TextBoxAmountOfMastersToChange
            // 
            this.TextBoxAmountOfMastersToChange.Location = new System.Drawing.Point(521, 331);
            this.TextBoxAmountOfMastersToChange.Name = "TextBoxAmountOfMastersToChange";
            this.TextBoxAmountOfMastersToChange.Size = new System.Drawing.Size(125, 27);
            this.TextBoxAmountOfMastersToChange.TabIndex = 19;
            // 
            // LabelWorkerChange
            // 
            this.LabelWorkerChange.AutoSize = true;
            this.LabelWorkerChange.Location = new System.Drawing.Point(666, 219);
            this.LabelWorkerChange.Name = "LabelWorkerChange";
            this.LabelWorkerChange.Size = new System.Drawing.Size(56, 20);
            this.LabelWorkerChange.TabIndex = 22;
            this.LabelWorkerChange.Text = "Worker";
            // 
            // LabelMasterChange
            // 
            this.LabelMasterChange.AutoSize = true;
            this.LabelMasterChange.Location = new System.Drawing.Point(666, 331);
            this.LabelMasterChange.Name = "LabelMasterChange";
            this.LabelMasterChange.Size = new System.Drawing.Size(54, 20);
            this.LabelMasterChange.TabIndex = 23;
            this.LabelMasterChange.Text = "Master";
            // 
            // ComboBoxSecondaryFactory
            // 
            this.ComboBoxSecondaryFactory.FormattingEnabled = true;
            this.ComboBoxSecondaryFactory.Location = new System.Drawing.Point(796, 219);
            this.ComboBoxSecondaryFactory.Name = "ComboBoxSecondaryFactory";
            this.ComboBoxSecondaryFactory.Size = new System.Drawing.Size(151, 28);
            this.ComboBoxSecondaryFactory.TabIndex = 24;
            // 
            // LabelCurrentSelected
            // 
            this.LabelCurrentSelected.AutoSize = true;
            this.LabelCurrentSelected.Location = new System.Drawing.Point(478, 64);
            this.LabelCurrentSelected.Name = "LabelCurrentSelected";
            this.LabelCurrentSelected.Size = new System.Drawing.Size(118, 20);
            this.LabelCurrentSelected.TabIndex = 25;
            this.LabelCurrentSelected.Text = "Current Selected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(796, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Current Selected (To compare or add)";
            // 
            // CompareBtn
            // 
            this.CompareBtn.Location = new System.Drawing.Point(796, 265);
            this.CompareBtn.Name = "CompareBtn";
            this.CompareBtn.Size = new System.Drawing.Size(94, 29);
            this.CompareBtn.TabIndex = 27;
            this.CompareBtn.Text = "Compare";
            this.CompareBtn.UseVisualStyleBackColor = true;
            this.CompareBtn.Click += new System.EventHandler(this.CompareBtn_Click);
            // 
            // AddToSelectedBtn
            // 
            this.AddToSelectedBtn.Location = new System.Drawing.Point(796, 322);
            this.AddToSelectedBtn.Name = "AddToSelectedBtn";
            this.AddToSelectedBtn.Size = new System.Drawing.Size(151, 29);
            this.AddToSelectedBtn.TabIndex = 28;
            this.AddToSelectedBtn.Text = "Add To Selected";
            this.AddToSelectedBtn.UseVisualStyleBackColor = true;
            this.AddToSelectedBtn.Click += new System.EventHandler(this.AddToSelectedBtn_Click);
            // 
            // CalculateRevenueBtn
            // 
            this.CalculateRevenueBtn.Location = new System.Drawing.Point(346, 403);
            this.CalculateRevenueBtn.Name = "CalculateRevenueBtn";
            this.CalculateRevenueBtn.Size = new System.Drawing.Size(152, 29);
            this.CalculateRevenueBtn.TabIndex = 29;
            this.CalculateRevenueBtn.Text = "Calculate Revenue";
            this.CalculateRevenueBtn.UseVisualStyleBackColor = true;
            this.CalculateRevenueBtn.Click += new System.EventHandler(this.CalculateRevenueBtn_Click);
            // 
            // TextBoxMoneyInput
            // 
            this.TextBoxMoneyInput.Location = new System.Drawing.Point(197, 405);
            this.TextBoxMoneyInput.Name = "TextBoxMoneyInput";
            this.TextBoxMoneyInput.Size = new System.Drawing.Size(125, 27);
            this.TextBoxMoneyInput.TabIndex = 30;
            // 
            // LabelMoneyInput
            // 
            this.LabelMoneyInput.AutoSize = true;
            this.LabelMoneyInput.Location = new System.Drawing.Point(12, 403);
            this.LabelMoneyInput.Name = "LabelMoneyInput";
            this.LabelMoneyInput.Size = new System.Drawing.Size(179, 20);
            this.LabelMoneyInput.TabIndex = 31;
            this.LabelMoneyInput.Text = "Money you ready to input";
            // 
            // ShowFullInfoBtn
            // 
            this.ShowFullInfoBtn.Location = new System.Drawing.Point(796, 55);
            this.ShowFullInfoBtn.Name = "ShowFullInfoBtn";
            this.ShowFullInfoBtn.Size = new System.Drawing.Size(94, 29);
            this.ShowFullInfoBtn.TabIndex = 32;
            this.ShowFullInfoBtn.Text = "Show Info";
            this.ShowFullInfoBtn.UseVisualStyleBackColor = true;
            this.ShowFullInfoBtn.Click += new System.EventHandler(this.ShowFullInfoBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 462);
            this.Controls.Add(this.ShowFullInfoBtn);
            this.Controls.Add(this.LabelMoneyInput);
            this.Controls.Add(this.TextBoxMoneyInput);
            this.Controls.Add(this.CalculateRevenueBtn);
            this.Controls.Add(this.AddToSelectedBtn);
            this.Controls.Add(this.CompareBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelCurrentSelected);
            this.Controls.Add(this.ComboBoxSecondaryFactory);
            this.Controls.Add(this.LabelMasterChange);
            this.Controls.Add(this.LabelWorkerChange);
            this.Controls.Add(this.FireMasterBtn);
            this.Controls.Add(this.HireMasterBtn);
            this.Controls.Add(this.TextBoxAmountOfMastersToChange);
            this.Controls.Add(this.FireWorkerBtn);
            this.Controls.Add(this.HireWorkerBtn);
            this.Controls.Add(this.TextBoxAmountOfWorkersToChange);
            this.Controls.Add(this.ComboBoxCurrentSelectedFactory);
            this.Controls.Add(this.AddFactoryBtn);
            this.Controls.Add(this.LabelMoneyGivesWorker);
            this.Controls.Add(this.TextBoxAmountOfMasters);
            this.Controls.Add(this.LabelMoneyGivingMaster);
            this.Controls.Add(this.LabelSalaryWorker);
            this.Controls.Add(this.LabelSalaryMaster);
            this.Controls.Add(this.LabelAmountOfMasters);
            this.Controls.Add(this.LabelAmountOfDepartments);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxMoneyGivingWorker);
            this.Controls.Add(this.TextBoxMoneyGivingMaster);
            this.Controls.Add(this.TextBoxSalaryWorker);
            this.Controls.Add(this.TextBoxSalaryMaster);
            this.Controls.Add(this.TextBoxAmountOfDepartments);
            this.Controls.Add(this.TextBoxNameFactory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxNameFactory;
        private TextBox TextBoxAmountOfDepartments;
        private TextBox TextBoxSalaryMaster;
        private TextBox TextBoxSalaryWorker;
        private TextBox TextBoxMoneyGivingMaster;
        private TextBox TextBoxMoneyGivingWorker;
        private Label LabelName;
        private Label LabelAmountOfDepartments;
        private Label LabelAmountOfMasters;
        private Label LabelSalaryMaster;
        private Label LabelSalaryWorker;
        private Label LabelMoneyGivingMaster;
        private TextBox TextBoxAmountOfMasters;
        private Label LabelMoneyGivesWorker;
        private Button AddFactoryBtn;
        private ComboBox ComboBoxCurrentSelectedFactory;
        private TextBox TextBoxAmountOfWorkersToChange;
        private Button HireWorkerBtn;
        private Button FireWorkerBtn;
        private Button FireMasterBtn;
        private Button HireMasterBtn;
        private TextBox TextBoxAmountOfMastersToChange;
        private Label LabelWorkerChange;
        private Label LabelMasterChange;
        private ComboBox ComboBoxSecondaryFactory;
        private Label LabelCurrentSelected;
        private Label label1;
        private Button CompareBtn;
        private Button AddToSelectedBtn;
        private Button CalculateRevenueBtn;
        private TextBox TextBoxMoneyInput;
        private Label LabelMoneyInput;
        private Button ShowFullInfoBtn;
    }
}
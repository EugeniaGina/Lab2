namespace Lab2CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Factory> _factories = new List<Factory>(5);
        private void AddFactoryBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxNameFactory.Text))
            {
                MessageBox.Show("Name was empty");
                return;
            }
            int[] amounts = new int[2];
            decimal[] moneyRelated = new decimal[4];
            TextBox[] textBoxes = { TextBoxAmountOfDepartments, TextBoxAmountOfMasters,  TextBoxMoneyGivingMaster, TextBoxMoneyGivingWorker, TextBoxSalaryMaster, TextBoxSalaryWorker };
            for (int i = 0, j = 0; i < textBoxes.Length; i++)
            {
                if (i <= 1) {
                   bool parsedAm =  int.TryParse(textBoxes[i].Text, out int parsedAmount);
                    if (!parsedAm)
                    {
                        MessageBox.Show("Incorrect input");
                        return;
                    }
                    amounts[i] = parsedAmount;
                    continue;
                }
                bool parsed = decimal.TryParse(textBoxes[i].Text, out decimal parsedMoneyRelated);
                if (!parsed)
                {
                    MessageBox.Show("Incorrect input");
                    return;
                }
                moneyRelated[j] = parsedMoneyRelated;
                j++;
            }
            _factories.Add(new Factory(TextBoxNameFactory.Text, amounts[0], amounts[1], moneyRelated[0], moneyRelated[1], moneyRelated[2], moneyRelated[3]));
            UpdateList();
            MessageBox.Show("Done!");
        }

        private void UpdateList()
        {
            ComboBoxCurrentSelectedFactory.Items.Clear();
            ComboBoxSecondaryFactory.Items.Clear();
            foreach (var factory in _factories)
            {
                ComboBoxCurrentSelectedFactory.Items.Add(factory);
                ComboBoxSecondaryFactory.Items.Add(factory);
            }
            ComboBoxCurrentSelectedFactory.Text = String.Empty;
            ComboBoxSecondaryFactory.Text = String.Empty;
        }
        public bool TryGetFactoryFromCheckBox(ComboBox comboBox, out Factory? factory)
        {
            factory = (Factory)comboBox.SelectedItem;
            if (factory == null)
            {
                return false;
            }
            return true;
        }

   
        private void FireWorkerBtn_Click(object sender, EventArgs e)
        {
            if(!TryGetFactoryFromCheckBox(ComboBoxCurrentSelectedFactory, out Factory? factory))
            {
                MessageBox.Show("Factory is not selected!");
                return;
            }
            if(!int.TryParse(TextBoxAmountOfWorkersToChange.Text, out int amount))
            {
                MessageBox.Show("Incorrect amount!");
                return;
            }
            try
            {
                factory.FireWorker(amount);
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FireMasterBtn_Click(object sender, EventArgs e)
        {
            if (!TryGetFactoryFromCheckBox(ComboBoxCurrentSelectedFactory, out Factory? factory))
            {
                MessageBox.Show("Factory is not selected!");
                return;
            }
            if (!int.TryParse(TextBoxAmountOfMastersToChange.Text, out int amount))
            {
                MessageBox.Show("Incorrect amount!");
                return;
            }
            try
            {
                factory.FireMaster(amount);
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HireWorkerBtn_Click(object sender, EventArgs e)
        {
            if (!TryGetFactoryFromCheckBox(ComboBoxCurrentSelectedFactory, out Factory? factory))
            {
                MessageBox.Show("Factory is not selected!");
                return;
            }
            if (!int.TryParse(TextBoxAmountOfWorkersToChange.Text, out int amount))
            {
                MessageBox.Show("Incorrect amount!");
                return;
            }
            factory.HireWorker(amount);
            MessageBox.Show("Done!");
        }

        private void HireMasterBtn_Click(object sender, EventArgs e)
        {
            if (!TryGetFactoryFromCheckBox(ComboBoxCurrentSelectedFactory, out Factory? factory))
            {
                MessageBox.Show("Factory is not selected!");
                return;
            }
            if (!int.TryParse(TextBoxAmountOfMastersToChange.Text, out int amount))
            {
                MessageBox.Show("Incorrect amount!");
                return;
            }
            factory.HireMaster(amount);
            MessageBox.Show("Done!");
        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
            if (!TryGetFactoryFromCheckBox(ComboBoxCurrentSelectedFactory, out Factory? factory))
            {
                MessageBox.Show("Factory is not selected!");
                return;
            }
            if (!TryGetFactoryFromCheckBox(ComboBoxSecondaryFactory, out Factory? factorySecondary))
            {
                MessageBox.Show("Factory is not selected!");
                return;
            }
            int res = factory.CompareTo(factorySecondary);
            if(res == 0)
            {
                MessageBox.Show("Factories are equal");
                return;
            }
            if(res == 1)
            {
                MessageBox.Show("First factory is larger");
                return;
            }
            MessageBox.Show("Second factory is larger");
        }

        private void AddToSelectedBtn_Click(object sender, EventArgs e)
        {
            if (!TryGetFactoryFromCheckBox(ComboBoxCurrentSelectedFactory, out Factory? factoryA))
            {
                MessageBox.Show("Factory is not selected!");
                return;
            }
            if (!TryGetFactoryFromCheckBox(ComboBoxSecondaryFactory, out Factory? factorySecondary))
            {
                MessageBox.Show("Factory is not selected!");
                return;
            }
            Factory factory = factoryA + factorySecondary;
            _factories.Add(factory);
            UpdateList();
            MessageBox.Show("Done!");
        }

        private void CalculateRevenueBtn_Click(object sender, EventArgs e)
        {
            if (!TryGetFactoryFromCheckBox(ComboBoxCurrentSelectedFactory, out Factory? factory))
            {
                MessageBox.Show("Factory is not selected!");
                return;
            }
            if(!decimal.TryParse(TextBoxMoneyInput.Text, out decimal moneyToInput))
            {
                MessageBox.Show("Incorrect Amount");
                return;
            }
            MessageBox.Show($"Money can get {factory.MoneyCanGet(moneyToInput)}");

        }

        private void ShowFullInfoBtn_Click(object sender, EventArgs e)
        {
            if (!TryGetFactoryFromCheckBox(ComboBoxCurrentSelectedFactory, out Factory? factory))
            {
                MessageBox.Show("Factory is not selected!");
                return;
            }
            MessageBox.Show(factory.GetFullInfo());
        }
    }

}
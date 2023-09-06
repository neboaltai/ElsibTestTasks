namespace TestTask
{
    public partial class AddDataForm : Form
    {
        private readonly MainForm _mainForm;

        public AddDataForm(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _mainForm.DataGridView.Rows.Add(codeTextBox.Text, materialTextBox.Text, costTextBox.Text);

            ClearTextBoxes();

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();

            Close();
        }

        private void ClearTextBoxes()
        {
            codeTextBox.Text = "";

            materialTextBox.Text = "";

            costTextBox.Text = "";
        }
    }
}

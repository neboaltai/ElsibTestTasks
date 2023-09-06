namespace TestTask
{
    public partial class MainForm : Form
    {
        private readonly Form _addDataForm;

        public DataGridView DataGridView
        {
            get
            {
                return dataGridView;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            _addDataForm = new AddDataForm(this);

            dataGridView.ColumnCount = 3;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _addDataForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridView.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    DataGridView.Rows.Remove(row);
                }
            }
        }
    }
}
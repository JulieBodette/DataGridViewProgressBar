
using Wisej.Web;

namespace DataGridViewProgressBar
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void Page1_Load(object sender, System.EventArgs e)
		{
			dataGridView1.RowCount = 2;
			dataGridView1.ColumnCount = 2;

			var progressBar = new ProgressBar();
			progressBar.Minimum = 0;
			progressBar.Maximum = 100;
			progressBar.Value = 50;
			dataGridView1.Rows[0].Cells[0].Control = progressBar;
		}

	}
}

using static ExamWeek4.Configuration.KetubahConfig;
using static ExamWeek4.Service.KetubahService;

namespace ExamWeek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateXmlIfNotExists();
        }

        private void onShowResBtn(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dayComboBox.Text) ||
                string.IsNullOrWhiteSpace(dayMonthComboBox.Text) ||
                string.IsNullOrWhiteSpace(monthComboBox.Text) ||
                string.IsNullOrWhiteSpace(yearComboBox.Text))
            {
                MessageBox.Show("נא הכנס כל הפרמטרים!");
                return;
            }
            MessageBox.Show(AddDate(dayComboBox.Text, dayMonthComboBox.Text, monthComboBox.Text, yearComboBox.Text));
            MessageBox.Show("תאריך הוכנס בהצלחה!");
        }
    }
}

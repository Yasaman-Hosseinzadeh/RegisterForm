using WinFormsAppRegister.Models;

namespace WinFormsAppRegister
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

            Person person = new Person();
            person.FirstName = FirstNameTextBox.Text;
            person.LastName = LastNametextBox.Text;
            person.CellPhone = CellphoneTextBox.Text;
            person.NationalCode = NationalcodetextBox.Text;


            if (string.IsNullOrEmpty(person.FirstName) || string.IsNullOrEmpty(person.LastName) || string.IsNullOrEmpty(person.CellPhone) || string.IsNullOrEmpty(person.NationalCode) || (!FemaleradioButton.Checked && !MaleradioButton.Checked))
            {
                MessageBox.Show("please enter your information ! ");
                return;
            }

            person.CellPhone = person.CellPhone.Replace('۰', '0').Replace('۱', '1').Replace('۲', '2').Replace('۳', '3').Replace('۴', '4').Replace('۵', '5')
                                 .Replace('۶', '6').Replace('۷', '7').Replace('۸', '8').Replace('۹', '9');

            if (person.CellPhone.Length < 11 || person.CellPhone.Length > 13 || (!person.CellPhone.StartsWith("09") && !person.CellPhone.StartsWith("989") && !person.CellPhone.StartsWith("+989")))
            {
                MessageBox.Show("please enter your cell number correctly ! ");
                return;
            }
            else
            {
                if (person.CellPhone.StartsWith("989"))
                {
                    person.CellPhone = "0" + person.CellPhone.Substring(2, 10);
                }
                else if (person.CellPhone.StartsWith("+989"))
                {
                    person.CellPhone = "0" + person.CellPhone.Substring(3, 10);
                }
            }

            long nationalCode = 0;
            if (person.NationalCode.Length != 10 || !long.TryParse(person.NationalCode, out nationalCode))
            {
                MessageBox.Show("please enter your national Code correctly ! ");
                return;
            }

            person.Gendar = FemaleradioButton.Checked ? "زن" : "مرد";

            people.Add(person);
            OutPutTextBox.Text += $"نام: {person.FirstName}، نام خانوادگی: {person.LastName}، شماره تلفن همراه: {person.CellPhone} ، کدملی: {person.NationalCode} ، جنسیت: {person.Gendar}{Environment.NewLine}";

        }

    }
}

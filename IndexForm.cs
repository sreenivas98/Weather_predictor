using System.Text.RegularExpressions;

namespace MiniProject_new
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            radioZipCode.Checked = false;
            radioCity.Checked = false;
            zipCode.Text = string.Empty;
            city.Text = string.Empty;
            zipCode.Enabled = false;
            city.Enabled = false;
            submit.Enabled = false;
        }

        private void radioZipCode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioZipCode.Checked)
            {
                city.Enabled = false;
                city.Text = string.Empty;
                zipCode.Enabled = true;
                cityWarn.Visible = false;
            }
            else
            {
                city.Enabled = true;
            }
        }

        private void radioCity_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCity.Checked)
            {
                zipCode.Enabled = false;
                zipCode.Text = string.Empty;
                city.Enabled = true;
                zipWarn.Visible = false;
            }
            else
            {
                zipCode.Enabled = true;
            }
        }


        private void zipCode_Leave(object sender, EventArgs e)
        {
            // Define a regular expression pattern for a US Zipcode
            string zipPattern = @"^\d{5}(?:[-\s]\d{4})?$";

            // Get the text from the text box
            string zipText = zipCode.Text;

            // Check if the text matches the regular expression pattern
            bool isValid = Regex.IsMatch(zipText, zipPattern);

            // Update the background color of the text box based on the validation result and display a warning message
            if (isValid)
            {
                zipCode.BackColor = Color.White;
                zipWarn.Visible = false;
                submit.Enabled = true;
            }
            else
            {
                zipWarn.Text = "Invalid Zipcode";
                zipWarn.ForeColor = Color.Red;
                zipWarn.Visible = true;
                zipCode.Text = string.Empty;
                submit.Enabled = false;
            }
        }

        private void city_Leave(object sender, EventArgs e)
        {
            // Define a regular expression pattern for a US City name
            string cityPattern = @"^[a-zA-Z ]*$";

            // Get the text from the text box
            string cityText = city.Text;

            // Check if the text matches the regular expression pattern
            bool isValid = Regex.IsMatch(cityText, cityPattern);

            // Update the background color of the text box based on the validation result and display a warning message
            if (isValid)
            {
                city.BackColor = Color.White;
                cityWarn.Visible = false;
                submit.Enabled = true;
            }
            else
            {
                cityWarn.Text = "Invalid City Name";
                cityWarn.ForeColor = Color.Red;
                cityWarn.Visible = true;
                city.Text = string.Empty;
                submit.Enabled = false;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string inputData = "";
            if (radioZipCode.Checked && !string.IsNullOrEmpty(zipCode.Text))
            {
                inputData = $"zipCode: {zipCode.Text}";
            }
            else if (radioCity.Checked && !string.IsNullOrEmpty(city.Text))
            {
                inputData = $"city: {city.Text.Replace(" ", "-")}";
            }
            else
            {
                inputData = "Some error";
            }
            WeatherApi apiObject = new WeatherApi();
            this.Hide();
            apiObject.getForecast(inputData);
        }
    }
}

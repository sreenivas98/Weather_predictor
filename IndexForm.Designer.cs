namespace MiniProject_new
{
    partial class IndexForm
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
            radioZipCode = new RadioButton();
            radioCity = new RadioButton();
            zipCode = new TextBox();
            city = new TextBox();
            Header = new Label();
            submit = new Button();
            Clear = new Button();
            zipWarn = new Label();
            cityWarn = new Label();
            SuspendLayout();
            // 
            // radioZipCode
            // 
            radioZipCode.AutoSize = true;
            radioZipCode.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioZipCode.Location = new Point(136, 140);
            radioZipCode.Name = "radioZipCode";
            radioZipCode.Size = new Size(107, 27);
            radioZipCode.TabIndex = 0;
            radioZipCode.TabStop = true;
            radioZipCode.Text = "Zip Code";
            radioZipCode.UseVisualStyleBackColor = true;
            radioZipCode.CheckedChanged += radioZipCode_CheckedChanged;
            // 
            // radioCity
            // 
            radioCity.AutoSize = true;
            radioCity.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioCity.Location = new Point(136, 198);
            radioCity.Name = "radioCity";
            radioCity.Size = new Size(67, 27);
            radioCity.TabIndex = 1;
            radioCity.TabStop = true;
            radioCity.Text = "City";
            radioCity.UseVisualStyleBackColor = true;
            radioCity.CheckedChanged += radioCity_CheckedChanged;
            // 
            // zipCode
            // 
            zipCode.Enabled = false;
            zipCode.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zipCode.Location = new Point(265, 137);
            zipCode.Name = "zipCode";
            zipCode.PlaceholderText = "Enter valid zip code";
            zipCode.Size = new Size(166, 30);
            zipCode.TabIndex = 2;
            zipCode.Leave += zipCode_Leave;
            // 
            // city
            // 
            city.Enabled = false;
            city.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            city.Location = new Point(265, 195);
            city.Name = "city";
            city.PlaceholderText = "Enter a valid city";
            city.Size = new Size(166, 30);
            city.TabIndex = 3;
            city.Leave += city_Leave;
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Header.Location = new Point(190, 57);
            Header.Name = "Header";
            Header.Size = new Size(192, 25);
            Header.TabIndex = 4;
            Header.Text = "Weather Forecast";
            // 
            // submit
            // 
            submit.Enabled = false;
            submit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submit.Location = new Point(163, 264);
            submit.Name = "submit";
            submit.Size = new Size(107, 29);
            submit.TabIndex = 5;
            submit.Text = "Generate";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // Clear
            // 
            Clear.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.Location = new Point(310, 264);
            Clear.Name = "Clear";
            Clear.Size = new Size(94, 29);
            Clear.TabIndex = 6;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // zipWarn
            // 
            zipWarn.AutoSize = true;
            zipWarn.Location = new Point(443, 141);
            zipWarn.Name = "zipWarn";
            zipWarn.Size = new Size(0, 20);
            zipWarn.TabIndex = 7;
            zipWarn.Visible = false;
            // 
            // cityWarn
            // 
            cityWarn.AutoSize = true;
            cityWarn.Location = new Point(446, 200);
            cityWarn.Name = "cityWarn";
            cityWarn.Size = new Size(0, 20);
            cityWarn.TabIndex = 8;
            cityWarn.Visible = false;
            // 
            // IndexForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 450);
            Controls.Add(cityWarn);
            Controls.Add(zipWarn);
            Controls.Add(Clear);
            Controls.Add(submit);
            Controls.Add(Header);
            Controls.Add(city);
            Controls.Add(zipCode);
            Controls.Add(radioCity);
            Controls.Add(radioZipCode);
            Name = "IndexForm";
            Text = "Weather Forecast Request Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioZipCode;
        private RadioButton radioCity;
        private TextBox zipCode;
        private TextBox city;
        private Label Header;
        private Button submit;
        private Button Clear;
        private Label zipWarn;
        private Label cityWarn;
    }
}
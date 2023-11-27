namespace MiniProject_new
{
    partial class ResponseForm
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
            temp = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // temp
            // 
            temp.AutoSize = true;
            temp.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            temp.Location = new Point(12, 9);
            temp.Name = "temp";
            temp.Size = new Size(48, 22);
            temp.TabIndex = 0;
            temp.Text = "temp";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(274, 393);
            button1.Name = "button1";
            button1.Size = new Size(204, 29);
            button1.TabIndex = 10;
            button1.Text = "Go Back To Index Form";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ResponseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(temp);
            Name = "ResponseForm";
            Text = "ResponseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label temp;
        private Button button1;
    }
}
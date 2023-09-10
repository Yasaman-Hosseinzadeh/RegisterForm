namespace WinFormsAppRegister
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
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            CellphoneLabel = new Label();
            NatinalcodeLabel = new Label();
            GenderLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNametextBox = new TextBox();
            CellphoneTextBox = new TextBox();
            NationalcodetextBox = new TextBox();
            FemaleradioButton = new RadioButton();
            MaleradioButton = new RadioButton();
            RegisterButton = new Button();
            OutPutMessageLabel = new Label();
            OutPutTextBox = new TextBox();
            SuspendLayout();
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(740, 24);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(21, 15);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "نام";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(692, 76);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(69, 15);
            LastNameLabel.TabIndex = 1;
            LastNameLabel.Text = "نام خانوادگی";
            // 
            // CellphoneLabel
            // 
            CellphoneLabel.AutoSize = true;
            CellphoneLabel.Location = new Point(668, 122);
            CellphoneLabel.Name = "CellphoneLabel";
            CellphoneLabel.Size = new Size(93, 15);
            CellphoneLabel.TabIndex = 2;
            CellphoneLabel.Text = "شماره تلفن همراه";
            // 
            // NatinalcodeLabel
            // 
            NatinalcodeLabel.AutoSize = true;
            NatinalcodeLabel.Location = new Point(718, 165);
            NatinalcodeLabel.Name = "NatinalcodeLabel";
            NatinalcodeLabel.Size = new Size(43, 15);
            NatinalcodeLabel.TabIndex = 3;
            NatinalcodeLabel.Text = "کد ملی";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(718, 215);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(43, 15);
            GenderLabel.TabIndex = 4;
            GenderLabel.Text = "جنسیت";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(455, 24);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(197, 23);
            FirstNameTextBox.TabIndex = 5;
            FirstNameTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // LastNametextBox
            // 
            LastNametextBox.Location = new Point(455, 68);
            LastNametextBox.Name = "LastNametextBox";
            LastNametextBox.Size = new Size(197, 23);
            LastNametextBox.TabIndex = 6;
            LastNametextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // CellphoneTextBox
            // 
            CellphoneTextBox.Location = new Point(455, 114);
            CellphoneTextBox.Name = "CellphoneTextBox";
            CellphoneTextBox.Size = new Size(197, 23);
            CellphoneTextBox.TabIndex = 7;
            CellphoneTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // NationalcodetextBox
            // 
            NationalcodetextBox.Location = new Point(455, 157);
            NationalcodetextBox.Name = "NationalcodetextBox";
            NationalcodetextBox.Size = new Size(197, 23);
            NationalcodetextBox.TabIndex = 8;
            NationalcodetextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // FemaleradioButton
            // 
            FemaleradioButton.AutoSize = true;
            FemaleradioButton.Location = new Point(614, 211);
            FemaleradioButton.Name = "FemaleradioButton";
            FemaleradioButton.Size = new Size(38, 19);
            FemaleradioButton.TabIndex = 9;
            FemaleradioButton.TabStop = true;
            FemaleradioButton.Text = "زن";
            FemaleradioButton.UseVisualStyleBackColor = true;
            // 
            // MaleradioButton
            // 
            MaleradioButton.AutoSize = true;
            MaleradioButton.Location = new Point(467, 211);
            MaleradioButton.Name = "MaleradioButton";
            MaleradioButton.Size = new Size(42, 19);
            MaleradioButton.TabIndex = 10;
            MaleradioButton.TabStop = true;
            MaleradioButton.Text = "مرد";
            MaleradioButton.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            RegisterButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterButton.Location = new Point(455, 264);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(306, 42);
            RegisterButton.TabIndex = 11;
            RegisterButton.Text = "ثبت نام";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // OutPutMessageLabel
            // 
            OutPutMessageLabel.AutoSize = true;
            OutPutMessageLabel.Location = new Point(699, 389);
            OutPutMessageLabel.Name = "OutPutMessageLabel";
            OutPutMessageLabel.Size = new Size(62, 15);
            OutPutMessageLabel.TabIndex = 12;
            OutPutMessageLabel.Text = "پیام خروجی";
            // 
            // OutPutTextBox
            // 
            OutPutTextBox.Location = new Point(29, 386);
            OutPutTextBox.Multiline = true;
            OutPutTextBox.Name = "OutPutTextBox";
            OutPutTextBox.ReadOnly = true;
            OutPutTextBox.Size = new Size(664, 215);
            OutPutTextBox.TabIndex = 13;
            OutPutTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 636);
            Controls.Add(OutPutTextBox);
            Controls.Add(OutPutMessageLabel);
            Controls.Add(RegisterButton);
            Controls.Add(MaleradioButton);
            Controls.Add(FemaleradioButton);
            Controls.Add(NationalcodetextBox);
            Controls.Add(CellphoneTextBox);
            Controls.Add(LastNametextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(GenderLabel);
            Controls.Add(NatinalcodeLabel);
            Controls.Add(CellphoneLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label CellphoneLabel;
        private Label NatinalcodeLabel;
        private Label GenderLabel;
        private TextBox FirstNameTextBox;
        private TextBox LastNametextBox;
        private TextBox CellphoneTextBox;
        private TextBox NationalcodetextBox;
        private RadioButton FemaleradioButton;
        private RadioButton MaleradioButton;
        private Button RegisterButton;
        private Label OutPutMessageLabel;
        private TextBox OutPutTextBox;
    }
}
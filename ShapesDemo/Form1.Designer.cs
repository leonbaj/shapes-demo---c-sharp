namespace ShapesDemo
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
            this.ChooseBox = new System.Windows.Forms.ComboBox();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.EraseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.Instructions2Label = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ShapeTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseBox
            // 
            this.ChooseBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseBox.FormattingEnabled = true;
            this.ChooseBox.Items.AddRange(new object[] {
            "Rectangle",
            "Square",
            "Triangle"});
            this.ChooseBox.Location = new System.Drawing.Point(132, 132);
            this.ChooseBox.Name = "ChooseBox";
            this.ChooseBox.Size = new System.Drawing.Size(121, 29);
            this.ChooseBox.TabIndex = 0;
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstructionsLabel.Location = new System.Drawing.Point(12, 9);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(372, 27);
            this.InstructionsLabel.TabIndex = 1;
            this.InstructionsLabel.Text = "Provide dimensions for the shape and";
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(132, 169);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(121, 51);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // EraseButton
            // 
            this.EraseButton.Location = new System.Drawing.Point(623, 132);
            this.EraseButton.Name = "EraseButton";
            this.EraseButton.Size = new System.Drawing.Size(121, 51);
            this.EraseButton.TabIndex = 3;
            this.EraseButton.Text = "Erase";
            this.EraseButton.UseVisualStyleBackColor = true;
            this.EraseButton.Click += new System.EventHandler(this.EraseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(475, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click Erase to enter new shape";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(34, 83);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 23);
            this.HeightTextBox.TabIndex = 6;
            this.HeightTextBox.Text = "Height";
            // 
            // Instructions2Label
            // 
            this.Instructions2Label.AutoSize = true;
            this.Instructions2Label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Instructions2Label.Location = new System.Drawing.Point(12, 36);
            this.Instructions2Label.Name = "Instructions2Label";
            this.Instructions2Label.Size = new System.Drawing.Size(542, 27);
            this.Instructions2Label.TabIndex = 7;
            this.Instructions2Label.Text = "select a Shape to view Below! Click button to contiue! ";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(153, 83);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 23);
            this.WidthTextBox.TabIndex = 8;
            this.WidthTextBox.Text = "Width";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(256, 253);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 23);
            this.ErrorLabel.TabIndex = 9;
            // 
            // ShapeTextLabel
            // 
            this.ShapeTextLabel.AutoSize = true;
            this.ShapeTextLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShapeTextLabel.Location = new System.Drawing.Point(34, 280);
            this.ShapeTextLabel.Name = "ShapeTextLabel";
            this.ShapeTextLabel.Size = new System.Drawing.Size(0, 23);
            this.ShapeTextLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShapeTextLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.Instructions2Label);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EraseButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.ChooseBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ChooseBox;
        private Label InstructionsLabel;
        private Button EnterButton;
        private Button EraseButton;
        private Label label1;
        private TextBox HeightTextBox;
        private Label Instructions2Label;
        private TextBox WidthTextBox;
        private Label ErrorLabel;
        private Label ShapeTextLabel;
    }
}
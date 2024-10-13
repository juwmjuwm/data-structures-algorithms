namespace algorithms
{
    partial class MainForm
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
            dataInput = new TextBox();
            dataInputLabel = new Label();
            submitDataBtn = new Button();
            inputDisplayLabel = new Label();
            inputDisplay = new Label();
            outputDisplayLabel = new Label();
            outputDisplay = new Label();
            SuspendLayout();
            // 
            // dataInput
            // 
            dataInput.Anchor = AnchorStyles.Top;
            dataInput.Location = new Point(147, 51);
            dataInput.Margin = new Padding(4);
            dataInput.Name = "dataInput";
            dataInput.Size = new Size(300, 29);
            dataInput.TabIndex = 0;
            // 
            // dataInputLabel
            // 
            dataInputLabel.Anchor = AnchorStyles.Top;
            dataInputLabel.AutoSize = true;
            dataInputLabel.Location = new Point(168, 18);
            dataInputLabel.Margin = new Padding(4, 0, 4, 8);
            dataInputLabel.Name = "dataInputLabel";
            dataInputLabel.Size = new Size(258, 21);
            dataInputLabel.TabIndex = 1;
            dataInputLabel.Text = "Enter numbers separated by spaces:";
            // 
            // submitDataBtn
            // 
            submitDataBtn.Anchor = AnchorStyles.Top;
            submitDataBtn.Location = new Point(235, 94);
            submitDataBtn.Margin = new Padding(3, 10, 3, 3);
            submitDataBtn.Name = "submitDataBtn";
            submitDataBtn.Size = new Size(124, 38);
            submitDataBtn.TabIndex = 2;
            submitDataBtn.Text = "Submit data";
            submitDataBtn.UseVisualStyleBackColor = true;
            submitDataBtn.Click += SubmitDataBtn_Click;
            // 
            // inputDisplayLabel
            // 
            inputDisplayLabel.AutoSize = true;
            inputDisplayLabel.Location = new Point(12, 158);
            inputDisplayLabel.Margin = new Padding(10, 0, 3, 0);
            inputDisplayLabel.Name = "inputDisplayLabel";
            inputDisplayLabel.Size = new Size(49, 21);
            inputDisplayLabel.TabIndex = 3;
            inputDisplayLabel.Text = "Input:";
            // 
            // inputDisplay
            // 
            inputDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputDisplay.BackColor = Color.Gainsboro;
            inputDisplay.Location = new Point(12, 193);
            inputDisplay.Name = "inputDisplay";
            inputDisplay.Size = new Size(571, 32);
            inputDisplay.TabIndex = 4;
            inputDisplay.Text = "...";
            inputDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // outputDisplayLabel
            // 
            outputDisplayLabel.AutoSize = true;
            outputDisplayLabel.Location = new Point(12, 246);
            outputDisplayLabel.Name = "outputDisplayLabel";
            outputDisplayLabel.Size = new Size(62, 21);
            outputDisplayLabel.TabIndex = 5;
            outputDisplayLabel.Text = "Output:";
            // 
            // outputDisplay
            // 
            outputDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            outputDisplay.BackColor = Color.Gainsboro;
            outputDisplay.Location = new Point(12, 280);
            outputDisplay.Name = "outputDisplay";
            outputDisplay.Size = new Size(571, 32);
            outputDisplay.TabIndex = 6;
            outputDisplay.Text = "...";
            outputDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 486);
            Controls.Add(outputDisplay);
            Controls.Add(outputDisplayLabel);
            Controls.Add(inputDisplay);
            Controls.Add(inputDisplayLabel);
            Controls.Add(submitDataBtn);
            Controls.Add(dataInputLabel);
            Controls.Add(dataInput);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(450, 450);
            Name = "MainForm";
            Text = "Algorithms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dataInput;
        private Label dataInputLabel;
        private Button submitDataBtn;
        private Label inputDisplayLabel;
        private Label inputDisplay;
        private Label outputDisplayLabel;
        private Label outputDisplay;
    }
}

using dsa;

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
            AlgComboItem algComboItem1 = new AlgComboItem();
            AlgComboItem algComboItem2 = new AlgComboItem();
            AlgComboItem algComboItem3 = new AlgComboItem();
            AlgComboItem algComboItem4 = new AlgComboItem();
            AlgComboItem algComboItem5 = new AlgComboItem();
            dataInput = new TextBox();
            dataInputLabel = new Label();
            submitDataBtn = new Button();
            inputDisplayLabel = new Label();
            inputDisplay = new Label();
            outputDisplayLabel = new Label();
            outputDisplay = new Label();
            splitContainer1 = new SplitContainer();
            generatorBtn = new Button();
            generatorLabel = new Label();
            generatorLengthPicker = new NumericUpDown();
            applyBtn = new Button();
            timeLabel = new Label();
            runningTime = new Label();
            algorithmComboBox = new ComboBox();
            statusLabel = new Label();
            statusInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)generatorLengthPicker).BeginInit();
            SuspendLayout();
            // 
            // dataInput
            // 
            dataInput.Anchor = AnchorStyles.Top;
            dataInput.Location = new Point(4, 51);
            dataInput.Margin = new Padding(4);
            dataInput.Name = "dataInput";
            dataInput.Size = new Size(425, 29);
            dataInput.TabIndex = 0;
            // 
            // dataInputLabel
            // 
            dataInputLabel.Anchor = AnchorStyles.Top;
            dataInputLabel.AutoSize = true;
            dataInputLabel.Location = new Point(146, 11);
            dataInputLabel.Margin = new Padding(4, 0, 4, 8);
            dataInputLabel.Name = "dataInputLabel";
            dataInputLabel.Size = new Size(115, 21);
            dataInputLabel.TabIndex = 1;
            dataInputLabel.Text = "Enter numbers:";
            // 
            // submitDataBtn
            // 
            submitDataBtn.Anchor = AnchorStyles.Top;
            submitDataBtn.Location = new Point(159, 124);
            submitDataBtn.Margin = new Padding(3, 10, 3, 3);
            submitDataBtn.Name = "submitDataBtn";
            submitDataBtn.Size = new Size(129, 41);
            submitDataBtn.TabIndex = 2;
            submitDataBtn.Text = "Submit data";
            submitDataBtn.UseVisualStyleBackColor = true;
            submitDataBtn.Click += SubmitDataBtn_Click;
            // 
            // inputDisplayLabel
            // 
            inputDisplayLabel.AutoSize = true;
            inputDisplayLabel.Location = new Point(12, 238);
            inputDisplayLabel.Margin = new Padding(10, 0, 3, 0);
            inputDisplayLabel.Name = "inputDisplayLabel";
            inputDisplayLabel.Size = new Size(138, 21);
            inputDisplayLabel.TabIndex = 3;
            inputDisplayLabel.Text = "Input (the first 15):";
            // 
            // inputDisplay
            // 
            inputDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inputDisplay.BackColor = Color.Gainsboro;
            inputDisplay.Location = new Point(12, 273);
            inputDisplay.Name = "inputDisplay";
            inputDisplay.Size = new Size(661, 32);
            inputDisplay.TabIndex = 4;
            inputDisplay.Text = "...";
            inputDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // outputDisplayLabel
            // 
            outputDisplayLabel.AutoSize = true;
            outputDisplayLabel.Location = new Point(12, 374);
            outputDisplayLabel.Name = "outputDisplayLabel";
            outputDisplayLabel.Size = new Size(151, 21);
            outputDisplayLabel.TabIndex = 5;
            outputDisplayLabel.Text = "Output (the first 15):";
            // 
            // outputDisplay
            // 
            outputDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            outputDisplay.BackColor = Color.Gainsboro;
            outputDisplay.Location = new Point(12, 408);
            outputDisplay.Name = "outputDisplay";
            outputDisplay.Size = new Size(661, 32);
            outputDisplay.TabIndex = 6;
            outputDisplay.Text = "...";
            outputDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataInputLabel);
            splitContainer1.Panel1.Controls.Add(submitDataBtn);
            splitContainer1.Panel1.Controls.Add(dataInput);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(generatorBtn);
            splitContainer1.Panel2.Controls.Add(generatorLabel);
            splitContainer1.Panel2.Controls.Add(generatorLengthPicker);
            splitContainer1.Size = new Size(661, 201);
            splitContainer1.SplitterDistance = 433;
            splitContainer1.TabIndex = 7;
            // 
            // generatorBtn
            // 
            generatorBtn.Location = new Point(57, 124);
            generatorBtn.Name = "generatorBtn";
            generatorBtn.Size = new Size(109, 41);
            generatorBtn.TabIndex = 2;
            generatorBtn.Text = "Generate";
            generatorBtn.UseVisualStyleBackColor = true;
            generatorBtn.Click += generatorBtn_Click;
            // 
            // generatorLabel
            // 
            generatorLabel.AutoSize = true;
            generatorLabel.Location = new Point(30, 11);
            generatorLabel.Name = "generatorLabel";
            generatorLabel.Size = new Size(132, 21);
            generatorLabel.TabIndex = 1;
            generatorLabel.Text = "Generate random";
            // 
            // generatorLengthPicker
            // 
            generatorLengthPicker.Location = new Point(30, 52);
            generatorLengthPicker.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            generatorLengthPicker.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            generatorLengthPicker.Name = "generatorLengthPicker";
            generatorLengthPicker.Size = new Size(150, 29);
            generatorLengthPicker.TabIndex = 0;
            generatorLengthPicker.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // applyBtn
            // 
            applyBtn.Location = new Point(296, 330);
            applyBtn.Name = "applyBtn";
            applyBtn.Size = new Size(94, 42);
            applyBtn.TabIndex = 8;
            applyBtn.Text = "Apply";
            applyBtn.UseVisualStyleBackColor = true;
            applyBtn.Click += applyBtn_Click;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(407, 478);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(107, 21);
            timeLabel.TabIndex = 9;
            timeLabel.Text = "Running time:";
            // 
            // runningTime
            // 
            runningTime.AutoSize = true;
            runningTime.Location = new Point(407, 508);
            runningTime.MinimumSize = new Size(100, 0);
            runningTime.Name = "runningTime";
            runningTime.Size = new Size(100, 21);
            runningTime.TabIndex = 10;
            runningTime.Text = "...";
            // 
            // algorithmComboBox
            // 
            algorithmComboBox.DisplayMember = "Text";
            algorithmComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            algorithmComboBox.FormattingEnabled = true;
            algComboItem1.Id = 1;
            algComboItem1.Text = "Bubble sort";
            algComboItem2.Id = 2;
            algComboItem2.Text = "Insertion sort";
            algComboItem3.Id = 3;
            algComboItem3.Text = "Selection sort";
            algComboItem4.Id = 4;
            algComboItem4.Text = "Mergesort";
            algComboItem5.Id = 5;
            algComboItem5.Text = "Quicksort";
            algorithmComboBox.Items.AddRange(new object[] { algComboItem1, algComboItem2, algComboItem3, algComboItem4, algComboItem5 });
            algorithmComboBox.Location = new Point(70, 330);
            algorithmComboBox.Name = "algorithmComboBox";
            algorithmComboBox.Size = new Size(151, 29);
            algorithmComboBox.TabIndex = 11;
            algorithmComboBox.ValueMember = "Id";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(42, 478);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(55, 21);
            statusLabel.TabIndex = 12;
            statusLabel.Text = "Status:";
            // 
            // statusInfo
            // 
            statusInfo.AutoSize = true;
            statusInfo.Location = new Point(42, 508);
            statusInfo.MinimumSize = new Size(100, 0);
            statusInfo.Name = "statusInfo";
            statusInfo.Size = new Size(100, 21);
            statusInfo.TabIndex = 13;
            statusInfo.Text = "...";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 561);
            Controls.Add(statusInfo);
            Controls.Add(statusLabel);
            Controls.Add(algorithmComboBox);
            Controls.Add(runningTime);
            Controls.Add(timeLabel);
            Controls.Add(applyBtn);
            Controls.Add(splitContainer1);
            Controls.Add(outputDisplay);
            Controls.Add(outputDisplayLabel);
            Controls.Add(inputDisplay);
            Controls.Add(inputDisplayLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MinimumSize = new Size(700, 600);
            Name = "MainForm";
            Text = "Algorithms";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)generatorLengthPicker).EndInit();
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
        private SplitContainer splitContainer1;
        private Label generatorLabel;
        private NumericUpDown generatorLengthPicker;
        private Button generatorBtn;
        private Button applyBtn;
        private Label timeLabel;
        private Label runningTime;
        private ComboBox algorithmComboBox;
        private Label statusLabel;
        private Label statusInfo;
    }
}

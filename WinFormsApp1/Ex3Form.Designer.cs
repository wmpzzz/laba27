namespace laba
{
    partial class Ex3Form
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
            DepatureCityLabel = new Label();
            DepatureDataLabel = new Label();
            ArrivalCityLabel = new Label();
            ArrivalDateLabel = new Label();
            DepatureCityTextBox = new TextBox();
            ArrivalCityTextBox = new TextBox();
            DepatureDateTimePicker = new DateTimePicker();
            ArrivalDateTimePicker2 = new DateTimePicker();
            NeedReturnTicketCheckBox = new CheckBox();
            OrderButton = new Button();
            SuspendLayout();
            // 
            // DepatureCityLabel
            // 
            DepatureCityLabel.AutoSize = true;
            DepatureCityLabel.Location = new Point(31, 30);
            DepatureCityLabel.Name = "DepatureCityLabel";
            DepatureCityLabel.Size = new Size(134, 15);
            DepatureCityLabel.TabIndex = 0;
            DepatureCityLabel.Text = "Введите город отбытия";
            // 
            // DepatureDataLabel
            // 
            DepatureDataLabel.AutoSize = true;
            DepatureDataLabel.Location = new Point(31, 72);
            DepatureDataLabel.Name = "DepatureDataLabel";
            DepatureDataLabel.Size = new Size(125, 15);
            DepatureDataLabel.TabIndex = 1;
            DepatureDataLabel.Text = "Введите дату отбытия";
            // 
            // ArrivalCityLabel
            // 
            ArrivalCityLabel.AutoSize = true;
            ArrivalCityLabel.Location = new Point(31, 116);
            ArrivalCityLabel.Name = "ArrivalCityLabel";
            ArrivalCityLabel.Size = new Size(143, 15);
            ArrivalCityLabel.TabIndex = 2;
            ArrivalCityLabel.Text = "Введите город прибытия";
            // 
            // ArrivalDateLabel
            // 
            ArrivalDateLabel.AutoSize = true;
            ArrivalDateLabel.Location = new Point(31, 159);
            ArrivalDateLabel.Name = "ArrivalDateLabel";
            ArrivalDateLabel.Size = new Size(153, 15);
            ArrivalDateLabel.TabIndex = 3;
            ArrivalDateLabel.Text = "Введите дату возвращения";
            // 
            // DepatureCityTextBox
            // 
            DepatureCityTextBox.Location = new Point(194, 27);
            DepatureCityTextBox.Name = "DepatureCityTextBox";
            DepatureCityTextBox.Size = new Size(362, 23);
            DepatureCityTextBox.TabIndex = 4;
            // 
            // ArrivalCityTextBox
            // 
            ArrivalCityTextBox.Location = new Point(194, 113);
            ArrivalCityTextBox.Name = "ArrivalCityTextBox";
            ArrivalCityTextBox.Size = new Size(362, 23);
            ArrivalCityTextBox.TabIndex = 5;
            // 
            // DepatureDateTimePicker
            // 
            DepatureDateTimePicker.Location = new Point(194, 64);
            DepatureDateTimePicker.MinDate = new DateTime(2024, 11, 19, 0, 0, 0, 0);
            DepatureDateTimePicker.Name = "DepatureDateTimePicker";
            DepatureDateTimePicker.Size = new Size(362, 23);
            DepatureDateTimePicker.TabIndex = 6;
            // 
            // ArrivalDateTimePicker2
            // 
            ArrivalDateTimePicker2.Location = new Point(194, 153);
            ArrivalDateTimePicker2.MinDate = new DateTime(2024, 11, 19, 0, 0, 0, 0);
            ArrivalDateTimePicker2.Name = "ArrivalDateTimePicker2";
            ArrivalDateTimePicker2.Size = new Size(362, 23);
            ArrivalDateTimePicker2.TabIndex = 7;
            // 
            // NeedReturnTicketCheckBox
            // 
            NeedReturnTicketCheckBox.AutoSize = true;
            NeedReturnTicketCheckBox.Location = new Point(194, 182);
            NeedReturnTicketCheckBox.Name = "NeedReturnTicketCheckBox";
            NeedReturnTicketCheckBox.Size = new Size(156, 19);
            NeedReturnTicketCheckBox.TabIndex = 8;
            NeedReturnTicketCheckBox.Text = "Нужен обратный билет";
            NeedReturnTicketCheckBox.UseVisualStyleBackColor = true;
            // 
            // OrderButton
            // 
            OrderButton.Location = new Point(169, 227);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(250, 36);
            OrderButton.TabIndex = 9;
            OrderButton.Text = "Заказать";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += button1_Click;
            // 
            // Ex3Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 292);
            Controls.Add(OrderButton);
            Controls.Add(NeedReturnTicketCheckBox);
            Controls.Add(ArrivalDateTimePicker2);
            Controls.Add(DepatureDateTimePicker);
            Controls.Add(ArrivalCityTextBox);
            Controls.Add(DepatureCityTextBox);
            Controls.Add(ArrivalDateLabel);
            Controls.Add(ArrivalCityLabel);
            Controls.Add(DepatureDataLabel);
            Controls.Add(DepatureCityLabel);
            Name = "Ex3Form";
            Text = "Задание 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DepatureCityLabel;
        private Label DepatureDataLabel;
        private Label ArrivalCityLabel;
        private Label ArrivalDateLabel;
        private TextBox DepatureCityTextBox;
        private TextBox ArrivalCityTextBox;
        private DateTimePicker DepatureDateTimePicker;
        private DateTimePicker ArrivalDateTimePicker2;
        private CheckBox NeedReturnTicketCheckBox;
        private Button OrderButton;
    }
}
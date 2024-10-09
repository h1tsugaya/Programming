namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelName = new Label();
            labelIndex = new Label();
            labelCountry = new Label();
            labelCity = new Label();
            textBoxIndex = new TextBox();
            labelStreet = new Label();
            labelBuilding = new Label();
            labelApartment = new Label();
            textBoxCountry = new TextBox();
            textBoxCity = new TextBox();
            textBoxStreet = new TextBox();
            textBoxBuilding = new TextBox();
            textBoxApartment = new TextBox();
            toolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelName.Location = new Point(3, 10);
            labelName.Name = "labelName";
            labelName.Size = new Size(101, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Delivery Address";
            // 
            // labelIndex
            // 
            labelIndex.AutoSize = true;
            labelIndex.Location = new Point(3, 36);
            labelIndex.Name = "labelIndex";
            labelIndex.Size = new Size(65, 15);
            labelIndex.TabIndex = 1;
            labelIndex.Text = "Post Index:";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(3, 67);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(53, 15);
            labelCountry.TabIndex = 2;
            labelCountry.Text = "Country:";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(281, 67);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(31, 15);
            labelCity.TabIndex = 3;
            labelCity.Text = "City:";
            // 
            // textBoxIndex
            // 
            textBoxIndex.Location = new Point(74, 33);
            textBoxIndex.Name = "textBoxIndex";
            textBoxIndex.Size = new Size(117, 23);
            textBoxIndex.TabIndex = 4;
            // 
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Location = new Point(3, 99);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(40, 15);
            labelStreet.TabIndex = 5;
            labelStreet.Text = "Street:";
            // 
            // labelBuilding
            // 
            labelBuilding.AutoSize = true;
            labelBuilding.Location = new Point(5, 132);
            labelBuilding.Name = "labelBuilding";
            labelBuilding.Size = new Size(54, 15);
            labelBuilding.TabIndex = 6;
            labelBuilding.Text = "Building:";
            // 
            // labelApartment
            // 
            labelApartment.AutoSize = true;
            labelApartment.Location = new Point(170, 132);
            labelApartment.Name = "labelApartment";
            labelApartment.Size = new Size(67, 15);
            labelApartment.TabIndex = 7;
            labelApartment.Text = "Apartment:";
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(74, 64);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(201, 23);
            textBoxCountry.TabIndex = 8;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(318, 64);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(229, 23);
            textBoxCity.TabIndex = 9;
            // 
            // textBoxStreet
            // 
            textBoxStreet.Location = new Point(74, 96);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(473, 23);
            textBoxStreet.TabIndex = 10;
            // 
            // textBoxBuilding
            // 
            textBoxBuilding.Location = new Point(74, 129);
            textBoxBuilding.Name = "textBoxBuilding";
            textBoxBuilding.Size = new Size(90, 23);
            textBoxBuilding.TabIndex = 11;
            // 
            // textBoxApartment
            // 
            textBoxApartment.Location = new Point(243, 129);
            textBoxApartment.Name = "textBoxApartment";
            textBoxApartment.Size = new Size(89, 23);
            textBoxApartment.TabIndex = 12;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxApartment);
            Controls.Add(textBoxBuilding);
            Controls.Add(textBoxStreet);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxCountry);
            Controls.Add(labelApartment);
            Controls.Add(labelBuilding);
            Controls.Add(labelStreet);
            Controls.Add(textBoxIndex);
            Controls.Add(labelCity);
            Controls.Add(labelCountry);
            Controls.Add(labelIndex);
            Controls.Add(labelName);
            Name = "AddressControl";
            Size = new Size(550, 158);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelIndex;
        private Label labelCountry;
        private Label labelCity;
        private TextBox textBoxIndex;
        private Label labelStreet;
        private Label labelBuilding;
        private Label labelApartment;
        private TextBox textBoxCountry;
        private TextBox textBoxCity;
        private TextBox textBoxStreet;
        private TextBox textBoxBuilding;
        private TextBox textBoxApartment;
        private ToolTip toolTip;
    }
}

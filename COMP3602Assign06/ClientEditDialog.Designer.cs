namespace COMP3602Assign06
{
    partial class ClientEditDialog
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
            components = new System.ComponentModel.Container();
            textBoxNotes = new TextBox();
            textBoxYTDSales = new TextBox();
            textBoxProvince = new TextBox();
            textBoxCity = new TextBox();
            textBoxAddress2 = new TextBox();
            textBoxAddress1 = new TextBox();
            textBoxCompanyName = new TextBox();
            textBoxClientCode = new TextBox();
            checkBoxCreditHold = new CheckBox();
            labelNotes = new Label();
            labelYTDSales = new Label();
            labelPostalCode = new Label();
            labelCity = new Label();
            labelAddress2 = new Label();
            labelProvince = new Label();
            labelAddress1 = new Label();
            labelCompanyName = new Label();
            labelClientCode = new Label();
            buttonOk = new Button();
            buttonCancel = new Button();
            errorProvider = new ErrorProvider(components);
            maskedTextBoxPostalCode = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(138, 288);
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(235, 23);
            textBoxNotes.TabIndex = 42;
            // 
            // textBoxYTDSales
            // 
            textBoxYTDSales.Location = new Point(138, 255);
            textBoxYTDSales.Name = "textBoxYTDSales";
            textBoxYTDSales.Size = new Size(144, 23);
            textBoxYTDSales.TabIndex = 41;
            textBoxYTDSales.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxProvince
            // 
            textBoxProvince.CharacterCasing = CharacterCasing.Upper;
            textBoxProvince.Location = new Point(138, 186);
            textBoxProvince.Name = "textBoxProvince";
            textBoxProvince.Size = new Size(144, 23);
            textBoxProvince.TabIndex = 39;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(138, 153);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(144, 23);
            textBoxCity.TabIndex = 38;
            // 
            // textBoxAddress2
            // 
            textBoxAddress2.Location = new Point(138, 120);
            textBoxAddress2.Name = "textBoxAddress2";
            textBoxAddress2.Size = new Size(235, 23);
            textBoxAddress2.TabIndex = 37;
            // 
            // textBoxAddress1
            // 
            textBoxAddress1.Location = new Point(138, 87);
            textBoxAddress1.Name = "textBoxAddress1";
            textBoxAddress1.Size = new Size(235, 23);
            textBoxAddress1.TabIndex = 36;
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.Location = new Point(138, 57);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.Size = new Size(235, 23);
            textBoxCompanyName.TabIndex = 35;
            // 
            // textBoxClientCode
            // 
            textBoxClientCode.CharacterCasing = CharacterCasing.Upper;
            textBoxClientCode.Location = new Point(138, 21);
            textBoxClientCode.Name = "textBoxClientCode";
            textBoxClientCode.Size = new Size(84, 23);
            textBoxClientCode.TabIndex = 34;
            // 
            // checkBoxCreditHold
            // 
            checkBoxCreditHold.AutoSize = true;
            checkBoxCreditHold.Location = new Point(138, 335);
            checkBoxCreditHold.Name = "checkBoxCreditHold";
            checkBoxCreditHold.Size = new Size(84, 19);
            checkBoxCreditHold.TabIndex = 43;
            checkBoxCreditHold.Text = "&CreditHold";
            checkBoxCreditHold.UseVisualStyleBackColor = true;
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Location = new Point(20, 296);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(41, 15);
            labelNotes.TabIndex = 32;
            labelNotes.Text = "&Notes:";
            // 
            // labelYTDSales
            // 
            labelYTDSales.AutoSize = true;
            labelYTDSales.Location = new Point(20, 263);
            labelYTDSales.Name = "labelYTDSales";
            labelYTDSales.Size = new Size(54, 15);
            labelYTDSales.TabIndex = 31;
            labelYTDSales.Text = "&YTDSales";
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Location = new Point(20, 227);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(70, 15);
            labelPostalCode.TabIndex = 30;
            labelPostalCode.Text = "&PostalCode:";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(20, 161);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(31, 15);
            labelCity.TabIndex = 29;
            labelCity.Text = "&City:";
            // 
            // labelAddress2
            // 
            labelAddress2.AutoSize = true;
            labelAddress2.Location = new Point(20, 128);
            labelAddress2.Name = "labelAddress2";
            labelAddress2.Size = new Size(58, 15);
            labelAddress2.TabIndex = 28;
            labelAddress2.Text = "&Address2:";
            // 
            // labelProvince
            // 
            labelProvince.AutoSize = true;
            labelProvince.Location = new Point(20, 194);
            labelProvince.Name = "labelProvince";
            labelProvince.Size = new Size(56, 15);
            labelProvince.TabIndex = 27;
            labelProvince.Text = "&Province:";
            // 
            // labelAddress1
            // 
            labelAddress1.AutoSize = true;
            labelAddress1.Location = new Point(20, 95);
            labelAddress1.Name = "labelAddress1";
            labelAddress1.Size = new Size(58, 15);
            labelAddress1.TabIndex = 26;
            labelAddress1.Text = "&Address1:";
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.Location = new Point(20, 60);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(94, 15);
            labelCompanyName.TabIndex = 25;
            labelCompanyName.Text = "&CompanyName:";
            // 
            // labelClientCode
            // 
            labelClientCode.AutoSize = true;
            labelClientCode.Location = new Point(20, 29);
            labelClientCode.Name = "labelClientCode";
            labelClientCode.Size = new Size(69, 15);
            labelClientCode.TabIndex = 24;
            labelClientCode.Text = "&ClientCode:";
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk.Location = new Point(206, 371);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(67, 23);
            buttonOk.TabIndex = 44;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Location = new Point(298, 371);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 45;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // maskedTextBoxPostalCode
            // 
            maskedTextBoxPostalCode.Location = new Point(138, 224);
            maskedTextBoxPostalCode.Mask = ">L0L 0L0";
            maskedTextBoxPostalCode.Name = "maskedTextBoxPostalCode";
            maskedTextBoxPostalCode.Size = new Size(84, 23);
            maskedTextBoxPostalCode.TabIndex = 40;
            // 
            // ClientEditDialog
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(395, 406);
            Controls.Add(maskedTextBoxPostalCode);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(textBoxNotes);
            Controls.Add(textBoxYTDSales);
            Controls.Add(textBoxProvince);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxAddress2);
            Controls.Add(textBoxAddress1);
            Controls.Add(textBoxCompanyName);
            Controls.Add(textBoxClientCode);
            Controls.Add(checkBoxCreditHold);
            Controls.Add(labelNotes);
            Controls.Add(labelYTDSales);
            Controls.Add(labelPostalCode);
            Controls.Add(labelCity);
            Controls.Add(labelAddress2);
            Controls.Add(labelProvince);
            Controls.Add(labelAddress1);
            Controls.Add(labelCompanyName);
            Controls.Add(labelClientCode);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClientEditDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ClientEditDialog";
            Load += ClientEditDialog_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxNotes;
        private TextBox textBoxYTDSales;
        private TextBox textBoxProvince;
        private TextBox textBoxCity;
        private TextBox textBoxAddress2;
        private TextBox textBoxAddress1;
        private TextBox textBoxCompanyName;
        private TextBox textBoxClientCode;
        private CheckBox checkBoxCreditHold;
        private Label labelNotes;
        private Label labelYTDSales;
        private Label labelPostalCode;
        private Label labelCity;
        private Label labelAddress2;
        private Label labelProvince;
        private Label labelAddress1;
        private Label labelCompanyName;
        private Label labelClientCode;
        private Button buttonOk;
        private Button buttonCancel;
        private ErrorProvider errorProvider;
        private MaskedTextBox maskedTextBoxPostalCode;
    }
}
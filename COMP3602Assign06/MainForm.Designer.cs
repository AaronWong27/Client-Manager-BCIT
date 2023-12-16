namespace COMP3602Assign06
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
            dataGridViewClients = new DataGridView();
            buttonNew = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            checkBoxConfirmDelete = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(12, 12);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowTemplate.Height = 25;
            dataGridViewClients.Size = new Size(1387, 284);
            dataGridViewClients.TabIndex = 11;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(992, 320);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(75, 23);
            buttonNew.TabIndex = 24;
            buttonNew.Text = "&New";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(1090, 318);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(71, 25);
            buttonEdit.TabIndex = 25;
            buttonEdit.Text = "&Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(1177, 320);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 26;
            buttonDelete.Text = "&Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // checkBoxConfirmDelete
            // 
            checkBoxConfirmDelete.AutoSize = true;
            checkBoxConfirmDelete.Checked = true;
            checkBoxConfirmDelete.CheckState = CheckState.Checked;
            checkBoxConfirmDelete.Location = new Point(1280, 324);
            checkBoxConfirmDelete.Name = "checkBoxConfirmDelete";
            checkBoxConfirmDelete.Size = new Size(106, 19);
            checkBoxConfirmDelete.TabIndex = 27;
            checkBoxConfirmDelete.Text = "&Confirm Delete";
            checkBoxConfirmDelete.UseVisualStyleBackColor = true;
            checkBoxConfirmDelete.CheckedChanged += checkBoxConfirmDelete_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 369);
            Controls.Add(checkBoxConfirmDelete);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonNew);
            Controls.Add(dataGridViewClients);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assign06";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewClients;
        private Button buttonNew;
        private Button buttonEdit;
        private Button buttonDelete;
        private CheckBox checkBoxConfirmDelete;
    }
}
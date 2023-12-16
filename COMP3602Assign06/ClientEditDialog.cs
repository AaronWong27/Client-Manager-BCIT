using BusinessLib.Business;
using BusinessLib.Common;
using Microsoft.Data.SqlClient;

namespace COMP3602Assign06
{
    public partial class ClientEditDialog : Form
    {
        private ClientViewModel clientVM;

        public bool IsEditMode { get; set; }

        public ClientViewModel ClientVM
        {
            get => clientVM;
            set => clientVM = value;
        }
        public ClientEditDialog()
        {
            InitializeComponent();
        }

        private void ClientEditDialog_Load(object sender, EventArgs e)
        {
            if (this.IsEditMode)
            {
                this.Text = "Editing Product Record";
            }
            else
            {
                this.Text = "New Product Record";
                ClientVM.SetDisplayClient(new Client());
            }

            setBindings();
        }

        private void setBindings()
        {
            textBoxClientCode.DataBindings.Add("Text", clientVM, "Client.ClientCode");

            textBoxCompanyName.DataBindings.Add("Text", clientVM, "Client.CompanyName");

            textBoxAddress1.DataBindings.Add("Text", clientVM, "Client.Address1");

            textBoxAddress2.DataBindings.Add("Text", clientVM, "Client.Address2");

            textBoxCity.DataBindings.Add("Text", clientVM, "Client.City");

            textBoxProvince.DataBindings.Add("Text", clientVM, "Client.Province");

            maskedTextBoxPostalCode.DataBindings.Add("Text", clientVM, "Client.PostalCode");

            textBoxYTDSales.DataBindings.Add("Text", clientVM, "Client.YtdSales");

            checkBoxCreditHold.DataBindings.Add("Checked", clientVM, "Client.CreditHold");

            textBoxNotes.DataBindings.Add("Text", clientVM, "Client.Notes");

        }

        // when buttonOk is clicked
        private void buttonOk_Click(object sender, EventArgs e)
        {
            int rowsAffected;
            clearErrors();

            try
            {
                Client client = clientVM.GetDisplayClient();

                // if in edit mode, update client
                if (this.IsEditMode)
                {
                    rowsAffected = ClientValidation.UpdateClient(client);
                }
                // if not in edit mode, add client
                else
                {
                    rowsAffected = ClientValidation.AddClient(client);
                }

                if (rowsAffected == 1)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    errorProvider.SetError(buttonOk, ClientValidation.ErrorMessage);
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Data Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // clear errors of the button
        private void clearErrors() => errorProvider.SetError(buttonOk, "");
    }

}

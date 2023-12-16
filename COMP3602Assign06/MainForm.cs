using BusinessLib.Business;
using BusinessLib.Common;
using Microsoft.Data.SqlClient;

namespace COMP3602Assign06;

// Main Form
public partial class MainForm : Form
{
    private ClientViewModel clientVM;

    bool check = true;

    // main form
    public MainForm()
    {
        InitializeComponent();
    }

    // form loads, set up clients and grid
    private void MainForm_Load(object sender, EventArgs e)
    {
        clientVM = new ClientViewModel();

        dataGridViewClients.AutoGenerateColumns = false;
        dataGridViewClients.DataSource = clientVM.Clients;
        setupDataGridView();

    }

    // grid set up
    private void setupDataGridView()
    {
        // configure for readonly 
        dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewClients.MultiSelect = false;
        dataGridViewClients.AllowUserToAddRows = false;
        dataGridViewClients.EditMode = DataGridViewEditMode.EditProgrammatically;
        dataGridViewClients.AllowUserToOrderColumns = false;
        dataGridViewClients.AllowUserToResizeColumns = false;
        dataGridViewClients.AllowUserToResizeRows = false;
        dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
        dataGridViewClients.RowHeadersVisible = false;

        // view of code
        DataGridViewTextBoxColumn code = new DataGridViewTextBoxColumn();
        code.Name = "code";
        code.DataPropertyName = "ClientCode"; // change
        code.HeaderText = "Code";
        code.Width = 50;
        code.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        code.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        code.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(code);

        // view of name
        DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
        name.Name = "name";
        name.DataPropertyName = "CompanyName";
        name.HeaderText = "Name";
        name.Width = 150;
        name.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        name.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(name);

        // view of address1
        DataGridViewTextBoxColumn address1 = new DataGridViewTextBoxColumn();
        address1.Name = "address1";
        address1.DataPropertyName = "Address1";
        address1.HeaderText = "Address1";
        address1.Width = 150;
        address1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        address1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        address1.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(address1);

        // view of address2
        DataGridViewTextBoxColumn address2 = new DataGridViewTextBoxColumn();
        address2.Name = "address2";
        address2.DataPropertyName = "Address2";
        address2.HeaderText = "Address2";
        address2.Width = 150;
        address2.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        address2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        address2.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(address2);

        // view of city
        DataGridViewTextBoxColumn city = new DataGridViewTextBoxColumn();
        city.Name = "city";
        city.DataPropertyName = "City";
        city.HeaderText = "City";
        city.Width = 100;
        city.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        city.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        city.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(city);

        // view of province
        DataGridViewTextBoxColumn province = new DataGridViewTextBoxColumn();
        province.Name = "province";
        province.DataPropertyName = "Province";
        province.HeaderText = "Province";
        province.Width = 100;
        province.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        province.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        province.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(province);

        // view of postalCode
        DataGridViewTextBoxColumn postalCode = new DataGridViewTextBoxColumn();
        postalCode.Name = "postalCode";
        postalCode.DataPropertyName = "PostalCode";
        postalCode.HeaderText = "PostalCode";
        postalCode.Width = 70;
        postalCode.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        postalCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        postalCode.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(postalCode);

        // view of ytdSales
        DataGridViewTextBoxColumn ytdSales = new DataGridViewTextBoxColumn();
        ytdSales.Name = "ytdSales";
        ytdSales.DataPropertyName = "YTDSales";
        ytdSales.HeaderText = "YTDSales";
        ytdSales.Width = 70;
        ytdSales.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        ytdSales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        ytdSales.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(ytdSales);

        // view of creditHold
        DataGridViewCheckBoxColumn creditHold = new DataGridViewCheckBoxColumn();
        creditHold.Name = "hold";
        creditHold.DataPropertyName = "CreditHold";
        creditHold.HeaderText = "CreditHold";
        creditHold.Width = 100;
        creditHold.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        creditHold.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //creditHold.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        creditHold.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(creditHold);

        // view of notes
        DataGridViewTextBoxColumn notes = new DataGridViewTextBoxColumn();
        notes.Name = "notes";
        notes.DataPropertyName = "Notes";
        notes.HeaderText = "Notes";
        notes.Width = 100;
        notes.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        notes.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(notes);
    }

    // open dialog
    private void openDialog(bool isEditMode = true)
    {
        int index = dataGridViewClients.CurrentRow.Index;
        clientVM.SetDisplayClient(clientVM.Clients[index]);

        ClientEditDialog dlg = new();
        dlg.IsEditMode = isEditMode;
        dlg.ClientVM = clientVM;
        dlg.ShowDialog();

        if (dlg.DialogResult == DialogResult.OK)
        {
            refreshGrid();

            dataGridViewClients.Rows[index].Selected = true;
            dataGridViewClients.CurrentCell = dataGridViewClients[0, index];
        }

        dlg.Dispose();
    }

    // refresh the grid
    private void refreshGrid()
    {
        dataGridViewClients.DataSource = null;
        clientVM.RefreshClientListFromDb();
        dataGridViewClients.DataSource = clientVM.Clients;
    }


    // make a new client when buttonNew is clicked
    private void buttonNew_Click(object sender, EventArgs e)
    {
        clientVM.SetDisplayClient(new Client());
        openDialog(false);
    }

    // delete a client with buttonDelete is clicked
    private void buttonDelete_Click(object sender, EventArgs e)
    {
        //if the checked boolean is true, output a confimation box
        if (check == true)
        {
            DialogResult result = MessageBox.Show("Delete Client?",          // Message Text
                                            "Confirm Delete",          // Caption Text
                                             MessageBoxButtons.YesNo,  // Buttons
                                             MessageBoxIcon.Question);

            // if the dialog is yes, delete
            if (result == DialogResult.Yes)
            {
                try
                {
                    int index = dataGridViewClients.CurrentRow.Index;

                    //Client client = clientVM.GetDisplayClient();
                    Client client = clientVM.Clients[index];
                    ClientValidation.DeleteClient(client);

                    refreshGrid();

                    index = Math.Max(0, index - 1);

                    dataGridViewClients.Rows[index].Selected = true;
                    dataGridViewClients.CurrentCell = dataGridViewClients[0, index];
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
        }
        // if checked boolean is false, delete the client without confirmation
        if (check == false)
        {
            try
            {
                int index = dataGridViewClients.CurrentRow.Index;

                //Client client = clientVM.GetDisplayClient();
                Client client = clientVM.Clients[index];
                ClientValidation.DeleteClient(client);

                refreshGrid();

                index = Math.Max(0, index - 1);

                dataGridViewClients.Rows[index].Selected = true;
                dataGridViewClients.CurrentCell = dataGridViewClients[0, index];
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



    }

    // edit client when buttonEdit is clicked
    private void buttonEdit_Click(object sender, EventArgs e)
    {
        int index = dataGridViewClients.CurrentRow.Index;
        clientVM.SetDisplayClient(clientVM.Clients[index]);
        openDialog(true);
    }

    // confirm delete checkbox
    private void checkBoxConfirmDelete_CheckedChanged(object sender, EventArgs e)
    {
        check = checkBoxConfirmDelete.Checked;
        Console.WriteLine(check);
    }
}

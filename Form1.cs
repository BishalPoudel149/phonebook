//student id: 30013014
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PhonebookApp
{
    public partial class Form1 : Form
    {
        private const int CP_DISABLE_CLOSE_BUTTON = 0x200;
        BindingList<Contact> Contacts = new BindingList<Contact>();
        public Form1()
        {
            InitializeComponent();
            setDataSource(Contacts);
        }

        //Disable the Close Button of Windows Form 
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cls = base.CreateParams;
                cls.ClassStyle = cls.ClassStyle | CP_DISABLE_CLOSE_BUTTON;
                return cls;
            }
        }

        //The BindingSource  which acts as both a conduit and a data source for other controls to bind to.
        private void setDataSource(BindingList<Contact> _Contacts)
        {
            lbFName.DataSource = _Contacts;
            lbLName.DataSource = _Contacts;
            LbNumber.DataSource = _Contacts;
            lblStatus.Text = _Contacts.Count.ToString();
        }

        //Contact Information Entry section, -Insert button would insert data to Respective ListBox
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFName.Text))
            {
                MessageBox.Show("First Name Mandatory"); return;
            }
            if (string.IsNullOrEmpty(tbLName.Text))
            {
                MessageBox.Show("Last Name Mandatory"); return;
            }
            if (string.IsNullOrEmpty(tbNumber.Text))
            {
                MessageBox.Show("Contact Number Mandatory"); return;
            }
            if (Contacts.Any(x => x.Number == tbNumber.Text))
            {
                MessageBox.Show("Contact Number Already Exist"); return;
            }

            Contact con = new Contact();
            con.FirstName = tbFName.Text;
            con.LastName = tbLName.Text;
            con.Number = tbNumber.Text;

            Contacts.Add(con);
            Contacts = new BindingList<Contact>(Contacts.OrderBy(x => x.Number).ToList());
            setDataSource(Contacts);

            if (Contacts.Count >= 30)
                btnSave.Enabled = false;

            btnDelete.Enabled = true;
            btnClear.Enabled = true;
            tbFName.Text = tbLName.Text = tbNumber.Text = string.Empty;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Clear button that would clear all the data of listbox
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Clear?", "Delete Contact", MessageBoxButtons.YesNo) == DialogResult.Yes);
            {
                Contacts.Clear();
                lblStatus.Text = Contacts.Count.ToString();
                if (!btnSave.Enabled)
                    btnSave.Enabled = true;

                btnDelete.Enabled = false;
                btnClear.Enabled = false;
            }
        }

        //Deleting the selected Contact Information from ListBox
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbFName.SelectedIndex == -1 && lbLName.SelectedIndex == -1 && LbNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Record from any of Listboxes"); return;
            }

            if (lbFName.SelectedIndex != -1)
            {
                Contacts.RemoveAt(lbFName.SelectedIndex);
            }
            else if (lbLName.SelectedIndex != -1)
            {
                Contacts.RemoveAt(lbLName.SelectedIndex);
            }
            else if (LbNumber.SelectedIndex != -1)
            {
                Contacts.RemoveAt(LbNumber.SelectedIndex);
            }
            lblStatus.Text = Contacts.Count.ToString();

            if (!btnSave.Enabled)
                btnSave.Enabled = true;

            if (Contacts.Count == 0)
            {
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
            }
            MessageBox.Show("Deleted Successfully");
        }

        //Load the txt file from the Drive to Form.  
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Title = "Browse Files";
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openFileDialog.FileName))
                {

                    FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader streamReader = new StreamReader(fileStream);
                    try
                    {
                        string text = streamReader.ReadLine();
                        while (text != "00000000000")
                        {
                            Contact contact = new Contact();

                            contact.FirstName = text;

                            text = streamReader.ReadLine();
                            contact.LastName = text;

                            text = streamReader.ReadLine();
                            contact.Number = text;

                            Contacts.Add(contact);
                            text = streamReader.ReadLine();
                        }
                        lblStatus.Text = Contacts.Count.ToString();

                        if (Contacts.Count > 0)
                        {
                            btnDelete.Enabled = true;
                            btnClear.Enabled = true;
                        }

                        if (Contacts.Count >= 30)
                            btnSave.Enabled = false;
                    }
                    finally
                    {
                        fileStream.Close();
                        streamReader.Close();
                    }
                }
            }
        }

        //Contact Information of the listbox we entered to be saved in the txt file format
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "txt";
            saveFile.Title = "Browse Files";
            saveFile.Filter = "txt files (*.txt)|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(saveFile.FileName))
                {
                    FileStream fileStream = new FileStream(saveFile.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(fileStream);
                    try
                    {
                        foreach (var item in Contacts)
                        {
                            writer.WriteLine(item.FirstName);
                            writer.WriteLine(item.LastName);
                            writer.WriteLine(item.Number);
                        }
                        writer.WriteLine("00000000000");
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        writer.Close();
                        fileStream.Close();
                    }
                }
            }
        }

        //Search ALgorithm with respective search as accordance to the radio button selected
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (rbFName.Checked == false && rbLName.Checked == false && rbNumber.Checked == false)
            {
                MessageBox.Show("Select a Search option"); return;
            }
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                setDataSource(Contacts);
                MessageBox.Show("Enter some text to search");
                tbSearch.Text = string.Empty;
                return;
            }
            BindingList<Contact> Filtered = new BindingList<Contact>();

            if (rbFName.Checked == true)
            {
                int index = FirstNameContactSearch(0, Contacts.Count-1, tbSearch.Text);
                if (index != -1)
                    Filtered.Add(Contacts[index]);
            }
            else if (rbLName.Checked == true)
            {
                int index = LastNameContactSearch(0, Contacts.Count-1, tbSearch.Text);
                if (index != -1)
                    Filtered.Add(Contacts[index]);
            }
            else if (rbNumber.Checked == true)
            {
                int index = NumberContactSearch(0, Contacts.Count-1, tbSearch.Text);
                if (index != -1)
                    Filtered.Add(Contacts[index]);
            }
            setDataSource(Filtered);
        }

        //Searching ALgorithm
        //search Contact By FIrst Name
        int FirstNameContactSearch(int l, int r, string txt)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (Contacts[mid].FirstName.Equals(txt))
                    return mid;

                if (Contacts[mid].FirstName.CompareTo(txt) < 0)
                    return FirstNameContactSearch(l, mid - 1, txt);


                return FirstNameContactSearch(mid + 1, r, txt);
            }

            return -1;
        }
        //Search contact By Last Name
        int LastNameContactSearch(int l, int r, string txt)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (Contacts[mid].LastName.Equals(txt))
                    return mid;

                if (Contacts[mid].LastName.CompareTo(txt) < 0)
                    return LastNameContactSearch(l, mid - 1, txt);

                return LastNameContactSearch(mid + 1, r, txt);
            }

            return -1;
        }

        //Implementation of Binary Search Algorithm : Search Contact by PhoneNumber
        int NumberContactSearch(int l, int r, string txt)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (Contacts[mid].Number.Equals(txt))
                    return mid;

                if (Contacts[mid].Number.CompareTo(txt) < 0)
                    return NumberContactSearch(l, mid - 1, txt);

                return NumberContactSearch(mid + 1, r, txt);
            }

            return -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    //Contact Class To invoke the Required Data of Our Choice 
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }


    }
}

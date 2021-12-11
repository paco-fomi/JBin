
using System;
using System.IO;
using JBin;
using System.Windows.Forms;
using System.Drawing;

namespace JBin_Test_C
{
    public partial class Form1 : Form
    {

        Clients myClients = new Clients();
        AG myJBin;
        bool AbortWrite = false;
        enum Status
        {

            New = 0,

            Edit = 2,

            View = 3,
        }
        Status StatusForm;
        int IndexCliente = -1;
        string FileClients = (Application.StartupPath + "\\clients.jbin");

        public Form1()
        {
            InitializeComponent();            
        }

        private void JBIN_Error(object Sender, AGErrorEventArgs e)
        {
            string caption = "Error Detected in Input";
            MessageBox.Show(e.ToString(), caption);
            AbortWrite = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.Show();
            this.Refresh();
            FileInfo f = new FileInfo(FileClients);
            if (f.Exists)
            {
                myJBin = new AG();

                myJBin.OnError += JBIN_Error;

                myJBin.TypeFile = TypeFileJBin.Custom;
                myJBin.Load(FileClients);
                ReadClients();
            }

            StatusForm = Status.View;
            RefrehsStatus();
            lblIntro.Visible = false;
            BtnExit.Visible = true;
            GroupBoxAll.Visible = true;
        }

        private void RefrehsStatus()
        {
            switch (StatusForm)
            {
                case Status.Edit:
                    GroupBoxClient.Enabled = true;
                    BtnNew.Enabled = false;
                    BtnDelete.Enabled = true;
                    BtnSave.Enabled = true;
                    BtnCancel.Enabled = true;
                    break;
                case Status.New:
                    txtID.Text = ((myClients.CountClient + 1)).ToString();
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtMobile.Text = "";
                    lblColor.BackColor = Color.Black;
                    DateTimePicker1.Value = DateTime.Now;
                    txtAddress.Text = "";
                    txtCountry.Text = "";
                    txtDetails.Text = "";
                    GroupBoxClient.Enabled = true;
                    BtnNew.Enabled = false;
                    BtnEdit.Enabled = false;
                    BtnDelete.Enabled = false;
                    BtnSave.Enabled = true;
                    BtnCancel.Enabled = true;
                    break;
                case Status.View:
                    GroupBoxClient.Enabled = false;
                    BtnNew.Enabled = true;
                    BtnDelete.Enabled = false;
                    BtnSave.Enabled = false;
                    BtnCancel.Enabled = false;
                    break;
            }
        }

        private void ViewClient(int Index)
        {
            if ((Index == -1))
            {
                txtID.Text = "";
                txtName.Text = "";
                txtEmail.Text = "";
                txtMobile.Text = "";
                lblColor.BackColor = Color.Black;
                DateTimePicker1.Value = DateTime.Now;
                txtAddress.Text = "";
                txtCountry.Text = "";
                txtDetails.Text = "";
            }
            else
            {
                txtID.Text = Convert.ToString(myClients.Item[Index].ID);
                txtName.Text = myClients.Item[Index].Name;
                txtEmail.Text = myClients.Item[Index].Email;
                txtMobile.Text = myClients.Item[Index].Mobile;
                lblColor.BackColor = myClients.Item[Index].HairColor;
                DateTimePicker1.Value = myClients.Item[Index].Birthdate;
                txtAddress.Text = myClients.Item[Index].Address;
                txtCountry.Text = myClients.Item[Index].Country;
                txtDetails.Text = myClients.Item[Index].Details;
            }

            lblView.Text = ((Index + 1) + (" of " + myClients.CountClient));
        }

        private void ReadClients()
        {

            int NumCl = myJBin.GetInt();
            for (int i = 0; (i <= (NumCl - 1)); i++)
            {
                Client newCl = new Client();
                // With...
                newCl.ID = myJBin.GetInt();
                newCl.Name = myJBin.GetString();
                newCl.Email = myJBin.GetString();
                newCl.Mobile = myJBin.GetString();
                newCl.HairColor = myJBin.GetColor();
                newCl.Birthdate = myJBin.GetDate();
                newCl.Address = myJBin.GetString();
                newCl.Country = myJBin.GetString();
                newCl.Details = myJBin.GetString();
                myClients.AddClient(newCl);
            }

            if ((myClients.CountClient > 0))
            {
                scrollIndex.Maximum = myClients.CountClient;
                NumericUpDown1.Maximum = myClients.CountClient;
                scrollIndex.Value = 1;
                scrollIndex.Minimum = 1;
            }
            else
            {
                scrollIndex.Value = 0;
                scrollIndex.Minimum = 0;
                scrollIndex.Maximum = 0;
                NumericUpDown1.Maximum = 1;
            }

        }
        
        private void WriteClients()
        {
            myJBin = new AG();
            myJBin.TypeFile = TypeFileJBin.Custom;

            myJBin.AddInt(myClients.CountClient);

            for (int i = 0; (i <= (myClients.CountClient - 1)); i++)
            {
                // With...
                myJBin.AddInt(myClients.Item[i].ID);
                myJBin.AddString(myClients.Item[i].Name);
                myJBin.AddString(myClients.Item[i].Email);
                myJBin.AddString(myClients.Item[i].Mobile);
                myJBin.AddColor(myClients.Item[i].HairColor);
                myJBin.AddDate(myClients.Item[i].Birthdate);
                myJBin.AddString(myClients.Item[i].Address);
                myJBin.AddString(myClients.Item[i].Country);
                myJBin.AddString(myClients.Item[i].Details);
                //  EXAMPLE FOR DETECT ERROR
                if (AbortWrite)
                {
                    return;
                }

                myJBin.Save(FileClients);
            }

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            StatusForm = Status.New;
            RefrehsStatus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            StatusForm = Status.Edit;
            RefrehsStatus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if ((IndexCliente == -1))
            {
                return;
            }

            if ((myClients.CountClient == 0))
            {
                return;
            }

            string message = "Delete client?";
            string caption = "Delete Item";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                myClients.RemoveClient(IndexCliente);
                if ((myClients.CountClient == 0))
                {
                    IndexCliente = -1;
                    ViewClient(IndexCliente);
                }
                else if ((IndexCliente
                            > (myClients.CountClient - 1)))
                {
                    IndexCliente = (myClients.CountClient - 1);
                }

                ViewClient(IndexCliente);
            }

            StatusForm = Status.View;
            RefrehsStatus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            switch (StatusForm)
            {
                case Status.Edit:
                    // With...
                    myClients.Item[IndexCliente].ID = Convert.ToInt16(txtID.Text);
                    myClients.Item[IndexCliente].Name = txtName.Text;
                    myClients.Item[IndexCliente].Email = txtEmail.Text;
                    myClients.Item[IndexCliente].Mobile= txtMobile.Text;
                    myClients.Item[IndexCliente].HairColor = lblColor.BackColor;
                    myClients.Item[IndexCliente].Birthdate= DateTimePicker1.Value;
                    myClients.Item[IndexCliente].Address= txtAddress.Text;
                    myClients.Item[IndexCliente].Country= txtCountry.Text;
                    myClients.Item[IndexCliente].Details= txtDetails.Text;
                    break;

                case Status.New:
                    Client newCl = new Client();
                    newCl.ID = Convert.ToInt16(txtID.Text);
                    newCl.Name = txtName.Text;
                    newCl.Email = txtEmail.Text;
                    newCl.Mobile = txtMobile.Text;
                    newCl.HairColor = lblColor.BackColor;
                    newCl.Birthdate = DateTimePicker1.Value;
                    newCl.Address = txtAddress.Text;
                    newCl.Country = txtCountry.Text;
                    newCl.Details = txtDetails.Text;
                    myClients.AddClient(newCl);

                    scrollIndex.Maximum = myClients.CountClient;
                    NumericUpDown1.Maximum = myClients.CountClient;
                    scrollIndex.Value = myClients.CountClient;
                    scrollIndex.Minimum = 1;
                    break;
            }
            StatusForm = Status.View;
            RefrehsStatus();
            WriteClients();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            StatusForm = Status.View;
            RefrehsStatus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            if ((NumericUpDown1.Value
            > (myClients.CountClient - 1)))
            {
                NumericUpDown1.Value = myClients.CountClient;
            }

            if ((NumericUpDown1.Value < 1))
            {
                NumericUpDown1.Value = 1;
            }

            IndexCliente = Convert.ToInt16(NumericUpDown1.Value - 1);
            ViewClient(IndexCliente);
        }

        private void scrollIndex_ValueChanged(object sender, EventArgs e)
        {
            IndexCliente = (scrollIndex.Value - 1);
            ViewClient(IndexCliente);
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            ColorDialog ColorDialog1 = new ColorDialog();
            ColorDialog1.Color = lblColor.BackColor;
            if (ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                lblColor.BackColor = ColorDialog1.Color;
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

    }

    public class Client
    {

        int _ID;
        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }

        string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        string _Email;
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }

        string _Mobile;
        public string Mobile
        {
            get
            {
                return _Mobile;
            }
            set
            {
                _Mobile = value;
            }
        }

        DateTime _Birthdate;
        public DateTime Birthdate
        {
            get
            {
                return _Birthdate;
            }
            set
            {
                _Birthdate = value;
            }
        }

        Color _HairColor;
        public Color HairColor
        {
            get
            {
                return _HairColor;
            }
            set
            {
                _HairColor = value;
            }
        }

        string _Country;
        public string Country
        {
            get
            {
                return _Country;
            }
            set
            {
                _Country = value;
            }
        }

        string _Address;
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }

        string _Details;


        public string Details
        {
            get
            {
                return _Details;
            }
            set
            {
                _Details = value;
            }
        }

    }

    public class Clients
    {

        public Client[] Item;
  
        int newCount;
        public int CountClient
        {
            get
            {
                if ((Item == null))
                {
                    newCount = 0;
                }
                else
                {
                    newCount = Item.Length;
                }

                return newCount;
            }
        }

        public int AddClient(Client newCl)
        {
            if ((newCl == null))
            {
                return -1;
            }

            int MaxFiles;
            if ((Item == null))
            {
                MaxFiles = 0;
            }
            else
            {
                MaxFiles = Item.Length;
            }

            Array.Resize(ref Item, MaxFiles +1 );
            Item[MaxFiles] = new Client();
            Item[MaxFiles] = newCl;
            return 0;
        }

        public void RemoveClient(int Index)
        {
            if ((Item == null))
            {
                return;
            }

            if ((Index < 0))
            {
                return;
            }

            if ((Index
                        > (Item.Length - 1)))
            {
                return;
            }

            for (int x = (Index + 1); (x <= (Item.Length - 1)); x++)
            {
                Item[x - 1] = Item[x];
            }

            Array.Resize(ref Item, Item.Length - 2);
        }


    }

}

namespace Praktikum_21_Maret
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string dataSama = TbData.Text;
            ListBoxData.Items.Add(TbData.Text);
            TbData.Text = "";
            if (TbData.Text ==dataSama)
            {
                MessageBox.Show("Isi TextBox Tidak Boleh Sama");
            }
        }

        private void RbWarnaMerah_CheckedChanged(object sender, EventArgs e)
        {
            LbOutput.ForeColor= Color.Red;
        }

        private void RbWarnaBiru_CheckedChanged(object sender, EventArgs e)
        {
            LbOutput.ForeColor = Color.Blue;
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LbOutput.Text=ListBoxData.SelectedItem.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LbOutput.Text = "";
            ListBoxData.Items.Clear(); 
            RbWarnaBiru.Checked = false;
            RbWarnaMerah.Checked = false;
        }

        private void CbAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (CbAktif.Checked == true)
            {
                LbOutput.ForeColor = Color.Red;
                LbOutput.ForeColor = Color.Blue;

            }
            else if (CbAktif.Checked == false)
            {
                
                LbOutput.ForeColor = Color.Black;
            }

        }
    }
}
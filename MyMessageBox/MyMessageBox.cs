using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;


namespace MyMessageBox
{
    public partial class MyMessageBox : Form
    {

        public MyMessageBox(String Entete, String Message)
        {
            InitializeComponent();
            SystemSounds.Beep.Play();
            lblTitreMessage.Text = Entete;
            txtMessage.Text = Message;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {

        }
        
        private void MyMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

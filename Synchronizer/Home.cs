using System.Configuration;

namespace Synchronizer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_ConfigurarBackup_Click(object sender, EventArgs e)
        {
            //ConfigBackup configBackup = new ConfigBackup();
            //configBackup.ConfBackupDefault();

            Configurar_Bkp configurar_Bkp = new Configurar_Bkp();
            configurar_Bkp.ShowDialog();
            
        }

    
    }
}
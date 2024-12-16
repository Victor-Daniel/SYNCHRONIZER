using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Reflection;

namespace Synchronizer
{
    public partial class Configurar_Bkp : Form
    {
        public Configurar_Bkp()
        {
            InitializeComponent();
        }

        private void Configurar_Bkp_Load(object sender, EventArgs e)
        {
            ConfigBackup configBackup = new ConfigBackup();
            if (configBackup.CurrentConfigINI("CONFIG_SYS", "MODE") == "Default" || configBackup.CurrentConfigINI("CONFIG_SYS", "MODE") == "DEFAULT")
            {
                rd_Default.Checked = true;
                rd_Person.Checked = false;
                tb_Person.Enabled = false;
                btn_Browser.Enabled = false;
                lb_Person.Enabled = false;
                tb_Default.Text = configBackup.DefaultPathBKP();
                btn_Salvar.Enabled = false;
                tb_Person.Text = String.Empty;
                configBackup.ConfBackupDefault();
                btn_BackupDiferencial.Enabled = false;
                btn_BackpComp.Enabled = false;


            }
            else
            {
                rd_Default.Checked = false;
                rd_Person.Checked = true;
                tb_Person.Enabled = true;
                btn_Browser.Enabled = true;
                lb_Person.Enabled = true;
                tb_Default.Text = "";
                btn_Salvar.Enabled = true;
                tb_Person.Text = configBackup.CurrentConfigINI("BKP_CONFIG_PERSON", "PATH");
                tb_Default.Text = String.Empty;
                btn_BackupDiferencial.Enabled = true;
                btn_BackpComp.Enabled = true;
            }

        }

        private void rd_Person_MouseClick(object sender, MouseEventArgs e)
        {
            rd_Default.Checked = false;
            rd_Person.Checked = true;
            tb_Person.Enabled = true;
            btn_Browser.Enabled = true;
            lb_Person.Enabled = true;
            btn_Salvar.Enabled = true;
            ConfigBackup configBackup = new ConfigBackup();
            configBackup.ModifyConfigIni("CONFIG_SYS", "MODE", "Person");
            tb_Default.Text = "";
            tb_Person.Text = configBackup.CurrentConfigINI("BKP_CONFIG_PERSON", "PATH");
            tb_Default.Text = String.Empty;
            btn_BackupDiferencial.Enabled = true;
            btn_BackpComp.Enabled = true;
        }

        private void rd_Default_MouseClick(object sender, MouseEventArgs e)
        {
            rd_Default.Checked = true;
            rd_Person.Checked = false;
            tb_Person.Enabled = false;
            btn_Browser.Enabled = false;
            lb_Person.Enabled = false;
            btn_Salvar.Enabled = false;
            ConfigBackup configBackup = new ConfigBackup();
            configBackup.ModifyConfigIni("CONFIG_SYS", "MODE", "Default");
            tb_Default.Text = configBackup.DefaultPathBKP();
            tb_Person.Text = String.Empty;
            configBackup.ConfBackupDefault();
            btn_BackupDiferencial.Enabled = false;
            btn_BackpComp.Enabled = false;
        }

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            var Directory = new FolderBrowserDialog();
            Directory.ShowDialog();
            var Folder = Directory.SelectedPath;
            tb_Person.Text = Folder;

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            ConfigBackup configBackup = new ConfigBackup();
            configBackup.SaveConfigurationPerson(tb_Person.Text);

        }

        private void btn_mkdir_Click(object sender, EventArgs e)
        {
            var Directory = new FolderBrowserDialog();
            Directory.ShowDialog();
            var Folder = Directory.SelectedPath;
            if (!lb_Person.Items.Contains(Folder))
            {
                if (Folder !=String.Empty)
                {
                    lb_Person.Items.Add(Folder);
                    MessageBox.Show(Folder);
                }
                
            }
            else
            {
                MessageBox.Show("Difretório já foi adicionado!");
            }

        }


    }
}

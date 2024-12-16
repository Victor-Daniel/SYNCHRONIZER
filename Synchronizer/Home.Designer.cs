namespace Synchronizer
{
    partial class Home
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
            label1 = new Label();
            btn_CreateService = new Button();
            btn_AgendarBackup = new Button();
            btn_ConfigurarBackup = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(212, 83);
            label1.Name = "label1";
            label1.Size = new Size(391, 43);
            label1.TabIndex = 0;
            label1.Text = "SYNCHRONIZER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_CreateService
            // 
            btn_CreateService.Cursor = Cursors.Hand;
            btn_CreateService.Image = Properties.Resources.service;
            btn_CreateService.Location = new Point(82, 197);
            btn_CreateService.Margin = new Padding(3, 4, 3, 4);
            btn_CreateService.Name = "btn_CreateService";
            btn_CreateService.Size = new Size(159, 247);
            btn_CreateService.TabIndex = 1;
            btn_CreateService.Text = "CRIAR SERVIÇO";
            btn_CreateService.TextAlign = ContentAlignment.BottomCenter;
            btn_CreateService.UseVisualStyleBackColor = true;
            // 
            // btn_AgendarBackup
            // 
            btn_AgendarBackup.Cursor = Cursors.Hand;
            btn_AgendarBackup.Image = Properties.Resources.agendar_backup;
            btn_AgendarBackup.Location = new Point(330, 197);
            btn_AgendarBackup.Margin = new Padding(3, 4, 3, 4);
            btn_AgendarBackup.Name = "btn_AgendarBackup";
            btn_AgendarBackup.Size = new Size(159, 247);
            btn_AgendarBackup.TabIndex = 2;
            btn_AgendarBackup.Text = "AGENDAR BACKUP";
            btn_AgendarBackup.TextAlign = ContentAlignment.BottomCenter;
            btn_AgendarBackup.UseVisualStyleBackColor = true;
            // 
            // btn_ConfigurarBackup
            // 
            btn_ConfigurarBackup.Cursor = Cursors.Hand;
            btn_ConfigurarBackup.Image = Properties.Resources.configurar;
            btn_ConfigurarBackup.Location = new Point(582, 197);
            btn_ConfigurarBackup.Margin = new Padding(3, 4, 3, 4);
            btn_ConfigurarBackup.Name = "btn_ConfigurarBackup";
            btn_ConfigurarBackup.Size = new Size(159, 247);
            btn_ConfigurarBackup.TabIndex = 3;
            btn_ConfigurarBackup.Text = "CONFIGURAR BACKUP";
            btn_ConfigurarBackup.TextAlign = ContentAlignment.BottomCenter;
            btn_ConfigurarBackup.UseVisualStyleBackColor = true;
            btn_ConfigurarBackup.Click += btn_ConfigurarBackup_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 524);
            Controls.Add(btn_ConfigurarBackup);
            Controls.Add(btn_AgendarBackup);
            Controls.Add(btn_CreateService);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Início";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btn_CreateService;
        private Button btn_AgendarBackup;
        private Button btn_ConfigurarBackup;
    }
}
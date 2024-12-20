﻿namespace Synchronizer
{
    partial class Configurar_Bkp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tb_Default = new TextBox();
            btn_Browser = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tb_Person = new TextBox();
            label3 = new Label();
            rd_Default = new RadioButton();
            rd_Person = new RadioButton();
            lb_Person = new ListBox();
            btn_Config_Cloud = new Button();
            btn_Salvar = new Button();
            btn_BackpComp = new Button();
            btn_BackupDiferencial = new Button();
            btn_rmdir = new Button();
            btn_mkdir = new Button();
            btn_Verificar = new Button();
            btn_Save_Directory = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(234, 27);
            label1.Name = "label1";
            label1.Size = new Size(391, 43);
            label1.TabIndex = 1;
            label1.Text = "SYNCHRONIZER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(260, 170);
            label2.Name = "label2";
            label2.Size = new Size(212, 21);
            label2.TabIndex = 2;
            label2.Text = "Pasta padrão de Backup:";
            // 
            // tb_Default
            // 
            tb_Default.Enabled = false;
            tb_Default.Location = new Point(260, 195);
            tb_Default.Name = "tb_Default";
            tb_Default.Size = new Size(308, 27);
            tb_Default.TabIndex = 3;
            // 
            // btn_Browser
            // 
            btn_Browser.Location = new Point(260, 296);
            btn_Browser.Name = "btn_Browser";
            btn_Browser.Size = new Size(103, 34);
            btn_Browser.TabIndex = 4;
            btn_Browser.Text = "Browser";
            btn_Browser.UseVisualStyleBackColor = true;
            btn_Browser.Click += btn_Browser_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.folder_Icon;
            pictureBox1.Location = new Point(573, 181);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 48);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.folder_Icon;
            pictureBox2.Location = new Point(573, 249);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 53);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // tb_Person
            // 
            tb_Person.Enabled = false;
            tb_Person.Location = new Point(260, 263);
            tb_Person.Name = "tb_Person";
            tb_Person.Size = new Size(308, 27);
            tb_Person.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(260, 239);
            label3.Name = "label3";
            label3.Size = new Size(267, 21);
            label3.TabIndex = 6;
            label3.Text = "Pasta personalizada de Backup:";
            // 
            // rd_Default
            // 
            rd_Default.AutoSize = true;
            rd_Default.Location = new Point(284, 109);
            rd_Default.Name = "rd_Default";
            rd_Default.Size = new Size(114, 24);
            rd_Default.TabIndex = 9;
            rd_Default.TabStop = true;
            rd_Default.Text = "Pasta Padrão";
            rd_Default.UseVisualStyleBackColor = true;
            rd_Default.MouseClick += rd_Default_MouseClick;
            // 
            // rd_Person
            // 
            rd_Person.AutoSize = true;
            rd_Person.Location = new Point(404, 109);
            rd_Person.Name = "rd_Person";
            rd_Person.Size = new Size(191, 24);
            rd_Person.TabIndex = 10;
            rd_Person.TabStop = true;
            rd_Person.Text = "Pasta(s) Personalizada(s)";
            rd_Person.UseVisualStyleBackColor = true;
            rd_Person.MouseClick += rd_Person_MouseClick;
            // 
            // lb_Person
            // 
            lb_Person.FormattingEnabled = true;
            lb_Person.ItemHeight = 20;
            lb_Person.Location = new Point(235, 361);
            lb_Person.Name = "lb_Person";
            lb_Person.Size = new Size(333, 244);
            lb_Person.TabIndex = 11;
            // 
            // btn_Config_Cloud
            // 
            btn_Config_Cloud.Location = new Point(339, 611);
            btn_Config_Cloud.Name = "btn_Config_Cloud";
            btn_Config_Cloud.Size = new Size(189, 38);
            btn_Config_Cloud.TabIndex = 12;
            btn_Config_Cloud.Text = "Configurar Nuvem";
            btn_Config_Cloud.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Location = new Point(464, 296);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(103, 34);
            btn_Salvar.TabIndex = 13;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = true;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // btn_BackpComp
            // 
            btn_BackpComp.Location = new Point(574, 484);
            btn_BackpComp.Name = "btn_BackpComp";
            btn_BackpComp.Size = new Size(158, 34);
            btn_BackpComp.TabIndex = 14;
            btn_BackpComp.Text = "Backup Completo";
            btn_BackpComp.UseVisualStyleBackColor = true;
            // 
            // btn_BackupDiferencial
            // 
            btn_BackupDiferencial.Location = new Point(574, 524);
            btn_BackupDiferencial.Name = "btn_BackupDiferencial";
            btn_BackupDiferencial.Size = new Size(158, 34);
            btn_BackupDiferencial.TabIndex = 15;
            btn_BackupDiferencial.Text = "Backup Diferencial";
            btn_BackupDiferencial.UseVisualStyleBackColor = true;
            // 
            // btn_rmdir
            // 
            btn_rmdir.Location = new Point(574, 404);
            btn_rmdir.Name = "btn_rmdir";
            btn_rmdir.Size = new Size(158, 34);
            btn_rmdir.TabIndex = 16;
            btn_rmdir.Text = "Remover Diretórios";
            btn_rmdir.UseVisualStyleBackColor = true;
            // 
            // btn_mkdir
            // 
            btn_mkdir.Location = new Point(574, 364);
            btn_mkdir.Name = "btn_mkdir";
            btn_mkdir.Size = new Size(158, 34);
            btn_mkdir.TabIndex = 17;
            btn_mkdir.Text = "Adicionar Diretórios";
            btn_mkdir.UseVisualStyleBackColor = true;
            btn_mkdir.Click += btn_mkdir_Click;
            // 
            // btn_Verificar
            // 
            btn_Verificar.Location = new Point(574, 564);
            btn_Verificar.Name = "btn_Verificar";
            btn_Verificar.Size = new Size(158, 34);
            btn_Verificar.TabIndex = 18;
            btn_Verificar.Text = "Verificar Informações";
            btn_Verificar.UseVisualStyleBackColor = true;
            // 
            // btn_Save_Directory
            // 
            btn_Save_Directory.Location = new Point(574, 444);
            btn_Save_Directory.Name = "btn_Save_Directory";
            btn_Save_Directory.Size = new Size(158, 34);
            btn_Save_Directory.TabIndex = 19;
            btn_Save_Directory.Text = "Salvar Diretórios";
            btn_Save_Directory.UseVisualStyleBackColor = true;
            btn_Save_Directory.Click += btn_Save_Directory_Click;
            // 
            // Configurar_Bkp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 704);
            Controls.Add(btn_Save_Directory);
            Controls.Add(btn_Verificar);
            Controls.Add(btn_mkdir);
            Controls.Add(btn_rmdir);
            Controls.Add(btn_BackupDiferencial);
            Controls.Add(btn_BackpComp);
            Controls.Add(btn_Salvar);
            Controls.Add(btn_Config_Cloud);
            Controls.Add(lb_Person);
            Controls.Add(rd_Person);
            Controls.Add(rd_Default);
            Controls.Add(pictureBox2);
            Controls.Add(tb_Person);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Browser);
            Controls.Add(tb_Default);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Configurar_Bkp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurar Backup";
            Load += Configurar_Bkp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_Default;
        private Button btn_Browser;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox tb_Person;
        private Label label3;
        private RadioButton rd_Default;
        private RadioButton rd_Person;
        private ListBox lb_Person;
        private Button btn_Config_Cloud;
        private Button btn_Salvar;
        private Button btn_BackpComp;
        private Button btn_BackupDiferencial;
        private Button btn_rmdir;
        private Button btn_mkdir;
        private Button btn_Verificar;
        private Button btn_Save_Directory;
    }
}
namespace Nuotrauku_skirstytuvas
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.pasirinktiIsKur = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.isKurLangas = new System.Windows.Forms.TextBox();
            this.iKur = new System.Windows.Forms.TextBox();
            this.pasirinktiIKur = new System.Windows.Forms.Button();
            this.failuKiekisLangas = new System.Windows.Forms.TextBox();
            this.kopijuoti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "iskur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "į kur";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // pasirinktiIsKur
            // 
            this.pasirinktiIsKur.Location = new System.Drawing.Point(568, 55);
            this.pasirinktiIsKur.Name = "pasirinktiIsKur";
            this.pasirinktiIsKur.Size = new System.Drawing.Size(75, 23);
            this.pasirinktiIsKur.TabIndex = 1;
            this.pasirinktiIsKur.Text = "Pasirinkti";
            this.pasirinktiIsKur.UseVisualStyleBackColor = true;
            this.pasirinktiIsKur.Click += new System.EventHandler(this.pasirinktiIsKur_Click);
            // 
            // isKurLangas
            // 
            this.isKurLangas.Location = new System.Drawing.Point(60, 55);
            this.isKurLangas.Name = "isKurLangas";
            this.isKurLangas.Size = new System.Drawing.Size(409, 20);
            this.isKurLangas.TabIndex = 2;
            // 
            // iKur
            // 
            this.iKur.Location = new System.Drawing.Point(60, 221);
            this.iKur.Name = "iKur";
            this.iKur.Size = new System.Drawing.Size(409, 20);
            this.iKur.TabIndex = 2;
            // 
            // pasirinktiIKur
            // 
            this.pasirinktiIKur.Location = new System.Drawing.Point(568, 221);
            this.pasirinktiIKur.Name = "pasirinktiIKur";
            this.pasirinktiIKur.Size = new System.Drawing.Size(75, 23);
            this.pasirinktiIKur.TabIndex = 1;
            this.pasirinktiIKur.Text = "Pasirinkti";
            this.pasirinktiIKur.UseVisualStyleBackColor = true;
            this.pasirinktiIKur.Click += new System.EventHandler(this.pasirinktiIKur_Click);
            // 
            // failuKiekisLangas
            // 
            this.failuKiekisLangas.Location = new System.Drawing.Point(60, 92);
            this.failuKiekisLangas.Multiline = true;
            this.failuKiekisLangas.Name = "failuKiekisLangas";
            this.failuKiekisLangas.Size = new System.Drawing.Size(409, 70);
            this.failuKiekisLangas.TabIndex = 3;
            // 
            // kopijuoti
            // 
            this.kopijuoti.Location = new System.Drawing.Point(325, 340);
            this.kopijuoti.Name = "kopijuoti";
            this.kopijuoti.Size = new System.Drawing.Size(75, 23);
            this.kopijuoti.TabIndex = 4;
            this.kopijuoti.Text = "Kopijuoti";
            this.kopijuoti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kopijuoti.UseVisualStyleBackColor = true;
            this.kopijuoti.Click += new System.EventHandler(this.kopijuoti_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(730, 406);
            this.Controls.Add(this.kopijuoti);
            this.Controls.Add(this.failuKiekisLangas);
            this.Controls.Add(this.iKur);
            this.Controls.Add(this.isKurLangas);
            this.Controls.Add(this.pasirinktiIKur);
            this.Controls.Add(this.pasirinktiIsKur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button pasirinktiIsKur;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox isKurLangas;
        private System.Windows.Forms.TextBox iKur;
        private System.Windows.Forms.Button pasirinktiIKur;
        private System.Windows.Forms.TextBox failuKiekisLangas;
        private System.Windows.Forms.Button kopijuoti;
    }
}


namespace Manga_Combine
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FBDSelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectFolderFrom = new System.Windows.Forms.Button();
            this.btnSelectFolderTo = new System.Windows.Forms.Button();
            this.tbAddrFrom = new System.Windows.Forms.TextBox();
            this.tbAddrTo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FBDSelectFolder
            // 
            this.FBDSelectFolder.ShowNewFolderButton = false;
            // 
            // btnSelectFolderFrom
            // 
            this.btnSelectFolderFrom.Location = new System.Drawing.Point(12, 12);
            this.btnSelectFolderFrom.Name = "btnSelectFolderFrom";
            this.btnSelectFolderFrom.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolderFrom.TabIndex = 0;
            this.btnSelectFolderFrom.Text = "Откуда";
            this.btnSelectFolderFrom.UseVisualStyleBackColor = true;
            this.btnSelectFolderFrom.Click += new System.EventHandler(this.btnSelectFolderFrom_Click);
            // 
            // btnSelectFolderTo
            // 
            this.btnSelectFolderTo.Location = new System.Drawing.Point(12, 41);
            this.btnSelectFolderTo.Name = "btnSelectFolderTo";
            this.btnSelectFolderTo.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolderTo.TabIndex = 1;
            this.btnSelectFolderTo.Text = "Куда";
            this.btnSelectFolderTo.UseVisualStyleBackColor = true;
            this.btnSelectFolderTo.Click += new System.EventHandler(this.btnSelectFolderTo_Click);
            // 
            // tbAddrFrom
            // 
            this.tbAddrFrom.Location = new System.Drawing.Point(93, 14);
            this.tbAddrFrom.Name = "tbAddrFrom";
            this.tbAddrFrom.Size = new System.Drawing.Size(314, 20);
            this.tbAddrFrom.TabIndex = 2;
            // 
            // tbAddrTo
            // 
            this.tbAddrTo.Location = new System.Drawing.Point(92, 44);
            this.tbAddrTo.Name = "tbAddrTo";
            this.tbAddrTo.Size = new System.Drawing.Size(314, 20);
            this.tbAddrTo.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbAddrTo);
            this.Controls.Add(this.tbAddrFrom);
            this.Controls.Add(this.btnSelectFolderTo);
            this.Controls.Add(this.btnSelectFolderFrom);
            this.Name = "MainForm";
            this.Text = "Manga_Combine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FBDSelectFolder;
        private System.Windows.Forms.Button btnSelectFolderFrom;
        private System.Windows.Forms.Button btnSelectFolderTo;
        private System.Windows.Forms.TextBox tbAddrFrom;
        private System.Windows.Forms.TextBox tbAddrTo;
    }
}


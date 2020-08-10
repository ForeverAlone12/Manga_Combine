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
            this.btnPrepareFolders = new System.Windows.Forms.Button();
            this.tbVolumeName = new System.Windows.Forms.TextBox();
            this.tbPartName = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbCreditsName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FBDSelectFolder
            // 
            this.FBDSelectFolder.SelectedPath = "F:\\Desktop\\Манга\\Извращенка со вторым размером - копия";
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
            this.tbAddrFrom.Location = new System.Drawing.Point(93, 13);
            this.tbAddrFrom.Name = "tbAddrFrom";
            this.tbAddrFrom.Size = new System.Drawing.Size(314, 20);
            this.tbAddrFrom.TabIndex = 2;
            // 
            // tbAddrTo
            // 
            this.tbAddrTo.Location = new System.Drawing.Point(92, 42);
            this.tbAddrTo.Name = "tbAddrTo";
            this.tbAddrTo.Size = new System.Drawing.Size(314, 20);
            this.tbAddrTo.TabIndex = 3;
            // 
            // btnPrepareFolders
            // 
            this.btnPrepareFolders.Location = new System.Drawing.Point(12, 70);
            this.btnPrepareFolders.Name = "btnPrepareFolders";
            this.btnPrepareFolders.Size = new System.Drawing.Size(90, 23);
            this.btnPrepareFolders.TabIndex = 4;
            this.btnPrepareFolders.Text = "Подготовить";
            this.btnPrepareFolders.UseVisualStyleBackColor = true;
            this.btnPrepareFolders.Click += new System.EventHandler(this.btnPrepareFolders_Click);
            // 
            // tbVolumeName
            // 
            this.tbVolumeName.Location = new System.Drawing.Point(413, 13);
            this.tbVolumeName.Name = "tbVolumeName";
            this.tbVolumeName.Size = new System.Drawing.Size(100, 20);
            this.tbVolumeName.TabIndex = 5;
            this.tbVolumeName.Text = "Том";
            this.tbVolumeName.TextChanged += new System.EventHandler(this.tbVolumeName_TextChanged);
            // 
            // tbPartName
            // 
            this.tbPartName.Location = new System.Drawing.Point(412, 42);
            this.tbPartName.Name = "tbPartName";
            this.tbPartName.Size = new System.Drawing.Size(100, 20);
            this.tbPartName.TabIndex = 6;
            this.tbPartName.Text = "Глава";
            this.tbPartName.TextChanged += new System.EventHandler(this.tbPartName_TextChanged);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(12, 99);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(90, 23);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "Переместить";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbCreditsName
            // 
            this.tbCreditsName.Location = new System.Drawing.Point(519, 12);
            this.tbCreditsName.Name = "tbCreditsName";
            this.tbCreditsName.Size = new System.Drawing.Size(100, 20);
            this.tbCreditsName.TabIndex = 8;
            this.tbCreditsName.Text = "9999.jpg";
            this.tbCreditsName.TextChanged += new System.EventHandler(this.tbCreditsName_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCreditsName);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tbPartName);
            this.Controls.Add(this.tbVolumeName);
            this.Controls.Add(this.btnPrepareFolders);
            this.Controls.Add(this.tbAddrTo);
            this.Controls.Add(this.tbAddrFrom);
            this.Controls.Add(this.btnSelectFolderTo);
            this.Controls.Add(this.btnSelectFolderFrom);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnPrepareFolders;
        private System.Windows.Forms.TextBox tbVolumeName;
        private System.Windows.Forms.TextBox tbPartName;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbCreditsName;
    }
}


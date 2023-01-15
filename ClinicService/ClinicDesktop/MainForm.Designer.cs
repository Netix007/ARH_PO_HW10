namespace ClinicDesktop
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
            this.ListViewClients = new System.Windows.Forms.ListView();
            this.ButtonLoadClients = new System.Windows.Forms.Button();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPatronymic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListViewClients
            // 
            this.ListViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderSurname,
            this.columnHeaderFirstname,
            this.columnHeaderPatronymic});
            this.ListViewClients.FullRowSelect = true;
            this.ListViewClients.GridLines = true;
            this.ListViewClients.HideSelection = false;
            this.ListViewClients.Location = new System.Drawing.Point(12, 12);
            this.ListViewClients.MultiSelect = false;
            this.ListViewClients.Name = "ListViewClients";
            this.ListViewClients.Size = new System.Drawing.Size(778, 397);
            this.ListViewClients.TabIndex = 1;
            this.ListViewClients.UseCompatibleStateImageBehavior = false;
            this.ListViewClients.View = System.Windows.Forms.View.Details;
            // 
            // ButtonLoadClients
            // 
            this.ButtonLoadClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLoadClients.Location = new System.Drawing.Point(633, 422);
            this.ButtonLoadClients.Name = "ButtonLoadClients";
            this.ButtonLoadClients.Size = new System.Drawing.Size(157, 44);
            this.ButtonLoadClients.TabIndex = 2;
            this.ButtonLoadClients.Text = "Загрузить";
            this.ButtonLoadClients.UseVisualStyleBackColor = true;
            this.ButtonLoadClients.Click += new System.EventHandler(this.ButtonLoadClients_Click);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "#";
            // 
            // columnHeaderSurname
            // 
            this.columnHeaderSurname.Text = "Фамилия";
            this.columnHeaderSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSurname.Width = 200;
            // 
            // columnHeaderFirstname
            // 
            this.columnHeaderFirstname.Text = "Имя";
            this.columnHeaderFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderFirstname.Width = 200;
            // 
            // columnHeaderPatronymic
            // 
            this.columnHeaderPatronymic.Text = "Отчество";
            this.columnHeaderPatronymic.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(802, 478);
            this.Controls.Add(this.ButtonLoadClients);
            this.Controls.Add(this.ListViewClients);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моя клиника";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewClients;
        private System.Windows.Forms.Button ButtonLoadClients;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderSurname;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstname;
        private System.Windows.Forms.ColumnHeader columnHeaderPatronymic;
    }
}


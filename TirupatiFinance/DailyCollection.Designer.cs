namespace TirupatiFinance
{
    partial class DailyCollection
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
            this.tabPanelDailyCollection = new System.Windows.Forms.TabControl();
            this.tabDaily = new System.Windows.Forms.TabPage();
            this.dataGridDaily = new System.Windows.Forms.DataGridView();
            this.tabWeekly = new System.Windows.Forms.TabPage();
            this.dataGridWeekly = new System.Windows.Forms.DataGridView();
            this.tabMonthly = new System.Windows.Forms.TabPage();
            this.dataGridMonthly = new System.Windows.Forms.DataGridView();
            this.tabPanelDailyCollection.SuspendLayout();
            this.tabDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDaily)).BeginInit();
            this.tabWeekly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWeekly)).BeginInit();
            this.tabMonthly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonthly)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPanelDailyCollection
            // 
            this.tabPanelDailyCollection.Controls.Add(this.tabDaily);
            this.tabPanelDailyCollection.Controls.Add(this.tabWeekly);
            this.tabPanelDailyCollection.Controls.Add(this.tabMonthly);
            this.tabPanelDailyCollection.Location = new System.Drawing.Point(0, 0);
            this.tabPanelDailyCollection.Name = "tabPanelDailyCollection";
            this.tabPanelDailyCollection.SelectedIndex = 0;
            this.tabPanelDailyCollection.Size = new System.Drawing.Size(1500, 619);
            this.tabPanelDailyCollection.TabIndex = 0;
            this.tabPanelDailyCollection.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabPanelDailyCollection_Selected);
            // 
            // tabDaily
            // 
            this.tabDaily.Controls.Add(this.dataGridDaily);
            this.tabDaily.Location = new System.Drawing.Point(4, 29);
            this.tabDaily.Name = "tabDaily";
            this.tabDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tabDaily.Size = new System.Drawing.Size(1492, 586);
            this.tabDaily.TabIndex = 0;
            this.tabDaily.Text = "Daily";
            this.tabDaily.UseVisualStyleBackColor = true;
            // 
            // dataGridDaily
            // 
            this.dataGridDaily.AllowUserToAddRows = false;
            this.dataGridDaily.AllowUserToDeleteRows = false;
            this.dataGridDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDaily.Location = new System.Drawing.Point(0, 0);
            this.dataGridDaily.Name = "dataGridDaily";
            this.dataGridDaily.RowHeadersWidth = 62;
            this.dataGridDaily.RowTemplate.Height = 28;
            this.dataGridDaily.Size = new System.Drawing.Size(1492, 478);
            this.dataGridDaily.TabIndex = 0;
            // 
            // tabWeekly
            // 
            this.tabWeekly.Controls.Add(this.dataGridWeekly);
            this.tabWeekly.Location = new System.Drawing.Point(4, 29);
            this.tabWeekly.Name = "tabWeekly";
            this.tabWeekly.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeekly.Size = new System.Drawing.Size(1492, 586);
            this.tabWeekly.TabIndex = 1;
            this.tabWeekly.Text = "Weekly";
            this.tabWeekly.UseVisualStyleBackColor = true;
            // 
            // dataGridWeekly
            // 
            this.dataGridWeekly.AllowUserToAddRows = false;
            this.dataGridWeekly.AllowUserToDeleteRows = false;
            this.dataGridWeekly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWeekly.Location = new System.Drawing.Point(8, 8);
            this.dataGridWeekly.Name = "dataGridWeekly";
            this.dataGridWeekly.RowHeadersWidth = 62;
            this.dataGridWeekly.RowTemplate.Height = 28;
            this.dataGridWeekly.Size = new System.Drawing.Size(1458, 518);
            this.dataGridWeekly.TabIndex = 0;
            // 
            // tabMonthly
            // 
            this.tabMonthly.Controls.Add(this.dataGridMonthly);
            this.tabMonthly.Location = new System.Drawing.Point(4, 29);
            this.tabMonthly.Name = "tabMonthly";
            this.tabMonthly.Size = new System.Drawing.Size(1492, 586);
            this.tabMonthly.TabIndex = 2;
            this.tabMonthly.Text = "Monthly";
            this.tabMonthly.UseVisualStyleBackColor = true;
            // 
            // dataGridMonthly
            // 
            this.dataGridMonthly.AllowUserToAddRows = false;
            this.dataGridMonthly.AllowUserToDeleteRows = false;
            this.dataGridMonthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMonthly.Location = new System.Drawing.Point(8, 8);
            this.dataGridMonthly.Name = "dataGridMonthly";
            this.dataGridMonthly.RowHeadersWidth = 62;
            this.dataGridMonthly.RowTemplate.Height = 28;
            this.dataGridMonthly.Size = new System.Drawing.Size(1460, 535);
            this.dataGridMonthly.TabIndex = 0;
            // 
            // DailyCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 700);
            this.Controls.Add(this.tabPanelDailyCollection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DailyCollection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Collection";
            this.tabPanelDailyCollection.ResumeLayout(false);
            this.tabDaily.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDaily)).EndInit();
            this.tabWeekly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWeekly)).EndInit();
            this.tabMonthly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonthly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPanelDailyCollection;
        private System.Windows.Forms.TabPage tabDaily;
        private System.Windows.Forms.TabPage tabWeekly;
        private System.Windows.Forms.TabPage tabMonthly;
        private System.Windows.Forms.DataGridView dataGridDaily;
        private System.Windows.Forms.DataGridView dataGridWeekly;
        private System.Windows.Forms.DataGridView dataGridMonthly;
    }
}
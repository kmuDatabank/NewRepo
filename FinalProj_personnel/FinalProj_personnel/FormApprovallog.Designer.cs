namespace FinalProj_personnel
{
    partial class FormApprovallog
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
            this.dataGridViewappr_log = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewappr_log)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewappr_log
            // 
            this.dataGridViewappr_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewappr_log.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewappr_log.Name = "dataGridViewappr_log";
            this.dataGridViewappr_log.RowTemplate.Height = 23;
            this.dataGridViewappr_log.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewappr_log.TabIndex = 0;
            // 
            // FormApprovallog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewappr_log);
            this.Name = "FormApprovallog";
            this.Text = "결재 로그 확인";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewappr_log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewappr_log;
    }
}
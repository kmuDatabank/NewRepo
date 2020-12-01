namespace FinalProj_personnel
{
    partial class TMmodform
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_mod = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_modafter = new System.Windows.Forms.TextBox();
            this.textBox_modbefore = new System.Windows.Forms.TextBox();
            this.comboBox_modafter = new System.Windows.Forms.ComboBox();
            this.comboBox_modbefore = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_mod);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_modafter);
            this.groupBox2.Controls.Add(this.textBox_modbefore);
            this.groupBox2.Controls.Add(this.comboBox_modafter);
            this.groupBox2.Controls.Add(this.comboBox_modbefore);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 215);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "선택수정,";
            // 
            // button_mod
            // 
            this.button_mod.Location = new System.Drawing.Point(90, 175);
            this.button_mod.Name = "button_mod";
            this.button_mod.Size = new System.Drawing.Size(75, 23);
            this.button_mod.TabIndex = 14;
            this.button_mod.Text = "수정하기";
            this.button_mod.UseVisualStyleBackColor = true;
            this.button_mod.Click += new System.EventHandler(this.button_mod_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "변경뒤";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "변경전";
            // 
            // textBox_modafter
            // 
            this.textBox_modafter.Location = new System.Drawing.Point(145, 97);
            this.textBox_modafter.Multiline = true;
            this.textBox_modafter.Name = "textBox_modafter";
            this.textBox_modafter.Size = new System.Drawing.Size(121, 28);
            this.textBox_modafter.TabIndex = 5;
            // 
            // textBox_modbefore
            // 
            this.textBox_modbefore.Location = new System.Drawing.Point(6, 97);
            this.textBox_modbefore.Multiline = true;
            this.textBox_modbefore.Name = "textBox_modbefore";
            this.textBox_modbefore.Size = new System.Drawing.Size(99, 28);
            this.textBox_modbefore.TabIndex = 4;
            // 
            // comboBox_modafter
            // 
            this.comboBox_modafter.FormattingEnabled = true;
            this.comboBox_modafter.Items.AddRange(new object[] {
            "large_cate",
            "middle_cate",
            "small_cate"});
            this.comboBox_modafter.Location = new System.Drawing.Point(145, 50);
            this.comboBox_modafter.Name = "comboBox_modafter";
            this.comboBox_modafter.Size = new System.Drawing.Size(121, 20);
            this.comboBox_modafter.TabIndex = 3;
            // 
            // comboBox_modbefore
            // 
            this.comboBox_modbefore.FormattingEnabled = true;
            this.comboBox_modbefore.Items.AddRange(new object[] {
            "large_cate",
            "middle_cate",
            "small_cate"});
            this.comboBox_modbefore.Location = new System.Drawing.Point(6, 50);
            this.comboBox_modbefore.Name = "comboBox_modbefore";
            this.comboBox_modbefore.Size = new System.Drawing.Size(99, 20);
            this.comboBox_modbefore.TabIndex = 2;
            // 
            // TMmodform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 221);
            this.Controls.Add(this.groupBox2);
            this.Name = "TMmodform";
            this.Text = "수정하기";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_mod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_modafter;
        private System.Windows.Forms.TextBox textBox_modbefore;
        private System.Windows.Forms.ComboBox comboBox_modafter;
        private System.Windows.Forms.ComboBox comboBox_modbefore;
    }
}
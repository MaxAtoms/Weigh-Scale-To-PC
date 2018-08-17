namespace WeightMonitor
{
    partial class WeightMonitor
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComPortComboBox = new System.Windows.Forms.ComboBox();
            this.UnitComboBox = new System.Windows.Forms.ComboBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.TareButton = new System.Windows.Forms.Button();
            this.WeightOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComPortComboBox
            // 
            this.ComPortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPortComboBox.FormattingEnabled = true;
            this.ComPortComboBox.Location = new System.Drawing.Point(8, 135);
            this.ComPortComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ComPortComboBox.MaxDropDownItems = 10;
            this.ComPortComboBox.Name = "ComPortComboBox";
            this.ComPortComboBox.Size = new System.Drawing.Size(82, 21);
            this.ComPortComboBox.Sorted = true;
            this.ComPortComboBox.TabIndex = 1;
            this.ComPortComboBox.SelectedIndexChanged += new System.EventHandler(this.ComPortComboBox_SelectionChangeCommited);
            // 
            // UnitComboBox
            // 
            this.UnitComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitComboBox.FormattingEnabled = true;
            this.UnitComboBox.Items.AddRange(new object[] {
            "Kilogram",
            "Gram"});
            this.UnitComboBox.Location = new System.Drawing.Point(246, 135);
            this.UnitComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.UnitComboBox.Name = "UnitComboBox";
            this.UnitComboBox.Size = new System.Drawing.Size(82, 21);
            this.UnitComboBox.TabIndex = 4;
            this.UnitComboBox.SelectedIndexChanged += new System.EventHandler(this.UnitComboBox_SelectionChangeCommited);
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyButton.Location = new System.Drawing.Point(138, 135);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(2);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(50, 21);
            this.CopyButton.TabIndex = 5;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // TareButton
            // 
            this.TareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TareButton.Location = new System.Drawing.Point(192, 135);
            this.TareButton.Margin = new System.Windows.Forms.Padding(2);
            this.TareButton.Name = "TareButton";
            this.TareButton.Size = new System.Drawing.Size(50, 21);
            this.TareButton.TabIndex = 6;
            this.TareButton.Text = "Tare";
            this.TareButton.UseVisualStyleBackColor = true;
            this.TareButton.Click += new System.EventHandler(this.TareButton_Click);
            // 
            // WeightOutput
            // 
            this.WeightOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightOutput.AutoSize = true;
            this.WeightOutput.Location = new System.Drawing.Point(120, 54);
            this.WeightOutput.Name = "WeightOutput";
            this.WeightOutput.Size = new System.Drawing.Size(0, 13);
            this.WeightOutput.TabIndex = 7;
            this.WeightOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.WeightOutput);
            this.Controls.Add(this.TareButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.UnitComboBox);
            this.Controls.Add(this.ComPortComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeightMonitor";
            this.Text = "WeightMonitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComPortComboBox;
        private System.Windows.Forms.ComboBox UnitComboBox;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button TareButton;
        private System.Windows.Forms.Label WeightOutput;
    }
}


namespace MegaDesk_Warner
{
    partial class DisplayQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayQuote));
            widthLabel = new Label();
            rushDaysLabel = new Label();
            materialLabel = new Label();
            drawersLabel = new Label();
            depthLabel = new Label();
            costLabel = new Label();
            label1 = new Label();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(302, 162);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(60, 25);
            widthLabel.TabIndex = 0;
            widthLabel.Text = "Width";
            // 
            // rushDaysLabel
            // 
            rushDaysLabel.AutoSize = true;
            rushDaysLabel.Location = new Point(302, 440);
            rushDaysLabel.Name = "rushDaysLabel";
            rushDaysLabel.Size = new Size(95, 25);
            rushDaysLabel.TabIndex = 4;
            rushDaysLabel.Text = "Rush Days";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new Point(302, 367);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(75, 25);
            materialLabel.TabIndex = 5;
            materialLabel.Text = "Material";
            // 
            // drawersLabel
            // 
            drawersLabel.AutoSize = true;
            drawersLabel.Location = new Point(302, 292);
            drawersLabel.Name = "drawersLabel";
            drawersLabel.Size = new Size(76, 25);
            drawersLabel.TabIndex = 6;
            drawersLabel.Text = "Drawers";
            // 
            // depthLabel
            // 
            depthLabel.AutoSize = true;
            depthLabel.Location = new Point(302, 224);
            depthLabel.Name = "depthLabel";
            depthLabel.Size = new Size(61, 25);
            depthLabel.TabIndex = 7;
            depthLabel.Text = "Depth";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(302, 516);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(90, 25);
            costLabel.TabIndex = 8;
            costLabel.Text = "Total Cost";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(236, 52);
            label1.Name = "label1";
            label1.Size = new Size(315, 41);
            label1.TabIndex = 9;
            label1.Text = "Success! Quote added";
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(632, 696);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(112, 34);
            closeBtn.TabIndex = 10;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // DisplayQuote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 783);
            Controls.Add(closeBtn);
            Controls.Add(label1);
            Controls.Add(costLabel);
            Controls.Add(depthLabel);
            Controls.Add(drawersLabel);
            Controls.Add(materialLabel);
            Controls.Add(rushDaysLabel);
            Controls.Add(widthLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DisplayQuote";
            Text = "DisplayQuote";
            Load += DisplayQuote_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label widthLabel;
        private Label rushDaysLabel;
        private Label materialLabel;
        private Label drawersLabel;
        private Label depthLabel;
        private Label costLabel;
        private Label label1;
        private Button closeBtn;
    }
}
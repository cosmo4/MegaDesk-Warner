namespace MegaDesk_Warner
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            CustomerNameTB = new TextBox();
            DeskWidth = new NumericUpDown();
            DeskDepth = new NumericUpDown();
            Drawers = new NumericUpDown();
            SurfaceMaterial = new ComboBox();
            RushOrderOptions = new ComboBox();
            SubmitNewQuote = new Button();
            ((System.ComponentModel.ISupportInitialize)DeskWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeskDepth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Drawers).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(682, 642);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 82);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 1;
            label1.Text = "Customer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 144);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 2;
            label2.Text = "Desk Width:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 210);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 3;
            label3.Text = "Desk Depth:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 274);
            label4.Name = "label4";
            label4.Size = new Size(172, 25);
            label4.TabIndex = 4;
            label4.Text = "Number of Drawers:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 341);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 5;
            label5.Text = "Surface Material:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 410);
            label6.Name = "label6";
            label6.Size = new Size(171, 25);
            label6.TabIndex = 6;
            label6.Text = "Rush Order Options";
            // 
            // CustomerNameTB
            // 
            CustomerNameTB.Location = new Point(255, 79);
            CustomerNameTB.MaxLength = 100;
            CustomerNameTB.Name = "CustomerNameTB";
            CustomerNameTB.Size = new Size(330, 31);
            CustomerNameTB.TabIndex = 7;
            // 
            // DeskWidth
            // 
            DeskWidth.Location = new Point(255, 144);
            DeskWidth.Name = "DeskWidth";
            DeskWidth.Size = new Size(130, 31);
            DeskWidth.TabIndex = 8;
            DeskWidth.Validating += DeskWidth_Validating;
            // 
            // DeskDepth
            // 
            DeskDepth.Location = new Point(255, 210);
            DeskDepth.Name = "DeskDepth";
            DeskDepth.Size = new Size(130, 31);
            DeskDepth.TabIndex = 9;
            DeskDepth.Validating += DeskDepth_Validating;
            // 
            // Drawers
            // 
            Drawers.Location = new Point(255, 274);
            Drawers.Name = "Drawers";
            Drawers.Size = new Size(130, 31);
            Drawers.TabIndex = 10;
            Drawers.Validating += Drawers_Validating;
            // 
            // SurfaceMaterial
            // 
            SurfaceMaterial.FormattingEnabled = true;
            SurfaceMaterial.Items.AddRange(new object[] { "Oak", "Laminate", "Pine", "Rosewood", "Veneer" });
            SurfaceMaterial.Location = new Point(255, 341);
            SurfaceMaterial.MaxDropDownItems = 4;
            SurfaceMaterial.Name = "SurfaceMaterial";
            SurfaceMaterial.Size = new Size(182, 33);
            SurfaceMaterial.TabIndex = 11;
            SurfaceMaterial.Text = "Choose";
            // 
            // RushOrderOptions
            // 
            RushOrderOptions.FormattingEnabled = true;
            RushOrderOptions.Items.AddRange(new object[] { "3 Day", "5 Day", "7 Day" });
            RushOrderOptions.Location = new Point(255, 410);
            RushOrderOptions.Name = "RushOrderOptions";
            RushOrderOptions.Size = new Size(182, 33);
            RushOrderOptions.TabIndex = 12;
            RushOrderOptions.Text = "Choose";
            // 
            // SubmitNewQuote
            // 
            SubmitNewQuote.Location = new Point(255, 498);
            SubmitNewQuote.Name = "SubmitNewQuote";
            SubmitNewQuote.Size = new Size(144, 59);
            SubmitNewQuote.TabIndex = 13;
            SubmitNewQuote.Text = "Add Quote";
            SubmitNewQuote.UseVisualStyleBackColor = true;
            SubmitNewQuote.Click += SubmitNewQuote_Click;
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button1;
            ClientSize = new Size(874, 740);
            Controls.Add(SubmitNewQuote);
            Controls.Add(RushOrderOptions);
            Controls.Add(SurfaceMaterial);
            Controls.Add(Drawers);
            Controls.Add(DeskDepth);
            Controls.Add(DeskWidth);
            Controls.Add(CustomerNameTB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddQuote";
            Text = "Add New Quote";
            ((System.ComponentModel.ISupportInitialize)DeskWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeskDepth).EndInit();
            ((System.ComponentModel.ISupportInitialize)Drawers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox CustomerNameTB;
        private NumericUpDown DeskWidth;
        private NumericUpDown DeskDepth;
        private NumericUpDown Drawers;
        private ComboBox SurfaceMaterial;
        private ComboBox RushOrderOptions;
        private Button SubmitNewQuote;
    }
}
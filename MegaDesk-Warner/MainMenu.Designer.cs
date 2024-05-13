namespace MegaDesk_Warner
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            NewQuoteBtn = new Button();
            SearchQuoteBtn = new Button();
            ViewQuoteBtn = new Button();
            ExitBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NewQuoteBtn
            // 
            NewQuoteBtn.Location = new Point(134, 83);
            NewQuoteBtn.Name = "NewQuoteBtn";
            NewQuoteBtn.Size = new Size(157, 73);
            NewQuoteBtn.TabIndex = 0;
            NewQuoteBtn.Text = "Add New Quote";
            NewQuoteBtn.UseVisualStyleBackColor = true;
            NewQuoteBtn.Click += NewQuoteBtn_Click;
            // 
            // SearchQuoteBtn
            // 
            SearchQuoteBtn.Location = new Point(134, 304);
            SearchQuoteBtn.Name = "SearchQuoteBtn";
            SearchQuoteBtn.Size = new Size(157, 73);
            SearchQuoteBtn.TabIndex = 1;
            SearchQuoteBtn.Text = "Search Quotes";
            SearchQuoteBtn.UseVisualStyleBackColor = true;
            // 
            // ViewQuoteBtn
            // 
            ViewQuoteBtn.Location = new Point(134, 191);
            ViewQuoteBtn.Name = "ViewQuoteBtn";
            ViewQuoteBtn.Size = new Size(157, 79);
            ViewQuoteBtn.TabIndex = 2;
            ViewQuoteBtn.Text = "View Quotes";
            ViewQuoteBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(134, 415);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(157, 73);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(448, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 267);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 585);
            Controls.Add(pictureBox1);
            Controls.Add(ExitBtn);
            Controls.Add(ViewQuoteBtn);
            Controls.Add(SearchQuoteBtn);
            Controls.Add(NewQuoteBtn);
            Name = "MainMenu";
            Text = "MegaDesk-Warner";
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button NewQuoteBtn;
        private Button SearchQuoteBtn;
        private Button ViewQuoteBtn;
        private Button ExitBtn;
        private PictureBox pictureBox1;
    }
}

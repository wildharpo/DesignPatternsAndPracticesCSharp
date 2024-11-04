namespace DesignPatterns.GUI
{
    partial class Form1
    {
        private System.Windows.Forms.NativeWindow _window;
        private System.Windows.Forms.ScrollBar _scrollBar;

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
            CreateMotifScrollbarButton = new Button();
            CreatePmScrollbarButton = new Button();
            VerticalScrollBar = new VScrollBar();
            SuspendLayout();
            // 
            // CreateMotifScrollbarButton
            // 
            CreateMotifScrollbarButton.Location = new Point(22, 17);
            CreateMotifScrollbarButton.Name = "CreateMotifScrollbarButton";
            CreateMotifScrollbarButton.Size = new Size(150, 29);
            CreateMotifScrollbarButton.TabIndex = 0;
            CreateMotifScrollbarButton.Text = "Create Motif Scrollbar";
            CreateMotifScrollbarButton.UseVisualStyleBackColor = true;
            CreateMotifScrollbarButton.Click += CreateMotifScrollbarButton_Click;
            // 
            // CreatePmScrollbarButton
            // 
            CreatePmScrollbarButton.Location = new Point(22, 63);
            CreatePmScrollbarButton.Name = "CreatePmScrollbarButton";
            CreatePmScrollbarButton.Size = new Size(150, 28);
            CreatePmScrollbarButton.TabIndex = 1;
            CreatePmScrollbarButton.Text = "Create PM Scrollbar";
            CreatePmScrollbarButton.UseVisualStyleBackColor = true;
            CreatePmScrollbarButton.Click += CreatePmScrollbarButton_Click;
            // 
            // VerticalScrollBar
            // 
            VerticalScrollBar.Location = new Point(219, 17);
            VerticalScrollBar.Name = "VerticalScrollBar";
            VerticalScrollBar.Size = new Size(32, 211);
            VerticalScrollBar.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VerticalScrollBar);
            Controls.Add(CreatePmScrollbarButton);
            Controls.Add(CreateMotifScrollbarButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CreateMotifScrollbarButton;
        private Button CreatePmScrollbarButton;
        public VScrollBar VerticalScrollBar;
    }
}

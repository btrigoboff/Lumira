
namespace Amiratest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.devicesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.abortTestButton = new System.Windows.Forms.Button();
            this.viewTestDataButton = new System.Windows.Forms.Button();
            this.viewTestProgressButton = new System.Windows.Forms.Button();
            this.panelTestButton = new System.Windows.Forms.Button();
            this.singleTestButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.leftPanel.Controls.Add(this.aboutButton);
            this.leftPanel.Controls.Add(this.devicesButton);
            this.leftPanel.Controls.Add(this.exitButton);
            this.leftPanel.Controls.Add(this.abortTestButton);
            this.leftPanel.Controls.Add(this.viewTestDataButton);
            this.leftPanel.Controls.Add(this.viewTestProgressButton);
            this.leftPanel.Controls.Add(this.panelTestButton);
            this.leftPanel.Controls.Add(this.singleTestButton);
            this.leftPanel.Controls.Add(this.logoPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(246, 827);
            this.leftPanel.TabIndex = 0;
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // aboutButton
            // 
            this.aboutButton.AutoSize = true;
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aboutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aboutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.aboutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.Location = new System.Drawing.Point(2, 472);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(244, 60);
            this.aboutButton.TabIndex = 20;
            this.aboutButton.Text = "About";
            this.aboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aboutButton.UseVisualStyleBackColor = false;
            // 
            // devicesButton
            // 
            this.devicesButton.AutoSize = true;
            this.devicesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.devicesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.devicesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.devicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devicesButton.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.devicesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.devicesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.devicesButton.Location = new System.Drawing.Point(0, 412);
            this.devicesButton.Name = "devicesButton";
            this.devicesButton.Size = new System.Drawing.Size(246, 60);
            this.devicesButton.TabIndex = 19;
            this.devicesButton.Text = "Devices";
            this.devicesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.devicesButton.UseCompatibleTextRendering = true;
            this.devicesButton.UseVisualStyleBackColor = false;
            this.devicesButton.Click += new System.EventHandler(this.devicesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(0, 532);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(246, 60);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit ";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // abortTestButton
            // 
            this.abortTestButton.AutoSize = true;
            this.abortTestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.abortTestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.abortTestButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.abortTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abortTestButton.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.abortTestButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.abortTestButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abortTestButton.Location = new System.Drawing.Point(0, 358);
            this.abortTestButton.Name = "abortTestButton";
            this.abortTestButton.Size = new System.Drawing.Size(246, 60);
            this.abortTestButton.TabIndex = 16;
            this.abortTestButton.Text = "Abort Test";
            this.abortTestButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.abortTestButton.UseVisualStyleBackColor = false;
            this.abortTestButton.Click += new System.EventHandler(this.abortTestButton_Click);
            // 
            // viewTestDataButton
            // 
            this.viewTestDataButton.AutoSize = true;
            this.viewTestDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewTestDataButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewTestDataButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.viewTestDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTestDataButton.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.viewTestDataButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewTestDataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewTestDataButton.Location = new System.Drawing.Point(0, 298);
            this.viewTestDataButton.Name = "viewTestDataButton";
            this.viewTestDataButton.Size = new System.Drawing.Size(246, 60);
            this.viewTestDataButton.TabIndex = 15;
            this.viewTestDataButton.Text = "View Test Data";
            this.viewTestDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewTestDataButton.UseVisualStyleBackColor = false;
            this.viewTestDataButton.Click += new System.EventHandler(this.viewTestDataButton_Click);
            // 
            // viewTestProgressButton
            // 
            this.viewTestProgressButton.AutoSize = true;
            this.viewTestProgressButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewTestProgressButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewTestProgressButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.viewTestProgressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTestProgressButton.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.viewTestProgressButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewTestProgressButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewTestProgressButton.Location = new System.Drawing.Point(0, 238);
            this.viewTestProgressButton.Name = "viewTestProgressButton";
            this.viewTestProgressButton.Size = new System.Drawing.Size(246, 60);
            this.viewTestProgressButton.TabIndex = 14;
            this.viewTestProgressButton.Text = "View Test Progress";
            this.viewTestProgressButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewTestProgressButton.UseVisualStyleBackColor = false;
            this.viewTestProgressButton.Click += new System.EventHandler(this.viewTestResultsButton_Click);
            // 
            // panelTestButton
            // 
            this.panelTestButton.AutoSize = true;
            this.panelTestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTestButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.panelTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelTestButton.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.panelTestButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTestButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelTestButton.Location = new System.Drawing.Point(0, 118);
            this.panelTestButton.Name = "panelTestButton";
            this.panelTestButton.Size = new System.Drawing.Size(246, 60);
            this.panelTestButton.TabIndex = 6;
            this.panelTestButton.Text = "Full Panel Test";
            this.panelTestButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.panelTestButton.UseVisualStyleBackColor = false;
            this.panelTestButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // singleTestButton
            // 
            this.singleTestButton.AutoSize = true;
            this.singleTestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.singleTestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.singleTestButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.singleTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singleTestButton.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.singleTestButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.singleTestButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.singleTestButton.Location = new System.Drawing.Point(0, 178);
            this.singleTestButton.Name = "singleTestButton";
            this.singleTestButton.Size = new System.Drawing.Size(246, 60);
            this.singleTestButton.TabIndex = 13;
            this.singleTestButton.Text = "Single Board Test";
            this.singleTestButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.singleTestButton.UseVisualStyleBackColor = false;
            this.singleTestButton.Click += new System.EventHandler(this.testSetupButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(246, 117);
            this.logoPanel.TabIndex = 12;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.headerPanel.Location = new System.Drawing.Point(246, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1604, 117);
            this.headerPanel.TabIndex = 9;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(19, 38);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(481, 38);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Amiratest Functional Test Suite";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(246, 117);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1604, 710);
            this.mainPanel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1850, 827);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.leftPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amiratest Start";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel leftPanel;   
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button panelTestButton;
        private System.Windows.Forms.Button singleTestButton;
        private System.Windows.Forms.Button viewTestProgressButton;
        private System.Windows.Forms.Button viewTestDataButton;
        private System.Windows.Forms.Button devicesButton;
        private System.Windows.Forms.Button abortTestButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button exitButton;

        
        
    }
}


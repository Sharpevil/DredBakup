namespace DredBakup
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
            this.tbxSource = new System.Windows.Forms.TextBox();
            this.tbxDestination = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAutoStart = new System.Windows.Forms.Button();
            this.btnAutoStop = new System.Windows.Forms.Button();
            this.btnBakNow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnNuke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSource
            // 
            this.tbxSource.Location = new System.Drawing.Point(12, 39);
            this.tbxSource.Name = "tbxSource";
            this.tbxSource.Size = new System.Drawing.Size(292, 20);
            this.tbxSource.TabIndex = 0;
            // 
            // tbxDestination
            // 
            this.tbxDestination.Location = new System.Drawing.Point(12, 78);
            this.tbxDestination.Name = "tbxDestination";
            this.tbxDestination.Size = new System.Drawing.Size(292, 20);
            this.tbxDestination.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Backup Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAutoStart
            // 
            this.btnAutoStart.Location = new System.Drawing.Point(12, 236);
            this.btnAutoStart.Name = "btnAutoStart";
            this.btnAutoStart.Size = new System.Drawing.Size(394, 52);
            this.btnAutoStart.TabIndex = 5;
            this.btnAutoStart.Text = "Start Automatic Backup";
            this.btnAutoStart.UseVisualStyleBackColor = true;
            this.btnAutoStart.Click += new System.EventHandler(this.btnAutoStart_Click);
            // 
            // btnAutoStop
            // 
            this.btnAutoStop.Location = new System.Drawing.Point(12, 294);
            this.btnAutoStop.Name = "btnAutoStop";
            this.btnAutoStop.Size = new System.Drawing.Size(394, 52);
            this.btnAutoStop.TabIndex = 6;
            this.btnAutoStop.Text = "End Automatic Backup";
            this.btnAutoStop.UseVisualStyleBackColor = true;
            this.btnAutoStop.Click += new System.EventHandler(this.btnAutoStop_Click);
            // 
            // btnBakNow
            // 
            this.btnBakNow.Location = new System.Drawing.Point(12, 352);
            this.btnBakNow.Name = "btnBakNow";
            this.btnBakNow.Size = new System.Drawing.Size(394, 37);
            this.btnBakNow.TabIndex = 7;
            this.btnBakNow.Text = "Backup Now";
            this.btnBakNow.UseVisualStyleBackColor = true;
            this.btnBakNow.Click += new System.EventHandler(this.btnBakNow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(124, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Backup every";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(157, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "minutes";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(163, 163);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(103, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnNuke
            // 
            this.btnNuke.BackColor = System.Drawing.Color.Maroon;
            this.btnNuke.Font = new System.Drawing.Font("Mars Needs Cunnilingus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuke.ForeColor = System.Drawing.Color.Yellow;
            this.btnNuke.Location = new System.Drawing.Point(12, 395);
            this.btnNuke.Name = "btnNuke";
            this.btnNuke.Size = new System.Drawing.Size(394, 37);
            this.btnNuke.TabIndex = 11;
            this.btnNuke.Text = "NUKE THE DIGGLES";
            this.btnNuke.UseVisualStyleBackColor = false;
            this.btnNuke.Click += new System.EventHandler(this.btnNuke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(418, 438);
            this.Controls.Add(this.btnNuke);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBakNow);
            this.Controls.Add(this.btnAutoStop);
            this.Controls.Add(this.btnAutoStart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxDestination);
            this.Controls.Add(this.tbxSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dungeons of Dredmor Save Backup Tool";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxSource;
        private System.Windows.Forms.TextBox tbxDestination;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAutoStart;
        private System.Windows.Forms.Button btnAutoStop;
        private System.Windows.Forms.Button btnBakNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnNuke;
    }
}


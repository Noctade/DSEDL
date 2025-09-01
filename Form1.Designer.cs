namespace DSEDL
{
    partial class DefaultWindow
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultWindow));
            locationBrowse = new System.Windows.Forms.FolderBrowserDialog();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(14, 176);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(377, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(14, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(379, 30);
            label1.TabIndex = 1;
            label1.Text = "Discord Sticker and Emoji Downloader";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.Location = new System.Drawing.Point(14, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(407, 21);
            label2.TabIndex = 2;
            label2.Text = "Step 1: Select the type of emoticon you want to download";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(14, 92);
            radioButton1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(65, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Emoji";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(95, 92);
            radioButton2.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(71, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Sticker";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label3.Location = new System.Drawing.Point(14, 136);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(288, 21);
            label3.TabIndex = 5;
            label3.Text = "Step 2: Input the ID of the Emoji / Sticker";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label5.Location = new System.Drawing.Point(14, 224);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(136, 21);
            label5.TabIndex = 9;
            label5.Text = "Step 3: Download!";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(14, 264);
            button2.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(177, 44);
            button2.TabIndex = 10;
            button2.Text = "Download!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DefaultWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(560, 323);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            Location = new System.Drawing.Point(15, 15);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "DSEDL";
            Load += DefaultWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;

        #endregion

        private System.Windows.Forms.FolderBrowserDialog locationBrowse;
    }
}

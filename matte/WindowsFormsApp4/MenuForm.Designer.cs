namespace WindowsFormsApp4
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxDiv = new System.Windows.Forms.CheckBox();
            this.checkBoxMulti = new System.Windows.Forms.CheckBox();
            this.checkBoxMinus = new System.Windows.Forms.CheckBox();
            this.checkBoxPlus = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.trackBarLevel = new System.Windows.Forms.TrackBar();
            this.groupAntal = new System.Windows.Forms.GroupBox();
            this.lblAntal = new System.Windows.Forms.Label();
            this.trackBarAntal = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLevel)).BeginInit();
            this.groupAntal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAntal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxDiv);
            this.groupBox1.Controls.Add(this.checkBoxMulti);
            this.groupBox1.Controls.Add(this.checkBoxMinus);
            this.groupBox1.Controls.Add(this.checkBoxPlus);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(192, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Räknesätt";
            // 
            // checkBoxDiv
            // 
            this.checkBoxDiv.AutoSize = true;
            this.checkBoxDiv.Location = new System.Drawing.Point(16, 88);
            this.checkBoxDiv.Name = "checkBoxDiv";
            this.checkBoxDiv.Size = new System.Drawing.Size(63, 17);
            this.checkBoxDiv.TabIndex = 3;
            this.checkBoxDiv.Text = "Division";
            this.checkBoxDiv.UseVisualStyleBackColor = true;
            this.checkBoxDiv.CheckedChanged += new System.EventHandler(this.checkBoxDiv_CheckedChanged);
            // 
            // checkBoxMulti
            // 
            this.checkBoxMulti.AutoSize = true;
            this.checkBoxMulti.Location = new System.Drawing.Point(16, 65);
            this.checkBoxMulti.Name = "checkBoxMulti";
            this.checkBoxMulti.Size = new System.Drawing.Size(87, 17);
            this.checkBoxMulti.TabIndex = 2;
            this.checkBoxMulti.Text = "Multiplikation";
            this.checkBoxMulti.UseVisualStyleBackColor = true;
            this.checkBoxMulti.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxMinus
            // 
            this.checkBoxMinus.AutoSize = true;
            this.checkBoxMinus.Location = new System.Drawing.Point(16, 42);
            this.checkBoxMinus.Name = "checkBoxMinus";
            this.checkBoxMinus.Size = new System.Drawing.Size(80, 17);
            this.checkBoxMinus.TabIndex = 1;
            this.checkBoxMinus.Text = "Subtraktion";
            this.checkBoxMinus.UseVisualStyleBackColor = true;
            this.checkBoxMinus.CheckedChanged += new System.EventHandler(this.checkBoxMinus_CheckedChanged);
            // 
            // checkBoxPlus
            // 
            this.checkBoxPlus.AutoSize = true;
            this.checkBoxPlus.Checked = true;
            this.checkBoxPlus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPlus.Location = new System.Drawing.Point(16, 19);
            this.checkBoxPlus.Name = "checkBoxPlus";
            this.checkBoxPlus.Size = new System.Drawing.Size(67, 17);
            this.checkBoxPlus.TabIndex = 0;
            this.checkBoxPlus.Text = "Addition ";
            this.checkBoxPlus.UseVisualStyleBackColor = true;
            this.checkBoxPlus.CheckedChanged += new System.EventHandler(this.checkBoxPlus_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(19, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Starta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "AlvLins Matte";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLevel);
            this.groupBox2.Controls.Add(this.trackBarLevel);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(192, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 69);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nivå";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(91, 16);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 37);
            this.lblLevel.TabIndex = 12;
            this.lblLevel.Text = "1";
            // 
            // trackBarLevel
            // 
            this.trackBarLevel.Location = new System.Drawing.Point(6, 20);
            this.trackBarLevel.Minimum = 1;
            this.trackBarLevel.Name = "trackBarLevel";
            this.trackBarLevel.Size = new System.Drawing.Size(87, 45);
            this.trackBarLevel.TabIndex = 11;
            this.trackBarLevel.Value = 1;
            this.trackBarLevel.Scroll += new System.EventHandler(this.trackBarLevel_Scroll);
            // 
            // groupAntal
            // 
            this.groupAntal.Controls.Add(this.lblAntal);
            this.groupAntal.Controls.Add(this.trackBarAntal);
            this.groupAntal.ForeColor = System.Drawing.Color.Navy;
            this.groupAntal.Location = new System.Drawing.Point(192, 244);
            this.groupAntal.Name = "groupAntal";
            this.groupAntal.Size = new System.Drawing.Size(157, 69);
            this.groupAntal.TabIndex = 6;
            this.groupAntal.TabStop = false;
            this.groupAntal.Text = "Antal frågor";
            // 
            // lblAntal
            // 
            this.lblAntal.AutoSize = true;
            this.lblAntal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntal.Location = new System.Drawing.Point(91, 16);
            this.lblAntal.Name = "lblAntal";
            this.lblAntal.Size = new System.Drawing.Size(51, 37);
            this.lblAntal.TabIndex = 12;
            this.lblAntal.Text = "10";
            // 
            // trackBarAntal
            // 
            this.trackBarAntal.Location = new System.Drawing.Point(6, 20);
            this.trackBarAntal.Maximum = 30;
            this.trackBarAntal.Minimum = 1;
            this.trackBarAntal.Name = "trackBarAntal";
            this.trackBarAntal.Size = new System.Drawing.Size(87, 45);
            this.trackBarAntal.TabIndex = 11;
            this.trackBarAntal.Value = 10;
            this.trackBarAntal.Scroll += new System.EventHandler(this.trackBarAntal_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(374, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupAntal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.Text = "Meny";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLevel)).EndInit();
            this.groupAntal.ResumeLayout(false);
            this.groupAntal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAntal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxMinus;
        private System.Windows.Forms.CheckBox checkBoxPlus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBarLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.CheckBox checkBoxMulti;
        private System.Windows.Forms.GroupBox groupAntal;
        private System.Windows.Forms.Label lblAntal;
        private System.Windows.Forms.TrackBar trackBarAntal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxDiv;
    }
}
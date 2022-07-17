namespace GameOfLifeLike
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pixelsize_numeric = new System.Windows.Forms.NumericUpDown();
            this.speed_numeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.symmetrical_checkbox = new System.Windows.Forms.CheckBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.empty_btn = new System.Windows.Forms.Button();
            this.food_btn = new System.Windows.Forms.Button();
            this.prey_btn = new System.Windows.Forms.Button();
            this.predator_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelsize_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // picturebox
            // 
            this.picturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturebox.Location = new System.Drawing.Point(12, 12);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(1558, 796);
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            this.picturebox.Click += new System.EventHandler(this.picturebox_Click);
            this.picturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseDown);
            this.picturebox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseMove);
            this.picturebox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseUp);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pixelsize_numeric
            // 
            this.pixelsize_numeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pixelsize_numeric.Location = new System.Drawing.Point(89, 814);
            this.pixelsize_numeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.pixelsize_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pixelsize_numeric.Name = "pixelsize_numeric";
            this.pixelsize_numeric.Size = new System.Drawing.Size(37, 27);
            this.pixelsize_numeric.TabIndex = 1;
            this.pixelsize_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pixelsize_numeric.ValueChanged += new System.EventHandler(this.pixelsize_numeric_ValueChanged);
            // 
            // speed_numeric
            // 
            this.speed_numeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.speed_numeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speed_numeric.Location = new System.Drawing.Point(185, 814);
            this.speed_numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.speed_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speed_numeric.Name = "speed_numeric";
            this.speed_numeric.Size = new System.Drawing.Size(82, 27);
            this.speed_numeric.TabIndex = 2;
            this.speed_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speed_numeric.ValueChanged += new System.EventHandler(this.speed_numeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 816);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pixel Size";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 816);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Delay";
            // 
            // symmetrical_checkbox
            // 
            this.symmetrical_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.symmetrical_checkbox.AutoSize = true;
            this.symmetrical_checkbox.Location = new System.Drawing.Point(285, 817);
            this.symmetrical_checkbox.Name = "symmetrical_checkbox";
            this.symmetrical_checkbox.Size = new System.Drawing.Size(113, 24);
            this.symmetrical_checkbox.TabIndex = 5;
            this.symmetrical_checkbox.Text = "Symmetrical";
            this.symmetrical_checkbox.UseVisualStyleBackColor = true;
            this.symmetrical_checkbox.CheckedChanged += new System.EventHandler(this.symmetrical_checkbox_CheckedChanged);
            // 
            // clear_btn
            // 
            this.clear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clear_btn.Location = new System.Drawing.Point(404, 814);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(63, 27);
            this.clear_btn.TabIndex = 6;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // empty_btn
            // 
            this.empty_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.empty_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.empty_btn.Location = new System.Drawing.Point(473, 814);
            this.empty_btn.Name = "empty_btn";
            this.empty_btn.Size = new System.Drawing.Size(27, 27);
            this.empty_btn.TabIndex = 7;
            this.empty_btn.UseVisualStyleBackColor = false;
            this.empty_btn.Click += new System.EventHandler(this.empty_btn_Click);
            // 
            // food_btn
            // 
            this.food_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.food_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.food_btn.Location = new System.Drawing.Point(506, 814);
            this.food_btn.Name = "food_btn";
            this.food_btn.Size = new System.Drawing.Size(27, 27);
            this.food_btn.TabIndex = 8;
            this.food_btn.UseVisualStyleBackColor = false;
            this.food_btn.Click += new System.EventHandler(this.food_btn_Click);
            // 
            // prey_btn
            // 
            this.prey_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prey_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.prey_btn.Location = new System.Drawing.Point(539, 814);
            this.prey_btn.Name = "prey_btn";
            this.prey_btn.Size = new System.Drawing.Size(27, 27);
            this.prey_btn.TabIndex = 9;
            this.prey_btn.UseVisualStyleBackColor = false;
            this.prey_btn.Click += new System.EventHandler(this.prey_btn_Click);
            // 
            // predator_btn
            // 
            this.predator_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.predator_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(75)))), ((int)(((byte)(22)))));
            this.predator_btn.Location = new System.Drawing.Point(572, 814);
            this.predator_btn.Name = "predator_btn";
            this.predator_btn.Size = new System.Drawing.Size(27, 27);
            this.predator_btn.TabIndex = 10;
            this.predator_btn.UseVisualStyleBackColor = false;
            this.predator_btn.Click += new System.EventHandler(this.predator_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.predator_btn);
            this.Controls.Add(this.prey_btn);
            this.Controls.Add(this.food_btn);
            this.Controls.Add(this.empty_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.symmetrical_checkbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speed_numeric);
            this.Controls.Add(this.pixelsize_numeric);
            this.Controls.Add(this.picturebox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelsize_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picturebox;
        private System.Windows.Forms.Timer timer;
        private NumericUpDown pixelsize_numeric;
        private NumericUpDown speed_numeric;
        private Label label1;
        private Label label2;
        private CheckBox symmetrical_checkbox;
        private Button clear_btn;
        private Button empty_btn;
        private Button food_btn;
        private Button prey_btn;
        private Button predator_btn;
    }
}
namespace Pizza_POS
{
    partial class Main_Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.pb_config = new System.Windows.Forms.PictureBox();
            this.pb_mmenu = new System.Windows.Forms.PictureBox();
            this.pb_food = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_food)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.pb_exit);
            this.panel1.Controls.Add(this.pb_config);
            this.panel1.Controls.Add(this.pb_mmenu);
            this.panel1.Controls.Add(this.pb_food);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1100, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 720);
            this.panel1.TabIndex = 0;
            // 
            // pb_exit
            // 
            this.pb_exit.Image = ((System.Drawing.Image)(resources.GetObject("pb_exit.Image")));
            this.pb_exit.Location = new System.Drawing.Point(5, 618);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(90, 90);
            this.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_exit.TabIndex = 6;
            this.pb_exit.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_exit, "Salir");
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // pb_config
            // 
            this.pb_config.Image = ((System.Drawing.Image)(resources.GetObject("pb_config.Image")));
            this.pb_config.Location = new System.Drawing.Point(5, 398);
            this.pb_config.Name = "pb_config";
            this.pb_config.Size = new System.Drawing.Size(90, 90);
            this.pb_config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_config.TabIndex = 7;
            this.pb_config.TabStop = false;
            // 
            // pb_mmenu
            // 
            this.pb_mmenu.Image = ((System.Drawing.Image)(resources.GetObject("pb_mmenu.Image")));
            this.pb_mmenu.Location = new System.Drawing.Point(5, 134);
            this.pb_mmenu.Name = "pb_mmenu";
            this.pb_mmenu.Size = new System.Drawing.Size(90, 90);
            this.pb_mmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_mmenu.TabIndex = 4;
            this.pb_mmenu.TabStop = false;
            // 
            // pb_food
            // 
            this.pb_food.Image = ((System.Drawing.Image)(resources.GetObject("pb_food.Image")));
            this.pb_food.Location = new System.Drawing.Point(7, 266);
            this.pb_food.Name = "pb_food";
            this.pb_food.Size = new System.Drawing.Size(90, 90);
            this.pb_food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_food.TabIndex = 5;
            this.pb_food.TabStop = false;
            this.pb_food.Click += new System.EventHandler(this.pb_food_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Diary of an 8-bit mage", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú Principal";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 100);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(905, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Menu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_food)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_food;
        private System.Windows.Forms.PictureBox pb_mmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pb_config;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}
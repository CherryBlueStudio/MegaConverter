namespace MegaConverter
{
    partial class homeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.elecBut = new System.Windows.Forms.Button();
            this.areaBut = new System.Windows.Forms.Button();
            this.fluidBut = new System.Windows.Forms.Button();
            this.tempBut = new System.Windows.Forms.Button();
            this.lengthBut = new System.Windows.Forms.Button();
            this.weightBut = new System.Windows.Forms.Button();
            this.mainLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mainLogo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.elecBut, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.areaBut, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.fluidBut, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tempBut, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lengthBut, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.weightBut, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 333);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 325);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // elecBut
            // 
            this.elecBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elecBut.BackColor = System.Drawing.Color.White;
            this.elecBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("elecBut.BackgroundImage")));
            this.elecBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.elecBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elecBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.elecBut.FlatAppearance.BorderSize = 3;
            this.elecBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.elecBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.elecBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elecBut.Location = new System.Drawing.Point(573, 193);
            this.elecBut.Name = "elecBut";
            this.elecBut.Size = new System.Drawing.Size(150, 100);
            this.elecBut.TabIndex = 5;
            this.elecBut.UseVisualStyleBackColor = false;
            this.elecBut.Click += new System.EventHandler(this.elecBut_Click);
            // 
            // areaBut
            // 
            this.areaBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.areaBut.BackColor = System.Drawing.Color.White;
            this.areaBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("areaBut.BackgroundImage")));
            this.areaBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.areaBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.areaBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.areaBut.FlatAppearance.BorderSize = 3;
            this.areaBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.areaBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.areaBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.areaBut.Location = new System.Drawing.Point(313, 193);
            this.areaBut.Name = "areaBut";
            this.areaBut.Size = new System.Drawing.Size(150, 100);
            this.areaBut.TabIndex = 4;
            this.areaBut.UseVisualStyleBackColor = false;
            this.areaBut.Click += new System.EventHandler(this.areaBut_Click);
            // 
            // fluidBut
            // 
            this.fluidBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fluidBut.BackColor = System.Drawing.Color.White;
            this.fluidBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fluidBut.BackgroundImage")));
            this.fluidBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fluidBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fluidBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fluidBut.FlatAppearance.BorderSize = 3;
            this.fluidBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.fluidBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.fluidBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fluidBut.Location = new System.Drawing.Point(54, 193);
            this.fluidBut.Name = "fluidBut";
            this.fluidBut.Size = new System.Drawing.Size(150, 100);
            this.fluidBut.TabIndex = 3;
            this.fluidBut.UseVisualStyleBackColor = false;
            this.fluidBut.Click += new System.EventHandler(this.fluidBut_Click);
            // 
            // tempBut
            // 
            this.tempBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tempBut.BackColor = System.Drawing.Color.White;
            this.tempBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tempBut.BackgroundImage")));
            this.tempBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tempBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tempBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tempBut.FlatAppearance.BorderSize = 3;
            this.tempBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.tempBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.tempBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tempBut.Location = new System.Drawing.Point(573, 31);
            this.tempBut.Name = "tempBut";
            this.tempBut.Size = new System.Drawing.Size(150, 100);
            this.tempBut.TabIndex = 2;
            this.tempBut.UseVisualStyleBackColor = false;
            this.tempBut.Click += new System.EventHandler(this.tempBut_Click);
            // 
            // lengthBut
            // 
            this.lengthBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lengthBut.BackColor = System.Drawing.Color.White;
            this.lengthBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lengthBut.BackgroundImage")));
            this.lengthBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lengthBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lengthBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.lengthBut.FlatAppearance.BorderSize = 3;
            this.lengthBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.lengthBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.lengthBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lengthBut.Font = new System.Drawing.Font("AcmeFont", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthBut.ForeColor = System.Drawing.Color.Transparent;
            this.lengthBut.Location = new System.Drawing.Point(54, 31);
            this.lengthBut.Name = "lengthBut";
            this.lengthBut.Size = new System.Drawing.Size(150, 100);
            this.lengthBut.TabIndex = 0;
            this.lengthBut.UseVisualStyleBackColor = false;
            this.lengthBut.Click += new System.EventHandler(this.lengthBut_Click);
            // 
            // weightBut
            // 
            this.weightBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weightBut.BackColor = System.Drawing.Color.White;
            this.weightBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("weightBut.BackgroundImage")));
            this.weightBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.weightBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weightBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.weightBut.FlatAppearance.BorderSize = 3;
            this.weightBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.weightBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.weightBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weightBut.Location = new System.Drawing.Point(313, 31);
            this.weightBut.Name = "weightBut";
            this.weightBut.Size = new System.Drawing.Size(150, 100);
            this.weightBut.TabIndex = 1;
            this.weightBut.UseVisualStyleBackColor = false;
            this.weightBut.Click += new System.EventHandler(this.weightBut_Click);
            // 
            // mainLogo
            // 
            this.mainLogo.BackColor = System.Drawing.Color.Gray;
            this.mainLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLogo.Image = ((System.Drawing.Image)(resources.GetObject("mainLogo.Image")));
            this.mainLogo.Location = new System.Drawing.Point(3, 3);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(778, 258);
            this.mainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainLogo.TabIndex = 1;
            this.mainLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(92, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "homeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mega Converter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox mainLogo;
        private System.Windows.Forms.Button elecBut;
        private System.Windows.Forms.Button areaBut;
        private System.Windows.Forms.Button fluidBut;
        private System.Windows.Forms.Button lengthBut;
        private System.Windows.Forms.Button weightBut;
        private System.Windows.Forms.Button tempBut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


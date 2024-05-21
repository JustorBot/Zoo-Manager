namespace ZooManager
{
    partial class ZooManagerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZooManagerForm));
            this.AddAnimalBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveAnimalBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SkipBtn = new System.Windows.Forms.Button();
            this.listViewAnimals = new System.Windows.Forms.ListView();
            this.columnHeaderSpecies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHealthStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWater = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMovable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDiet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSleepTimes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZooTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddAnimalBtn
            // 
            this.AddAnimalBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddAnimalBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAnimalBtn.Location = new System.Drawing.Point(399, 20);
            this.AddAnimalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddAnimalBtn.Name = "AddAnimalBtn";
            this.AddAnimalBtn.Size = new System.Drawing.Size(189, 44);
            this.AddAnimalBtn.TabIndex = 0;
            this.AddAnimalBtn.Text = "Add Animal";
            this.AddAnimalBtn.UseVisualStyleBackColor = true;
            this.AddAnimalBtn.Click += new System.EventHandler(this.AddAnimalBtn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1238, 70);
            this.label7.TabIndex = 14;
            this.label7.Text = "Zoo Manager";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.RemoveAnimalBtn);
            this.panel1.Controls.Add(this.AddAnimalBtn);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 83);
            this.panel1.TabIndex = 15;
            // 
            // RemoveAnimalBtn
            // 
            this.RemoveAnimalBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveAnimalBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveAnimalBtn.Location = new System.Drawing.Point(595, 20);
            this.RemoveAnimalBtn.Name = "RemoveAnimalBtn";
            this.RemoveAnimalBtn.Size = new System.Drawing.Size(189, 44);
            this.RemoveAnimalBtn.TabIndex = 1;
            this.RemoveAnimalBtn.Text = "Remove Animal";
            this.RemoveAnimalBtn.UseVisualStyleBackColor = true;
            this.RemoveAnimalBtn.Click += new System.EventHandler(this.RemoveAnimalBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.SkipBtn);
            this.panel2.Location = new System.Drawing.Point(12, 578);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1238, 83);
            this.panel2.TabIndex = 16;
            // 
            // SkipBtn
            // 
            this.SkipBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SkipBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkipBtn.Location = new System.Drawing.Point(524, 23);
            this.SkipBtn.Name = "SkipBtn";
            this.SkipBtn.Size = new System.Drawing.Size(189, 43);
            this.SkipBtn.TabIndex = 4;
            this.SkipBtn.Text = "Exit";
            this.SkipBtn.UseVisualStyleBackColor = true;
            this.SkipBtn.Click += new System.EventHandler(this.SkipBtn_Click);
            // 
            // listViewAnimals
            // 
            this.listViewAnimals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewAnimals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSpecies,
            this.columnHeaderName,
            this.columnHeaderAge,
            this.columnHeaderHealthStatus,
            this.columnHeaderFood,
            this.columnHeaderWater,
            this.columnHeaderMovable,
            this.columnHeaderLocation,
            this.columnHeaderDiet,
            this.columnHeaderSleepTimes,
            this.columnHeaderZooTime,
            this.columnHeaderCost});
            this.listViewAnimals.FullRowSelect = true;
            this.listViewAnimals.GridLines = true;
            this.listViewAnimals.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAnimals.HideSelection = false;
            this.listViewAnimals.Location = new System.Drawing.Point(50, 171);
            this.listViewAnimals.Name = "listViewAnimals";
            this.listViewAnimals.Size = new System.Drawing.Size(1154, 401);
            this.listViewAnimals.TabIndex = 17;
            this.listViewAnimals.UseCompatibleStateImageBehavior = false;
            this.listViewAnimals.View = System.Windows.Forms.View.Details;
            this.listViewAnimals.SelectedIndexChanged += new System.EventHandler(this.listViewAnimals_SelectedIndexChanged);
            // 
            // columnHeaderSpecies
            // 
            this.columnHeaderSpecies.Text = "Species";
            this.columnHeaderSpecies.Width = 100;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 100;
            // 
            // columnHeaderAge
            // 
            this.columnHeaderAge.Text = "Age";
            this.columnHeaderAge.Width = 50;
            // 
            // columnHeaderHealthStatus
            // 
            this.columnHeaderHealthStatus.Text = "Health Status";
            this.columnHeaderHealthStatus.Width = 100;
            // 
            // columnHeaderFood
            // 
            this.columnHeaderFood.Text = "Food";
            this.columnHeaderFood.Width = 100;
            // 
            // columnHeaderWater
            // 
            this.columnHeaderWater.Text = "Water";
            this.columnHeaderWater.Width = 100;
            // 
            // columnHeaderMovable
            // 
            this.columnHeaderMovable.Text = "Movable";
            this.columnHeaderMovable.Width = 100;
            // 
            // columnHeaderLocation
            // 
            this.columnHeaderLocation.Text = "Location";
            this.columnHeaderLocation.Width = 100;
            // 
            // columnHeaderDiet
            // 
            this.columnHeaderDiet.Text = "Diet";
            this.columnHeaderDiet.Width = 100;
            // 
            // columnHeaderSleepTimes
            // 
            this.columnHeaderSleepTimes.Text = "Sleep Times";
            this.columnHeaderSleepTimes.Width = 100;
            // 
            // columnHeaderZooTime
            // 
            this.columnHeaderZooTime.Text = "Zoo Time";
            this.columnHeaderZooTime.Width = 100;
            // 
            // columnHeaderCost
            // 
            this.columnHeaderCost.Text = "Cost";
            this.columnHeaderCost.Width = 100;
            // 
            // ZooManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(247)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.listViewAnimals);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ZooManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoo Manager";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button AddAnimalBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SkipBtn;
        private System.Windows.Forms.ListView listViewAnimals;
        private System.Windows.Forms.ColumnHeader columnHeaderSpecies;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderAge;
        private System.Windows.Forms.ColumnHeader columnHeaderHealthStatus;
        private System.Windows.Forms.ColumnHeader columnHeaderFood;
        private System.Windows.Forms.ColumnHeader columnHeaderWater;
        private System.Windows.Forms.ColumnHeader columnHeaderMovable;
        private System.Windows.Forms.ColumnHeader columnHeaderLocation;
        private System.Windows.Forms.ColumnHeader columnHeaderDiet;
        private System.Windows.Forms.ColumnHeader columnHeaderSleepTimes;
        private System.Windows.Forms.ColumnHeader columnHeaderZooTime;
        private System.Windows.Forms.ColumnHeader columnHeaderCost;
        private System.Windows.Forms.Button RemoveAnimalBtn;
    }
}

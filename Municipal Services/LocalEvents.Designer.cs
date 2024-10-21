namespace Municipal_Services
{
    partial class LocalEvents
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
            this.Back = new System.Windows.Forms.Button();
            this.lvEvents = new System.Windows.Forms.ListView();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Back.FlatAppearance.BorderSize = 2;
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.LightGray;
            this.Back.Location = new System.Drawing.Point(344, 262);
            this.Back.Name = "Back";
            this.Back.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Back.Size = new System.Drawing.Size(102, 41);
            this.Back.TabIndex = 103;
            this.Back.Tag = "";
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // lvEvents
            // 
            this.lvEvents.HideSelection = false;
            this.lvEvents.Location = new System.Drawing.Point(15, 82);
            this.lvEvents.Name = "lvEvents";
            this.lvEvents.Size = new System.Drawing.Size(490, 171);
            this.lvEvents.TabIndex = 102;
            this.lvEvents.UseCompatibleStateImageBehavior = false;
            this.lvEvents.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvEvents_ColumnClick);
            this.lvEvents.SelectedIndexChanged += new System.EventHandler(this.lvEvents_SelectedIndexChanged);
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Location = new System.Drawing.Point(15, 56);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(200, 20);
            this.dtpSearchDate.TabIndex = 101;
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Location = new System.Drawing.Point(15, 30);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(298, 20);
            this.txtSearchCategory.TabIndex = 100;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(319, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 43);
            this.btnSearch.TabIndex = 99;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LocalEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 315);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.lvEvents);
            this.Controls.Add(this.dtpSearchDate);
            this.Controls.Add(this.txtSearchCategory);
            this.Controls.Add(this.btnSearch);
            this.Name = "LocalEvents";
            this.Text = "LocalEvents";
            this.Load += new System.EventHandler(this.LocalEvents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ListView lvEvents;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.Button btnSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
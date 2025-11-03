namespace csharp_RPG
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblHitPoints = new Label();
            lblGold = new Label();
            lblExperience = new Label();
            lblLevel = new Label();
            label5 = new Label();
            cboWeapon = new ComboBox();
            cboPotions = new ComboBox();
            btnUseWeapon = new Button();
            btnUsePotion = new Button();
            btnNorth = new Button();
            btnEast = new Button();
            btnSouth = new Button();
            btnWest = new Button();
            rbtLocation = new RichTextBox();
            rbtMessage = new RichTextBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hit Points:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 46);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Gold:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 74);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Experience:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 100);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 2;
            label4.Text = "Level:";
            // 
            // lblHitPoints
            // 
            lblHitPoints.AutoSize = true;
            lblHitPoints.Location = new Point(100, 19);
            lblHitPoints.Name = "lblHitPoints";
            lblHitPoints.Size = new Size(0, 15);
            lblHitPoints.TabIndex = 5;
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.Location = new Point(100, 45);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(0, 15);
            lblGold.TabIndex = 4;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Location = new Point(100, 73);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(0, 15);
            lblExperience.TabIndex = 7;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(100, 99);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(0, 15);
            lblLevel.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(617, 531);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 8;
            label5.Text = "Select Action";
            label5.Click += label5_Click;
            // 
            // cboWeapon
            // 
            cboWeapon.FormattingEnabled = true;
            cboWeapon.Location = new Point(369, 559);
            cboWeapon.Name = "cboWeapon";
            cboWeapon.Size = new Size(121, 23);
            cboWeapon.TabIndex = 9;
            // 
            // cboPotions
            // 
            cboPotions.FormattingEnabled = true;
            cboPotions.Location = new Point(369, 593);
            cboPotions.Name = "cboPotions";
            cboPotions.Size = new Size(121, 23);
            cboPotions.TabIndex = 10;
            // 
            // btnUseWeapon
            // 
            btnUseWeapon.Location = new Point(620, 559);
            btnUseWeapon.Name = "btnUseWeapon";
            btnUseWeapon.Size = new Size(75, 23);
            btnUseWeapon.TabIndex = 11;
            btnUseWeapon.Text = "Use";
            btnUseWeapon.UseVisualStyleBackColor = true;
            // 
            // btnUsePotion
            // 
            btnUsePotion.Location = new Point(620, 593);
            btnUsePotion.Name = "btnUsePotion";
            btnUsePotion.Size = new Size(75, 23);
            btnUsePotion.TabIndex = 12;
            btnUsePotion.Text = "Use";
            btnUsePotion.UseVisualStyleBackColor = true;
            // 
            // btnNorth
            // 
            btnNorth.Location = new Point(493, 433);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(75, 23);
            btnNorth.TabIndex = 13;
            btnNorth.Text = "North";
            btnNorth.UseVisualStyleBackColor = true;
            // 
            // btnEast
            // 
            btnEast.Location = new Point(573, 457);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(75, 23);
            btnEast.TabIndex = 14;
            btnEast.Text = "btnEast";
            btnEast.UseVisualStyleBackColor = true;
            // 
            // btnSouth
            // 
            btnSouth.Location = new Point(493, 487);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(75, 23);
            btnSouth.TabIndex = 15;
            btnSouth.Text = "South";
            btnSouth.UseVisualStyleBackColor = true;
            // 
            // btnWest
            // 
            btnWest.Location = new Point(412, 457);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(75, 23);
            btnWest.TabIndex = 16;
            btnWest.Text = "West";
            btnWest.UseVisualStyleBackColor = true;
            // 
            // rbtLocation
            // 
            rbtLocation.Location = new Point(347, 19);
            rbtLocation.Name = "rbtLocation";
            rbtLocation.ReadOnly = true;
            rbtLocation.Size = new Size(360, 105);
            rbtLocation.TabIndex = 17;
            rbtLocation.Text = "";
            // 
            // rbtMessage
            // 
            rbtMessage.Location = new Point(347, 130);
            rbtMessage.Name = "rbtMessage";
            rbtMessage.ReadOnly = true;
            rbtMessage.Size = new Size(360, 286);
            rbtMessage.TabIndex = 18;
            rbtMessage.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(16, 446);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(312, 189);
            dataGridView1.TabIndex = 19;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView2.Enabled = false;
            dataGridView2.Location = new Point(16, 130);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(312, 309);
            dataGridView2.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 651);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(rbtMessage);
            Controls.Add(rbtLocation);
            Controls.Add(btnWest);
            Controls.Add(btnSouth);
            Controls.Add(btnEast);
            Controls.Add(btnNorth);
            Controls.Add(btnUsePotion);
            Controls.Add(btnUseWeapon);
            Controls.Add(cboPotions);
            Controls.Add(cboWeapon);
            Controls.Add(label5);
            Controls.Add(lblExperience);
            Controls.Add(lblLevel);
            Controls.Add(lblHitPoints);
            Controls.Add(lblGold);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tideless RPG";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblHitPoints;
        private Label lblGold;
        private Label lblExperience;
        private Label lblLevel;
        private Label label5;
        private ComboBox cboWeapon;
        private ComboBox cboPotions;
        private Button btnUseWeapon;
        private Button btnUsePotion;
        private Button btnNorth;
        private Button btnEast;
        private Button btnSouth;
        private Button btnWest;
        private RichTextBox rbtLocation;
        private RichTextBox rbtMessage;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}

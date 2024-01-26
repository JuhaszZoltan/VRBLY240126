namespace RealEstateGUI
{
    partial class RealEstateForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lsbNames = new ListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblUI01 = new Label();
            lblUI02 = new Label();
            lblUI03 = new Label();
            lblName = new Label();
            lblPhone = new Label();
            lblNoAds = new Label();
            btnLoadAds = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(lsbNames, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(860, 537);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lsbNames
            // 
            lsbNames.Dock = DockStyle.Fill;
            lsbNames.Font = new Font("Segoe UI", 12F);
            lsbNames.FormattingEnabled = true;
            lsbNames.ItemHeight = 21;
            lsbNames.Location = new Point(3, 3);
            lsbNames.Name = "lsbNames";
            lsbNames.Size = new Size(338, 531);
            lsbNames.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lblUI01, 0, 0);
            tableLayoutPanel2.Controls.Add(lblUI02, 0, 1);
            tableLayoutPanel2.Controls.Add(lblUI03, 0, 3);
            tableLayoutPanel2.Controls.Add(lblName, 1, 0);
            tableLayoutPanel2.Controls.Add(lblPhone, 1, 1);
            tableLayoutPanel2.Controls.Add(lblNoAds, 1, 3);
            tableLayoutPanel2.Controls.Add(btnLoadAds, 0, 2);
            tableLayoutPanel2.Location = new Point(347, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(510, 191);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Dock = DockStyle.Fill;
            lblUI01.Font = new Font("Segoe UI", 12F);
            lblUI01.Location = new Point(3, 0);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(249, 47);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Eladó neve:";
            lblUI01.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Dock = DockStyle.Fill;
            lblUI02.Font = new Font("Segoe UI", 12F);
            lblUI02.Location = new Point(3, 47);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(249, 47);
            lblUI02.TabIndex = 1;
            lblUI02.Text = "Eladó telefonszáma:";
            lblUI02.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Dock = DockStyle.Fill;
            lblUI03.Font = new Font("Segoe UI", 12F);
            lblUI03.Location = new Point(3, 141);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(249, 50);
            lblUI03.TabIndex = 2;
            lblUI03.Text = "Hirdetések száma:";
            lblUI03.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(258, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(249, 47);
            lblName.TabIndex = 3;
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Font = new Font("Segoe UI", 12F);
            lblPhone.Location = new Point(258, 47);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(249, 47);
            lblPhone.TabIndex = 4;
            lblPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNoAds
            // 
            lblNoAds.AutoSize = true;
            lblNoAds.Dock = DockStyle.Fill;
            lblNoAds.Font = new Font("Segoe UI", 12F);
            lblNoAds.Location = new Point(258, 141);
            lblNoAds.Name = "lblNoAds";
            lblNoAds.Size = new Size(249, 50);
            lblNoAds.TabIndex = 5;
            lblNoAds.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLoadAds
            // 
            tableLayoutPanel2.SetColumnSpan(btnLoadAds, 2);
            btnLoadAds.Dock = DockStyle.Fill;
            btnLoadAds.Font = new Font("Segoe UI", 12F);
            btnLoadAds.Location = new Point(3, 97);
            btnLoadAds.Name = "btnLoadAds";
            btnLoadAds.Size = new Size(504, 41);
            btnLoadAds.TabIndex = 6;
            btnLoadAds.Text = "hirdetések betöltése";
            btnLoadAds.UseVisualStyleBackColor = true;
            // 
            // RealEstateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(tableLayoutPanel1);
            Name = "RealEstateForm";
            Text = "Ingatlanok";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListBox lsbNames;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblUI01;
        private Label lblUI02;
        private Label lblUI03;
        private Label lblName;
        private Label lblPhone;
        private Label lblNoAds;
        private Button btnLoadAds;
    }
}

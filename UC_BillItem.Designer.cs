namespace Menu_Management
{
    partial class UC_BillItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BillItem));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelMain = new Panel();
            panel2 = new Panel();
            OrderItemInfo = new Label();
            label9 = new Label();
            panel1 = new Panel();
            OrderTotal = new Label();
            label4 = new Label();
            PrintButton = new Guna.UI2.WinForms.Guna2Button();
            panelHeader = new Panel();
            label5 = new Label();
            label3 = new Label();
            EmployeeName = new Label();
            OrderedTime = new Label();
            Bill = new Label();
            label1 = new Label();
            ClearBillItem = new Guna.UI2.WinForms.Guna2Button();
            panelMain.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panel2);
            panelMain.Controls.Add(panel1);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(280, 400);
            panelMain.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(OrderItemInfo);
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 194);
            panel2.TabIndex = 2;
            // 
            // OrderItemInfo
            // 
            OrderItemInfo.AutoSize = true;
            OrderItemInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderItemInfo.Location = new Point(15, 43);
            OrderItemInfo.Name = "OrderItemInfo";
            OrderItemInfo.Size = new Size(198, 17);
            OrderItemInfo.TabIndex = 0;
            OrderItemInfo.Text = "1 --- Hamburger ---- 2  ---90000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 16);
            label9.Name = "label9";
            label9.Size = new Size(265, 17);
            label9.TabIndex = 0;
            label9.Text = "[số tt] --- [Tên món] ---- [số lượng]  --- [Giá]";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(OrderTotal);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(PrintButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 302);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 98);
            panel1.TabIndex = 1;
            // 
            // OrderTotal
            // 
            OrderTotal.AutoSize = true;
            OrderTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderTotal.Location = new Point(68, 14);
            OrderTotal.Name = "OrderTotal";
            OrderTotal.Size = new Size(74, 17);
            OrderTotal.TabIndex = 23;
            OrderTotal.Text = "45000 VNĐ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 11);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 23;
            label4.Text = "Total :";
            // 
            // PrintButton
            // 
            PrintButton.BorderRadius = 25;
            PrintButton.CustomizableEdges = customizableEdges5;
            PrintButton.DisabledState.BorderColor = Color.DarkGray;
            PrintButton.DisabledState.CustomBorderColor = Color.DarkGray;
            PrintButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            PrintButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            PrintButton.FillColor = Color.FromArgb(255, 107, 0);
            PrintButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrintButton.ForeColor = Color.White;
            PrintButton.Location = new Point(60, 40);
            PrintButton.Name = "PrintButton";
            PrintButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PrintButton.Size = new Size(153, 49);
            PrintButton.TabIndex = 18;
            PrintButton.Text = "Print";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(28, 40, 51);
            panelHeader.Controls.Add(label5);
            panelHeader.Controls.Add(label3);
            panelHeader.Controls.Add(EmployeeName);
            panelHeader.Controls.Add(OrderedTime);
            panelHeader.Controls.Add(Bill);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(ClearBillItem);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(280, 108);
            panelHeader.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 107, 0);
            label5.Location = new Point(13, 70);
            label5.Name = "label5";
            label5.Size = new Size(73, 17);
            label5.TabIndex = 4;
            label5.Text = "Nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 107, 0);
            label3.Location = new Point(13, 44);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 4;
            label3.Text = "Thời gian:";
            // 
            // EmployeeName
            // 
            EmployeeName.AutoSize = true;
            EmployeeName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeName.ForeColor = Color.FromArgb(255, 107, 0);
            EmployeeName.Location = new Point(98, 70);
            EmployeeName.Name = "EmployeeName";
            EmployeeName.Size = new Size(95, 17);
            EmployeeName.TabIndex = 4;
            EmployeeName.Text = "Nguyễn Văn A";
            // 
            // OrderedTime
            // 
            OrderedTime.AutoSize = true;
            OrderedTime.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderedTime.ForeColor = Color.FromArgb(255, 107, 0);
            OrderedTime.Location = new Point(89, 44);
            OrderedTime.Name = "OrderedTime";
            OrderedTime.Size = new Size(115, 17);
            OrderedTime.TabIndex = 4;
            OrderedTime.Text = "1/6/2025 - 17:23:12";
            // 
            // Bill
            // 
            Bill.AutoSize = true;
            Bill.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bill.ForeColor = Color.FromArgb(255, 107, 0);
            Bill.Location = new Point(83, 17);
            Bill.Name = "Bill";
            Bill.Size = new Size(53, 17);
            Bill.TabIndex = 4;
            Bill.Text = "HD1254";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 107, 0);
            label1.Location = new Point(13, 17);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 4;
            label1.Text = "Hóa đơn:";
            // 
            // ClearBillItem
            // 
            ClearBillItem.BackColor = Color.Transparent;
            ClearBillItem.BorderRadius = 5;
            customizableEdges7.BottomRight = false;
            customizableEdges7.TopLeft = false;
            customizableEdges7.TopRight = false;
            ClearBillItem.CustomizableEdges = customizableEdges7;
            ClearBillItem.DisabledState.BorderColor = Color.DarkGray;
            ClearBillItem.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearBillItem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearBillItem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearBillItem.FillColor = Color.FromArgb(255, 107, 0);
            ClearBillItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearBillItem.ForeColor = Color.Black;
            ClearBillItem.Image = (Image)resources.GetObject("ClearBillItem.Image");
            ClearBillItem.ImageSize = new Size(12, 12);
            ClearBillItem.Location = new Point(250, 0);
            ClearBillItem.Name = "ClearBillItem";
            ClearBillItem.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ClearBillItem.Size = new Size(30, 22);
            ClearBillItem.TabIndex = 3;
            // 
            // UC_BillItem
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panelMain);
            Margin = new Padding(10);
            Name = "UC_BillItem";
            Size = new Size(280, 400);
            panelMain.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panel2;
        private Panel panel1;
        private Panel panelHeader;
        private Guna.UI2.WinForms.Guna2Button PrintButton;
        private Label label4;
        private Label OrderTotal;
        private Guna.UI2.WinForms.Guna2Button ClearBillItem;
        private Label label5;
        private Label label3;
        private Label Bill;
        private Label label1;
        private Label EmployeeName;
        private Label OrderedTime;
        private Label OrderItemInfo;
        private Label label9;
    }
}

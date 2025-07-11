namespace Menu_Management
{
    partial class HomeForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelMainContent = new Panel();
            panelMenu = new Panel();
            CategoryLabel = new Label();
            DishFlowPanel = new FlowLayoutPanel();
            panelCategory = new Panel();
            CategoryFlowPanel = new FlowLayoutPanel();
            panelHeader = new Panel();
            SearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            panel1 = new Panel();
            OrderTotalLabel = new Label();
            label4 = new Label();
            btnOrder = new Guna.UI2.WinForms.Guna2Button();
            OrderflowLayout = new FlowLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            panelMainContent.SuspendLayout();
            panelMenu.SuspendLayout();
            panelCategory.SuspendLayout();
            panelHeader.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMainContent
            // 
            panelMainContent.Controls.Add(panelMenu);
            panelMainContent.Controls.Add(panelCategory);
            panelMainContent.Controls.Add(panelHeader);
            panelMainContent.Controls.Add(panel1);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(0, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(982, 775);
            panelMainContent.TabIndex = 1;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(CategoryLabel);
            panelMenu.Controls.Add(DishFlowPanel);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 196);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(659, 579);
            panelMenu.TabIndex = 3;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Segoe UI", 15.75F);
            CategoryLabel.Location = new Point(8, 3);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(98, 30);
            CategoryLabel.TabIndex = 4;
            CategoryLabel.Text = "Breakfast";
            // 
            // DishFlowPanel
            // 
            DishFlowPanel.AutoScroll = true;
            DishFlowPanel.Location = new Point(3, 36);
            DishFlowPanel.Name = "DishFlowPanel";
            DishFlowPanel.Size = new Size(643, 543);
            DishFlowPanel.TabIndex = 3;
            // 
            // panelCategory
            // 
            panelCategory.Controls.Add(CategoryFlowPanel);
            panelCategory.Dock = DockStyle.Top;
            panelCategory.Location = new Point(0, 66);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(659, 130);
            panelCategory.TabIndex = 2;
            // 
            // CategoryFlowPanel
            // 
            CategoryFlowPanel.AutoScroll = true;
            CategoryFlowPanel.Dock = DockStyle.Fill;
            CategoryFlowPanel.Location = new Point(0, 0);
            CategoryFlowPanel.Name = "CategoryFlowPanel";
            CategoryFlowPanel.Size = new Size(659, 130);
            CategoryFlowPanel.TabIndex = 11;
            CategoryFlowPanel.WrapContents = false;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(SearchBar);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(659, 66);
            panelHeader.TabIndex = 1;
            // 
            // SearchBar
            // 
            SearchBar.BorderRadius = 20;
            SearchBar.BorderThickness = 0;
            SearchBar.CustomizableEdges = customizableEdges7;
            SearchBar.DefaultText = "";
            SearchBar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchBar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchBar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchBar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchBar.FillColor = Color.FromArgb(224, 224, 224);
            SearchBar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchBar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchBar.IconRight = (Image)resources.GetObject("SearchBar.IconRight");
            SearchBar.IconRightSize = new Size(36, 36);
            SearchBar.Location = new Point(250, 11);
            SearchBar.Margin = new Padding(4);
            SearchBar.Name = "SearchBar";
            SearchBar.PlaceholderForeColor = Color.Silver;
            SearchBar.PlaceholderText = "Search dish";
            SearchBar.SelectedText = "";
            SearchBar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            SearchBar.Size = new Size(385, 45);
            SearchBar.TabIndex = 11;
            SearchBar.TextChanged += SearchBar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 11);
            label1.Name = "label1";
            label1.Size = new Size(113, 45);
            label1.TabIndex = 10;
            label1.Text = "Dishes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(234, 234, 234);
            panel1.Controls.Add(OrderTotalLabel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnOrder);
            panel1.Controls.Add(OrderflowLayout);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(659, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 775);
            panel1.TabIndex = 0;
            // 
            // OrderTotalLabel
            // 
            OrderTotalLabel.AutoSize = true;
            OrderTotalLabel.BackColor = Color.Transparent;
            OrderTotalLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderTotalLabel.Location = new Point(142, 670);
            OrderTotalLabel.Name = "OrderTotalLabel";
            OrderTotalLabel.Size = new Size(69, 25);
            OrderTotalLabel.TabIndex = 23;
            OrderTotalLabel.Text = "VNĐ 0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 670);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 22;
            label4.Text = "Total :";
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Transparent;
            btnOrder.BorderRadius = 10;
            btnOrder.CustomizableEdges = customizableEdges5;
            btnOrder.DisabledState.BorderColor = Color.DarkGray;
            btnOrder.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOrder.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOrder.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOrder.FillColor = Color.FromArgb(255, 107, 0);
            btnOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(13, 714);
            btnOrder.Name = "btnOrder";
            btnOrder.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnOrder.Size = new Size(298, 49);
            btnOrder.TabIndex = 21;
            btnOrder.Text = "Order";
            btnOrder.Click += btnOrder_Click;
            // 
            // OrderflowLayout
            // 
            OrderflowLayout.AutoScroll = true;
            OrderflowLayout.Location = new Point(0, 121);
            OrderflowLayout.Name = "OrderflowLayout";
            OrderflowLayout.Size = new Size(323, 528);
            OrderflowLayout.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 49);
            label3.Name = "label3";
            label3.Size = new Size(107, 17);
            label3.TabIndex = 3;
            label3.Text = "Transaction #243";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 9);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 2;
            label2.Text = "Current Order";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 775);
            Controls.Add(panelMainContent);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeForm";
            panelMainContent.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelCategory.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMainContent;
        private Panel panelMenu;
        private Label CategoryLabel;
        private FlowLayoutPanel DishFlowPanel;
        private Panel panelCategory;
        private FlowLayoutPanel CategoryFlowPanel;
        private Panel panelHeader;
        private Guna.UI2.WinForms.Guna2TextBox SearchBar;
        private Label label1;
        private Panel panel1;
        private Label OrderTotalLabel;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private FlowLayoutPanel OrderflowLayout;
        private Label label3;
        private Label label2;
        private UC_OrderItem uC_OrderItem1;
    }
}
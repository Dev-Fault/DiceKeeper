namespace DiceKeeper
{
    partial class DiceKeeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceKeeper));
            this.rollPoolButton = new System.Windows.Forms.Button();
            this.diceFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.diceButtonTemplate = new System.Windows.Forms.Button();
            this.diceButtonContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logLeftButton = new System.Windows.Forms.Button();
            this.logRightButton = new System.Windows.Forms.Button();
            this.logRollTotalsLabel = new System.Windows.Forms.Label();
            this.logRollNameLabel = new System.Windows.Forms.Label();
            this.logRollTotalLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addDiceButton = new System.Windows.Forms.Button();
            this.poolToggleButton = new System.Windows.Forms.Button();
            this.resetDiceButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.addDicePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sidesTextBox = new System.Windows.Forms.TextBox();
            this.numberOfDiceTextBox = new System.Windows.Forms.TextBox();
            this.modifierTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.modifierTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addDiceConfirmButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.diceFlowPanel.SuspendLayout();
            this.diceButtonContextStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.addDicePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rollPoolButton
            // 
            this.rollPoolButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rollPoolButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.rollPoolButton.FlatAppearance.BorderSize = 0;
            this.rollPoolButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rollPoolButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.rollPoolButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rollPoolButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollPoolButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollPoolButton.ForeColor = System.Drawing.Color.Transparent;
            this.rollPoolButton.Location = new System.Drawing.Point(545, 0);
            this.rollPoolButton.Margin = new System.Windows.Forms.Padding(0);
            this.rollPoolButton.Name = "rollPoolButton";
            this.rollPoolButton.Size = new System.Drawing.Size(200, 75);
            this.rollPoolButton.TabIndex = 0;
            this.rollPoolButton.Text = "ROLL";
            this.rollPoolButton.UseVisualStyleBackColor = false;
            this.rollPoolButton.Click += new System.EventHandler(this.rollPoolButton_Click);
            // 
            // diceFlowPanel
            // 
            this.diceFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.diceFlowPanel.AutoScroll = true;
            this.diceFlowPanel.AutoSize = true;
            this.diceFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.diceFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.diceFlowPanel.Controls.Add(this.diceButtonTemplate);
            this.diceFlowPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceFlowPanel.Location = new System.Drawing.Point(577, 93);
            this.diceFlowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.diceFlowPanel.Name = "diceFlowPanel";
            this.diceFlowPanel.Size = new System.Drawing.Size(135, 348);
            this.diceFlowPanel.TabIndex = 0;
            this.diceFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // diceButtonTemplate
            // 
            this.diceButtonTemplate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.diceButtonTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.diceButtonTemplate.ContextMenuStrip = this.diceButtonContextStrip;
            this.diceButtonTemplate.FlatAppearance.BorderSize = 0;
            this.diceButtonTemplate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.diceButtonTemplate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.diceButtonTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diceButtonTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceButtonTemplate.ForeColor = System.Drawing.Color.FloralWhite;
            this.diceButtonTemplate.Image = ((System.Drawing.Image)(resources.GetObject("diceButtonTemplate.Image")));
            this.diceButtonTemplate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.diceButtonTemplate.Location = new System.Drawing.Point(5, 5);
            this.diceButtonTemplate.Margin = new System.Windows.Forms.Padding(5);
            this.diceButtonTemplate.Name = "diceButtonTemplate";
            this.diceButtonTemplate.Padding = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.diceButtonTemplate.Size = new System.Drawing.Size(125, 125);
            this.diceButtonTemplate.TabIndex = 0;
            this.diceButtonTemplate.Text = "D4";
            this.diceButtonTemplate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.diceButtonTemplate.UseVisualStyleBackColor = false;
            this.diceButtonTemplate.Click += new System.EventHandler(this.diceButtonTemplate_Click);
            this.diceButtonTemplate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.diceButtonTemplate_MouseDown);
            // 
            // diceButtonContextStrip
            // 
            this.diceButtonContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMenuItem});
            this.diceButtonContextStrip.Name = "diceButtonContextStrip";
            this.diceButtonContextStrip.Size = new System.Drawing.Size(108, 26);
            this.diceButtonContextStrip.Opening += new System.ComponentModel.CancelEventHandler(this.diceButtonContextStrip_Opening);
            this.diceButtonContextStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.diceButtonContextStrip_ItemClicked);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteMenuItem.Text = "Delete";
            // 
            // logLeftButton
            // 
            this.logLeftButton.FlatAppearance.BorderSize = 0;
            this.logLeftButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.logLeftButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.logLeftButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.logLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logLeftButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLeftButton.ForeColor = System.Drawing.Color.Transparent;
            this.logLeftButton.Location = new System.Drawing.Point(150, 0);
            this.logLeftButton.Margin = new System.Windows.Forms.Padding(0);
            this.logLeftButton.Name = "logLeftButton";
            this.logLeftButton.Size = new System.Drawing.Size(50, 50);
            this.logLeftButton.TabIndex = 1;
            this.logLeftButton.Text = "<";
            this.toolTip.SetToolTip(this.logLeftButton, "View previous roll");
            this.logLeftButton.UseVisualStyleBackColor = true;
            this.logLeftButton.Click += new System.EventHandler(this.logLeftButton_Click);
            // 
            // logRightButton
            // 
            this.logRightButton.FlatAppearance.BorderSize = 0;
            this.logRightButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.logRightButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.logRightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.logRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logRightButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logRightButton.ForeColor = System.Drawing.Color.Transparent;
            this.logRightButton.Location = new System.Drawing.Point(200, 0);
            this.logRightButton.Margin = new System.Windows.Forms.Padding(0);
            this.logRightButton.Name = "logRightButton";
            this.logRightButton.Size = new System.Drawing.Size(50, 50);
            this.logRightButton.TabIndex = 2;
            this.logRightButton.Text = ">";
            this.toolTip.SetToolTip(this.logRightButton, "View next roll");
            this.logRightButton.UseVisualStyleBackColor = true;
            this.logRightButton.Click += new System.EventHandler(this.logRightButton_Click);
            // 
            // logRollTotalsLabel
            // 
            this.logRollTotalsLabel.AutoSize = true;
            this.logRollTotalsLabel.BackColor = System.Drawing.Color.Transparent;
            this.logRollTotalsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logRollTotalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logRollTotalsLabel.ForeColor = System.Drawing.Color.White;
            this.logRollTotalsLabel.Location = new System.Drawing.Point(0, 155);
            this.logRollTotalsLabel.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.logRollTotalsLabel.Name = "logRollTotalsLabel";
            this.logRollTotalsLabel.Size = new System.Drawing.Size(1290, 37);
            this.logRollTotalsLabel.TabIndex = 2;
            this.logRollTotalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logRollNameLabel
            // 
            this.logRollNameLabel.AutoSize = true;
            this.logRollNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.logRollNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logRollNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logRollNameLabel.ForeColor = System.Drawing.Color.White;
            this.logRollNameLabel.Location = new System.Drawing.Point(0, 15);
            this.logRollNameLabel.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.logRollNameLabel.Name = "logRollNameLabel";
            this.logRollNameLabel.Size = new System.Drawing.Size(1290, 42);
            this.logRollNameLabel.TabIndex = 1;
            this.logRollNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logRollTotalLabel
            // 
            this.logRollTotalLabel.AutoSize = true;
            this.logRollTotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.logRollTotalLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logRollTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logRollTotalLabel.ForeColor = System.Drawing.Color.White;
            this.logRollTotalLabel.Location = new System.Drawing.Point(0, 85);
            this.logRollTotalLabel.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.logRollTotalLabel.Name = "logRollTotalLabel";
            this.logRollTotalLabel.Size = new System.Drawing.Size(1290, 55);
            this.logRollTotalLabel.TabIndex = 0;
            this.logRollTotalLabel.Text = "Roll some dice!";
            this.logRollTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logRollTotalLabel.Click += new System.EventHandler(this.logRollTotalLabel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1290, 733);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.flowLayoutPanel1.Controls.Add(this.addDiceButton);
            this.flowLayoutPanel1.Controls.Add(this.poolToggleButton);
            this.flowLayoutPanel1.Controls.Add(this.resetDiceButton);
            this.flowLayoutPanel1.Controls.Add(this.logLeftButton);
            this.flowLayoutPanel1.Controls.Add(this.logRightButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1290, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // addDiceButton
            // 
            this.addDiceButton.BackColor = System.Drawing.Color.Transparent;
            this.addDiceButton.BackgroundImage = global::DiceKeeper.Properties.Resources.addDiceButton;
            this.addDiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addDiceButton.FlatAppearance.BorderSize = 0;
            this.addDiceButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.addDiceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.addDiceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.addDiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDiceButton.ForeColor = System.Drawing.Color.Transparent;
            this.addDiceButton.Location = new System.Drawing.Point(0, 0);
            this.addDiceButton.Margin = new System.Windows.Forms.Padding(0);
            this.addDiceButton.Name = "addDiceButton";
            this.addDiceButton.Size = new System.Drawing.Size(50, 50);
            this.addDiceButton.TabIndex = 2;
            this.toolTip.SetToolTip(this.addDiceButton, "Add new die");
            this.addDiceButton.UseVisualStyleBackColor = false;
            this.addDiceButton.Click += new System.EventHandler(this.addDiceButton_Click);
            // 
            // poolToggleButton
            // 
            this.poolToggleButton.BackColor = System.Drawing.Color.Transparent;
            this.poolToggleButton.BackgroundImage = global::DiceKeeper.Properties.Resources.multiDiceButton;
            this.poolToggleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.poolToggleButton.FlatAppearance.BorderSize = 0;
            this.poolToggleButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.poolToggleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.poolToggleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.poolToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poolToggleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poolToggleButton.ForeColor = System.Drawing.Color.Transparent;
            this.poolToggleButton.Location = new System.Drawing.Point(50, 0);
            this.poolToggleButton.Margin = new System.Windows.Forms.Padding(0);
            this.poolToggleButton.Name = "poolToggleButton";
            this.poolToggleButton.Size = new System.Drawing.Size(50, 50);
            this.poolToggleButton.TabIndex = 1;
            this.toolTip.SetToolTip(this.poolToggleButton, "Select multiple dice");
            this.poolToggleButton.UseVisualStyleBackColor = false;
            this.poolToggleButton.Click += new System.EventHandler(this.poolToggleButton_Click);
            // 
            // resetDiceButton
            // 
            this.resetDiceButton.BackgroundImage = global::DiceKeeper.Properties.Resources.resetButton;
            this.resetDiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.resetDiceButton.FlatAppearance.BorderSize = 0;
            this.resetDiceButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.resetDiceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.resetDiceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.resetDiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetDiceButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetDiceButton.ForeColor = System.Drawing.Color.Transparent;
            this.resetDiceButton.Location = new System.Drawing.Point(100, 0);
            this.resetDiceButton.Margin = new System.Windows.Forms.Padding(0);
            this.resetDiceButton.Name = "resetDiceButton";
            this.resetDiceButton.Size = new System.Drawing.Size(50, 50);
            this.resetDiceButton.TabIndex = 3;
            this.toolTip.SetToolTip(this.resetDiceButton, "Reset to default dice");
            this.resetDiceButton.UseVisualStyleBackColor = true;
            this.resetDiceButton.Click += new System.EventHandler(this.resetDiceButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.logRollTotalLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.logRollNameLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.logRollTotalsLabel, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 73);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1290, 210);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.rollPoolButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.diceFlowPanel, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 292);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.09039F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.90961F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1290, 441);
            this.tableLayoutPanel4.TabIndex = 2;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint_2);
            // 
            // addDicePanel
            // 
            this.addDicePanel.AutoSize = true;
            this.addDicePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.addDicePanel.Controls.Add(this.tableLayoutPanel2);
            this.addDicePanel.Controls.Add(this.addDiceConfirmButton);
            this.addDicePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.addDicePanel.Location = new System.Drawing.Point(0, 50);
            this.addDicePanel.Margin = new System.Windows.Forms.Padding(0);
            this.addDicePanel.Name = "addDicePanel";
            this.addDicePanel.Padding = new System.Windows.Forms.Padding(5);
            this.addDicePanel.Size = new System.Drawing.Size(406, 310);
            this.addDicePanel.TabIndex = 1;
            this.addDicePanel.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.sidesTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.numberOfDiceTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.modifierTextBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nameTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.modifierTypeComboBox, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(396, 240);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modifier";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modifier Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of dice";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sidesTextBox
            // 
            this.sidesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sidesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.sidesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidesTextBox.ForeColor = System.Drawing.Color.White;
            this.sidesTextBox.Location = new System.Drawing.Point(178, 6);
            this.sidesTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.sidesTextBox.MaxLength = 4;
            this.sidesTextBox.Name = "sidesTextBox";
            this.sidesTextBox.Size = new System.Drawing.Size(218, 26);
            this.sidesTextBox.TabIndex = 0;
            // 
            // numberOfDiceTextBox
            // 
            this.numberOfDiceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numberOfDiceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.numberOfDiceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfDiceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDiceTextBox.ForeColor = System.Drawing.Color.White;
            this.numberOfDiceTextBox.Location = new System.Drawing.Point(178, 123);
            this.numberOfDiceTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.numberOfDiceTextBox.MaxLength = 2;
            this.numberOfDiceTextBox.Name = "numberOfDiceTextBox";
            this.numberOfDiceTextBox.Size = new System.Drawing.Size(218, 26);
            this.numberOfDiceTextBox.TabIndex = 2;
            // 
            // modifierTextBox
            // 
            this.modifierTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.modifierTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.modifierTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modifierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierTextBox.ForeColor = System.Drawing.Color.White;
            this.modifierTextBox.Location = new System.Drawing.Point(178, 204);
            this.modifierTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.modifierTextBox.MaxLength = 2;
            this.modifierTextBox.Name = "modifierTextBox";
            this.modifierTextBox.Size = new System.Drawing.Size(218, 26);
            this.modifierTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sides";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(178, 84);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nameTextBox.MaxLength = 5;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(218, 26);
            this.nameTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label6, 2);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(0, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(396, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Optional";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // modifierTypeComboBox
            // 
            this.modifierTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.modifierTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.modifierTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modifierTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifierTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.modifierTypeComboBox.FormattingEnabled = true;
            this.modifierTypeComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.modifierTypeComboBox.Location = new System.Drawing.Point(178, 161);
            this.modifierTypeComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.modifierTypeComboBox.Name = "modifierTypeComboBox";
            this.modifierTypeComboBox.Size = new System.Drawing.Size(218, 28);
            this.modifierTypeComboBox.TabIndex = 11;
            // 
            // addDiceConfirmButton
            // 
            this.addDiceConfirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addDiceConfirmButton.AutoSize = true;
            this.addDiceConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.addDiceConfirmButton.FlatAppearance.BorderSize = 0;
            this.addDiceConfirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.addDiceConfirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.addDiceConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDiceConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDiceConfirmButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.addDiceConfirmButton.Location = new System.Drawing.Point(160, 255);
            this.addDiceConfirmButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.addDiceConfirmButton.Name = "addDiceConfirmButton";
            this.addDiceConfirmButton.Size = new System.Drawing.Size(85, 50);
            this.addDiceConfirmButton.TabIndex = 1;
            this.addDiceConfirmButton.Text = "OK";
            this.addDiceConfirmButton.UseVisualStyleBackColor = false;
            this.addDiceConfirmButton.Click += new System.EventHandler(this.addDiceConfirmButton_Click);
            // 
            // DiceKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1290, 733);
            this.Controls.Add(this.addDicePanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 650);
            this.Name = "DiceKeeper";
            this.Text = "DiceKeeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DiceKeeper_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.diceFlowPanel.ResumeLayout(false);
            this.diceButtonContextStrip.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.addDicePanel.ResumeLayout(false);
            this.addDicePanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button poolToggleButton;
        private System.Windows.Forms.FlowLayoutPanel diceFlowPanel;
        private System.Windows.Forms.Button rollPoolButton;
        private System.Windows.Forms.Button logLeftButton;
        private System.Windows.Forms.Button logRightButton;
        private System.Windows.Forms.Label logRollTotalsLabel;
        private System.Windows.Forms.Label logRollNameLabel;
        private System.Windows.Forms.Label logRollTotalLabel;
        private System.Windows.Forms.Button diceButtonTemplate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel addDicePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox sidesTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberOfDiceTextBox;
        private System.Windows.Forms.TextBox modifierTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox modifierTypeComboBox;
        private System.Windows.Forms.Button addDiceConfirmButton;
        private System.Windows.Forms.Button addDiceButton;
        private System.Windows.Forms.ContextMenuStrip diceButtonContextStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.Button resetDiceButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}


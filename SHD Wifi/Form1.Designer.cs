namespace SHD_Wifi
{
    partial class Form1
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
            this.shardxwifi = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showShardXWifiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeShardXWifiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showActiveConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shardxwifi
            // 
            this.shardxwifi.ContextMenuStrip = this.contextMenuStrip1;
            this.shardxwifi.Text = "ShardX Wifi";
            this.shardxwifi.Visible = true;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.panelEx1.Controls.Add(this.bar1);
            this.panelEx1.Controls.Add(this.buttonX1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(414, 301);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Text = "panelEx1";
            // 
            // bar1
            // 
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem2,
            this.buttonItem5,
            this.buttonItem4});
            this.bar1.Location = new System.Drawing.Point(3, 3);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(491, 25);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.bar1.TabIndex = 1;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            this.bar1.ItemClick += new System.EventHandler(this.bar1_ItemClick);
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.buttonItem1.Text = "Settings";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "Connected Devices";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // buttonItem5
            // 
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.Text = "Minimize";
            this.buttonItem5.Click += new System.EventHandler(this.buttonItem5_Click);
            // 
            // buttonItem4
            // 
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.Text = "Close";
            this.buttonItem4.Click += new System.EventHandler(this.buttonItem4_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.AutoExpandOnClick = true;
            this.buttonX1.AutoSize = true;
            this.buttonX1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::SHD_Wifi.Properties.Resources.wifiico;
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.buttonX1.Location = new System.Drawing.Point(75, 31);
            this.buttonX1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Padding = new System.Windows.Forms.Padding(3);
            this.buttonX1.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.buttonX1.Size = new System.Drawing.Size(264, 262);
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showShardXWifiToolStripMenuItem,
            this.showActiveConnectionsToolStripMenuItem,
            this.closeShardXWifiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 70);
            // 
            // showShardXWifiToolStripMenuItem
            // 
            this.showShardXWifiToolStripMenuItem.Name = "showShardXWifiToolStripMenuItem";
            this.showShardXWifiToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.showShardXWifiToolStripMenuItem.Text = "&Show ShardX Wifi";
            this.showShardXWifiToolStripMenuItem.Click += new System.EventHandler(this.showShardXWifiToolStripMenuItem_Click);
            // 
            // closeShardXWifiToolStripMenuItem
            // 
            this.closeShardXWifiToolStripMenuItem.Name = "closeShardXWifiToolStripMenuItem";
            this.closeShardXWifiToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.closeShardXWifiToolStripMenuItem.Text = "Close ShardXWifi";
            this.closeShardXWifiToolStripMenuItem.Click += new System.EventHandler(this.closeShardXWifiToolStripMenuItem_Click);
            // 
            // showActiveConnectionsToolStripMenuItem
            // 
            this.showActiveConnectionsToolStripMenuItem.Name = "showActiveConnectionsToolStripMenuItem";
            this.showActiveConnectionsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.showActiveConnectionsToolStripMenuItem.Text = "Show Active Connections";
            this.showActiveConnectionsToolStripMenuItem.Click += new System.EventHandler(this.showActiveConnectionsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 301);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ShardX Wifi Control Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon shardxwifi;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showShardXWifiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showActiveConnectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeShardXWifiToolStripMenuItem;
    }
}


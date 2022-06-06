namespace ThreadingExample
{
    partial class frmGroceryStore
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
            this.btnSendToCheckout = new System.Windows.Forms.Button();
            this.numShoppers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.numLanesOpen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenNewLane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numShoppers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLanesOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendToCheckout
            // 
            this.btnSendToCheckout.Location = new System.Drawing.Point(174, 38);
            this.btnSendToCheckout.Name = "btnSendToCheckout";
            this.btnSendToCheckout.Size = new System.Drawing.Size(141, 23);
            this.btnSendToCheckout.TabIndex = 0;
            this.btnSendToCheckout.Text = "Send to checkout";
            this.btnSendToCheckout.UseVisualStyleBackColor = true;
            this.btnSendToCheckout.Click += new System.EventHandler(this.btnSendToCheckout_Click);
            // 
            // numShoppers
            // 
            this.numShoppers.Location = new System.Drawing.Point(122, 41);
            this.numShoppers.Name = "numShoppers";
            this.numShoppers.Size = new System.Drawing.Size(46, 20);
            this.numShoppers.TabIndex = 2;
            this.numShoppers.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shoppers";
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLog.Location = new System.Drawing.Point(0, 89);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(456, 254);
            this.txtLog.TabIndex = 4;
            this.txtLog.Text = "";
            // 
            // numLanesOpen
            // 
            this.numLanesOpen.Location = new System.Drawing.Point(122, 10);
            this.numLanesOpen.Name = "numLanesOpen";
            this.numLanesOpen.ReadOnly = true;
            this.numLanesOpen.Size = new System.Drawing.Size(46, 20);
            this.numLanesOpen.TabIndex = 5;
            this.numLanesOpen.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Checkout lanes open";
            // 
            // btnOpenNewLane
            // 
            this.btnOpenNewLane.Location = new System.Drawing.Point(174, 10);
            this.btnOpenNewLane.Name = "btnOpenNewLane";
            this.btnOpenNewLane.Size = new System.Drawing.Size(141, 23);
            this.btnOpenNewLane.TabIndex = 7;
            this.btnOpenNewLane.Text = "Open New Lane";
            this.btnOpenNewLane.UseVisualStyleBackColor = true;
            this.btnOpenNewLane.Click += new System.EventHandler(this.btnOpenNewLane_Click);
            // 
            // frmGroceryStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 343);
            this.Controls.Add(this.btnOpenNewLane);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numLanesOpen);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numShoppers);
            this.Controls.Add(this.btnSendToCheckout);
            this.Name = "frmGroceryStore";
            this.Text = "Grocery Store";
            ((System.ComponentModel.ISupportInitialize)(this.numShoppers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLanesOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendToCheckout;
        private System.Windows.Forms.NumericUpDown numShoppers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.NumericUpDown numLanesOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenNewLane;
    }
}



namespace LiveSplit.UI.Components
{
    partial class SplitCounterSettings
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTextBox = new System.Windows.Forms.TextBox();
            this.ignoreSplitsDataGrid = new System.Windows.Forms.DataGridView();
            this.ignoreSplitsLabel = new System.Windows.Forms.Label();
            this.labelNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ignoreSplitsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.45455F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.54546F));
            this.tableLayoutPanel1.Controls.Add(this.labelTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ignoreSplitsDataGrid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ignoreSplitsLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNameLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 393);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelTextBox
            // 
            this.labelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTextBox.Location = new System.Drawing.Point(102, 3);
            this.labelTextBox.Name = "labelTextBox";
            this.labelTextBox.Size = new System.Drawing.Size(379, 22);
            this.labelTextBox.TabIndex = 1;
            // 
            // ignoreSplitsDataGrid
            // 
            this.ignoreSplitsDataGrid.AllowUserToResizeColumns = false;
            this.ignoreSplitsDataGrid.AllowUserToResizeRows = false;
            this.ignoreSplitsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ignoreSplitsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ignoreSplitsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ignoreSplitsDataGrid.Location = new System.Drawing.Point(102, 31);
            this.ignoreSplitsDataGrid.Name = "ignoreSplitsDataGrid";
            this.ignoreSplitsDataGrid.RowHeadersWidth = 51;
            this.ignoreSplitsDataGrid.RowTemplate.Height = 24;
            this.ignoreSplitsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ignoreSplitsDataGrid.Size = new System.Drawing.Size(379, 359);
            this.ignoreSplitsDataGrid.TabIndex = 3;
            // 
            // ignoreSplitsLabel
            // 
            this.ignoreSplitsLabel.AutoSize = true;
            this.ignoreSplitsLabel.Location = new System.Drawing.Point(3, 28);
            this.ignoreSplitsLabel.Name = "ignoreSplitsLabel";
            this.ignoreSplitsLabel.Size = new System.Drawing.Size(86, 17);
            this.ignoreSplitsLabel.TabIndex = 2;
            this.ignoreSplitsLabel.Text = "Ignore Splits";
            // 
            // labelNameLabel
            // 
            this.labelNameLabel.AutoSize = true;
            this.labelNameLabel.Location = new System.Drawing.Point(3, 0);
            this.labelNameLabel.Name = "labelNameLabel";
            this.labelNameLabel.Size = new System.Drawing.Size(43, 17);
            this.labelNameLabel.TabIndex = 0;
            this.labelNameLabel.Text = "Label";
            // 
            // SplitCounterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SplitCounterSettings";
            this.Size = new System.Drawing.Size(487, 396);
            this.Load += new System.EventHandler(this.SplitCounterSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ignoreSplitsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelNameLabel;
        private System.Windows.Forms.TextBox labelTextBox;
        private System.Windows.Forms.Label ignoreSplitsLabel;
        private System.Windows.Forms.DataGridView ignoreSplitsDataGrid;
    }
}

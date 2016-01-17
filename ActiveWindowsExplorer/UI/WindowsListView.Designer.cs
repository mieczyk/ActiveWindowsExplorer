namespace ActiveWindowsExplorer.UI
{
    partial class WindowsListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsListView));
            this._windowsTreeView = new System.Windows.Forms.TreeView();
            this._searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._countLabel = new System.Windows.Forms.Label();
            this._refreshButton = new System.Windows.Forms.Button();
            this._searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _windowsTreeView
            // 
            this._windowsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._windowsTreeView.Location = new System.Drawing.Point(14, 79);
            this._windowsTreeView.Margin = new System.Windows.Forms.Padding(2);
            this._windowsTreeView.Name = "_windowsTreeView";
            this._windowsTreeView.Size = new System.Drawing.Size(500, 342);
            this._windowsTreeView.TabIndex = 2;
            // 
            // _searchTextBox
            // 
            this._searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._searchTextBox.Location = new System.Drawing.Point(14, 48);
            this._searchTextBox.Name = "_searchTextBox";
            this._searchTextBox.Size = new System.Drawing.Size(421, 22);
            this._searchTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Detected windows count:";
            // 
            // _countLabel
            // 
            this._countLabel.AutoSize = true;
            this._countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._countLabel.Location = new System.Drawing.Point(193, 21);
            this._countLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._countLabel.Name = "_countLabel";
            this._countLabel.Size = new System.Drawing.Size(15, 16);
            this._countLabel.TabIndex = 11;
            this._countLabel.Text = "0";
            // 
            // _refreshButton
            // 
            this._refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._refreshButton.Image = global::ActiveWindowsExplorer.Properties.Resources.refresh_24;
            this._refreshButton.Location = new System.Drawing.Point(479, 35);
            this._refreshButton.Margin = new System.Windows.Forms.Padding(2);
            this._refreshButton.Name = "_refreshButton";
            this._refreshButton.Size = new System.Drawing.Size(35, 38);
            this._refreshButton.TabIndex = 10;
            this._refreshButton.UseVisualStyleBackColor = true;
            this._refreshButton.Click += new System.EventHandler(this._refreshButton_Click);
            // 
            // _searchButton
            // 
            this._searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._searchButton.Image = ((System.Drawing.Image)(resources.GetObject("_searchButton.Image")));
            this._searchButton.Location = new System.Drawing.Point(440, 35);
            this._searchButton.Margin = new System.Windows.Forms.Padding(2);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(35, 38);
            this._searchButton.TabIndex = 9;
            this._searchButton.UseVisualStyleBackColor = true;
            // 
            // WindowsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this._countLabel);
            this.Controls.Add(this._refreshButton);
            this.Controls.Add(this._searchButton);
            this.Controls.Add(this._searchTextBox);
            this.Controls.Add(this._windowsTreeView);
            this.Name = "WindowsListView";
            this.Size = new System.Drawing.Size(526, 438);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView _windowsTreeView;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.TextBox _searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _countLabel;
        private System.Windows.Forms.Button _refreshButton;
    }
}

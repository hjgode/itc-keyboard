namespace FunctionKeys2ControlKeys
{
    partial class MapFKeysToCtrlKeys
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuOptions = new System.Windows.Forms.MenuItem();
            this.mnuDump = new System.Windows.Forms.MenuItem();
            this.btnMapKeys = new System.Windows.Forms.Button();
            this.btnRestoreDefaults = new System.Windows.Forms.Button();
            this.mnuRestore = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.mnuOptions);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Exit";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.MenuItems.Add(this.mnuDump);
            this.mnuOptions.MenuItems.Add(this.mnuRestore);
            this.mnuOptions.Text = "Options";
            // 
            // mnuDump
            // 
            this.mnuDump.Text = "Dump Keys";
            this.mnuDump.Click += new System.EventHandler(this.mnuDump_Click);
            // 
            // btnMapKeys
            // 
            this.btnMapKeys.Location = new System.Drawing.Point(31, 84);
            this.btnMapKeys.Name = "btnMapKeys";
            this.btnMapKeys.Size = new System.Drawing.Size(165, 27);
            this.btnMapKeys.TabIndex = 0;
            this.btnMapKeys.Text = "Map Keys";
            this.btnMapKeys.Click += new System.EventHandler(this.btnMapKeys_Click);
            // 
            // btnRestoreDefaults
            // 
            this.btnRestoreDefaults.Location = new System.Drawing.Point(31, 133);
            this.btnRestoreDefaults.Name = "btnRestoreDefaults";
            this.btnRestoreDefaults.Size = new System.Drawing.Size(165, 27);
            this.btnRestoreDefaults.TabIndex = 0;
            this.btnRestoreDefaults.Text = "Restore Defaults";
            this.btnRestoreDefaults.Click += new System.EventHandler(this.btnRestoreDefaults_Click);
            // 
            // mnuRestore
            // 
            this.mnuRestore.Text = "Restore Defaults";
            this.mnuRestore.Click += new System.EventHandler(this.mnuRestore_Click);
            // 
            // MapFKeysToCtrlKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.ControlBox = false;
            this.Controls.Add(this.btnRestoreDefaults);
            this.Controls.Add(this.btnMapKeys);
            this.Menu = this.mainMenu1;
            this.Name = "MapFKeysToCtrlKeys";
            this.Text = "MapFKeysToCtrlKeys";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.Button btnMapKeys;
        private System.Windows.Forms.Button btnRestoreDefaults;
        private System.Windows.Forms.MenuItem mnuOptions;
        private System.Windows.Forms.MenuItem mnuDump;
        private System.Windows.Forms.MenuItem mnuRestore;
    }
}


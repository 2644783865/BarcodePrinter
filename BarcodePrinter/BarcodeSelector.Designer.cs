namespace BarcodePrinter
{
    partial class BarcodeSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeSelector));
            this.cbAssemblyType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtGalvID = new DevExpress.XtraEditors.TextEdit();
            this.spinTotalItems = new DevExpress.XtraEditors.SpinEdit();
            this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbAssemblyType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGalvID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalItems.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAssemblyType
            // 
            this.cbAssemblyType.Location = new System.Drawing.Point(147, 49);
            this.cbAssemblyType.Name = "cbAssemblyType";
            this.cbAssemblyType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssemblyType.Properties.Appearance.Options.UseFont = true;
            this.cbAssemblyType.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cbAssemblyType.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbAssemblyType.Properties.AppearanceFocused.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cbAssemblyType.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbAssemblyType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAssemblyType.Properties.Items.AddRange(new object[] {
            "D6 Root",
            "D9 Root",
            "D9 4 Exit Multibase Root",
            "12 Bolt Root Section 4 Exit",
            "Planted Root",
            "8 Bolt Pad",
            "12 Bolt Pad",
            "Cantilever Root",
            "6 to 8 hole spool piece for deep cast root Version 2",
            "8 to 8 hole spool piece for deep cast root",
            "6 to 8 Hole Adapter Plate",
            "T Range headframe",
            "Elara / S Range / Phase 5 headframe",
            "Alpha Flagpole antennas adaptor",
            "Alpha Streetworks Headframe"});
            this.cbAssemblyType.Size = new System.Drawing.Size(261, 32);
            this.cbAssemblyType.TabIndex = 1;
            // 
            // txtGalvID
            // 
            this.txtGalvID.Location = new System.Drawing.Point(147, 12);
            this.txtGalvID.Name = "txtGalvID";
            this.txtGalvID.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGalvID.Properties.Appearance.Options.UseFont = true;
            this.txtGalvID.Size = new System.Drawing.Size(261, 32);
            this.txtGalvID.TabIndex = 0;
            // 
            // spinTotalItems
            // 
            this.spinTotalItems.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotalItems.Location = new System.Drawing.Point(147, 87);
            this.spinTotalItems.Name = "spinTotalItems";
            this.spinTotalItems.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinTotalItems.Properties.Appearance.Options.UseFont = true;
            this.spinTotalItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTotalItems.Size = new System.Drawing.Size(69, 32);
            this.spinTotalItems.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Appearance.Options.UseFont = true;
            this.btnGenerate.Location = new System.Drawing.Point(291, 147);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(117, 45);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 25);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Galv ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(12, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 25);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Assembly";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 25);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Total";
            // 
            // BarcodeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 211);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.spinTotalItems);
            this.Controls.Add(this.txtGalvID);
            this.Controls.Add(this.cbAssemblyType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarcodeSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.cbAssemblyType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGalvID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalItems.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbAssemblyType;
        private DevExpress.XtraEditors.TextEdit txtGalvID;
        private DevExpress.XtraEditors.SpinEdit spinTotalItems;
        private DevExpress.XtraEditors.SimpleButton btnGenerate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
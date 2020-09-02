namespace AnsProject
{
    partial class FrmMainMdi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMdi));
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.RdRbtnMainClasses = new Telerik.WinControls.UI.RadButtonElement();
            this.RdRbtnSubClasses = new Telerik.WinControls.UI.RadButtonElement();
            this.RdRbtnInstallation = new Telerik.WinControls.UI.RadButtonElement();
            this.RdRbtnMetallurgy = new Telerik.WinControls.UI.RadButtonElement();
            this.RdRbtnSize = new Telerik.WinControls.UI.RadButtonElement();
            this.RdRbtnTickness = new Telerik.WinControls.UI.RadButtonElement();
            this.RdRbtnJointType = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement8 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement9 = new Telerik.WinControls.UI.RadButtonElement();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.RdRbtnNDT = new Telerik.WinControls.UI.RadButtonElement();
            this.radImageButtonElement1 = new Telerik.WinControls.UI.RadImageButtonElement();
            this.radImageButtonElement2 = new Telerik.WinControls.UI.RadImageButtonElement();
            this.radImageButtonElement3 = new Telerik.WinControls.UI.RadImageButtonElement();
            this.radImageButtonElement4 = new Telerik.WinControls.UI.RadImageButtonElement();
            this.radImageButtonElement5 = new Telerik.WinControls.UI.RadImageButtonElement();
            this.radImageButtonElement6 = new Telerik.WinControls.UI.RadImageButtonElement();
            this.radImageButtonElement7 = new Telerik.WinControls.UI.RadImageButtonElement();
            this.radImageButtonElement8 = new Telerik.WinControls.UI.RadImageButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1,
            this.ribbonTab2});
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.LocalizationSettings.LayoutModeText = "Simplified Layout";
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.SimplifiedHeight = 100;
            this.radRibbonBar1.Size = new System.Drawing.Size(1232, 159);
            this.radRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar1.StartButtonImage")));
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "Ans Project";
            this.radRibbonBar1.ThemeName = "Fluent";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Masters";
            this.ribbonTab1.UseMnemonic = false;
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.RdRbtnMainClasses,
            this.radImageButtonElement1,
            this.RdRbtnSubClasses,
            this.radImageButtonElement2,
            this.RdRbtnInstallation,
            this.radImageButtonElement3,
            this.RdRbtnMetallurgy,
            this.radImageButtonElement4,
            this.RdRbtnSize,
            this.radImageButtonElement5,
            this.RdRbtnTickness,
            this.radImageButtonElement6,
            this.RdRbtnJointType,
            this.radImageButtonElement7,
            this.RdRbtnNDT,
            this.radImageButtonElement8});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "Administrator";
            // 
            // RdRbtnMainClasses
            // 
            this.RdRbtnMainClasses.Name = "RdRbtnMainClasses";
            this.RdRbtnMainClasses.Text = "Main Classes";
            this.RdRbtnMainClasses.Click += new System.EventHandler(this.RdRbtnMainClasses_Click);
            // 
            // RdRbtnSubClasses
            // 
            this.RdRbtnSubClasses.Name = "RdRbtnSubClasses";
            this.RdRbtnSubClasses.Text = "Sub Classes";
            // 
            // RdRbtnInstallation
            // 
            this.RdRbtnInstallation.Name = "RdRbtnInstallation";
            this.RdRbtnInstallation.Text = "Installation Type";
            // 
            // RdRbtnMetallurgy
            // 
            this.RdRbtnMetallurgy.Name = "RdRbtnMetallurgy";
            this.RdRbtnMetallurgy.Text = "Metallurgy";
            // 
            // RdRbtnSize
            // 
            this.RdRbtnSize.Name = "RdRbtnSize";
            this.RdRbtnSize.Text = "Size ";
            // 
            // RdRbtnTickness
            // 
            this.RdRbtnTickness.Name = "RdRbtnTickness";
            this.RdRbtnTickness.Text = "Thickness ";
            // 
            // RdRbtnJointType
            // 
            this.RdRbtnJointType.Name = "RdRbtnJointType";
            this.RdRbtnJointType.Text = "Joint Type";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup2});
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Transition";
            this.ribbonTab2.UseMnemonic = false;
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement8,
            this.radButtonElement9});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "Generate Excel";
            // 
            // radButtonElement8
            // 
            this.radButtonElement8.Name = "radButtonElement8";
            this.radButtonElement8.Text = "radButtonElement8";
            // 
            // radButtonElement9
            // 
            this.radButtonElement9.Name = "radButtonElement9";
            this.radButtonElement9.Text = "radButtonElement9";
            // 
            // RdRbtnNDT
            // 
            this.RdRbtnNDT.Name = "RdRbtnNDT";
            this.RdRbtnNDT.Text = "NDT Works";
            // 
            // radImageButtonElement1
            // 
            this.radImageButtonElement1.Name = "radImageButtonElement1";
            this.radImageButtonElement1.Text = "radImageButtonElement1";
            // 
            // radImageButtonElement2
            // 
            this.radImageButtonElement2.Name = "radImageButtonElement2";
            this.radImageButtonElement2.Text = "radImageButtonElement2";
            // 
            // radImageButtonElement3
            // 
            this.radImageButtonElement3.Name = "radImageButtonElement3";
            this.radImageButtonElement3.Text = "radImageButtonElement3";
            // 
            // radImageButtonElement4
            // 
            this.radImageButtonElement4.Name = "radImageButtonElement4";
            this.radImageButtonElement4.Text = "radImageButtonElement4";
            // 
            // radImageButtonElement5
            // 
            this.radImageButtonElement5.Name = "radImageButtonElement5";
            this.radImageButtonElement5.Text = "radImageButtonElement5";
            // 
            // radImageButtonElement6
            // 
            this.radImageButtonElement6.Name = "radImageButtonElement6";
            this.radImageButtonElement6.Text = "radImageButtonElement6";
            // 
            // radImageButtonElement7
            // 
            this.radImageButtonElement7.Name = "radImageButtonElement7";
            this.radImageButtonElement7.Text = "radImageButtonElement7";
            // 
            // radImageButtonElement8
            // 
            this.radImageButtonElement8.Name = "radImageButtonElement8";
            this.radImageButtonElement8.Text = "radImageButtonElement8";
            // 
            // FrmMainMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 634);
            this.Controls.Add(this.radRibbonBar1);
            this.Name = "FrmMainMdi";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Ans Project";
            this.ThemeName = "Fluent";
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadButtonElement RdRbtnMainClasses;
        private Telerik.WinControls.UI.RadButtonElement RdRbtnSubClasses;
        private Telerik.WinControls.UI.RadButtonElement RdRbtnInstallation;
        private Telerik.WinControls.UI.RadButtonElement RdRbtnMetallurgy;
        private Telerik.WinControls.UI.RadButtonElement RdRbtnSize;
        private Telerik.WinControls.UI.RadButtonElement RdRbtnTickness;
        private Telerik.WinControls.UI.RadButtonElement RdRbtnJointType;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement8;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement9;
        private Telerik.WinControls.UI.RadButtonElement RdRbtnNDT;
        private Telerik.WinControls.UI.RadImageButtonElement radImageButtonElement1;
        private Telerik.WinControls.UI.RadImageButtonElement radImageButtonElement2;
        private Telerik.WinControls.UI.RadImageButtonElement radImageButtonElement3;
        private Telerik.WinControls.UI.RadImageButtonElement radImageButtonElement4;
        private Telerik.WinControls.UI.RadImageButtonElement radImageButtonElement5;
        private Telerik.WinControls.UI.RadImageButtonElement radImageButtonElement6;
        private Telerik.WinControls.UI.RadImageButtonElement radImageButtonElement7;
        private Telerik.WinControls.UI.RadImageButtonElement radImageButtonElement8;
    }
}


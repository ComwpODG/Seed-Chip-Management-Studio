
namespace Seed_Chip_Management_Studio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chipsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weaponPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeChipsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addChipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWeaponPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleDarkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardDamageCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noChipDamageCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customChipDamageCalculatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pvEDamageCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ucAddChip1 = new Seed_Chip_Management_Studio.ucAddChip();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.appearanceToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.closeChipsetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chipsetToolStripMenuItem,
            this.weaponPresetToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // chipsetToolStripMenuItem
            // 
            this.chipsetToolStripMenuItem.Name = "chipsetToolStripMenuItem";
            this.chipsetToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.chipsetToolStripMenuItem.Text = "Chipset";
            // 
            // weaponPresetToolStripMenuItem
            // 
            this.weaponPresetToolStripMenuItem.Name = "weaponPresetToolStripMenuItem";
            this.weaponPresetToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.weaponPresetToolStripMenuItem.Text = "Weapon Preset";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openToolStripMenuItem.Text = "Open File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            // 
            // closeChipsetToolStripMenuItem
            // 
            this.closeChipsetToolStripMenuItem.Name = "closeChipsetToolStripMenuItem";
            this.closeChipsetToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.closeChipsetToolStripMenuItem.Text = "Close File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChipsToolStripMenuItem,
            this.addWeaponPresetToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addChipsToolStripMenuItem
            // 
            this.addChipsToolStripMenuItem.Name = "addChipsToolStripMenuItem";
            this.addChipsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addChipsToolStripMenuItem.Text = "Add Chips";
            // 
            // addWeaponPresetToolStripMenuItem
            // 
            this.addWeaponPresetToolStripMenuItem.Name = "addWeaponPresetToolStripMenuItem";
            this.addWeaponPresetToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addWeaponPresetToolStripMenuItem.Text = "Add Weapon Preset";
            // 
            // appearanceToolStripMenuItem
            // 
            this.appearanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleDarkModeToolStripMenuItem});
            this.appearanceToolStripMenuItem.Name = "appearanceToolStripMenuItem";
            this.appearanceToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.appearanceToolStripMenuItem.Text = "Appearance";
            // 
            // toggleDarkModeToolStripMenuItem
            // 
            this.toggleDarkModeToolStripMenuItem.Name = "toggleDarkModeToolStripMenuItem";
            this.toggleDarkModeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.toggleDarkModeToolStripMenuItem.Text = "Toggle Night Mode";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardDamageCalculatorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // standardDamageCalculatorToolStripMenuItem
            // 
            this.standardDamageCalculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noChipDamageCalculatorToolStripMenuItem,
            this.customChipDamageCalculatorToolStripMenuItem1,
            this.pvEDamageCalculatorToolStripMenuItem});
            this.standardDamageCalculatorToolStripMenuItem.Name = "standardDamageCalculatorToolStripMenuItem";
            this.standardDamageCalculatorToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.standardDamageCalculatorToolStripMenuItem.Text = "Calculators";
            // 
            // noChipDamageCalculatorToolStripMenuItem
            // 
            this.noChipDamageCalculatorToolStripMenuItem.Name = "noChipDamageCalculatorToolStripMenuItem";
            this.noChipDamageCalculatorToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.noChipDamageCalculatorToolStripMenuItem.Text = "No-Chip Damage Calculator";
            // 
            // customChipDamageCalculatorToolStripMenuItem1
            // 
            this.customChipDamageCalculatorToolStripMenuItem1.Name = "customChipDamageCalculatorToolStripMenuItem1";
            this.customChipDamageCalculatorToolStripMenuItem1.Size = new System.Drawing.Size(248, 22);
            this.customChipDamageCalculatorToolStripMenuItem1.Text = "Custom Chip Damage Calculator";
            // 
            // pvEDamageCalculatorToolStripMenuItem
            // 
            this.pvEDamageCalculatorToolStripMenuItem.Name = "pvEDamageCalculatorToolStripMenuItem";
            this.pvEDamageCalculatorToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.pvEDamageCalculatorToolStripMenuItem.Text = "PvE Damage Calculator";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(879, 488);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Welcome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucAddChip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(871, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Chips";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 394);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Damage Calculator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ucAddChip1
            // 
            this.ucAddChip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddChip1.Location = new System.Drawing.Point(3, 3);
            this.ucAddChip1.Name = "ucAddChip1";
            this.ucAddChip1.Size = new System.Drawing.Size(865, 456);
            this.ucAddChip1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(879, 518);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Seed Chip Management Studio 3.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chipsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeChipsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addChipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWeaponPresetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appearanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleDarkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardDamageCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noChipDamageCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customChipDamageCalculatorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pvEDamageCalculatorToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripMenuItem weaponPresetToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private ucAddChip ucAddChip1;
    }
}


﻿
namespace JRunner
{
    partial class UpdateSuccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSuccess));
            this.SuccessWizard = new AeroWizard.WizardControl();
            this.SuccessPage = new AeroWizard.WizardPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessWizard)).BeginInit();
            this.SuccessPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SuccessWizard
            // 
            this.SuccessWizard.BackColor = System.Drawing.Color.White;
            this.SuccessWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuccessWizard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessWizard.Location = new System.Drawing.Point(0, 0);
            this.SuccessWizard.Name = "SuccessWizard";
            this.SuccessWizard.Pages.Add(this.SuccessPage);
            this.SuccessWizard.Size = new System.Drawing.Size(554, 401);
            this.SuccessWizard.TabIndex = 0;
            this.SuccessWizard.Text = "J-Runner Pro";
            this.SuccessWizard.Title = "J-Runner Pro";
            this.SuccessWizard.TitleIcon = ((System.Drawing.Icon)(resources.GetObject("SuccessWizard.TitleIcon")));
            // 
            // SuccessPage
            // 
            this.SuccessPage.AllowBack = false;
            this.SuccessPage.AllowCancel = false;
            this.SuccessPage.Controls.Add(this.label2);
            this.SuccessPage.Controls.Add(this.pictureBox1);
            this.SuccessPage.Controls.Add(this.label1);
            this.SuccessPage.IsFinishPage = true;
            this.SuccessPage.Name = "SuccessPage";
            this.SuccessPage.ShowCancel = false;
            this.SuccessPage.Size = new System.Drawing.Size(507, 250);
            this.SuccessPage.TabIndex = 0;
            this.SuccessPage.Text = "Update Successful";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Click Finish to restart and launch the new version";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JRunner.Properties.Resources.greencheck;
            this.pictureBox1.Location = new System.Drawing.Point(2, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "J-Runner Pro has been updated successfully!";
            // 
            // UpdateSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 401);
            this.ControlBox = false;
            this.Controls.Add(this.SuccessWizard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateSuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "J-Runner Pro";
            ((System.ComponentModel.ISupportInitialize)(this.SuccessWizard)).EndInit();
            this.SuccessPage.ResumeLayout(false);
            this.SuccessPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl SuccessWizard;
        private AeroWizard.WizardPage SuccessPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
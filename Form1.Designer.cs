using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.VersionOS = new System.Windows.Forms.Label();
            this.PCName = new System.Windows.Forms.Label();
            this.Processor = new System.Windows.Forms.Label();
            this.RAM = new System.Windows.Forms.Label();
            this.ScreenResolution = new System.Windows.Forms.Label();
            this.VersionOSValue = new System.Windows.Forms.Label();
            this.PCNameValue = new System.Windows.Forms.Label();
            this.ProcessorTypeValue = new System.Windows.Forms.Label();
            this.RAMValue = new System.Windows.Forms.Label();
            this.ScreenResolutionValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VersionOS
            // 
            this.VersionOS.AutoSize = true;
            this.VersionOS.Location = new System.Drawing.Point(13, 13);
            this.VersionOS.Name = "VersionOS";
            this.VersionOS.Size = new System.Drawing.Size(63, 13);
            this.VersionOS.TabIndex = 0;
            this.VersionOS.Text = "Version OS:";
            // 
            // PCName
            // 
            this.PCName.AutoSize = true;
            this.PCName.Location = new System.Drawing.Point(13, 45);
            this.PCName.Name = "PCName";
            this.PCName.Size = new System.Drawing.Size(53, 13);
            this.PCName.TabIndex = 1;
            this.PCName.Text = "PC name:";
            // 
            // Processor
            // 
            this.Processor.AutoSize = true;
            this.Processor.Location = new System.Drawing.Point(13, 75);
            this.Processor.Name = "Processor";
            this.Processor.Size = new System.Drawing.Size(80, 13);
            this.Processor.TabIndex = 2;
            this.Processor.Text = "Processor type:";
            // 
            // RAM
            // 
            this.RAM.AutoSize = true;
            this.RAM.Location = new System.Drawing.Point(13, 104);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(34, 13);
            this.RAM.TabIndex = 3;
            this.RAM.Text = "RAM:";
            // 
            // ScreenResolution
            // 
            this.ScreenResolution.AutoSize = true;
            this.ScreenResolution.Location = new System.Drawing.Point(13, 132);
            this.ScreenResolution.Name = "ScreenResolution";
            this.ScreenResolution.Size = new System.Drawing.Size(92, 13);
            this.ScreenResolution.TabIndex = 4;
            this.ScreenResolution.Text = "Screen resolution:";
            // 
            // VersionOSValue
            // 
            this.VersionOSValue.AutoSize = true;
            this.VersionOSValue.Location = new System.Drawing.Point(284, 12);
            this.VersionOSValue.Name = "VersionOSValue";
            this.VersionOSValue.Size = new System.Drawing.Size(35, 13);
            this.VersionOSValue.TabIndex = 5;
            this.VersionOSValue.Text = "label1";
            // 
            // PCNameValue
            // 
            this.PCNameValue.AutoSize = true;
            this.PCNameValue.Location = new System.Drawing.Point(284, 45);
            this.PCNameValue.Name = "PCNameValue";
            this.PCNameValue.Size = new System.Drawing.Size(35, 13);
            this.PCNameValue.TabIndex = 6;
            this.PCNameValue.Text = "label1";
            // 
            // ProcessorTypeValue
            // 
            this.ProcessorTypeValue.AutoSize = true;
            this.ProcessorTypeValue.Location = new System.Drawing.Point(284, 75);
            this.ProcessorTypeValue.Name = "ProcessorTypeValue";
            this.ProcessorTypeValue.Size = new System.Drawing.Size(35, 13);
            this.ProcessorTypeValue.TabIndex = 7;
            this.ProcessorTypeValue.Text = "label1";
            // 
            // RAMValue
            // 
            this.RAMValue.AutoSize = true;
            this.RAMValue.Location = new System.Drawing.Point(284, 104);
            this.RAMValue.Name = "RAMValue";
            this.RAMValue.Size = new System.Drawing.Size(35, 13);
            this.RAMValue.TabIndex = 8;
            this.RAMValue.Text = "label2";
            // 
            // ScreenResolutionValue
            // 
            this.ScreenResolutionValue.AutoSize = true;
            this.ScreenResolutionValue.Location = new System.Drawing.Point(284, 132);
            this.ScreenResolutionValue.Name = "ScreenResolutionValue";
            this.ScreenResolutionValue.Size = new System.Drawing.Size(35, 13);
            this.ScreenResolutionValue.TabIndex = 9;
            this.ScreenResolutionValue.Text = "label3";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(559, 177);
            this.Controls.Add(this.ScreenResolutionValue);
            this.Controls.Add(this.RAMValue);
            this.Controls.Add(this.ProcessorTypeValue);
            this.Controls.Add(this.PCNameValue);
            this.Controls.Add(this.VersionOSValue);
            this.Controls.Add(this.ScreenResolution);
            this.Controls.Add(this.RAM);
            this.Controls.Add(this.Processor);
            this.Controls.Add(this.PCName);
            this.Controls.Add(this.VersionOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "inform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.File_link);
            this.Load += new System.EventHandler(this.Data_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VersionOS;
        private System.Windows.Forms.Label PCName;
        private System.Windows.Forms.Label Processor;
        private System.Windows.Forms.Label RAM;
        private System.Windows.Forms.Label ScreenResolution;
        private System.Windows.Forms.Label VersionOSValue;
        private System.Windows.Forms.Label PCNameValue;
        private System.Windows.Forms.Label ProcessorTypeValue;
        private System.Windows.Forms.Label RAMValue;
        private System.Windows.Forms.Label ScreenResolutionValue;
    }
}


﻿
namespace PresentationLayer
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.artikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDonuts = new System.Windows.Forms.Button();
            this.buttonMuffins = new System.Windows.Forms.Button();
            this.buttonPops = new System.Windows.Forms.Button();
            this.buttonBoxs = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.panelArticles = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgBill = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBill)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artikliToolStripMenuItem,
            this.zaposleniToolStripMenuItem,
            this.računiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(265, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // artikliToolStripMenuItem
            // 
            this.artikliToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.artikliToolStripMenuItem.Name = "artikliToolStripMenuItem";
            this.artikliToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.artikliToolStripMenuItem.Text = "Artikli";
            this.artikliToolStripMenuItem.Click += new System.EventHandler(this.artikliToolStripMenuItem_Click);
            // 
            // zaposleniToolStripMenuItem
            // 
            this.zaposleniToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.zaposleniToolStripMenuItem.Name = "zaposleniToolStripMenuItem";
            this.zaposleniToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.zaposleniToolStripMenuItem.Text = "Zaposleni";
            this.zaposleniToolStripMenuItem.Click += new System.EventHandler(this.zaposleniToolStripMenuItem_Click);
            // 
            // računiToolStripMenuItem
            // 
            this.računiToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.računiToolStripMenuItem.Name = "računiToolStripMenuItem";
            this.računiToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.računiToolStripMenuItem.Text = "Računi";
            this.računiToolStripMenuItem.Click += new System.EventHandler(this.računiToolStripMenuItem_Click);
            // 
            // buttonDonuts
            // 
            this.buttonDonuts.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonDonuts.FlatAppearance.BorderSize = 3;
            this.buttonDonuts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDonuts.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonDonuts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDonuts.Location = new System.Drawing.Point(14, 47);
            this.buttonDonuts.Name = "buttonDonuts";
            this.buttonDonuts.Size = new System.Drawing.Size(184, 46);
            this.buttonDonuts.TabIndex = 1;
            this.buttonDonuts.Text = "KROFNE";
            this.buttonDonuts.UseVisualStyleBackColor = false;
            this.buttonDonuts.Click += new System.EventHandler(this.buttonDonuts_Click);
            // 
            // buttonMuffins
            // 
            this.buttonMuffins.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonMuffins.FlatAppearance.BorderSize = 3;
            this.buttonMuffins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMuffins.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonMuffins.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMuffins.Location = new System.Drawing.Point(245, 47);
            this.buttonMuffins.Name = "buttonMuffins";
            this.buttonMuffins.Size = new System.Drawing.Size(184, 46);
            this.buttonMuffins.TabIndex = 2;
            this.buttonMuffins.Text = "MAFINI";
            this.buttonMuffins.UseVisualStyleBackColor = false;
            this.buttonMuffins.Click += new System.EventHandler(this.buttonMuffins_Click);
            // 
            // buttonPops
            // 
            this.buttonPops.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPops.FlatAppearance.BorderSize = 3;
            this.buttonPops.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPops.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonPops.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPops.Location = new System.Drawing.Point(470, 47);
            this.buttonPops.Name = "buttonPops";
            this.buttonPops.Size = new System.Drawing.Size(184, 46);
            this.buttonPops.TabIndex = 3;
            this.buttonPops.Text = "POPSI";
            this.buttonPops.UseVisualStyleBackColor = false;
            this.buttonPops.Click += new System.EventHandler(this.buttonPops_Click);
            // 
            // buttonBoxs
            // 
            this.buttonBoxs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonBoxs.FlatAppearance.BorderSize = 3;
            this.buttonBoxs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBoxs.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonBoxs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBoxs.Location = new System.Drawing.Point(695, 47);
            this.buttonBoxs.Name = "buttonBoxs";
            this.buttonBoxs.Size = new System.Drawing.Size(184, 46);
            this.buttonBoxs.TabIndex = 4;
            this.buttonBoxs.Text = "BOXOVI";
            this.buttonBoxs.UseVisualStyleBackColor = false;
            this.buttonBoxs.Click += new System.EventHandler(this.buttonBoxs_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDelete.FlatAppearance.BorderSize = 3;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDelete.Location = new System.Drawing.Point(920, 509);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(171, 46);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "IZBRIŠI";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonPay.FlatAppearance.BorderSize = 3;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonPay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPay.Location = new System.Drawing.Point(1117, 509);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(171, 46);
            this.buttonPay.TabIndex = 7;
            this.buttonPay.Text = "NAPLATI";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // panelArticles
            // 
            this.panelArticles.AutoScroll = true;
            this.panelArticles.Location = new System.Drawing.Point(14, 116);
            this.panelArticles.Name = "panelArticles";
            this.panelArticles.Size = new System.Drawing.Size(881, 438);
            this.panelArticles.TabIndex = 9;
            // 
            // dgBill
            // 
            this.dgBill.AllowUserToAddRows = false;
            this.dgBill.AllowUserToDeleteRows = false;
            this.dgBill.AllowUserToResizeColumns = false;
            this.dgBill.AllowUserToResizeRows = false;
            this.dgBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgBill.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SName,
            this.Price,
            this.Quantity,
            this.Sum});
            this.dgBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgBill.Location = new System.Drawing.Point(920, 116);
            this.dgBill.MultiSelect = false;
            this.dgBill.Name = "dgBill";
            this.dgBill.ReadOnly = true;
            this.dgBill.RowHeadersVisible = false;
            this.dgBill.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgBill.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgBill.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgBill.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.dgBill.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgBill.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgBill.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgBill.RowTemplate.Height = 25;
            this.dgBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBill.Size = new System.Drawing.Size(368, 364);
            this.dgBill.TabIndex = 20;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Id.DefaultCellStyle = dataGridViewCellStyle5;
            this.Id.HeaderText = "Šifra";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 93;
            // 
            // SName
            // 
            this.SName.DataPropertyName = "Name";
            this.SName.HeaderText = "Naziv";
            this.SName.MinimumWidth = 6;
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            this.SName.Width = 96;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Cena";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 86;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Količina";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 113;
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Ukupno";
            this.Sum.MinimumWidth = 6;
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            this.Sum.Width = 110;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1322, 615);
            this.Controls.Add(this.dgBill);
            this.Controls.Add(this.panelArticles);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonBoxs);
            this.Controls.Add(this.buttonPops);
            this.Controls.Add(this.buttonMuffins);
            this.Controls.Add(this.buttonDonuts);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računiToolStripMenuItem;
        private System.Windows.Forms.Button buttonDonuts;
        private System.Windows.Forms.Button buttonMuffins;
        private System.Windows.Forms.Button buttonPops;
        private System.Windows.Forms.Button buttonBoxs;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.FlowLayoutPanel panelArticles;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
    }
}
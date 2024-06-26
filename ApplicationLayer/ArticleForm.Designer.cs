﻿
namespace PresentationLayer
{
    partial class ArticleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDonut = new System.Windows.Forms.CheckBox();
            this.cbMuffin = new System.Windows.Forms.CheckBox();
            this.cbPops = new System.Windows.Forms.CheckBox();
            this.cbBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbArticalDescription = new System.Windows.Forms.TextBox();
            this.tbArticalPrice = new System.Windows.Forms.TextBox();
            this.tbArticalName = new System.Windows.Forms.TextBox();
            this.btnArticalAdd = new System.Windows.Forms.Button();
            this.btnArticalChange = new System.Windows.Forms.Button();
            this.btnArticalDelete = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dgArticles = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(18, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "TIP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(18, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "OPIS:";
            // 
            // cbDonut
            // 
            this.cbDonut.AutoSize = true;
            this.cbDonut.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDonut.ForeColor = System.Drawing.Color.Chocolate;
            this.cbDonut.Location = new System.Drawing.Point(317, 161);
            this.cbDonut.Name = "cbDonut";
            this.cbDonut.Size = new System.Drawing.Size(112, 30);
            this.cbDonut.TabIndex = 6;
            this.cbDonut.Text = "KROFNE";
            this.cbDonut.UseVisualStyleBackColor = true;
            // 
            // cbMuffin
            // 
            this.cbMuffin.AutoSize = true;
            this.cbMuffin.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMuffin.ForeColor = System.Drawing.Color.Chocolate;
            this.cbMuffin.Location = new System.Drawing.Point(151, 161);
            this.cbMuffin.Name = "cbMuffin";
            this.cbMuffin.Size = new System.Drawing.Size(105, 30);
            this.cbMuffin.TabIndex = 7;
            this.cbMuffin.Text = "MAFINI";
            this.cbMuffin.UseVisualStyleBackColor = true;
            // 
            // cbPops
            // 
            this.cbPops.AutoSize = true;
            this.cbPops.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPops.ForeColor = System.Drawing.Color.Chocolate;
            this.cbPops.Location = new System.Drawing.Point(151, 218);
            this.cbPops.Name = "cbPops";
            this.cbPops.Size = new System.Drawing.Size(90, 30);
            this.cbPops.TabIndex = 8;
            this.cbPops.Text = "POPSI";
            this.cbPops.UseVisualStyleBackColor = true;
            // 
            // cbBox
            // 
            this.cbBox.AutoSize = true;
            this.cbBox.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBox.ForeColor = System.Drawing.Color.Chocolate;
            this.cbBox.Location = new System.Drawing.Point(317, 218);
            this.cbBox.Name = "cbBox";
            this.cbBox.Size = new System.Drawing.Size(109, 30);
            this.cbBox.TabIndex = 9;
            this.cbBox.Text = "BOXOVI";
            this.cbBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "NAZIV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(18, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "CENA:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblFileName);
            this.panel1.Controls.Add(this.btnAddPhoto);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbArticalDescription);
            this.panel1.Controls.Add(this.tbArticalPrice);
            this.panel1.Controls.Add(this.tbArticalName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbPops);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbDonut);
            this.panel1.Controls.Add(this.cbMuffin);
            this.panel1.Location = new System.Drawing.Point(114, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 598);
            this.panel1.TabIndex = 12;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(352, 409);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 16);
            this.lblFileName.TabIndex = 21;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddPhoto.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhoto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAddPhoto.Location = new System.Drawing.Point(151, 449);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(135, 43);
            this.btnAddPhoto.TabIndex = 20;
            this.btnAddPhoto.Text = "DODAJ SLIKU";
            this.btnAddPhoto.UseVisualStyleBackColor = false;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(317, 449);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(18, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 35);
            this.label5.TabIndex = 16;
            this.label5.Text = "SLIKA:";
            // 
            // tbArticalDescription
            // 
            this.tbArticalDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbArticalDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbArticalDescription.Location = new System.Drawing.Point(151, 300);
            this.tbArticalDescription.Multiline = true;
            this.tbArticalDescription.Name = "tbArticalDescription";
            this.tbArticalDescription.Size = new System.Drawing.Size(286, 93);
            this.tbArticalDescription.TabIndex = 15;
            // 
            // tbArticalPrice
            // 
            this.tbArticalPrice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbArticalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbArticalPrice.Location = new System.Drawing.Point(151, 82);
            this.tbArticalPrice.Multiline = true;
            this.tbArticalPrice.Name = "tbArticalPrice";
            this.tbArticalPrice.Size = new System.Drawing.Size(286, 26);
            this.tbArticalPrice.TabIndex = 14;
            // 
            // tbArticalName
            // 
            this.tbArticalName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbArticalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbArticalName.Location = new System.Drawing.Point(151, 20);
            this.tbArticalName.Multiline = true;
            this.tbArticalName.Name = "tbArticalName";
            this.tbArticalName.Size = new System.Drawing.Size(286, 26);
            this.tbArticalName.TabIndex = 13;
            // 
            // btnArticalAdd
            // 
            this.btnArticalAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnArticalAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticalAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnArticalAdd.Location = new System.Drawing.Point(656, 459);
            this.btnArticalAdd.Name = "btnArticalAdd";
            this.btnArticalAdd.Size = new System.Drawing.Size(216, 51);
            this.btnArticalAdd.TabIndex = 16;
            this.btnArticalAdd.Text = "DODAJ";
            this.btnArticalAdd.UseVisualStyleBackColor = false;
            this.btnArticalAdd.Click += new System.EventHandler(this.btnArticalAdd_Click);
            // 
            // btnArticalChange
            // 
            this.btnArticalChange.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnArticalChange.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticalChange.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnArticalChange.Location = new System.Drawing.Point(880, 534);
            this.btnArticalChange.Name = "btnArticalChange";
            this.btnArticalChange.Size = new System.Drawing.Size(194, 55);
            this.btnArticalChange.TabIndex = 17;
            this.btnArticalChange.Text = "IZMENI";
            this.btnArticalChange.UseVisualStyleBackColor = false;
            this.btnArticalChange.Click += new System.EventHandler(this.btnArticalChange_Click);
            // 
            // btnArticalDelete
            // 
            this.btnArticalDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnArticalDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticalDelete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnArticalDelete.Location = new System.Drawing.Point(1063, 459);
            this.btnArticalDelete.Name = "btnArticalDelete";
            this.btnArticalDelete.Size = new System.Drawing.Size(204, 51);
            this.btnArticalDelete.TabIndex = 18;
            this.btnArticalDelete.Text = "IZBRISI";
            this.btnArticalDelete.UseVisualStyleBackColor = false;
            this.btnArticalDelete.Click += new System.EventHandler(this.btnArticalDelete_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "dialog";
            // 
            // dgArticles
            // 
            this.dgArticles.AllowUserToAddRows = false;
            this.dgArticles.AllowUserToDeleteRows = false;
            this.dgArticles.AllowUserToResizeColumns = false;
            this.dgArticles.AllowUserToResizeRows = false;
            this.dgArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgArticles.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SName,
            this.Price,
            this.Type});
            this.dgArticles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgArticles.Location = new System.Drawing.Point(709, 49);
            this.dgArticles.MultiSelect = false;
            this.dgArticles.Name = "dgArticles";
            this.dgArticles.ReadOnly = true;
            this.dgArticles.RowHeadersVisible = false;
            this.dgArticles.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgArticles.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgArticles.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgArticles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.dgArticles.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgArticles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgArticles.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgArticles.RowTemplate.Height = 25;
            this.dgArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgArticles.Size = new System.Drawing.Size(513, 331);
            this.dgArticles.TabIndex = 19;
            this.dgArticles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgArticles_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Id.DefaultCellStyle = dataGridViewCellStyle2;
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
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Tip";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 73;
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1305, 718);
            this.Controls.Add(this.dgArticles);
            this.Controls.Add(this.btnArticalDelete);
            this.Controls.Add(this.btnArticalChange);
            this.Controls.Add(this.btnArticalAdd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ArticleForm";
            this.Text = "Artikli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ArticleForm_FormClosed);
            this.Load += new System.EventHandler(this.Articals_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbDonut;
        private System.Windows.Forms.CheckBox cbMuffin;
        private System.Windows.Forms.CheckBox cbPops;
        private System.Windows.Forms.CheckBox cbBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbArticalDescription;
        private System.Windows.Forms.TextBox tbArticalPrice;
        private System.Windows.Forms.TextBox tbArticalName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnArticalAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnArticalChange;
        private System.Windows.Forms.Button btnArticalDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.DataGridView dgArticles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Label lblFileName;
    }
}
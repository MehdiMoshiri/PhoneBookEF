namespace PhoneBookEF
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
            this.components = new System.ComponentModel.Container();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_mobil = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_mobil = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personMobilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Blue;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(273, 383);
            this.btn_search.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(86, 54);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(185, 383);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 54);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(97, 383);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(86, 54);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Location = new System.Drawing.Point(9, 383);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(86, 54);
            this.btn_insert.TabIndex = 9;
            this.btn_insert.Text = "Save";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(20, 347);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(75, 20);
            this.lbl_address.TabIndex = 7;
            this.lbl_address.Text = "Address";
            // 
            // lbl_mobil
            // 
            this.lbl_mobil.AutoSize = true;
            this.lbl_mobil.Location = new System.Drawing.Point(560, 310);
            this.lbl_mobil.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_mobil.Name = "lbl_mobil";
            this.lbl_mobil.Size = new System.Drawing.Size(51, 20);
            this.lbl_mobil.TabIndex = 5;
            this.lbl_mobil.Text = "Mobil";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(316, 310);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(60, 20);
            this.lbl_phone.TabIndex = 3;
            this.lbl_phone.Text = "Phone";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(20, 310);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(43, 20);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Title";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(107, 344);
            this.txt_address.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_address.Name = "txt_address";
            this.txt_address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_address.Size = new System.Drawing.Size(714, 26);
            this.txt_address.TabIndex = 8;
            this.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_mobil
            // 
            this.txt_mobil.Location = new System.Drawing.Point(623, 307);
            this.txt_mobil.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_mobil.Name = "txt_mobil";
            this.txt_mobil.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_mobil.Size = new System.Drawing.Size(198, 26);
            this.txt_mobil.TabIndex = 6;
            this.txt_mobil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(388, 307);
            this.txt_tel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_tel.Size = new System.Drawing.Size(160, 26);
            this.txt_tel.TabIndex = 4;
            this.txt_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(75, 307);
            this.txt_title.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_title.Name = "txt_title";
            this.txt_title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_title.Size = new System.Drawing.Size(229, 26);
            this.txt_title.TabIndex = 2;
            this.txt_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgv1
            // 
            this.dgv1.AutoGenerateColumns = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIDDataGridViewTextBoxColumn,
            this.personTitleDataGridViewTextBoxColumn,
            this.personPhoneDataGridViewTextBoxColumn,
            this.personMobilDataGridViewTextBoxColumn,
            this.personAddressDataGridViewTextBoxColumn});
            this.dgv1.DataSource = this.personBindingSource;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(828, 293);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(735, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(647, 383);
            this.btn_new.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(86, 54);
            this.btn_new.TabIndex = 13;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.FillWeight = 35F;
            this.personIDDataGridViewTextBoxColumn.HeaderText = "Id";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            // 
            // personTitleDataGridViewTextBoxColumn
            // 
            this.personTitleDataGridViewTextBoxColumn.DataPropertyName = "PersonTitle";
            this.personTitleDataGridViewTextBoxColumn.FillWeight = 120F;
            this.personTitleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.personTitleDataGridViewTextBoxColumn.Name = "personTitleDataGridViewTextBoxColumn";
            // 
            // personPhoneDataGridViewTextBoxColumn
            // 
            this.personPhoneDataGridViewTextBoxColumn.DataPropertyName = "PersonPhone";
            this.personPhoneDataGridViewTextBoxColumn.FillWeight = 60F;
            this.personPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.personPhoneDataGridViewTextBoxColumn.Name = "personPhoneDataGridViewTextBoxColumn";
            // 
            // personMobilDataGridViewTextBoxColumn
            // 
            this.personMobilDataGridViewTextBoxColumn.DataPropertyName = "PersonMobil";
            this.personMobilDataGridViewTextBoxColumn.FillWeight = 60F;
            this.personMobilDataGridViewTextBoxColumn.HeaderText = "Mobil";
            this.personMobilDataGridViewTextBoxColumn.Name = "personMobilDataGridViewTextBoxColumn";
            // 
            // personAddressDataGridViewTextBoxColumn
            // 
            this.personAddressDataGridViewTextBoxColumn.DataPropertyName = "PersonAddress";
            this.personAddressDataGridViewTextBoxColumn.FillWeight = 80F;
            this.personAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.personAddressDataGridViewTextBoxColumn.Name = "personAddressDataGridViewTextBoxColumn";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(PhoneBookEF.Person);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 442);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_mobil);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_mobil);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Phone Book EF ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_mobil;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_mobil;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personMobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personAddressDataGridViewTextBoxColumn;
    }
}


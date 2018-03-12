namespace ZgloszeniaAppka
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.zgloszenia_lb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zgloszenieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOtworzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZamknieciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komentarzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzytkownikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zgloszeniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaZgloszenDataSet = new ZgloszeniaAppka.BazaZgloszenDataSet();
            this.zgloszeniaTableAdapter = new ZgloszeniaAppka.BazaZgloszenDataSetTableAdapters.ZgloszeniaTableAdapter();
            this.nowe_btn = new System.Windows.Forms.Button();
            this.zamkniete_btn = new System.Windows.Forms.Button();
            this.aktualne_btn = new System.Windows.Forms.Button();
            this.wszystkie_btn = new System.Windows.Forms.Button();
            this.usun_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.zamknij_btn = new System.Windows.Forms.Button();
            this.znajdz_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgloszeniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaZgloszenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // zgloszenia_lb
            // 
            this.zgloszenia_lb.AutoSize = true;
            this.zgloszenia_lb.BackColor = System.Drawing.Color.Transparent;
            this.zgloszenia_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zgloszenia_lb.ForeColor = System.Drawing.Color.White;
            this.zgloszenia_lb.Location = new System.Drawing.Point(6, 7);
            this.zgloszenia_lb.Name = "zgloszenia_lb";
            this.zgloszenia_lb.Size = new System.Drawing.Size(156, 31);
            this.zgloszenia_lb.TabIndex = 0;
            this.zgloszenia_lb.Text = "Zgłoszenia";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zgloszenieIDDataGridViewTextBoxColumn,
            this.tytulDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.dataOtworzeniaDataGridViewTextBoxColumn,
            this.dataZamknieciaDataGridViewTextBoxColumn,
            this.komentarzDataGridViewTextBoxColumn,
            this.uzytkownikIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zgloszeniaBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.Size = new System.Drawing.Size(874, 331);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // zgloszenieIDDataGridViewTextBoxColumn
            // 
            this.zgloszenieIDDataGridViewTextBoxColumn.DataPropertyName = "ZgloszenieID";
            this.zgloszenieIDDataGridViewTextBoxColumn.HeaderText = "Numer";
            this.zgloszenieIDDataGridViewTextBoxColumn.Name = "zgloszenieIDDataGridViewTextBoxColumn";
            this.zgloszenieIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.zgloszenieIDDataGridViewTextBoxColumn.Width = 119;
            // 
            // tytulDataGridViewTextBoxColumn
            // 
            this.tytulDataGridViewTextBoxColumn.DataPropertyName = "Tytul";
            this.tytulDataGridViewTextBoxColumn.HeaderText = "Tytuł";
            this.tytulDataGridViewTextBoxColumn.Name = "tytulDataGridViewTextBoxColumn";
            this.tytulDataGridViewTextBoxColumn.Width = 119;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 119;
            // 
            // dataOtworzeniaDataGridViewTextBoxColumn
            // 
            this.dataOtworzeniaDataGridViewTextBoxColumn.DataPropertyName = "DataOtworzenia";
            this.dataOtworzeniaDataGridViewTextBoxColumn.HeaderText = "Data Utworzenia";
            this.dataOtworzeniaDataGridViewTextBoxColumn.Name = "dataOtworzeniaDataGridViewTextBoxColumn";
            this.dataOtworzeniaDataGridViewTextBoxColumn.Width = 119;
            // 
            // dataZamknieciaDataGridViewTextBoxColumn
            // 
            this.dataZamknieciaDataGridViewTextBoxColumn.DataPropertyName = "DataZamkniecia";
            this.dataZamknieciaDataGridViewTextBoxColumn.HeaderText = "Data Zamkniecia";
            this.dataZamknieciaDataGridViewTextBoxColumn.Name = "dataZamknieciaDataGridViewTextBoxColumn";
            this.dataZamknieciaDataGridViewTextBoxColumn.Width = 119;
            // 
            // komentarzDataGridViewTextBoxColumn
            // 
            this.komentarzDataGridViewTextBoxColumn.DataPropertyName = "Komentarz";
            this.komentarzDataGridViewTextBoxColumn.HeaderText = "Komentarz";
            this.komentarzDataGridViewTextBoxColumn.Name = "komentarzDataGridViewTextBoxColumn";
            this.komentarzDataGridViewTextBoxColumn.Width = 119;
            // 
            // uzytkownikIDDataGridViewTextBoxColumn
            // 
            this.uzytkownikIDDataGridViewTextBoxColumn.DataPropertyName = "UzytkownikID";
            this.uzytkownikIDDataGridViewTextBoxColumn.HeaderText = "UzytkownikID";
            this.uzytkownikIDDataGridViewTextBoxColumn.Name = "uzytkownikIDDataGridViewTextBoxColumn";
            this.uzytkownikIDDataGridViewTextBoxColumn.Width = 119;
            // 
            // zgloszeniaBindingSource
            // 
            this.zgloszeniaBindingSource.DataMember = "Zgloszenia";
            this.zgloszeniaBindingSource.DataSource = this.bazaZgloszenDataSet;
            // 
            // bazaZgloszenDataSet
            // 
            this.bazaZgloszenDataSet.DataSetName = "BazaZgloszenDataSet";
            this.bazaZgloszenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zgloszeniaTableAdapter
            // 
            this.zgloszeniaTableAdapter.ClearBeforeFill = true;
            // 
            // nowe_btn
            // 
            this.nowe_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.nowe_btn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.nowe_btn.FlatAppearance.BorderSize = 0;
            this.nowe_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.nowe_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.nowe_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nowe_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nowe_btn.Location = new System.Drawing.Point(-1, 374);
            this.nowe_btn.Name = "nowe_btn";
            this.nowe_btn.Size = new System.Drawing.Size(114, 30);
            this.nowe_btn.TabIndex = 2;
            this.nowe_btn.Text = "Nowe zgłoszenie";
            this.nowe_btn.UseVisualStyleBackColor = false;
            this.nowe_btn.Click += new System.EventHandler(this.nowe_btn_Click);
            // 
            // zamkniete_btn
            // 
            this.zamkniete_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.zamkniete_btn.FlatAppearance.BorderSize = 0;
            this.zamkniete_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.zamkniete_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.zamkniete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zamkniete_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.zamkniete_btn.Location = new System.Drawing.Point(113, 374);
            this.zamkniete_btn.Name = "zamkniete_btn";
            this.zamkniete_btn.Size = new System.Drawing.Size(122, 30);
            this.zamkniete_btn.TabIndex = 3;
            this.zamkniete_btn.Text = "Zamknięte zgłoszenia";
            this.zamkniete_btn.UseVisualStyleBackColor = false;
            this.zamkniete_btn.Click += new System.EventHandler(this.zamkniete_btn_Click);
            // 
            // aktualne_btn
            // 
            this.aktualne_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.aktualne_btn.FlatAppearance.BorderSize = 0;
            this.aktualne_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.aktualne_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.aktualne_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aktualne_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.aktualne_btn.Location = new System.Drawing.Point(235, 374);
            this.aktualne_btn.Name = "aktualne_btn";
            this.aktualne_btn.Size = new System.Drawing.Size(111, 30);
            this.aktualne_btn.TabIndex = 4;
            this.aktualne_btn.Text = "Aktualne zlecenia";
            this.aktualne_btn.UseVisualStyleBackColor = false;
            this.aktualne_btn.Click += new System.EventHandler(this.aktualne_btn_Click);
            // 
            // wszystkie_btn
            // 
            this.wszystkie_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.wszystkie_btn.FlatAppearance.BorderSize = 0;
            this.wszystkie_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.wszystkie_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.wszystkie_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wszystkie_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.wszystkie_btn.Location = new System.Drawing.Point(346, 374);
            this.wszystkie_btn.Name = "wszystkie_btn";
            this.wszystkie_btn.Size = new System.Drawing.Size(104, 30);
            this.wszystkie_btn.TabIndex = 5;
            this.wszystkie_btn.Text = "Wszystkie";
            this.wszystkie_btn.UseVisualStyleBackColor = false;
            this.wszystkie_btn.Click += new System.EventHandler(this.wszystkie_btn_Click);
            // 
            // usun_btn
            // 
            this.usun_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.usun_btn.FlatAppearance.BorderSize = 0;
            this.usun_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.usun_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.usun_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usun_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.usun_btn.Location = new System.Drawing.Point(765, 374);
            this.usun_btn.Name = "usun_btn";
            this.usun_btn.Size = new System.Drawing.Size(108, 30);
            this.usun_btn.TabIndex = 6;
            this.usun_btn.Text = "Usuń";
            this.usun_btn.UseVisualStyleBackColor = false;
            this.usun_btn.Click += new System.EventHandler(this.usun_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.refresh_btn.FlatAppearance.BorderSize = 0;
            this.refresh_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.refresh_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.refresh_btn.Location = new System.Drawing.Point(660, 374);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(105, 30);
            this.refresh_btn.TabIndex = 7;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // zamknij_btn
            // 
            this.zamknij_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.zamknij_btn.FlatAppearance.BorderSize = 0;
            this.zamknij_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.zamknij_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.zamknij_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zamknij_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.zamknij_btn.Location = new System.Drawing.Point(556, 374);
            this.zamknij_btn.Name = "zamknij_btn";
            this.zamknij_btn.Size = new System.Drawing.Size(104, 30);
            this.zamknij_btn.TabIndex = 8;
            this.zamknij_btn.Text = "Zamknij";
            this.zamknij_btn.UseVisualStyleBackColor = false;
            this.zamknij_btn.Click += new System.EventHandler(this.zamknij_btn_Click);
            // 
            // znajdz_tb
            // 
            this.znajdz_tb.Location = new System.Drawing.Point(528, 12);
            this.znajdz_tb.Name = "znajdz_tb";
            this.znajdz_tb.Size = new System.Drawing.Size(298, 20);
            this.znajdz_tb.TabIndex = 9;
            this.znajdz_tb.TextChanged += new System.EventHandler(this.znajdz_tb_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(842, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(873, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.znajdz_tb);
            this.Controls.Add(this.zamknij_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.usun_btn);
            this.Controls.Add(this.wszystkie_btn);
            this.Controls.Add(this.aktualne_btn);
            this.Controls.Add(this.zamkniete_btn);
            this.Controls.Add(this.nowe_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.zgloszenia_lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgloszeniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaZgloszenDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label zgloszenia_lb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BazaZgloszenDataSet bazaZgloszenDataSet;
        private System.Windows.Forms.BindingSource zgloszeniaBindingSource;
        private BazaZgloszenDataSetTableAdapters.ZgloszeniaTableAdapter zgloszeniaTableAdapter;
        private System.Windows.Forms.Button nowe_btn;
        private System.Windows.Forms.Button zamkniete_btn;
        private System.Windows.Forms.Button aktualne_btn;
        private System.Windows.Forms.Button wszystkie_btn;
        private System.Windows.Forms.Button usun_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button zamknij_btn;
        private System.Windows.Forms.TextBox znajdz_tb;
        private System.Windows.Forms.DataGridViewTextBoxColumn zgloszenieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOtworzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZamknieciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn komentarzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzytkownikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}


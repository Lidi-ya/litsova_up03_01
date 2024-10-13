namespace Fotoalbom
{
    partial class Form_albom
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_albom = new System.Windows.Forms.DataGridView();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photoalbumDataSet = new Fotoalbom.PhotoalbumDataSet();
            this.albumsTableAdapter = new Fotoalbom.PhotoalbumDataSetTableAdapters.AlbumsTableAdapter();
            this.button_add = new System.Windows.Forms.Button();
            this.button_red = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.textBox_nomer_alboma = new System.Windows.Forms.TextBox();
            this.textBox_polz = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.label_nomer_alboma = new System.Windows.Forms.Label();
            this.label_polz = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_albom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoalbumDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_albom
            // 
            this.dataGridView_albom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView_albom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_albom.Location = new System.Drawing.Point(70, 24);
            this.dataGridView_albom.Name = "dataGridView_albom";
            this.dataGridView_albom.RowHeadersWidth = 62;
            this.dataGridView_albom.RowTemplate.Height = 28;
            this.dataGridView_albom.Size = new System.Drawing.Size(657, 205);
            this.dataGridView_albom.TabIndex = 0;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.photoalbumDataSet;
            // 
            // photoalbumDataSet
            // 
            this.photoalbumDataSet.DataSetName = "PhotoalbumDataSet";
            this.photoalbumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_add.Font = new System.Drawing.Font("MV Boli", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(563, 262);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(192, 56);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_red
            // 
            this.button_red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_red.Font = new System.Drawing.Font("MV Boli", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_red.Location = new System.Drawing.Point(563, 363);
            this.button_red.Name = "button_red";
            this.button_red.Size = new System.Drawing.Size(192, 55);
            this.button_red.TabIndex = 2;
            this.button_red.Text = "Изменить";
            this.button_red.UseVisualStyleBackColor = false;
            this.button_red.Click += new System.EventHandler(this.button_red_Click);
            // 
            // button_del
            // 
            this.button_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_del.Font = new System.Drawing.Font("MV Boli", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_del.Location = new System.Drawing.Point(563, 458);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(192, 61);
            this.button_del.TabIndex = 3;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // textBox_nomer_alboma
            // 
            this.textBox_nomer_alboma.Location = new System.Drawing.Point(335, 292);
            this.textBox_nomer_alboma.Name = "textBox_nomer_alboma";
            this.textBox_nomer_alboma.Size = new System.Drawing.Size(100, 26);
            this.textBox_nomer_alboma.TabIndex = 4;
            // 
            // textBox_polz
            // 
            this.textBox_polz.Location = new System.Drawing.Point(335, 353);
            this.textBox_polz.Name = "textBox_polz";
            this.textBox_polz.Size = new System.Drawing.Size(100, 26);
            this.textBox_polz.TabIndex = 5;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(335, 413);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 26);
            this.textBox_name.TabIndex = 6;
            // 
            // textBox_data
            // 
            this.textBox_data.Location = new System.Drawing.Point(335, 475);
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.Size = new System.Drawing.Size(100, 26);
            this.textBox_data.TabIndex = 7;
            // 
            // label_nomer_alboma
            // 
            this.label_nomer_alboma.AutoSize = true;
            this.label_nomer_alboma.Font = new System.Drawing.Font("MV Boli", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_nomer_alboma.Location = new System.Drawing.Point(63, 292);
            this.label_nomer_alboma.Name = "label_nomer_alboma";
            this.label_nomer_alboma.Size = new System.Drawing.Size(192, 37);
            this.label_nomer_alboma.TabIndex = 8;
            this.label_nomer_alboma.Text = "№ альбома";
            // 
            // label_polz
            // 
            this.label_polz.AutoSize = true;
            this.label_polz.Font = new System.Drawing.Font("MV Boli", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_polz.Location = new System.Drawing.Point(63, 353);
            this.label_polz.Name = "label_polz";
            this.label_polz.Size = new System.Drawing.Size(228, 37);
            this.label_polz.TabIndex = 9;
            this.label_polz.Text = "Пользователь";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("MV Boli", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_name.Location = new System.Drawing.Point(63, 413);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(162, 37);
            this.label_name.TabIndex = 10;
            this.label_name.Text = "Название";
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("MV Boli", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_data.Location = new System.Drawing.Point(63, 465);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(247, 37);
            this.label_data.TabIndex = 11;
            this.label_data.Text = "Дата создания";
            // 
            // Form_albom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_polz);
            this.Controls.Add(this.label_nomer_alboma);
            this.Controls.Add(this.textBox_data);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_polz);
            this.Controls.Add(this.textBox_nomer_alboma);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_red);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView_albom);
            this.Name = "Form_albom";
            this.Text = "Альбомы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_albom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoalbumDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_albom;
        private PhotoalbumDataSet photoalbumDataSet;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private PhotoalbumDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_red;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.TextBox textBox_nomer_alboma;
        private System.Windows.Forms.TextBox textBox_polz;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_data;
        private System.Windows.Forms.Label label_nomer_alboma;
        private System.Windows.Forms.Label label_polz;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_data;
    }
}


namespace HomeTask_WindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Create = new Button();
            GetAll = new Button();
            GetById = new Button();
            Update = new Button();
            Delete = new Button();
            musicName = new TextBox();
            artistName = new TextBox();
            musicDuration = new TextBox();
            categoryId = new TextBox();
            artistId = new TextBox();
            dataGridView1 = new DataGridView();
            id = new TextBox();
            dataGridView2 = new DataGridView();
            updateId = new TextBox();
            musicN = new TextBox();
            artistN = new TextBox();
            durationBtn = new TextBox();
            lastId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // Create
            // 
            Create.Location = new Point(12, 22);
            Create.Name = "Create";
            Create.Size = new Size(186, 68);
            Create.TabIndex = 0;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // GetAll
            // 
            GetAll.Location = new Point(34, 108);
            GetAll.Name = "GetAll";
            GetAll.Size = new Size(186, 65);
            GetAll.TabIndex = 1;
            GetAll.Text = "GetAll";
            GetAll.UseVisualStyleBackColor = true;
            GetAll.Click += GetAll_Click;
            // 
            // GetById
            // 
            GetById.Location = new Point(35, 194);
            GetById.Name = "GetById";
            GetById.Size = new Size(185, 65);
            GetById.TabIndex = 2;
            GetById.Text = "GetById";
            GetById.UseVisualStyleBackColor = true;
            GetById.Click += GetById_Click;
            // 
            // Update
            // 
            Update.Location = new Point(34, 276);
            Update.Name = "Update";
            Update.Size = new Size(185, 67);
            Update.TabIndex = 3;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(31, 361);
            Delete.Name = "Delete";
            Delete.Size = new Size(188, 77);
            Delete.TabIndex = 4;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // musicName
            // 
            musicName.Location = new Point(213, 43);
            musicName.Name = "musicName";
            musicName.Size = new Size(125, 27);
            musicName.TabIndex = 5;
            // 
            // artistName
            // 
            artistName.Location = new Point(344, 43);
            artistName.Name = "artistName";
            artistName.Size = new Size(125, 27);
            artistName.TabIndex = 6;
            // 
            // musicDuration
            // 
            musicDuration.Location = new Point(475, 43);
            musicDuration.Name = "musicDuration";
            musicDuration.Size = new Size(125, 27);
            musicDuration.TabIndex = 7;
            // 
            // categoryId
            // 
            categoryId.Location = new Point(636, 43);
            categoryId.Name = "categoryId";
            categoryId.Size = new Size(42, 27);
            categoryId.TabIndex = 8;
            // 
            // artistId
            // 
            artistId.Location = new Point(698, 43);
            artistId.Name = "artistId";
            artistId.Size = new Size(43, 27);
            artistId.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(254, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(542, 100);
            dataGridView1.TabIndex = 10;
            // 
            // id
            // 
            id.Location = new Point(225, 213);
            id.Name = "id";
            id.Size = new Size(30, 27);
            id.TabIndex = 11;
            id.TextChanged += id_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(274, 180);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(521, 79);
            dataGridView2.TabIndex = 12;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // updateId
            // 
            updateId.Location = new Point(225, 296);
            updateId.Name = "updateId";
            updateId.Size = new Size(30, 27);
            updateId.TabIndex = 14;
            // 
            // musicN
            // 
            musicN.Location = new Point(290, 296);
            musicN.Name = "musicN";
            musicN.Size = new Size(150, 27);
            musicN.TabIndex = 15;
            // 
            // artistN
            // 
            artistN.Location = new Point(466, 296);
            artistN.Name = "artistN";
            artistN.Size = new Size(145, 27);
            artistN.TabIndex = 16;
            // 
            // durationBtn
            // 
            durationBtn.Location = new Point(636, 296);
            durationBtn.Name = "durationBtn";
            durationBtn.Size = new Size(152, 27);
            durationBtn.TabIndex = 17;
            // 
            // lastId
            // 
            lastId.Location = new Point(239, 386);
            lastId.Name = "lastId";
            lastId.Size = new Size(30, 27);
            lastId.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lastId);
            Controls.Add(durationBtn);
            Controls.Add(artistN);
            Controls.Add(musicN);
            Controls.Add(updateId);
            Controls.Add(dataGridView2);
            Controls.Add(id);
            Controls.Add(dataGridView1);
            Controls.Add(artistId);
            Controls.Add(categoryId);
            Controls.Add(musicDuration);
            Controls.Add(artistName);
            Controls.Add(musicName);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(GetById);
            Controls.Add(GetAll);
            Controls.Add(Create);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Create;
        private Button GetAll;
        private Button GetById;
        private Button Update;
        private Button Delete;
        private TextBox musicName;
        private TextBox artistName;
        private TextBox musicDuration;
        private TextBox categoryId;
        private TextBox artistId;
        private DataGridView dataGridView1;
        private TextBox id;
        private DataGridView dataGridView2;
        private TextBox updateId;
        private TextBox musicN;
        private TextBox artistN;
        private TextBox durationBtn;
        private TextBox lastId;
    }
}

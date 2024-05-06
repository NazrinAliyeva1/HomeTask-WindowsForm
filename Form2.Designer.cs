namespace HomeTask_WindowsForms
{
    partial class Form2
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
            lastId = new TextBox();
            durationBtn = new TextBox();
            artistN = new TextBox();
            musicN = new TextBox();
            updateId = new TextBox();
            dataGridView2 = new DataGridView();
            id = new TextBox();
            dataGridView1 = new DataGridView();
            artistId = new TextBox();
            categoryId = new TextBox();
            musicDuration = new TextBox();
            artistName = new TextBox();
            musicGenre = new TextBox();
            Delete = new Button();
            Update = new Button();
            GetById = new Button();
            GetAll = new Button();
            Create = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lastId
            // 
            lastId.Location = new Point(235, 381);
            lastId.Name = "lastId";
            lastId.Size = new Size(30, 27);
            lastId.TabIndex = 37;
            // 
            // durationBtn
            // 
            durationBtn.Location = new Point(632, 291);
            durationBtn.Name = "durationBtn";
            durationBtn.Size = new Size(152, 27);
            durationBtn.TabIndex = 36;
            // 
            // artistN
            // 
            artistN.Location = new Point(462, 291);
            artistN.Name = "artistN";
            artistN.Size = new Size(145, 27);
            artistN.TabIndex = 35;
            // 
            // musicN
            // 
            musicN.Location = new Point(286, 291);
            musicN.Name = "musicN";
            musicN.Size = new Size(150, 27);
            musicN.TabIndex = 34;
            // 
            // updateId
            // 
            updateId.Location = new Point(221, 291);
            updateId.Name = "updateId";
            updateId.Size = new Size(30, 27);
            updateId.TabIndex = 33;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(270, 175);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(521, 79);
            dataGridView2.TabIndex = 31;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // id
            // 
            id.Location = new Point(221, 208);
            id.Name = "id";
            id.Size = new Size(30, 27);
            id.TabIndex = 30;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(250, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(542, 100);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // artistId
            // 
            artistId.Location = new Point(694, 38);
            artistId.Name = "artistId";
            artistId.Size = new Size(43, 27);
            artistId.TabIndex = 28;
            // 
            // categoryId
            // 
            categoryId.Location = new Point(632, 38);
            categoryId.Name = "categoryId";
            categoryId.Size = new Size(42, 27);
            categoryId.TabIndex = 27;
            // 
            // musicDuration
            // 
            musicDuration.Location = new Point(471, 38);
            musicDuration.Name = "musicDuration";
            musicDuration.Size = new Size(125, 27);
            musicDuration.TabIndex = 26;
            // 
            // artistName
            // 
            artistName.Location = new Point(340, 38);
            artistName.Name = "artistName";
            artistName.Size = new Size(125, 27);
            artistName.TabIndex = 25;
            // 
            // musicGenre
            // 
            musicGenre.Location = new Point(209, 38);
            musicGenre.Name = "musicGenre";
            musicGenre.Size = new Size(125, 27);
            musicGenre.TabIndex = 24;
            // 
            // Delete
            // 
            Delete.Location = new Point(27, 356);
            Delete.Name = "Delete";
            Delete.Size = new Size(188, 77);
            Delete.TabIndex = 23;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Update
            // 
            Update.Location = new Point(30, 271);
            Update.Name = "Update";
            Update.Size = new Size(185, 67);
            Update.TabIndex = 22;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // GetById
            // 
            GetById.Location = new Point(31, 189);
            GetById.Name = "GetById";
            GetById.Size = new Size(185, 65);
            GetById.TabIndex = 21;
            GetById.Text = "GetById";
            GetById.UseVisualStyleBackColor = true;
            GetById.Click += GetById_Click;
            // 
            // GetAll
            // 
            GetAll.Location = new Point(30, 103);
            GetAll.Name = "GetAll";
            GetAll.Size = new Size(186, 65);
            GetAll.TabIndex = 20;
            GetAll.Text = "GetAll";
            GetAll.UseVisualStyleBackColor = true;
            GetAll.Click += GetAll_Click;
            // 
            // Create
            // 
            Create.Location = new Point(8, 17);
            Create.Name = "Create";
            Create.Size = new Size(186, 68);
            Create.TabIndex = 19;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // Form2
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
            Controls.Add(musicGenre);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(GetById);
            Controls.Add(GetAll);
            Controls.Add(Create);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lastId;
        private TextBox durationBtn;
        private TextBox artistN;
        private TextBox musicN;
        private TextBox updateId;
        private DataGridView dataGridView2;
        private TextBox id;
        private DataGridView dataGridView1;
        private TextBox artistId;
        private TextBox categoryId;
        private TextBox musicDuration;
        private TextBox artistName;
        private TextBox musicGenre;
        private Button Delete;
        private Button Update;
        private Button GetById;
        private Button GetAll;
        private Button Create;
    }
}
namespace DearDiary
{
    partial class Homepage
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
            this.add = new System.Windows.Forms.Button();
            this.Show_note = new System.Windows.Forms.Button();
            this.Note_Add = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.TextBox();
            this.DiaryGridView = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.UP = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DiaryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(200, 135);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(226, 58);
            this.add.TabIndex = 1;
            this.add.Text = "Add Note";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Show_note
            // 
            this.Show_note.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_note.Location = new System.Drawing.Point(729, 135);
            this.Show_note.Margin = new System.Windows.Forms.Padding(4);
            this.Show_note.Name = "Show_note";
            this.Show_note.Size = new System.Drawing.Size(226, 58);
            this.Show_note.TabIndex = 2;
            this.Show_note.Text = "Show note";
            this.Show_note.UseVisualStyleBackColor = true;
            this.Show_note.Click += new System.EventHandler(this.Show_note_Click);
            // 
            // Note_Add
            // 
            this.Note_Add.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note_Add.Location = new System.Drawing.Point(618, 407);
            this.Note_Add.Margin = new System.Windows.Forms.Padding(4);
            this.Note_Add.Name = "Note_Add";
            this.Note_Add.Size = new System.Drawing.Size(173, 58);
            this.Note_Add.TabIndex = 1;
            this.Note_Add.Text = "Add";
            this.Note_Add.UseVisualStyleBackColor = true;
            this.Note_Add.Click += new System.EventHandler(this.Note_Add_Click);
            // 
            // Data
            // 
            this.Data.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(462, 256);
            this.Data.Margin = new System.Windows.Forms.Padding(4);
            this.Data.Multiline = true;
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(493, 126);
            this.Data.TabIndex = 0;
            // 
            // DiaryGridView
            // 
            this.DiaryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiaryGridView.Location = new System.Drawing.Point(200, 473);
            this.DiaryGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DiaryGridView.Name = "DiaryGridView";
            this.DiaryGridView.RowHeadersWidth = 51;
            this.DiaryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DiaryGridView.Size = new System.Drawing.Size(1017, 296);
            this.DiaryGridView.TabIndex = 3;
            this.DiaryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiaryGridView_CellClick);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(991, 135);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(226, 58);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete note";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(462, 135);
            this.Update.Margin = new System.Windows.Forms.Padding(4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(226, 58);
            this.Update.TabIndex = 4;
            this.Update.Text = "Update Note";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // UP
            // 
            this.UP.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UP.Location = new System.Drawing.Point(618, 407);
            this.UP.Margin = new System.Windows.Forms.Padding(4);
            this.UP.Name = "UP";
            this.UP.Size = new System.Drawing.Size(173, 58);
            this.UP.TabIndex = 6;
            this.UP.Text = "Update";
            this.UP.UseVisualStyleBackColor = true;
            this.UP.Click += new System.EventHandler(this.UP_Click);
            // 
            // Del
            // 
            this.Del.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del.Location = new System.Drawing.Point(618, 407);
            this.Del.Margin = new System.Windows.Forms.Padding(4);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(173, 58);
            this.Del.TabIndex = 7;
            this.Del.Text = "Delete";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(794, 96);
            this.label2.TabIndex = 8;
            this.label2.Text = "Welcome to Dear Diary";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DearDiary.Properties.Resources.mainbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1392, 815);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.UP);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Note_Add);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Show_note);
            this.Controls.Add(this.add);
            this.Controls.Add(this.DiaryGridView);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiaryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Show_note;
        private System.Windows.Forms.Button Note_Add;
        private System.Windows.Forms.TextBox Data;
        private System.Windows.Forms.DataGridView DiaryGridView;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button UP;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Label label2;
    }
}
namespace ShortNote
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
            gvd = new DataGridView();
            title = new DataGridViewTextBoxColumn();
            Descriptions = new DataGridViewTextBoxColumn();
            text1 = new TextBox();
            add = new Button();
            description1 = new TextBox();
            delete = new Button();
            update = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)gvd).BeginInit();
            SuspendLayout();
            // 
            // gvd
            // 
            gvd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvd.Columns.AddRange(new DataGridViewColumn[] { title, Descriptions });
            gvd.Location = new Point(561, 128);
            gvd.Name = "gvd";
            gvd.RowHeadersWidth = 62;
            gvd.RowTemplate.Height = 33;
            gvd.ScrollBars = ScrollBars.Vertical;
            gvd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvd.Size = new Size(446, 388);
            gvd.TabIndex = 0;
            gvd.CellContentClick += gvd_CellContentClick;
            // 
            // title
            // 
            title.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            title.HeaderText = "Title";
            title.MinimumWidth = 8;
            title.Name = "title";
            title.Width = 150;
            // 
            // Descriptions
            // 
            Descriptions.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Descriptions.HeaderText = "Descriptions";
            Descriptions.MinimumWidth = 8;
            Descriptions.Name = "Descriptions";
            Descriptions.Width = 250;
            // 
            // text1
            // 
            text1.Location = new Point(178, 138);
            text1.Name = "text1";
            text1.Size = new Size(340, 31);
            text1.TabIndex = 1;
            // 
            // add
            // 
            add.Location = new Point(406, 305);
            add.Name = "add";
            add.Size = new Size(112, 34);
            add.TabIndex = 2;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // description1
            // 
            description1.Location = new Point(178, 191);
            description1.Multiline = true;
            description1.Name = "description1";
            description1.Size = new Size(340, 92);
            description1.TabIndex = 1;
            // 
            // delete
            // 
            delete.Location = new Point(178, 305);
            delete.Name = "delete";
            delete.Size = new Size(112, 34);
            delete.TabIndex = 3;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.Location = new Point(296, 305);
            update.Name = "update";
            update.Size = new Size(104, 34);
            update.TabIndex = 4;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(100, 137);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 5;
            label1.Text = "Title :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 188);
            label2.Name = "label2";
            label2.Size = new Size(157, 32);
            label2.TabIndex = 5;
            label2.Text = "Descriptions :";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(437, 40);
            label3.Name = "label3";
            label3.Size = new Size(210, 51);
            label3.TabIndex = 5;
            label3.Text = "Short Note";
            label3.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1087, 554);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(update);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(description1);
            Controls.Add(text1);
            Controls.Add(gvd);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gvd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvd;
        private TextBox text1;
        private Button add;
        private TextBox description1;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn Descriptions;
        private Button delete;
        private Button update;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
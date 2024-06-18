namespace sort
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sort_btn = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.elements_show_btn = new System.Windows.Forms.Button();
            this.index_btn = new System.Windows.Forms.Button();
            this.selected_item_btn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 66);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 0;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(16, 114);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(133, 28);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "ADD NUMBER";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(157, 48);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(59, 212);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // sort_btn
            // 
            this.sort_btn.Location = new System.Drawing.Point(16, 150);
            this.sort_btn.Margin = new System.Windows.Forms.Padding(4);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(133, 28);
            this.sort_btn.TabIndex = 3;
            this.sort_btn.Text = "SORT";
            this.sort_btn.UseVisualStyleBackColor = true;
            this.sort_btn.UseWaitCursor = true;
            this.sort_btn.Click += new System.EventHandler(this.sort_btn_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(223, 48);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(59, 212);
            this.listBox2.TabIndex = 4;
            // 
            // elements_show_btn
            // 
            this.elements_show_btn.Location = new System.Drawing.Point(291, 79);
            this.elements_show_btn.Margin = new System.Windows.Forms.Padding(4);
            this.elements_show_btn.Name = "elements_show_btn";
            this.elements_show_btn.Size = new System.Drawing.Size(182, 28);
            this.elements_show_btn.TabIndex = 5;
            this.elements_show_btn.Text = "the number of elements";
            this.elements_show_btn.UseVisualStyleBackColor = true;
            this.elements_show_btn.Click += new System.EventHandler(this.elements_show_btn_Click);
            // 
            // index_btn
            // 
            this.index_btn.Location = new System.Drawing.Point(291, 114);
            this.index_btn.Margin = new System.Windows.Forms.Padding(4);
            this.index_btn.Name = "index_btn";
            this.index_btn.Size = new System.Drawing.Size(182, 28);
            this.index_btn.TabIndex = 6;
            this.index_btn.Text = "Index Show";
            this.index_btn.UseVisualStyleBackColor = true;
            this.index_btn.Click += new System.EventHandler(this.index_btn_Click);
            // 
            // selected_item_btn
            // 
            this.selected_item_btn.Location = new System.Drawing.Point(291, 150);
            this.selected_item_btn.Margin = new System.Windows.Forms.Padding(4);
            this.selected_item_btn.Name = "selected_item_btn";
            this.selected_item_btn.Size = new System.Drawing.Size(182, 28);
            this.selected_item_btn.TabIndex = 7;
            this.selected_item_btn.Text = "the selected item";
            this.selected_item_btn.UseVisualStyleBackColor = true;
            this.selected_item_btn.Click += new System.EventHandler(this.selected_item_btn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 268);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(59, 22);
            this.textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 322);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.selected_item_btn);
            this.Controls.Add(this.index_btn);
            this.Controls.Add(this.elements_show_btn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.sort_btn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button sort_btn;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button elements_show_btn;
        private System.Windows.Forms.Button index_btn;
        private System.Windows.Forms.Button selected_item_btn;
        private System.Windows.Forms.TextBox textBox2;
    }
}


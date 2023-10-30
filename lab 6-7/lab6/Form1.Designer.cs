namespace lab6
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
            this.filmlistbox = new System.Windows.Forms.ListBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.removesingleBtn = new System.Windows.Forms.Button();
            this.countBtn = new System.Windows.Forms.Button();
            this.clearlistBtn = new System.Windows.Forms.Button();
            this.filmTextBox = new System.Windows.Forms.TextBox();
            this.Addcopybooks = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // filmlistbox
            // 
            this.filmlistbox.FormattingEnabled = true;
            this.filmlistbox.ItemHeight = 20;
            this.filmlistbox.Items.AddRange(new object[] {
            " • «Терминал»",
            " • «Шестое чувство»",
            " • «Форрест Гамп»",
            " • «Титаник»",
            " • «Паразиты»",
            " • «Касабланка»",
            " • «В джазе только девушки»",
            " • «Солярис»"});
            this.filmlistbox.Location = new System.Drawing.Point(451, 14);
            this.filmlistbox.Name = "filmlistbox";
            this.filmlistbox.Size = new System.Drawing.Size(223, 424);
            this.filmlistbox.TabIndex = 0;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(60, 113);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(334, 40);
            this.Addbtn.TabIndex = 1;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // removesingleBtn
            // 
            this.removesingleBtn.Location = new System.Drawing.Point(60, 266);
            this.removesingleBtn.Name = "removesingleBtn";
            this.removesingleBtn.Size = new System.Drawing.Size(334, 40);
            this.removesingleBtn.TabIndex = 2;
            this.removesingleBtn.Text = "Remove single item";
            this.removesingleBtn.UseVisualStyleBackColor = true;
            this.removesingleBtn.Click += new System.EventHandler(this.removesingleBtn_Click);
            // 
            // countBtn
            // 
            this.countBtn.Location = new System.Drawing.Point(60, 314);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(334, 40);
            this.countBtn.TabIndex = 3;
            this.countBtn.Text = "Count items";
            this.countBtn.UseVisualStyleBackColor = true;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // clearlistBtn
            // 
            this.clearlistBtn.Location = new System.Drawing.Point(60, 360);
            this.clearlistBtn.Name = "clearlistBtn";
            this.clearlistBtn.Size = new System.Drawing.Size(334, 40);
            this.clearlistBtn.TabIndex = 4;
            this.clearlistBtn.Text = "Clear List";
            this.clearlistBtn.UseVisualStyleBackColor = true;
            this.clearlistBtn.Click += new System.EventHandler(this.clearlistBtn_Click);
            // 
            // filmTextBox
            // 
            this.filmTextBox.Location = new System.Drawing.Point(60, 60);
            this.filmTextBox.Name = "filmTextBox";
            this.filmTextBox.Size = new System.Drawing.Size(334, 26);
            this.filmTextBox.TabIndex = 5;
            // 
            // Addcopybooks
            // 
            this.Addcopybooks.Location = new System.Drawing.Point(60, 216);
            this.Addcopybooks.Name = "Addcopybooks";
            this.Addcopybooks.Size = new System.Drawing.Size(334, 44);
            this.Addcopybooks.TabIndex = 6;
            this.Addcopybooks.Text = "Add";
            this.Addcopybooks.UseVisualStyleBackColor = true;
            this.Addcopybooks.Click += new System.EventHandler(this.Addcopybooks_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            " • «Джон Уик 4»",
            " • «Стражи Галактики. Часть 3»",
            " • «Все вороны — белые»",
            " • «Восстание зловещих мертвецов»",
            " • «Кто убил Blackberry»",
            " • «Подземелья и драконы: Честь среди воров»",
            " • «Снегирь»",
            " • «Братья Супер Марио в кино»"});
            this.comboBox1.Location = new System.Drawing.Point(60, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(334, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = " Select here";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Addcopybooks);
            this.Controls.Add(this.filmTextBox);
            this.Controls.Add(this.clearlistBtn);
            this.Controls.Add(this.countBtn);
            this.Controls.Add(this.removesingleBtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.filmlistbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox filmlistbox;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button removesingleBtn;
        private System.Windows.Forms.Button countBtn;
        private System.Windows.Forms.Button clearlistBtn;
        private System.Windows.Forms.TextBox filmTextBox;
        private System.Windows.Forms.Button Addcopybooks;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}


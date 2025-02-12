namespace individual_project_bragin_sport.CustomControl
{
    partial class GoodsControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.price = new System.Windows.Forms.Label();
            this.supplier = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.product_category = new System.Windows.Forms.Label();
            this.Quantity_in_stock = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.price.Location = new System.Drawing.Point(184, 132);
            this.price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(52, 25);
            this.price.TabIndex = 0;
            this.price.Text = "цена";
            // 
            // supplier
            // 
            this.supplier.AutoSize = true;
            this.supplier.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.supplier.Location = new System.Drawing.Point(184, 66);
            this.supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(100, 25);
            this.supplier.TabIndex = 1;
            this.supplier.Text = "поставщик";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.description.Location = new System.Drawing.Point(184, 97);
            this.description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(57, 25);
            this.description.TabIndex = 2;
            this.description.Text = "товар";
            // 
            // product_category
            // 
            this.product_category.AutoSize = true;
            this.product_category.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_category.Location = new System.Drawing.Point(184, 25);
            this.product_category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.product_category.Name = "product_category";
            this.product_category.Size = new System.Drawing.Size(94, 25);
            this.product_category.TabIndex = 3;
            this.product_category.Text = "категория";
            // 
            // Quantity_in_stock
            // 
            this.Quantity_in_stock.AutoSize = true;
            this.Quantity_in_stock.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.Quantity_in_stock.Location = new System.Drawing.Point(640, 132);
            this.Quantity_in_stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quantity_in_stock.Name = "Quantity_in_stock";
            this.Quantity_in_stock.Size = new System.Drawing.Size(95, 25);
            this.Quantity_in_stock.TabIndex = 4;
            this.Quantity_in_stock.Text = "на складе";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.button1.Location = new System.Drawing.Point(872, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "в корзину";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::individual_project_bragin_sport.Properties.Resources.picture;
            this.pictureBox.Location = new System.Drawing.Point(25, 25);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(133, 123);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(851, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Добавлено! (x)";
            this.label1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(851, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Количество:";
            this.label2.Visible = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Location = new System.Drawing.Point(975, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 26);
            this.button2.TabIndex = 10;
            this.button2.Text = "↑";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Location = new System.Drawing.Point(975, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 26);
            this.button3.TabIndex = 11;
            this.button3.Text = "↓";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(976, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "x";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // GoodsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.Quantity_in_stock);
            this.Controls.Add(this.product_category);
            this.Controls.Add(this.description);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.price);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GoodsControl";
            this.Size = new System.Drawing.Size(1023, 185);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label supplier;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label product_category;
        private System.Windows.Forms.Label Quantity_in_stock;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}

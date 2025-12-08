namespace ЛР_8.CastomElements
{
    partial class ProductControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMinCost = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.labelMinCost);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(17, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 690);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ЛР_8.Properties.Resources.Color2;
            this.pictureBox1.Location = new System.Drawing.Point(29, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(20, 408);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(201, 52);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "NameData";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = "Минимальная цена";
            // 
            // labelMinCost
            // 
            this.labelMinCost.AutoSize = true;
            this.labelMinCost.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinCost.Location = new System.Drawing.Point(20, 604);
            this.labelMinCost.Name = "labelMinCost";
            this.labelMinCost.Size = new System.Drawing.Size(239, 52);
            this.labelMinCost.TabIndex = 4;
            this.labelMinCost.Text = "DataMinCost";
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ЛР_8.Properties.Resources.Color2;
            this.Controls.Add(this.panel1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(494, 721);
            this.Load += new System.EventHandler(this.ProductControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMinCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelName;
    }
}

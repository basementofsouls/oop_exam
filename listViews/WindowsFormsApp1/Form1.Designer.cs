namespace WindowsFormsApp1
{
    partial class Form1
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
            this.listOfIndexes = new System.Windows.Forms.ListView();
            this.listOfValues = new System.Windows.Forms.ListView();
            this.textBoxOfIndex = new System.Windows.Forms.TextBox();
            this.textBoxOfValues = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOfIndexes
            // 
            this.listOfIndexes.Location = new System.Drawing.Point(12, 12);
            this.listOfIndexes.Name = "listOfIndexes";
            this.listOfIndexes.Size = new System.Drawing.Size(32, 161);
            this.listOfIndexes.TabIndex = 0;
            this.listOfIndexes.UseCompatibleStateImageBehavior = false;
            this.listOfIndexes.View = System.Windows.Forms.View.List;
            // 
            // listOfValues
            // 
            this.listOfValues.Location = new System.Drawing.Point(50, 12);
            this.listOfValues.Name = "listOfValues";
            this.listOfValues.Size = new System.Drawing.Size(92, 161);
            this.listOfValues.TabIndex = 0;
            this.listOfValues.UseCompatibleStateImageBehavior = false;
            this.listOfValues.View = System.Windows.Forms.View.List;
            // 
            // textBoxOfIndex
            // 
            this.textBoxOfIndex.Location = new System.Drawing.Point(268, 12);
            this.textBoxOfIndex.Name = "textBoxOfIndex";
            this.textBoxOfIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxOfIndex.TabIndex = 1;
            // 
            // textBoxOfValues
            // 
            this.textBoxOfValues.Location = new System.Drawing.Point(268, 38);
            this.textBoxOfValues.Name = "textBoxOfValues";
            this.textBoxOfValues.Size = new System.Drawing.Size(100, 20);
            this.textBoxOfValues.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Idnex of element";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maximum value";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "buttonFind";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(383, 183);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOfValues);
            this.Controls.Add(this.textBoxOfIndex);
            this.Controls.Add(this.listOfValues);
            this.Controls.Add(this.listOfIndexes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listOfIndexes;
        private System.Windows.Forms.ListView listOfValues;
        private System.Windows.Forms.TextBox textBoxOfIndex;
        private System.Windows.Forms.TextBox textBoxOfValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}


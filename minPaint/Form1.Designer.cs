
namespace minPaint
{
    partial class MinPaint
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
            this.choice = new System.Windows.Forms.Panel();
            this.circle = new System.Windows.Forms.Button();
            this.ellipse = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.choice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // choice
            // 
            this.choice.Controls.Add(this.line);
            this.choice.Controls.Add(this.triangle);
            this.choice.Controls.Add(this.rectangle);
            this.choice.Controls.Add(this.square);
            this.choice.Controls.Add(this.ellipse);
            this.choice.Controls.Add(this.circle);
            this.choice.Location = new System.Drawing.Point(1, 0);
            this.choice.Name = "choice";
            this.choice.Size = new System.Drawing.Size(922, 65);
            this.choice.TabIndex = 0;
            // 
            // circle
            // 
            this.circle.Location = new System.Drawing.Point(11, 22);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(75, 23);
            this.circle.TabIndex = 0;
            this.circle.Text = "Круг";
            this.circle.UseVisualStyleBackColor = true;
            // 
            // ellipse
            // 
            this.ellipse.Location = new System.Drawing.Point(104, 22);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(75, 23);
            this.ellipse.TabIndex = 1;
            this.ellipse.Text = "эллипс";
            this.ellipse.UseVisualStyleBackColor = true;
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(198, 22);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(75, 23);
            this.square.TabIndex = 2;
            this.square.Text = "квадрат";
            this.square.UseVisualStyleBackColor = true;
            // 
            // rectangle
            // 
            this.rectangle.Location = new System.Drawing.Point(290, 22);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(99, 23);
            this.rectangle.TabIndex = 3;
            this.rectangle.Text = "прямоугольник";
            this.rectangle.UseVisualStyleBackColor = true;
            // 
            // triangle
            // 
            this.triangle.Location = new System.Drawing.Point(409, 22);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(90, 23);
            this.triangle.TabIndex = 4;
            this.triangle.Text = "треугольник";
            this.triangle.UseVisualStyleBackColor = true;
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(519, 22);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(75, 23);
            this.line.TabIndex = 5;
            this.line.Text = "линия";
            this.line.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(922, 380);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MinPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.choice);
            this.Name = "MinPaint";
            this.Text = "MinPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.choice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel choice;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button ellipse;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


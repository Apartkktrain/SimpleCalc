
namespace SimpleCalc
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.input1_textbox = new System.Windows.Forms.TextBox();
            this.plus_lavel = new System.Windows.Forms.Label();
            this.input2_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.answer_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input1_textbox
            // 
            this.input1_textbox.Location = new System.Drawing.Point(13, 12);
            this.input1_textbox.Name = "input1_textbox";
            this.input1_textbox.Size = new System.Drawing.Size(100, 19);
            this.input1_textbox.TabIndex = 0;
            // 
            // plus_lavel
            // 
            this.plus_lavel.AutoSize = true;
            this.plus_lavel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_lavel.Location = new System.Drawing.Point(119, 12);
            this.plus_lavel.Name = "plus_lavel";
            this.plus_lavel.Size = new System.Drawing.Size(17, 17);
            this.plus_lavel.TabIndex = 1;
            this.plus_lavel.Text = "+";
            // 
            // input2_textbox
            // 
            this.input2_textbox.Location = new System.Drawing.Point(142, 12);
            this.input2_textbox.Name = "input2_textbox";
            this.input2_textbox.Size = new System.Drawing.Size(100, 19);
            this.input2_textbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // answer_textbox
            // 
            this.answer_textbox.Location = new System.Drawing.Point(267, 11);
            this.answer_textbox.Name = "answer_textbox";
            this.answer_textbox.Size = new System.Drawing.Size(100, 19);
            this.answer_textbox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(13, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "計算実行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answer_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input2_textbox);
            this.Controls.Add(this.plus_lavel);
            this.Controls.Add(this.input1_textbox);
            this.Name = "Form1";
            this.Text = "Simple_Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1_textbox;
        private System.Windows.Forms.Label plus_lavel;
        private System.Windows.Forms.TextBox input2_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox answer_textbox;
        private System.Windows.Forms.Button button1;
    }
}


namespace QueryTrans
{
    partial class Sql_to_XML
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
            query_btn = new Button();
            cmd_tb = new TextBox();
            result_tb = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // query_btn
            // 
            query_btn.Location = new Point(680, 59);
            query_btn.Name = "query_btn";
            query_btn.Size = new Size(108, 34);
            query_btn.TabIndex = 0;
            query_btn.Text = "query";
            query_btn.UseVisualStyleBackColor = true;
            query_btn.Click += button1_Click;
            // 
            // cmd_tb
            // 
            cmd_tb.Location = new Point(102, 59);
            cmd_tb.Multiline = true;
            cmd_tb.Name = "cmd_tb";
            cmd_tb.Size = new Size(572, 34);
            cmd_tb.TabIndex = 1;
            cmd_tb.TextChanged += textBox1_TextChanged;
            // 
            // result_tb
            // 
            result_tb.Location = new Point(12, 111);
            result_tb.Multiline = true;
            result_tb.Name = "result_tb";
            result_tb.ReadOnly = true;
            result_tb.ScrollBars = ScrollBars.Vertical;
            result_tb.Size = new Size(776, 327);
            result_tb.TabIndex = 2;
            result_tb.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(84, 34);
            label1.TabIndex = 3;
            label1.Text = "Command";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Sql_to_XML
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(result_tb);
            Controls.Add(cmd_tb);
            Controls.Add(query_btn);
            Name = "Sql_to_XML";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button query_btn;
        private TextBox cmd_tb;
        private TextBox result_tb;
        private Label label1;
    }
}
namespace QueryTrans
{
    partial class Sql_to_Excel
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
            label1 = new Label();
            cmd_tb = new TextBox();
            Query_btn = new Button();
            result_dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)result_dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 15);
            label1.Name = "label1";
            label1.Size = new Size(89, 39);
            label1.TabIndex = 0;
            label1.Text = "Command";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmd_tb
            // 
            cmd_tb.Location = new Point(107, 20);
            cmd_tb.Multiline = true;
            cmd_tb.Name = "cmd_tb";
            cmd_tb.Size = new Size(493, 34);
            cmd_tb.TabIndex = 1;
            cmd_tb.TextChanged += textBox1_TextChanged;
            // 
            // Query_btn
            // 
            Query_btn.Location = new Point(653, 15);
            Query_btn.Name = "Query_btn";
            Query_btn.Size = new Size(135, 39);
            Query_btn.TabIndex = 2;
            Query_btn.Text = "Query";
            Query_btn.UseVisualStyleBackColor = true;
            Query_btn.Click += Query_btn_Click;
            // 
            // result_dgv
            // 
            result_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            result_dgv.Location = new Point(31, 104);
            result_dgv.Name = "result_dgv";
            result_dgv.ReadOnly = true;
            result_dgv.RowHeadersWidth = 51;
            result_dgv.Size = new Size(742, 315);
            result_dgv.TabIndex = 4;
            result_dgv.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Sql_to_Excel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result_dgv);
            Controls.Add(Query_btn);
            Controls.Add(cmd_tb);
            Controls.Add(label1);
            Name = "Sql_to_Excel";
            Text = "Sql_to_Excel";
            ((System.ComponentModel.ISupportInitialize)result_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox cmd_tb;
        private Button Query_btn;
        private DataGridView result_dgv;
    }
}
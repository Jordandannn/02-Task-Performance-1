namespace BasicQueuingContinuation
{
    partial class CashierWindowQueue
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
            btnNext = new Button();
            btnRefresh = new Button();
            listCashierQueue = new ListBox();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.SandyBrown;
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(5, 6);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 34);
            btnNext.TabIndex = 0;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click_1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SandyBrown;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(5, 46);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 34);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "REHRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // listCashierQueue
            // 
            listCashierQueue.BackColor = Color.Wheat;
            listCashierQueue.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            listCashierQueue.FormattingEnabled = true;
            listCashierQueue.ItemHeight = 20;
            listCashierQueue.Location = new Point(86, 6);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(180, 244);
            listCashierQueue.TabIndex = 2;
            // 
            // CashierWindowQueue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(278, 257);
            Controls.Add(listCashierQueue);
            Controls.Add(btnRefresh);
            Controls.Add(btnNext);
            Name = "CashierWindowQueue";
            Text = "CashierWindowQueue";
            Load += CashierWindowQueue_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Button btnNext;
        private Button btnRefresh;
        private ListBox listCashierQueue;
    }
}
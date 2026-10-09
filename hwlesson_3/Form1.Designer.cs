namespace hwlesson_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnStartGame = new Button();
            lblSignal = new Label();
            lblResult = new Label();
            btnTask2 = new Button();
            btnTask3 = new Button();
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnStartGame.Location = new Point(35, 29);
            btnStartGame.Margin = new Padding(4, 3, 4, 3);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(187, 46);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Game";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // lblSignal
            // 
            lblSignal.AutoSize = true;
            lblSignal.Font = new Font("Microsoft Sans Serif", 12F);
            lblSignal.Location = new Point(245, 29);
            lblSignal.Margin = new Padding(4, 0, 4, 0);
            lblSignal.Name = "lblSignal";
            lblSignal.Size = new Size(160, 20);
            lblSignal.TabIndex = 1;
            lblSignal.Text = "Press \"Start Game\"...";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblResult.Location = new Point(245, 58);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(152, 17);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result will appear here";
            // 
            // btnTask2
            // 
            btnTask2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnTask2.Location = new Point(35, 99);
            btnTask2.Margin = new Padding(4, 3, 4, 3);
            btnTask2.Name = "btnTask2";
            btnTask2.Size = new Size(187, 46);
            btnTask2.TabIndex = 3;
            btnTask2.Text = "Task 2";
            btnTask2.UseVisualStyleBackColor = true;
            btnTask2.Click += btnTask2_Click;
            // 
            // btnTask3
            // 
            btnTask3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnTask3.Location = new Point(35, 173);
            btnTask3.Margin = new Padding(4, 3, 4, 3);
            btnTask3.Name = "btnTask3";
            btnTask3.Size = new Size(187, 46);
            btnTask3.TabIndex = 4;
            btnTask3.Text = "Bank";
            btnTask3.UseVisualStyleBackColor = true;
            btnTask3.Click += btnTask3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 254);
            Controls.Add(btnTask3);
            Controls.Add(btnTask2);
            Controls.Add(lblResult);
            Controls.Add(lblSignal);
            Controls.Add(btnStartGame);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Multithreading";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblSignal;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnTask2;
        private System.Windows.Forms.Button btnTask3;
    }
}
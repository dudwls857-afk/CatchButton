namespace CatchButton
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Target = new Button();
            Reset = new Button();
            SuspendLayout();
            // 
            // Target
            // 
            Target.BackColor = Color.Black;
            Target.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Target.ForeColor = Color.Red;
            Target.Location = new Point(170, 189);
            Target.Name = "Target";
            Target.Size = new Size(420, 150);
            Target.TabIndex = 0;
            Target.Text = "나를 잡아봐";
            Target.UseVisualStyleBackColor = false;
            Target.Click += button1_Click;
            Target.MouseEnter += Target_MouseEnter;
            // 
            // Reset
            // 
            Reset.BackColor = Color.Red;
            Reset.ForeColor = Color.Blue;
            Reset.Location = new Point(181, 100);
            Reset.Name = "Reset";
            Reset.RightToLeft = RightToLeft.Yes;
            Reset.Size = new Size(400, 300);
            Reset.TabIndex = 1;
            Reset.Text = "다시시작";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += Reset_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 526);
            Controls.Add(Reset);
            Controls.Add(Target);
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "버튼을 잡아라!";
            Load += Form1_Load;
            VisibleChanged += Reset_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button Target;
        private Button Reset;
    }
}

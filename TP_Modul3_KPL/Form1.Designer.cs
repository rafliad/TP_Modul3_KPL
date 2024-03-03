namespace TP_Modul3_KPL
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
            buttonEnter = new Button();
            InputUser = new TextBox();
            OutputUser = new Label();
            SuspendLayout();
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(817, 182);
            buttonEnter.Margin = new Padding(4);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(127, 37);
            buttonEnter.TabIndex = 0;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // InputUser
            // 
            InputUser.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InputUser.Location = new Point(109, 182);
            InputUser.Margin = new Padding(4);
            InputUser.Name = "InputUser";
            InputUser.Size = new Size(664, 45);
            InputUser.TabIndex = 1;
            InputUser.TextChanged += textBox1_TextChanged;
            // 
            // OutputUser
            // 
            OutputUser.BackColor = Color.Gainsboro;
            OutputUser.BorderStyle = BorderStyle.FixedSingle;
            OutputUser.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OutputUser.Location = new Point(109, 266);
            OutputUser.Margin = new Padding(4, 0, 4, 0);
            OutputUser.Name = "OutputUser";
            OutputUser.Size = new Size(835, 138);
            OutputUser.TabIndex = 2;
            OutputUser.TextAlign = ContentAlignment.MiddleCenter;
            OutputUser.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 540);
            Controls.Add(OutputUser);
            Controls.Add(InputUser);
            Controls.Add(buttonEnter);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEnter;
        private TextBox InputUser;
        private Label OutputUser;
    }
}

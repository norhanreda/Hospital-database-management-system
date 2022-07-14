
namespace DBfinalproject
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.user_name_textbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1_Confirm_Pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(182, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 70);
            this.button1.TabIndex = 17;
            this.button1.Text = "change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "New Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "User Name";
            // 
            // password_textbox
            // 
            this.password_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password_textbox.Location = new System.Drawing.Point(240, 100);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(179, 22);
            this.password_textbox.TabIndex = 12;
            // 
            // user_name_textbox
            // 
            this.user_name_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user_name_textbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.user_name_textbox.Location = new System.Drawing.Point(240, 42);
            this.user_name_textbox.Name = "user_name_textbox";
            this.user_name_textbox.Size = new System.Drawing.Size(181, 22);
            this.user_name_textbox.TabIndex = 10;
            this.user_name_textbox.TextChanged += new System.EventHandler(this.user_name_textbox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(547, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 56);
            this.button2.TabIndex = 18;
            this.button2.Text = "Return To Sign in Window";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1_Confirm_Pass
            // 
            this.textBox1_Confirm_Pass.Location = new System.Drawing.Point(240, 156);
            this.textBox1_Confirm_Pass.Name = "textBox1_Confirm_Pass";
            this.textBox1_Confirm_Pass.Size = new System.Drawing.Size(179, 22);
            this.textBox1_Confirm_Pass.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Confirm Password";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DBfinalproject.Properties.Resources.state_of_healthcare_Artboard_3_copy_51;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1_Confirm_Pass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.user_name_textbox);
            this.Name = "Form3";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox user_name_textbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1_Confirm_Pass;
        private System.Windows.Forms.Label label4;
    }
}

namespace DemoProject
{
    partial class MainForm
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
            this.btnClickThis = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.CounterButton = new System.Windows.Forms.Button();
            this.countResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.BackColor = System.Drawing.Color.PaleGreen;
            this.btnClickThis.Location = new System.Drawing.Point(16, 74);
            this.btnClickThis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(108, 30);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Click this";
            this.btnClickThis.UseVisualStyleBackColor = false;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(146, 82);
            this.lblHelloWorld.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(0, 16);
            this.lblHelloWorld.TabIndex = 1;
            // 
            // CounterButton
            // 
            this.CounterButton.Location = new System.Drawing.Point(16, 110);
            this.CounterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CounterButton.Name = "CounterButton";
            this.CounterButton.Size = new System.Drawing.Size(108, 33);
            this.CounterButton.TabIndex = 2;
            this.CounterButton.Text = "Counter";
            this.CounterButton.UseVisualStyleBackColor = true;
            this.CounterButton.Click += new System.EventHandler(this.CounterButton_Click);
            // 
            // countResult
            // 
            this.countResult.AutoSize = true;
            this.countResult.Location = new System.Drawing.Point(146, 118);
            this.countResult.Name = "countResult";
            this.countResult.Size = new System.Drawing.Size(14, 16);
            this.countResult.TabIndex = 3;
            this.countResult.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "ClickMe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.countResult);
            this.Controls.Add(this.CounterButton);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnClickThis);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Demo Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.Button CounterButton;
        private System.Windows.Forms.Label countResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}


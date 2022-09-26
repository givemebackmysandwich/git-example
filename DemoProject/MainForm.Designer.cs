
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
            this.QuitButton = new System.Windows.Forms.Button();
            this.changeColorButton = new System.Windows.Forms.Button();
            this.CounterButton = new System.Windows.Forms.Button();
            this.countResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.BackColor = System.Drawing.Color.PaleGreen;
            this.btnClickThis.Location = new System.Drawing.Point(24, 115);
            this.btnClickThis.Margin = new System.Windows.Forms.Padding(6);
            this.btnClickThis.Location = new System.Drawing.Point(18, 92);
            this.btnClickThis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(122, 38);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Click this";
            this.btnClickThis.UseVisualStyleBackColor = false;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(164, 102);
            this.lblHelloWorld.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(0, 20);
            this.lblHelloWorld.TabIndex = 1;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(499, 172);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(117, 51);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // changeColorButton
            // 
            this.changeColorButton.Location = new System.Drawing.Point(41, 40);
            this.changeColorButton.Name = "changeColorButton";
            this.changeColorButton.Size = new System.Drawing.Size(177, 54);
            this.changeColorButton.TabIndex = 2;
            this.changeColorButton.Text = "Change Color";
            this.changeColorButton.UseVisualStyleBackColor = true;
            this.changeColorButton.Click += new System.EventHandler(this.changeColorButton_Click);
            // CounterButton
            // 
            this.CounterButton.Location = new System.Drawing.Point(18, 138);
            this.CounterButton.Name = "CounterButton";
            this.CounterButton.Size = new System.Drawing.Size(122, 41);
            this.CounterButton.TabIndex = 2;
            this.CounterButton.Text = "Counter";
            this.CounterButton.UseVisualStyleBackColor = true;
            this.CounterButton.Click += new System.EventHandler(this.CounterButton_Click);
            // 
            // countResult
            // 
            this.countResult.AutoSize = true;
            this.countResult.Location = new System.Drawing.Point(164, 148);
            this.countResult.Name = "countResult";
            this.countResult.Size = new System.Drawing.Size(18, 20);
            this.countResult.TabIndex = 3;
            this.countResult.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 279);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnClickThis);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Controls.Add(this.changeColorButton);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnClickThis);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.ClientSize = new System.Drawing.Size(488, 223);
            this.Controls.Add(this.countResult);
            this.Controls.Add(this.CounterButton);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnClickThis);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Demo Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button changeColorButton;
        private System.Windows.Forms.Button CounterButton;
        private System.Windows.Forms.Label countResult;
    }
}


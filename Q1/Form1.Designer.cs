namespace Q1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.guessbtn = new System.Windows.Forms.Button();
			this.label = new System.Windows.Forms.Label();
			this.inputtxt = new System.Windows.Forms.TextBox();
			this.resultlbl = new System.Windows.Forms.Label();
			this.newgamebtn = new System.Windows.Forms.Button();
			this.answerbtn = new System.Windows.Forms.Button();
			this.answerlbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// guessbtn
			// 
			this.guessbtn.Location = new System.Drawing.Point(386, 39);
			this.guessbtn.Name = "guessbtn";
			this.guessbtn.Size = new System.Drawing.Size(75, 23);
			this.guessbtn.TabIndex = 0;
			this.guessbtn.Text = "猜猜看";
			this.guessbtn.UseVisualStyleBackColor = true;
			this.guessbtn.Click += new System.EventHandler(this.guessbtn_Click);
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(41, 36);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(135, 55);
			this.label.TabIndex = 2;
			this.label.Text = "請輸入四位數\r\n0到9不重複的四位數";
			// 
			// inputtxt
			// 
			this.inputtxt.Location = new System.Drawing.Point(211, 36);
			this.inputtxt.MaxLength = 4;
			this.inputtxt.Name = "inputtxt";
			this.inputtxt.Size = new System.Drawing.Size(100, 22);
			this.inputtxt.TabIndex = 3;
			// 
			// resultlbl
			// 
			this.resultlbl.Location = new System.Drawing.Point(51, 91);
			this.resultlbl.Name = "resultlbl";
			this.resultlbl.Size = new System.Drawing.Size(281, 315);
			this.resultlbl.TabIndex = 2;
			this.resultlbl.Text = "  ";
			// 
			// newgamebtn
			// 
			this.newgamebtn.Location = new System.Drawing.Point(386, 138);
			this.newgamebtn.Name = "newgamebtn";
			this.newgamebtn.Size = new System.Drawing.Size(75, 23);
			this.newgamebtn.TabIndex = 4;
			this.newgamebtn.Text = "新遊戲";
			this.newgamebtn.UseVisualStyleBackColor = true;
			this.newgamebtn.Click += new System.EventHandler(this.newgamebtn_Click);
			// 
			// answerbtn
			// 
			this.answerbtn.Location = new System.Drawing.Point(386, 258);
			this.answerbtn.Name = "answerbtn";
			this.answerbtn.Size = new System.Drawing.Size(75, 23);
			this.answerbtn.TabIndex = 5;
			this.answerbtn.Text = "看答案";
			this.answerbtn.UseVisualStyleBackColor = true;
			this.answerbtn.Click += new System.EventHandler(this.answerbtn_Click);
			// 
			// answerlbl
			// 
			this.answerlbl.AutoSize = true;
			this.answerlbl.Location = new System.Drawing.Point(412, 319);
			this.answerlbl.Name = "answerlbl";
			this.answerlbl.Size = new System.Drawing.Size(49, 12);
			this.answerlbl.TabIndex = 6;
			this.answerlbl.Text = "answerlbl";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.answerlbl);
			this.Controls.Add(this.answerbtn);
			this.Controls.Add(this.newgamebtn);
			this.Controls.Add(this.inputtxt);
			this.Controls.Add(this.resultlbl);
			this.Controls.Add(this.label);
			this.Controls.Add(this.guessbtn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button guessbtn;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TextBox inputtxt;
		private System.Windows.Forms.Label resultlbl;
		private System.Windows.Forms.Button newgamebtn;
		private System.Windows.Forms.Button answerbtn;
		private System.Windows.Forms.Label answerlbl;
	}
}


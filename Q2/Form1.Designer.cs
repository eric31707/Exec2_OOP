namespace Q2
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
			this.resultlbl = new System.Windows.Forms.Label();
			this.answerlbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// guessbtn
			// 
			this.guessbtn.Location = new System.Drawing.Point(423, 102);
			this.guessbtn.Name = "guessbtn";
			this.guessbtn.Size = new System.Drawing.Size(75, 23);
			this.guessbtn.TabIndex = 1;
			this.guessbtn.Text = "擲骰子";
			this.guessbtn.UseVisualStyleBackColor = true;
			this.guessbtn.Click += new System.EventHandler(this.guessbtn_Click);
			// 
			// resultlbl
			// 
			this.resultlbl.AutoSize = true;
			this.resultlbl.Location = new System.Drawing.Point(232, 107);
			this.resultlbl.Name = "resultlbl";
			this.resultlbl.Size = new System.Drawing.Size(42, 12);
			this.resultlbl.TabIndex = 0;
			this.resultlbl.Text = "resultlbl";
			// 
			// answerlbl
			// 
			this.answerlbl.AutoSize = true;
			this.answerlbl.Location = new System.Drawing.Point(423, 207);
			this.answerlbl.Name = "answerlbl";
			this.answerlbl.Size = new System.Drawing.Size(49, 12);
			this.answerlbl.TabIndex = 2;
			this.answerlbl.Text = "answerlbl";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.answerlbl);
			this.Controls.Add(this.resultlbl);
			this.Controls.Add(this.guessbtn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button guessbtn;
		private System.Windows.Forms.Label resultlbl;
		private System.Windows.Forms.Label answerlbl;
	}
}


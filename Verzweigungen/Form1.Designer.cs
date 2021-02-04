
namespace Verzweigungen
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAusgabe = new System.Windows.Forms.Button();
			this.lblAusgabe = new System.Windows.Forms.Label();
			this.nUpDownEingabe = new System.Windows.Forms.NumericUpDown();
			this.btnTernärerOperator = new System.Windows.Forms.Button();
			this.btnSwitch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nUpDownEingabe)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAusgabe
			// 
			this.btnAusgabe.Location = new System.Drawing.Point(184, 13);
			this.btnAusgabe.Name = "btnAusgabe";
			this.btnAusgabe.Size = new System.Drawing.Size(75, 23);
			this.btnAusgabe.TabIndex = 0;
			this.btnAusgabe.Text = "Ausgabe";
			this.btnAusgabe.UseVisualStyleBackColor = true;
			this.btnAusgabe.Click += new System.EventHandler(this.btnAusgabe_Click);
			// 
			// lblAusgabe
			// 
			this.lblAusgabe.AutoSize = true;
			this.lblAusgabe.Location = new System.Drawing.Point(13, 13);
			this.lblAusgabe.Name = "lblAusgabe";
			this.lblAusgabe.Size = new System.Drawing.Size(35, 13);
			this.lblAusgabe.TabIndex = 1;
			this.lblAusgabe.Text = "label1";
			// 
			// nUpDownEingabe
			// 
			this.nUpDownEingabe.Location = new System.Drawing.Point(184, 43);
			this.nUpDownEingabe.Name = "nUpDownEingabe";
			this.nUpDownEingabe.Size = new System.Drawing.Size(75, 20);
			this.nUpDownEingabe.TabIndex = 2;
			// 
			// btnTernärerOperator
			// 
			this.btnTernärerOperator.Location = new System.Drawing.Point(184, 69);
			this.btnTernärerOperator.Name = "btnTernärerOperator";
			this.btnTernärerOperator.Size = new System.Drawing.Size(75, 23);
			this.btnTernärerOperator.TabIndex = 3;
			this.btnTernärerOperator.Text = "? :";
			this.btnTernärerOperator.UseVisualStyleBackColor = true;
			this.btnTernärerOperator.Click += new System.EventHandler(this.btnTernärerOperator_Click);
			// 
			// btnSwitch
			// 
			this.btnSwitch.Location = new System.Drawing.Point(184, 99);
			this.btnSwitch.Name = "btnSwitch";
			this.btnSwitch.Size = new System.Drawing.Size(75, 31);
			this.btnSwitch.TabIndex = 4;
			this.btnSwitch.Text = "switch case";
			this.btnSwitch.UseVisualStyleBackColor = true;
			this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 177);
			this.Controls.Add(this.btnSwitch);
			this.Controls.Add(this.btnTernärerOperator);
			this.Controls.Add(this.nUpDownEingabe);
			this.Controls.Add(this.lblAusgabe);
			this.Controls.Add(this.btnAusgabe);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.nUpDownEingabe)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAusgabe;
		private System.Windows.Forms.Label lblAusgabe;
		private System.Windows.Forms.NumericUpDown nUpDownEingabe;
		private System.Windows.Forms.Button btnTernärerOperator;
		private System.Windows.Forms.Button btnSwitch;
	}
}



namespace TreeViewProject
{
    partial class AddToCoreForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMain = new System.Windows.Forms.Label();
            this.btnSuccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(72, 81);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Назва";
            this.txtName.Size = new System.Drawing.Size(296, 41);
            this.txtName.TabIndex = 1;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMain.Location = new System.Drawing.Point(119, 13);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(200, 35);
            this.lblMain.TabIndex = 2;
            this.lblMain.Text = "Додати елемент";
            // 
            // btnSuccess
            // 
            this.btnSuccess.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuccess.ForeColor = System.Drawing.Color.Red;
            this.btnSuccess.Location = new System.Drawing.Point(119, 182);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(200, 61);
            this.btnSuccess.TabIndex = 3;
            this.btnSuccess.Text = "Додати";
            this.btnSuccess.UseVisualStyleBackColor = true;
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // AddToCoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 272);
            this.Controls.Add(this.btnSuccess);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.txtName);
            this.Name = "AddToCoreForm";
            this.Text = "Додавання до кореня";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnSuccess;
    }
}
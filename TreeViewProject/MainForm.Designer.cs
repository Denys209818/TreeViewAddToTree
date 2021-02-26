
namespace TreeViewProject
{
    partial class MainForm
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
            this.gbCategories = new System.Windows.Forms.GroupBox();
            this.tvCategories = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCategories
            // 
            this.gbCategories.Controls.Add(this.btnAdd);
            this.gbCategories.Controls.Add(this.tvCategories);
            this.gbCategories.Location = new System.Drawing.Point(13, 13);
            this.gbCategories.Name = "gbCategories";
            this.gbCategories.Size = new System.Drawing.Size(775, 425);
            this.gbCategories.TabIndex = 0;
            this.gbCategories.TabStop = false;
            this.gbCategories.Text = "Категорії";
            // 
            // tvCategories
            // 
            this.tvCategories.Location = new System.Drawing.Point(7, 27);
            this.tvCategories.Name = "tvCategories";
            this.tvCategories.Size = new System.Drawing.Size(331, 392);
            this.tvCategories.TabIndex = 0;
            this.tvCategories.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvCategories_BeforeExpand);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(484, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(285, 51);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додати в корінь";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCategories);
            this.Name = "MainForm";
            this.Text = "Головна форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbCategories.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategories;
        private System.Windows.Forms.TreeView tvCategories;
        private System.Windows.Forms.Button btnAdd;
    }
}


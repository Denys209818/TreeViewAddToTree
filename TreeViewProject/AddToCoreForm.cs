using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TreeViewProject.Entities;
using TreeViewProject.Models;

namespace TreeViewProject
{
    public partial class AddToCoreForm : Form
    {
        private EFContext _context { get; set; }
        public AddToCoreForm(EFContext context)
        {
            InitializeComponent();
            this._context = context;
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtName.Text))
            {
                string urlSlug = this.txtName.Text.ToLower().Replace(' ', '-');
                TreeNodeModel model = new TreeNodeModel
                {
                    Name = this.txtName.Text,
                    UrlSlug = urlSlug
                };

                this._context.categories.Add(new TreeViewElement
                {
                    Name = model.Name,
                    UrlSlug = model.UrlSlug,
                    ParentId = null
                });

                this._context.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
            else 
            {
                MessageBox.Show("Заповніть поле!");
            }
        }
    }
}

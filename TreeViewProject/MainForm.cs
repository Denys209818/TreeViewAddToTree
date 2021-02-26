using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeViewProject.Entities;
using TreeViewProject.Models;
using TreeViewProject.Services;

namespace TreeViewProject
{
    public partial class MainForm : Form
    {
        public EFContext _context { get; set; }
        public MainForm()
        {
            InitializeComponent();
            this._context = new EFContext();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DbSeeder.SeedAll(_context);
            FillTreeView();
        }

        private void FillTreeView() 
        {
            this.tvCategories.Nodes.Clear();
            foreach (var item in _context.categories.Where(x => x.ParentId == null).ToList())
            {
                TreeNode node = new TreeNode
                {
                    Name = item.Id.ToString(),
                    Text = item.Name,
                    Tag = item
                };
                node.Nodes.Add("");
                tvCategories.Nodes.Add(node);

            }
        }

        private void tvCategories_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Node.Nodes[0].Text)) 
            {
                var parent = e.Node.Tag as TreeViewElement;
                var groups  = this._context.categories
                    .ToList().GroupBy(x => x.ParentId).ToDictionary(x => x.Key.GetValueOrDefault(), x => x.ToList());
                if (groups.ContainsKey(parent.Id)) 
                {
                    var list = groups.FirstOrDefault(x => x.Key == parent.Id).Value.ToList();
                    e.Node.Nodes.Clear();
                    foreach (var item in list) 
                {
                    TreeNode node = new TreeNode
                    {
                        Name = item.Id.ToString(),
                        Text = item.Name,
                        Tag = item
                    };
                    node.Nodes.Add("");
                    e.Node.Nodes.Add(node);
                }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddToCoreForm form = new AddToCoreForm(_context);
            if (form.ShowDialog() == DialogResult.OK) 
            {
                FillTreeView();
            }
        }
    }
}

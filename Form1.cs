using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TreeParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de texto|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                PlainText.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Execute_Click(object sender, EventArgs e)
        {
            TextReader reader = new StringReader(PlainText.Text);
            TreeNode node = new TreeNode();
            node.Text = "Root";
            TreeView1.Nodes.Add(node);
            TreeParser(node, TreeView1, reader);
        }

        private void TreeParser(TreeNode node, System.Windows.Forms.TreeView treeView, TextReader reader)
        {
            if (reader.Peek() == -1) { return; }
            if (reader.Peek() == '.')
            {
                reader.Read();
                TreeParser(node, treeView, reader);
            }
            else
            {
                TreeView1.SelectedNode = node;
                TreeNode son = new TreeNode();
                son.Text = reader.ReadLine();
                TreeView1.SelectedNode.Nodes.Add(son);
                TreeParser(son, treeView, reader);
            }
        }


        private void Exit_Click(object sender, EventArgs e)
        {

        }
    }
}

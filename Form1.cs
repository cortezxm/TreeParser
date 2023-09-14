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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

            TreeParser(TreeView1);
        }

        private void TreeParser(System.Windows.Forms.TreeView treeView)
        {
            TextReader reader = new StringReader(PlainText.Text);
            TreeNode currentNode = null;

            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                int depth = 0;

                while (line.Length > 0 && line[0] == '.')
                {
                    depth++;
                    line = line.Substring(1);
                }

                TreeNode node = new TreeNode();
                node.Text = line;

                if (depth == 0)
                {
                    treeView.Nodes.Add(node);
                    currentNode = node;
                }
                else if (currentNode != null)
                {
                    AddNodeAtDepth(currentNode, node, depth);
                }
            }
        }

        private void AddNodeAtDepth(TreeNode parent, TreeNode node, int depth)
        {
            TreeNode currentNode = parent;
            for (int i = 1; i < depth; i++)
            {
                if (currentNode.Nodes.Count > 0)
                {
                    currentNode = currentNode.Nodes[currentNode.Nodes.Count - 1];
                }
                else
                {
                    TreeNode dummyNode = new TreeNode();
                    currentNode.Nodes.Add(dummyNode);
                    currentNode = dummyNode;
                }
            }

            currentNode.Nodes.Add(node);
        }




        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            TreeView1.Nodes.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

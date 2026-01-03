using System.Collections.Generic;
using System.Windows.Forms;
using static ImageIndex;
enum ImageIndex { File, ClosedFolder, OpenFolder };

namespace Learning
{
    public partial class TreeViewer : Form
    {

        List<TreeNode> CheckedNodes = new List<TreeNode> { };
        public TreeViewer() => InitializeComponent();


        public void AddFolder(string Key, string Text)
        {
            treeView1.Nodes.Add(Key, Text, (byte)ClosedFolder, (byte)ClosedFolder);

        }
        public void AddFolder(string Key, string Text, string Parent)
        {
            TreeNode[] NodeList;
            if ((NodeList = treeView1.Nodes.Find(Parent, true)).Length > 0)
            {
                NodeList[0].Nodes.Add(Key, Text, (byte)ClosedFolder, (byte)ClosedFolder);
            }
        }
        public void AddFile(string Key, string Text, string Parent)
        {
            TreeNode[] NodeList;
            if ((NodeList = treeView1.Nodes.Find(Parent, true)).Length > 0)
            {
                NodeList[0].Nodes.Add(Key, Text, (byte)File);
            }



        }
        private void Form_Loaded(object sender, System.EventArgs e)
        {


            AddFolder("books", "Books");
            AddFolder("sports", "Sports");

            AddFolder("prog-books", "Programming Books", Parent: "books");
            AddFile("book1", "a nice book about Programming", Parent: "prog-books");
            AddFile("book2", "another book about Programming", Parent: "prog-books");

            AddFolder("csharp-books", "C# Books", Parent: "prog-books");
            AddFile("book1", "C# Functional Prog", Parent: "csharp-books");
            AddFile("book2", "C# OOP", Parent: "csharp-books");


            AddFile("book3", "a book about Management", Parent: "books");
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = (byte)OpenFolder;
            e.Node.SelectedImageIndex = (byte)OpenFolder;
        }

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = (byte)ClosedFolder;
            e.Node.SelectedImageIndex = (byte)ClosedFolder;
        }

        void AddOrRemoveNode(TreeNode Node, bool Add)
        {
            if (Add) CheckedNodes.Add(Node);
            else CheckedNodes.Remove(Node);
        }
        private void CheckTreeNodes(TreeNode Root, bool IsChecked)
        {
            foreach (TreeNode Node in Root.Nodes)
                Node.Checked = IsChecked;
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            AddOrRemoveNode(e.Node, e.Node.Checked);

            if (e.Node.Nodes.Count > 0)
                CheckTreeNodes(e.Node, e.Node.Checked);

            labelCheckedItems.Text = CheckedNodes.Count.ToString();
            labelCheckedItems.Refresh();
        }
    }
}

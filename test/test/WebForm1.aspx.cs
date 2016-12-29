using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TreeView1.Nodes.Clear();

            TreeNode treeNodeFruits = new TreeNode("果物");
            TreeNode treeNodeVegetables = new TreeNode("野菜");
            TreeNode[] treeNodeSubFolder =
              { treeNodeFruits, treeNodeVegetables};

            // 下位階層に対してまとめて項目（ノード）を追加
            TreeNode treeNodeFood =
              new TreeNode("食べ物");

            TreeNode treeNodeDrink = new TreeNode("飲み物");

            // 最上位階層に対してまとめて項目（ノード）を追加
            TreeView1.Nodes.Add(treeNodeFood);
            TreeView1.Nodes.Add(treeNodeDrink);

            TreeView1.ExpandAll();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace XMUI.Nodes
{
    public class Node
    {
        public List<Node> children { get; set; }
        public string name { get; set; }

        public virtual void Ready()
        {
            foreach (Node node in children)
            {
                node.Ready();
            }
        }
        public virtual void Process()
        {
            foreach (Node node in children)
            {
                node.Process();
            }
        }
        public virtual void Render(int currentList)
        {
            foreach (Node node in children)
            {
                node.Render(currentList);
            }
        }
    }
}

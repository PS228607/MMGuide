namespace BinaryTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var tree = new BinaryTree
            {
                //Maakt mijn boomstructuur
                //'Root' word als beginpunt gebruikt
                Root = new BinaryTreeNode
                {
                    Value = 8,
                    Left = new BinaryTreeNode
                    {
                        Value = 3,
                        Left = new BinaryTreeNode
                        {
                            Value = 1
                        }
                    },


                    Right = new BinaryTreeNode
                    {
                        Value = 9,
                        Left = new BinaryTreeNode
                        {
                            Value = 6,
                            Left = new BinaryTreeNode
                            {
                                Value = 7,
                            },
                            Right = new BinaryTreeNode
                            {
                                Value = 4
                            }
                        },

                        Right = new BinaryTreeNode
                        {
                            Value = 10,
                            Left = new BinaryTreeNode
                            { 
                                Value = 2,
                            }
                        }
                    }
                }
            };

            Console.WriteLine("Enkelvoudige kindknooppunten:");
            tree.PrintSingleChildLeaves();
        }
    }


    public class BinaryTreeNode
    {
        public int Value { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
    }
    public class BinaryTree
    {
        public BinaryTreeNode Root { get; set; }

        public void PrintSingleChildLeaves()
        {
            PrintSingleChildLeaves(Root);
        }

        private void PrintSingleChildLeaves(BinaryTreeNode node)
        {
            if (node == null) //Controleert of de boom een huidig knooppunt heeft
                return;


            if ((node.Left == null && node.Right != null && node.Right.Left == null && node.Right.Right == null) ||
                (node.Right == null && node.Left != null && node.Left.Left == null && node.Left.Right == null))
            {
                Console.WriteLine(node.Value); //Geeft huidige knooppunt aan
            }

            PrintSingleChildLeaves(node.Left);
            PrintSingleChildLeaves(node.Right);

            /*Gaat net zo lang door ded methode voor linker en rechterkind,
            Tot dat alle enkelvoudige knooppunten bekend zijn*/
        }
    }
}
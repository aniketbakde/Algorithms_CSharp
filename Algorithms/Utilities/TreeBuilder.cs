

namespace Algorithms.Utilities
{
    public class TreeBuilder
    {
        
        /*
         *              10
         *      /               \
         *      2               10
         *   /     \                \
         * 20       1               -25
         *                      /       \
         *                      3       4
        */
        public TreeNode<int> BootStrapTree1()
        {
            return new TreeNode<int>()
            {
                Value = 10,
                LeftChild = new TreeNode<int>()
                {
                    Value = 2,
                    LeftChild = new TreeNode<int>()
                    {
                        Value = 20
                    },
                    RightChild = new TreeNode<int>()
                    {
                        Value = 1
                    }
                },
                RightChild = new TreeNode<int>()
                {
                    Value = 10,
                    RightChild = new TreeNode<int>()
                    {
                        Value = -25,
                        LeftChild = new TreeNode<int>()
                        {
                            Value = 3
                        },
                        RightChild = new TreeNode<int>()
                        {
                            Value = 4
                        }
                    }
                }
            };
        }

        /*
         *              1
         *      /               \
         *      2               3
        */
        public TreeNode<int> BootStrapTree2()
        {
            return new TreeNode<int>()
            {
                Value = 1,
                LeftChild = new TreeNode<int>()
                {
                    Value = 2
                },
                RightChild = new TreeNode<int>()
                {
                    Value = 3
                }
            };
        }

        /*
         *              -10
         *      /               \
         *      2               -10
         *   /     \                \
         * 20       1               25
         *                      /       \
         *                      3       4
        */
        public TreeNode<int> BootStrapTree3()
        {
            return new TreeNode<int>()
            {
                Value = -10,
                LeftChild = new TreeNode<int>()
                {
                    Value = 2,
                    LeftChild = new TreeNode<int>()
                    {
                        Value = 20
                    },
                    RightChild = new TreeNode<int>()
                    {
                        Value = 1
                    }
                },
                RightChild = new TreeNode<int>()
                {
                    Value = -10,
                    RightChild = new TreeNode<int>()
                    {
                        Value = 25,
                        LeftChild = new TreeNode<int>()
                        {
                            Value = 3
                        },
                        RightChild = new TreeNode<int>()
                        {
                            Value = 4
                        }
                    }
                }
            };
        }

        /*
         *              1
         *      /               \
         *      2               3
         *   /     \                
         * 4       5               
         *                      
         *                      
        */
        public TreeNode<int> BootStrapTree4()
        {
            return new TreeNode<int>()
            {
                Value = 1,
                LeftChild = new TreeNode<int>()
                {
                    Value = 2,
                    LeftChild = new TreeNode<int>()
                    {
                        Value = 4
                    },
                    RightChild = new TreeNode<int>()
                    {
                        Value = 5
                    }
                },
                RightChild = new TreeNode<int>()
                {
                    Value = 3
                }
            };
        }
    }
}

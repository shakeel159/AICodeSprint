namespace Trees
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 32, 2, 29, 1, 8, 14, 6 };
            DictionaryNodeRoot tree = new DictionaryNodeRoot();


            foreach (int nums in numbers)
            {

                tree.AddNumber(nums.ToString());
            }
            Console.WriteLine(tree.ContainsNum("2"));
        }
    }
    public class DictionaryNodeRoot
    {
        DictionaryNode _root = new DictionaryNode();

        public void AddNumber(string value)
        {
            DictionaryNode current = this._root;
            for (int i = 0; i < value.Length; i++)
            {
                current = current.Add(value[i]);
            }
            current.SetNumber(value);
        }

        public bool ContainsNum(string value)
        {
            DictionaryNode current = this._root;
            for (int i = 0; i < value.Length; i++)
            {
                current = current.Get(value[i]);
                if (current == null)
                {
                    return false;
                }
            }
            return current != null && current.GetNum() != null;
        }
    }
    public class DictionaryNode
    {
        string number;
        DictionaryNode[] _dict; // Use array for performance boost.

        public DictionaryNode Add(char value)
        {
            if (this._dict == null)
            {
                this._dict = new DictionaryNode[26];
            }
            // Look up and return if possible.
            int key = value % 26;
            if (this._dict[key] != null)
            {
                return this._dict[key];
            }
            // Store.
            var result = new DictionaryNode();
            this._dict[key] = result;
            return result;
        }

        public DictionaryNode Get(char value)
        {
            // Get individual child node.
            if (this._dict == null)
            {
                return null;
            }
            int key = value % 26;
            return this._dict[key];
        }

        public void SetNumber(string val)
        {
            this.number = val;
        }

        public string GetNum()
        {
            return this.number;
        }
    }

}
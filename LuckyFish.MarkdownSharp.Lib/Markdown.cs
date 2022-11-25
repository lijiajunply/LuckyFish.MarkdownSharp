using System.Text;

namespace LuckyFish.MarkdownSharp.Lib
{
    public class Markdown
    {
        private readonly List<MarkdownNode> RootNode;
        private readonly StringBuilder Builder;
        public string context;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Context"></param>
        public Markdown(string Context)
        {
            this.context = Context;
            RootNode = new List<MarkdownNode>();
            Builder = new StringBuilder();
            Transform();
            ToStringBuilder();
        }
        /// <summary>
        /// 翻译，将context翻译成List<MarkdownNode>(RootNode)
        /// </summary>
        private void Transform()
        {
            string line = "";
            bool isCodeBlock = false;
            using StreamReader reader =
                new StreamReader(new MemoryStream(Encoding.Unicode.GetBytes(context)));
            while ((line = reader.ReadLine()) is not null)
            {
                line = line.TrimStart(' ');
                if (!isCodeBlock && string.IsNullOrEmpty(line))
                {
                    continue;
                }

                if (1 == 1)
                {

                }
            }
        }
        /// <summary>
        /// 将RootNode翻译成StringBuild
        /// </summary>
        private void ToStringBuilder()
        {

        }
        public string ToHTML() => Builder.ToString();
        public List<MarkdownNode> GetList() => RootNode;
    }
}


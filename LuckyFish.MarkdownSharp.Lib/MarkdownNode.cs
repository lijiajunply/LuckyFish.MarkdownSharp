namespace LuckyFish.MarkdownSharp.Lib;
public enum MarkdownNodeType
{
    NULL,
    Heading1,//h1
    Heading2,
    Heading3,
    Heading4,
    Heading5,
    Heading6,//h6
    Paragraph,//段落
    Strong,//代码块
    Italic,//字体倾斜
    DeleteLine,//删除效果
    Blockquote,//左、右两边进行缩进（增加外边距）
    OrderedList,//有序列表
    UnorderedList,//无序列表
    ListItem,//列表元素
    Code,//代码块
    BlockCode,
    HorizontalRule,//水平线
    Link,//链接
    Image//图片
}

public class MarkdownNode
{
    public MarkdownNodeType Type { get; set; }
    public string Context { get; set; }
    /// <summary>
    /// 初始化
    /// </summary>
    /// <param name="type">类型</param>
    /// <param name="context">内容</param>
    public MarkdownNode(MarkdownNodeType type, string context)
    {
        this.Type = type;
        this.Context = context;
    }
}


class HTMLTag
{
    /// <summary>
    /// 开始节点
    /// </summary>
    public static readonly string[] BeginTag =
    {"", "<h1>", "<h2>", "<h3>", "<h4>", "<h5>", "<h6>", "<p>", "<strong>",
        "<em>", "<strike>", "<blockquote>", "<ol>", "<ul>", "<li>", "<code>", "<pre><code>",
        "<hr/>", "", ""};

    /// <summary>
    /// 结束节点
    /// </summary>
    public static readonly string[] EndTag =
    {"", "</h1>", "</h2>", "</h3>", "</h4>", "</h5>", "</h6>", "</p>", "</strong>",
        "</em>", "</strike>", "</blockquote>", "</ol>", "</ul>", "</li>", "</code>", "</code></pre>",
        "<hr/>", "", ""};
}
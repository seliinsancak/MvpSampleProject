
using MVPSampleProject.Models;

namespace System.Web
{
    public class UI
    {
        public class WebControls
        {
            public class Button
            {
            }

            public class GridView
            {
                public List<User> DataSource { get; internal set; }
                public object DataKeys { get; internal set; }

                internal void DataBind()
                {
                    throw new NotImplementedException();
                }
            }

            public class TextBox
            {
                public string Text { get; internal set; }
                public object Attributes { get; internal set; }
            }

            public class Label
            {
                public string Text { get; internal set; }
            }

            public class GridViewCommandEventArgs
            {
                public bool CommandArgument { get; internal set; }
                public string CommandName { get; internal set; }
            }
        }

        public class Page
        {
        }

        public class HtmlControls
        {
            public class HtmlInputText
            {
                public string Value { get; internal set; }
            }
        }
    }
}
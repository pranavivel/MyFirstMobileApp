using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Model

namespace MyFirstMobileApp._Resources.Models.Titles
{
    public class TitleLayout
    {
        //NOT NEEDED for this project

        //Creates the databinding for page StackLayoutView
        public static string StackLayoutTitle { get; set; } = "Stack Layout";
        public static string VerticalStackTitle { get; set; } = "Vertical Stack";
        public static string HorizontalStackTitle { get; set; } = "Horizontal Stack";
        public static string AbsoluteLayoutTitle { get; set; } = "Absolute Layout";
        public static string FlexLayoutTitle { get; set; } = "Flex Layout";
    }
}
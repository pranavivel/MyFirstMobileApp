using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Model

namespace MyFirstMobileApp.Models
{
    public class TitleLayout
    {
        //NOT NEEDED for this project

        //Creates the databinding for page StackLayoutView
        public static String StackLayoutTitle { get; set; } = "Stack Layout";
        public static String VerticalStackTitle { get; set; } = "Vertical Stack";
        public static String HorizontalStackTitle { get; set; } = "Horizontal Stack";
        public static String AbsoluteLayoutTitle { get; set; } = "Absolute Layout";
        public static String FlexLayoutTitle { get; set; } = "Flex Layout";
    }
}
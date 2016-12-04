using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.ViewModel
{
    public class StaticMethodBindTest
    {
        public static string TestBind()
        {
            return "メソッドに直接バインド成功";
        }


        private static string testPropertyBind = "プロパティに直接バインド成功";

        public static string TestPropertyBind
        {
            get
            {
                return testPropertyBind;
            }

            set
            {
                testPropertyBind = value;
            }
        }
    }

    public static class StaticMethodBindTestExtension
    {
        public static string TestBindExt(this StaticMethodBindTest staticMethodBindTest)
        {
            return "拡張メソッドからの直接バインド成功";
        }
    }
}

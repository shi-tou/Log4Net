using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Log4Net.Test
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnError_Click(object sender, EventArgs e)
        {
            LogHelper.Debug("Debug-Message");
            LogHelper.Debug("Exception", new Exception("这是一个Exception"));
            LogHelper.Debug("测试Format:{0}","12345678");

            LogHelper.Error("Debug-Message");
            LogHelper.Error("Exception", new Exception("这是一个Exception"));
            LogHelper.Error("测试Format:{0}", "12345678");

            LogHelper.Info("Debug-Message");
            LogHelper.Info("Exception", new Exception("这是一个Exception"));
            LogHelper.Info("测试Format:{0}", "12345678");

            LogHelper.Warn("Debug-Message");
            LogHelper.Warn("Exception", new Exception("这是一个Exception"));
            LogHelper.Warn("测试Format:{0}", "12345678");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLog4net
{
    public class LogHelper 
    {
        //日志记录组件
        private static ILog Log { set; get; }


        static LogHelper()
        {
            //创建日志记录组件
            LogHelper.Log = new Log4netWrapper();
        }

        /// <summary>
        /// 记录信息日志
        /// </summary>
        /// <param name="msg">信息日志</param>
        /// <param name="ex">异常</param>
        public static void Info(string msg, Exception ex = null)
        {
            Log.Info(msg, ex);
        }

        /// <summary>
        /// 记录调试日志
        /// </summary>
        /// <param name="msg">调试日志</param>
        /// <param name="ex">异常</param>
        public static void Debug(string msg, Exception ex = null)
        {
            Log.Debug(msg, ex);
        }

        /// <summary>
        /// 记录警告日志
        /// </summary>
        /// <param name="msg">警告日志</param>
        /// <param name="ex">异常</param>
        public static void Warn(string msg, Exception ex = null)
        {
            Log.Warn(msg, ex);
        }

        /// <summary>
        /// 记录错误日志
        /// </summary>
        /// <param name="msg">错误日志</param>
        /// <param name="ex">异常</param>
        public static void Error(string msg, Exception ex = null)
        {
            Log.Error(msg, ex);
        }
    }
}
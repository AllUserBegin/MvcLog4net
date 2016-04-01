using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLog4net
{
    public class Log4netWrapper: ILog
    {
            //日志记录组件
        private static log4net.ILog Log { set; get; }

        static Log4netWrapper()
        {
            log4net.Config.XmlConfigurator.Configure();

            //创建日志记录组件
            Log4netWrapper.Log = log4net.LogManager.GetLogger("log4net");
        }

        /// <summary>
        /// 记录信息日志
        /// </summary>
        /// <param name="msg">信息日志</param>
        /// <param name="ex">异常</param>
        public void Info(string msg, Exception ex = null)
        {
            Log.Info(msg, ex);
        }

        /// <summary>
        /// 记录调试日志
        /// </summary>
        /// <param name="msg">调试日志</param>
        /// <param name="ex">异常</param>
        public void Debug(string msg, Exception ex = null)
        {
            Log.Debug(msg, ex);
        }

        /// <summary>
        /// 记录警告日志
        /// </summary>
        /// <param name="msg">告日志</param>
        /// <param name="ex">异常</param>
        public void Warn(string msg, Exception ex = null)
        {
            Log.Warn(msg, ex);
        }

        /// <summary>
        /// 记录错误日志
        /// </summary>
        /// <param name="msg">错误日志</param>
        /// <param name="ex">异常</param>
        public void Error(string msg, Exception ex = null)
        {
            Log.Error(msg, ex);
        }
    }
}
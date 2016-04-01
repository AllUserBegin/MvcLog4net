using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLog4net
{
    /// <summary>
    /// 日志接口
    /// </summary>
    internal interface ILog
    {
        /// <summary>
        /// 记录信息日志
        /// </summary>
        /// <param name="msg">信息</param>
        /// <param name="ex">异常</param>
        void Info(string msg, Exception ex = null);

        /// <summary>
        /// 记录调试日志
        /// </summary>
        /// <param name="msg">调试信息</param>
        /// <param name="ex">异常</param>
        void Debug(string msg, Exception ex = null);

        /// <summary>
        /// 记录警告日志
        /// </summary>
        /// <param name="msg">警告信息</param>
        /// <param name="ex">异常</param>
        void Warn(string msg, Exception ex = null);

        /// <summary>
        /// 记录错误日志
        /// </summary>
        /// <param name="msg">错误信息</param>
        /// <param name="ex">异常</param>
        void Error(string msg, Exception ex = null);
    }
}
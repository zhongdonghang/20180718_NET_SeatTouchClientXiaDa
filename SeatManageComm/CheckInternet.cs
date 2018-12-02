using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace SeatManage.SeatManageComm
{
    public class CheckInternet
    {

        [DllImport("wininet")]
        public static extern bool InternetGetConnectedState(ref int lpdwFlags, int dwReserved);
        /// <summary>
        /// 检查本地连接
        /// </summary>
        /// <returns></returns>
        public static bool CheckLocal()
        {
            int Flag = 0;
            if (!InternetGetConnectedState(ref Flag, 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 判断服务器是否联通
        /// </summary>
        /// <param name="serverIP"></param>
        /// <param name="serverPort"></param>
        /// <returns></returns>
        public static bool CheckPort(string serverIP, string serverPort)
        {
            if (serverIP.ToLower() == "localhost")
            {
                serverIP = "127.0.0.1";
            }
            IPAddress ip = IPAddress.Parse(serverIP);
            IPEndPoint point = new IPEndPoint(ip, int.Parse(serverPort));
            try
            {
                TcpClient tcp = new TcpClient();
                tcp.Connect(point);
                return true;
            }
            catch (Exception ex)
            {
                SeatManageComm.WriteLog.Write("连接服务器失败：" + ex.Message);
                return false;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeatManage.ClassModel
{ 
    /// <summary>
    /// 二维码扫描页面的参数类,url格式：?param=******；参数格式：seatNum=xxx&readingRoomNum=xxxx ,
    /// 例如：http://yuyue.juneberry.cn/BookSeat/ScanCode.aspx?param=****
    /// </summary>
    public class ScanCodeParamModel
    {
        string readingRoomNum;
        string seatNum;

        /// <summary>
        /// 座位号
        /// </summary>
        public string SeatNum
        {
            get { return seatNum; }
            set { seatNum = value; }
        }
        /// <summary>
        /// 阅览室编号
        /// </summary>
        public string ReadingRoomNum
        {
            get { return readingRoomNum; }
            set { readingRoomNum = value; }
        }
        public ScanCodeParamModel(string ciphertext)
        {
            ScanCodeParamModel model =  Prase(ciphertext);
            this.readingRoomNum = model.readingRoomNum;
            this.seatNum = model.seatNum; 
        }
        private ScanCodeParamModel()
        {
             
        }

        public static ScanCodeParamModel Prase(string ciphertext)
        {
            ScanCodeParamModel model = null;
            try
            {
                string plainText = SeatManage.SeatManageComm.AESAlgorithm.UrlDecode(ciphertext);
                string[] strArr = plainText.Split('&');
                model = new ScanCodeParamModel();
                for (int i = 0; i < strArr.Length; i++)
                {

                    string[] itemArr = strArr[i].Split('=');
                    switch (itemArr[0])
                    {
                        case "readingRoomNum":
                            model.readingRoomNum = itemArr[1];
                            break;
                        case "seatNum":
                            model.seatNum = itemArr[1];
                            break;
                    }
                }
            }
            catch (Exception ex)
            { } 
            return model;
        }
    }
}

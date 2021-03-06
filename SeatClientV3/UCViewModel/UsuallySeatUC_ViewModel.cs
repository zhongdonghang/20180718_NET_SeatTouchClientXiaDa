﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SeatClientV3.UCViewModel
{
    public class UsuallySeatUC_ViewModel
    {
        private string _SeatNo = "";
        /// <summary>
        /// 座位编号
        /// </summary>
        public string SeatNo
        {
            get { return _SeatNo; }
            set { _SeatNo = value; Changed("SeatNo"); }
        }
        private string _ShortSeatNo = "";
        /// <summary>
        /// 座位编号
        /// </summary>
        public string ShortSeatNo
        {
            get { return _ShortSeatNo; }
            set { _ShortSeatNo = value; Changed("ShortSeatNo"); Changed("SeatInfo"); }
        }
        private string _ReadingRoomNo = "";
        /// <summary>
        /// 阅览室编号
        /// </summary>
        public string ReadingRoomNo
        {
            get { return _ReadingRoomNo; }
            set { _ReadingRoomNo = value; Changed("ReadingRoomNo"); }
        }
        private string _ReadingRoomName = "";
        /// <summary>
        /// 阅览室名称
        /// </summary>
        public string ReadingRoomName
        {
            get { return _ReadingRoomName; }
            set { _ReadingRoomName = value; Changed("ReadingRoomName"); Changed("SeatInfo"); }
        }
        /// <summary>
        /// 座位信息
        /// </summary>
        public string SeatInfo
        {
            get { return ReadingRoomName + " " + _ShortSeatNo + "号座位"; }
        }




        #region INotifyPropertyChanged 成员
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}

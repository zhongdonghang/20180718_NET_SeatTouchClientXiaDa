using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeatManage.ISystemTerminal.ILoginValidate
{
    public class DefaultLoginValidate : ILoginValidate
    {
        public string CheckUser(string loginId, string password)
        {
            try
            {
                IWCFService.ISeatManageService seatService = WcfAccessProxy.ServiceProxy.CreateChannelSeatManageService();
                using (seatService as IDisposable)
                {
                    SeatManage.ClassModel.UserInfo reader = seatService.GetUserInfo(loginId);
                    if (reader != null)
                    {
                        if (reader.Password.Equals(SeatManage.SeatManageComm.MD5Algorithm.GetMD5Str32(password)) && reader.IsUsing == EnumType.LogStatus.Valid)
                            return reader.LoginId;
                        else
                            return "";
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

﻿/***********************************************
 * 作者：王昊天
 * 创建时间：2013-5-23
 * 说明：后台服务设置获取
 * 修改人：王随
 * 修改时间：2013-6-15 修改获取同步设置方法，添加同步设置方法，添加获取座位管理规则的方法。
 * *********************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeatManage.EnumType;
using SeatManage.ClassModel;
using System.ServiceModel;

namespace SeatManage.Bll
{
    public class T_SM_SystemSet
    {
        /// <summary>
        /// 获取同步设置
        /// </summary>
        /// <param name="ID">设置编号</param>
        /// <returns></returns>
        public static StuLibSyncSetting GetStuLibSync()
        {
            IWCFService.ISeatManageService seatService = WcfAccessProxy.ServiceProxy.CreateChannelSeatManageService();
            bool error = false;
            try
            {
                return seatService.GetStuLibSync();
            }
            catch (Exception ex)
            {
                error = true;
                SeatManageComm.WriteLog.Write("获取设置失败：" + ex.Message);
                return new StuLibSyncSetting();
            }
            finally
            {
                ICommunicationObject ICommObjectService = seatService as ICommunicationObject;
                try
                {
                    if (ICommObjectService.State == CommunicationState.Faulted)
                    {
                        ICommObjectService.Abort();
                    }
                    else
                    {
                        ICommObjectService.Close();
                    }
                }
                catch
                {
                    ICommObjectService.Abort();
                }
            }
        }
        /// <summary>
        /// 更新同步设置
        /// </summary>
        /// <param name="set"></param>
        /// <returns></returns>
        public static bool UpdateStuLibSync(StuLibSyncSetting set)
        {
            IWCFService.ISeatManageService seatService = WcfAccessProxy.ServiceProxy.CreateChannelSeatManageService();
            bool error = false;
            try
            {
                return seatService.UpdateStuLibSync(set);
            }
            catch (Exception ex)
            {
                error = true;
                SeatManageComm.WriteLog.Write("获取设置失败：" + ex.Message);
                return false;
            }
            finally
            {
                ICommunicationObject ICommObjectService = seatService as ICommunicationObject;
                try
                {
                    if (ICommObjectService.State == CommunicationState.Faulted)
                    {
                        ICommObjectService.Abort();
                    }
                    else
                    {
                        ICommObjectService.Close();
                    }
                }
                catch
                {
                    ICommObjectService.Abort();
                }
            }
        }
        /// <summary>
        /// 获取管理规则设置
        /// </summary>
        /// <returns></returns>
        public static RegulationRulesSetting GetRegulationRulesSetting()
        {
            IWCFService.ISeatManageService seatService = WcfAccessProxy.ServiceProxy.CreateChannelSeatManageService();
            bool error = false;
            try
            {
                return seatService.GetRegulationRulesSetting();
            }
            catch (Exception ex)
            {
                error = true;
                SeatManageComm.WriteLog.Write("获取设置失败：" + ex.Message);
                return null;
            }
            finally
            {
                ICommunicationObject ICommObjectService = seatService as ICommunicationObject;
                try
                {
                    if (ICommObjectService.State == CommunicationState.Faulted)
                    {
                        ICommObjectService.Abort();
                    }
                    else
                    {
                        ICommObjectService.Close();
                    }
                }
                catch
                {
                    ICommObjectService.Abort();
                }
            }
        }

        public static bool UpdateRegulationRulesSetting(RegulationRulesSetting set)
        {
            IWCFService.ISeatManageService seatService = WcfAccessProxy.ServiceProxy.CreateChannelSeatManageService();
            bool error = false;
            try
            {
                return seatService.UpdateRegulationRulesSetting(set);
            }
            catch (Exception ex)
            {
                error = true;
                SeatManageComm.WriteLog.Write("获取设置失败：" + ex.Message);
                return false;
            }
            finally
            {
                ICommunicationObject ICommObjectService = seatService as ICommunicationObject;
                try
                {
                    if (ICommObjectService.State == CommunicationState.Faulted)
                    {
                        ICommObjectService.Abort();
                    }
                    else
                    {
                        ICommObjectService.Close();
                    }
                }
                catch
                {
                    ICommObjectService.Abort();
                }
            }
        }
        /// <summary>
        /// 获取门禁接口设置
        /// </summary>
        /// <returns></returns>
        public static AccessSetting GetAccessSetting()
        {
            IWCFService.ISeatManageService seatService = WcfAccessProxy.ServiceProxy.CreateChannelSeatManageService();
            bool error = false;
            try
            {
                return seatService.GetAccessSetting();
            }
            catch (Exception ex)
            {
                error = true;
                SeatManageComm.WriteLog.Write("获取门禁接口设置失败：" + ex.Message);
                return null;
            }
            finally
            {
                ICommunicationObject ICommObjectService = seatService as ICommunicationObject;
                try
                {
                    if (ICommObjectService.State == CommunicationState.Faulted)
                    {
                        ICommObjectService.Abort();
                    }
                    else
                    {
                        ICommObjectService.Close();
                    }
                }
                catch
                {
                    ICommObjectService.Abort();
                }
            }
        }

        public static bool UpdateAccessSetting(AccessSetting set)
        {
            IWCFService.ISeatManageService seatService = WcfAccessProxy.ServiceProxy.CreateChannelSeatManageService();
            bool error = false;
            try
            {
                return seatService.UpdateAccessSetting(set);
            }
            catch (Exception ex)
            {
                error = true;
                SeatManageComm.WriteLog.Write("更新门禁接口设置失败：" + ex.Message);
                return false;
            }
            finally
            {
                ICommunicationObject ICommObjectService = seatService as ICommunicationObject;
                try
                {
                    if (ICommObjectService.State == CommunicationState.Faulted)
                    {
                        ICommObjectService.Abort();
                    }
                    else
                    {
                        ICommObjectService.Close();
                    }
                }
                catch
                {
                    ICommObjectService.Abort();
                }
            }
        }
        /// <summary>
        /// 获取使用手册
        /// </summary>
        /// <returns></returns>
        public static UserGuideInfo GetUserGuide()
        {
            IWCFService.ISeatManageService seatService = WcfAccessProxy.ServiceProxy.CreateChannelSeatManageService();
            try
            {
                return seatService.GetUserGuide();
            }
            catch (Exception ex)
            {
                SeatManageComm.WriteLog.Write("更新门禁接口设置失败：" + ex.Message);
                return null;
            }
            finally
            {
                ICommunicationObject ICommObjectService = seatService as ICommunicationObject;
                try
                {
                    if (ICommObjectService.State == CommunicationState.Faulted)
                    {
                        ICommObjectService.Abort();
                    }
                    else
                    {
                        ICommObjectService.Close();
                    }
                }
                catch
                {
                    ICommObjectService.Abort();
                }
            }
        }
        /// <summary>
        /// 修改使用手册
        /// </summary>
        /// <returns></returns>
        public static bool UpdateUserGuide(UserGuideInfo model)
        {
            IWCFService.ISeatManageService seatService = WcfAccessProxy.ServiceProxy.CreateChannelSeatManageService();
            try
            {
                return seatService.UpdateUserGuide(model);
            }
            catch (Exception ex)
            {
                SeatManageComm.WriteLog.Write("更新门禁接口设置失败：" + ex.Message);
                return false; ;
            }
            finally
            {
                ICommunicationObject ICommObjectService = seatService as ICommunicationObject;
                try
                {
                    if (ICommObjectService.State == CommunicationState.Faulted)
                    {
                        ICommObjectService.Abort();
                    }
                    else
                    {
                        ICommObjectService.Close();
                    }
                }
                catch
                {
                    ICommObjectService.Abort();
                }
            }
        }
        /// <summary>
        /// 获取移动客户端设置
        /// </summary>
        /// <returns></returns>
        public static MoveWebAppSetting GetMoveWebAppSetting()
        {
            IWCFService.ISeatManageService seatService = WcfAccessProxy.ServiceProxy.CreateChannelSeatManageService();
            try
            {
                return seatService.GetMoveWebAppSetting();
            }
            catch (Exception ex)
            {
                SeatManageComm.WriteLog.Write("获取移动客户端设置失败：" + ex.Message);
                return null;
            }
            finally
            {
                ICommunicationObject ICommObjectService = seatService as ICommunicationObject;
                try
                {
                    if (ICommObjectService.State == CommunicationState.Faulted)
                    {
                        ICommObjectService.Abort();
                    }
                    else
                    {
                        ICommObjectService.Close();
                    }
                }
                catch
                {
                    ICommObjectService.Abort();
                }
            }
        }
        /// <summary>
        /// 修改移动客户端设置
        /// </summary>
        /// <returns></returns>
        public static bool SaveMoveWebAppSetting(MoveWebAppSetting model)
        {
            IWCFService.ISeatManageService seatService = WcfAccessProxy.ServiceProxy.CreateChannelSeatManageService();
            try
            {
                return seatService.SaveMoveWebAppSetting(model);
            }
            catch (Exception ex)
            {
                SeatManageComm.WriteLog.Write("保存移动客户端设置失败：" + ex.Message);
                return false; 
            }
            finally
            {
                ICommunicationObject ICommObjectService = seatService as ICommunicationObject;
                try
                {
                    if (ICommObjectService.State == CommunicationState.Faulted)
                    {
                        ICommObjectService.Abort();
                    }
                    else
                    {
                        ICommObjectService.Close();
                    }
                }
                catch
                {
                    ICommObjectService.Abort();
                }
            }
        }
        /// <summary>
        /// 获取消息推送设置
        /// </summary>
        /// <returns></returns>
        public static MsgPostSet GetMsgPostSet()
        {
            IWCFService.ISeatManageService seatService = WcfAccessProxy.ServiceProxy.CreateChannelSeatManageService();
            try
            {
                return seatService.GetMsgPostSet();
            }
            catch (Exception ex)
            {
                SeatManageComm.WriteLog.Write("获取消息推送设置失败：" + ex.Message);
                throw ex;
            }
            finally
            {
                ICommunicationObject ICommObjectService = seatService as ICommunicationObject;
                try
                {
                    if (ICommObjectService.State == CommunicationState.Faulted)
                    {
                        ICommObjectService.Abort();
                    }
                    else
                    {
                        ICommObjectService.Close();
                    }
                }
                catch
                {
                    ICommObjectService.Abort();
                }
            }
        }
        /// <summary>
        /// 保存消息设置
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns> 
        public static bool SaveMsgPostSet(MsgPostSet model)
        {
            IWCFService.ISeatManageService seatService = WcfAccessProxy.ServiceProxy.CreateChannelSeatManageService();
            try
            {
                return seatService.SaveMsgPostSet(model);
            }
            catch (Exception ex)
            {
                SeatManageComm.WriteLog.Write("消息推送设置保存失败：" + ex.Message);
                throw ex;
            }
            finally
            {
                ICommunicationObject ICommObjectService = seatService as ICommunicationObject;
                try
                {
                    if (ICommObjectService.State == CommunicationState.Faulted)
                    {
                        ICommObjectService.Abort();
                    }
                    else
                    {
                        ICommObjectService.Close();
                    }
                }
                catch
                {
                    ICommObjectService.Abort();
                }
            }
        }
    }
}

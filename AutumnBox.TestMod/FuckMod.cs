﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/2/23 21:38:12 (UTC +8:00)
** desc： ...
*************************************************/
using AutumnBox.Basic.Device;
using AutumnBox.OpenFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutumnBox.TestMod
{
    public class FuckMod : AutumnBoxMod
    {
        public override string Name => "测试模块2";

        public override string Desc => "用于测试";
        public override DeviceState RequiredDeviceState => DeviceState.Poweron | DeviceState.Recovery;
        protected override void OnStartCommand(StartArgs args)
        {
            AutumnGuiApi.ShowMessageBox(Name,"Hello AutumnBox!");
        }
    }
}
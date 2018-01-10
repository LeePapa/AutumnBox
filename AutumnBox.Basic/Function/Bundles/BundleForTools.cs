﻿/* =============================================================================*\
*
* Filename: BundleForTools
* Description: 
*
* Version: 1.0
* Created: 2017/11/22 19:30:04 (UTC+8:00)
* Compiler: Visual Studio 2017
* 
* Author: zsh2401
* Company: I am free man
*
\* =============================================================================*/
using AutumnBox.Basic.Device;
using AutumnBox.Basic.Executer;
using AutumnBox.Basic.Function.Args;
using System;

namespace AutumnBox.Basic.Function.Bundles
{
    public class BundleForTools
    {
        public CommandExecuter Executer { get; private set; }
        public Func<string, OutputData> Ae { get; private set; }
        public Func<string, OutputData> Fe { get; private set; }
        public ModuleArgs Args { get; private set; }
        public Serial Serial { get { return Args.DeviceBasicInfo.Serial; } }
        public BundleForTools(CommandExecuter executer, ModuleArgs args)
        {
            Executer = executer;
            Args = args;
            Ae = (command) =>
            { return Executer.Execute(Command.MakeForAdb(Serial, command)).Output; };
            Fe = (command) =>
            { return Executer.Execute(Command.MakeForFastboot(Serial, command)).Output; };
        }
    }
}
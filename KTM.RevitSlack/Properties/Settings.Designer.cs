﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KTM.RevitSlack.Properties
{


    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
    {

        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        public static Settings Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("vstemplateproject")]
        public string Prj_Name
        {
            get
            {
                return ((string)(this["Prj_Name"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Harvest my model!!")]
        public string Cmd_01_Description
        {
            get
            {
                return ((string)(this["Cmd_01_Description"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("KTM.RevitSlack.Entry.CmdMain")]
        public string Cmd_01_EntryPoint_Class
        {
            get
            {
                return ((string)(this["Cmd_01_EntryPoint_Class"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("IVL.Button")]
        public string Cmd_01_ButtonName
        {
            get
            {
                return ((string)(this["Cmd_01_ButtonName"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Harvest\r\nBuilding")]
        public string Cmd_01_ButtonText
        {
            get
            {
                return ((string)(this["Cmd_01_ButtonText"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("icons")]
        public string Prj_IconPath
        {
            get
            {
                return ((string)(this["Prj_IconPath"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("harvest_32.png")]
        public string Cmd_01_Button_Icon_32
        {
            get
            {
                return ((string)(this["Cmd_01_Button_Icon_32"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("harvest_16.png")]
        public string Cmd_01_Button_Icon_16
        {
            get
            {
                return ((string)(this["Cmd_01_Button_Icon_16"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2015")]
        public string Prj_RevitVersion
        {
            get
            {
                return ((string)(this["Prj_RevitVersion"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Incompatible Revit Version")]
        public string Prj_Error_RevitVersion
        {
            get
            {
                return ((string)(this["Prj_Error_RevitVersion"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("This Add-In was built for Revit ")]
        public string Prj_Error_Revit_UserString
        {
            get
            {
                return ((string)(this["Prj_Error_Revit_UserString"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("please contact INVIEWlabs for assistance...")]
        public string Prj_Error_Revit_Contact
        {
            get
            {
                return ((string)(this["Prj_Error_Revit_Contact"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("App License Not Verified")]
        public string Prj_Error_API_Error
        {
            get
            {
                return ((string)(this["Prj_Error_API_Error"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Either the tool has been retired or your License to use the tool has not been val" +
            "idated or has expired. \r\nContact {{Someone}} for assistance.")]
        public string Prj_Error_API_Error_Description
        {
            get
            {
                return ((string)(this["Prj_Error_API_Error_Description"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("IVL")]
        public string Prj_Client
        {
            get
            {
                return ((string)(this["Prj_Client"]));
            }
        }
    }
}

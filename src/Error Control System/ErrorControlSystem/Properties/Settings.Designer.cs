﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErrorControlSystem.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ErrorLogPath {
            get {
                return ((string)(this["ErrorLogPath"]));
            }
            set {
                this["ErrorLogPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4194304")]
        public long CacheLimitSize {
            get {
                return ((long)(this["CacheLimitSize"]));
            }
            set {
                this["CacheLimitSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("LocalApplicationData")]
        public global::ErrorControlSystem.CacheErrors.StoragePath StoragePath {
            get {
                return ((global::ErrorControlSystem.CacheErrors.StoragePath)(this["StoragePath"]));
            }
            set {
                this["StoragePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ReportHandledExceptions {
            get {
                return ((bool)(this["ReportHandledExceptions"]));
            }
            set {
                this["ReportHandledExceptions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500")]
        public int MaxQueuedCacheErrors {
            get {
                return ((int)(this["MaxQueuedCacheErrors"]));
            }
            set {
                this["MaxQueuedCacheErrors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool HandleProcessCorruptedStateExceptions {
            get {
                return ((bool)(this["HandleProcessCorruptedStateExceptions"]));
            }
            set {
                this["HandleProcessCorruptedStateExceptions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ExitApplicationImmediately {
            get {
                return ((bool)(this["ExitApplicationImmediately"]));
            }
            set {
                this["ExitApplicationImmediately"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DisplayDeveloperUI {
            get {
                return ((bool)(this["DisplayDeveloperUI"]));
            }
            set {
                this["DisplayDeveloperUI"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableNetworkSending {
            get {
                return ((bool)(this["EnableNetworkSending"]));
            }
            set {
                this["EnableNetworkSending"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CustomStoragePath {
            get {
                return ((string)(this["CustomStoragePath"]));
            }
            set {
                this["CustomStoragePath"] = value;
            }
        }
    }
}

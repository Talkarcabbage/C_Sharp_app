﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftTopics.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\\\Files\\\\Temp.txt")]
        public string temporaryFilePath {
            get {
                return ((string)(this["temporaryFilePath"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\\\Files\\\\TwoFactorSetup.txt")]
        public string twoFactorSetupPath {
            get {
                return ((string)(this["twoFactorSetupPath"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\\\Files\\\\MovieList.txt")]
        public string movieListPath {
            get {
                return ((string)(this["movieListPath"]));
            }
            set {
                this["movieListPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\\\Files\\\\OverDue.txt")]
        public string overDuePath {
            get {
                return ((string)(this["overDuePath"]));
            }
            set {
                this["overDuePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\\\Files\\\\RentalReport.txt")]
        public string rentalReportPath {
            get {
                return ((string)(this["rentalReportPath"]));
            }
            set {
                this["rentalReportPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\\\Files\\\\TempPassword.txt")]
        public string tempPasswordPath {
            get {
                return ((string)(this["tempPasswordPath"]));
            }
            set {
                this["tempPasswordPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\\\Files\\\\LateReturns.txt")]
        public string lateReturnsPath {
            get {
                return ((string)(this["lateReturnsPath"]));
            }
            set {
                this["lateReturnsPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\\\Files\\\\CheckedOut.txt")]
        public string checkedOutPath {
            get {
                return ((string)(this["checkedOutPath"]));
            }
            set {
                this["checkedOutPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\\\Files\\\\LoginReport.txt")]
        public string loginReportPath {
            get {
                return ((string)(this["loginReportPath"]));
            }
            set {
                this["loginReportPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\\\Files\\\\QuickLogin.txt")]
        public string quickLoginPath {
            get {
                return ((string)(this["quickLoginPath"]));
            }
            set {
                this["quickLoginPath"] = value;
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mordhau_RCON.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[]")]
        public string Servers {
            get {
                return ((string)(this["Servers"]));
            }
            set {
                this["Servers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool KeepAlive {
            get {
                return ((bool)(this["KeepAlive"]));
            }
            set {
                this["KeepAlive"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int AliveFreqSec {
            get {
                return ((int)(this["AliveFreqSec"]));
            }
            set {
                this["AliveFreqSec"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{\"ServerName\":\"LastServerEntry\",\"IP\":\"INVALID\",\"Port\":7778,\"Password\":\"CHANGEME\"}" +
            "")]
        public string LastServer {
            get {
                return ((string)(this["LastServer"]));
            }
            set {
                this["LastServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"255, 140, 0\"")]
        public string ColorConnecting {
            get {
                return ((string)(this["ColorConnecting"]));
            }
            set {
                this["ColorConnecting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"173, 255, 47\"")]
        public string ColorConSuc {
            get {
                return ((string)(this["ColorConSuc"]));
            }
            set {
                this["ColorConSuc"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"255, 0, 0\"")]
        public string ColorErrors {
            get {
                return ((string)(this["ColorErrors"]));
            }
            set {
                this["ColorErrors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"255, 255, 255\"")]
        public string ColorCommands {
            get {
                return ((string)(this["ColorCommands"]));
            }
            set {
                this["ColorCommands"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"255, 255, 0\"")]
        public string ColorOutput {
            get {
                return ((string)(this["ColorOutput"]));
            }
            set {
                this["ColorOutput"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"64, 64, 64\"")]
        public string ColorConsole {
            get {
                return ((string)(this["ColorConsole"]));
            }
            set {
                this["ColorConsole"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.99")]
        public double Opacity {
            get {
                return ((double)(this["Opacity"]));
            }
            set {
                this["Opacity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastCommands {
            get {
                return ((string)(this["LastCommands"]));
            }
            set {
                this["LastCommands"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"[""help"",""alive"",""listen allon"",""listen alloff"",""listen login"",""listen matchstate"",""listen killfeed"",""listen scorefeed"",""listen chat"",""listen custom"",""listen punishment"",""listenstatus"",""adminlist"",""banlist"",""mutelist"",""playerlist"",""maplist"",""addmap "",""removemap "",""addadmin "",""removeadmin "",""addbots "",""removebots "",""changelevel "",""say "",""customsay "",""string "",""event "",""spawnserveractor "",""kick "",""ban "",""unban "",""mute "",""unmute "",""scoreboard"",""info"",""stats"",""writetoconsole "",""changeteam "",""modifyinivar "",""getmatchduration"",""extendmatchduration "",""setmotd "",""teleportplayer "",""killplayer "",""getteamdamage "",""renameplayer "",""mountpak "",""chatlog "",""shutdown""]")]
        public string AutocompleteList {
            get {
                return ((string)(this["AutocompleteList"]));
            }
            set {
                this["AutocompleteList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpgradeRequired {
            get {
                return ((bool)(this["UpgradeRequired"]));
            }
            set {
                this["UpgradeRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SuppressAlive {
            get {
                return ((bool)(this["SuppressAlive"]));
            }
            set {
                this["SuppressAlive"] = value;
            }
        }
    }
}

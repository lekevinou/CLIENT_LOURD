﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
<<<<<<< HEAD
//     Version du runtime :4.0.30319.34014
=======
//     Version du runtime :4.0.30319.34209
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client_LOURD.Properties {
    
    
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
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=KEVIN-TOSH;Initial Catalog=gamilonbase;Integrated Security=True")]
        public string gamilonbaseConnectionString {
            get {
                return ((string)(this["gamilonbaseConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=PC-THOMAS;Initial Catalog=gamilonbase;Integrated Security=True")]
        public string gamilonbaseConnectionString1 {
            get {
                return ((string)(this["gamilonbaseConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=PC_RAKO;Initial Catalog=gamilonbase;Integrated Security=True")]
        public string gamilonbaseConnectionString2 {
            get {
                return ((string)(this["gamilonbaseConnectionString2"]));
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dramatiker.Library.Properties {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Dramatiker.Library.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static byte[] dramatiker {
            get {
                object obj = ResourceManager.GetObject("dramatiker", resourceCulture);
                return ((byte[])(obj));
            }
        }

        public static string Greeting {
            get {
                return ResourceManager.GetString("Greeting", resourceCulture);
            }
        }

        public static string Finished {
            get {
                return ResourceManager.GetString("Finished", resourceCulture);
            }
        }

        public static string NoSetFileFound {
            get {
                return ResourceManager.GetString("NoSetFileFound", resourceCulture);
            }
        }
        
        internal static string SettingUpWithConfig {
            get {
                return ResourceManager.GetString("SettingUpWithConfig", resourceCulture);
            }
        }
        
        internal static string PressKeyToContinue {
            get {
                return ResourceManager.GetString("PressKeyToContinue", resourceCulture);
            }
        }
        
        internal static string PressThePedal {
            get {
                return ResourceManager.GetString("PressThePedal", resourceCulture);
            }
        }
    }
}

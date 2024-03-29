﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ALMIS.Manager.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ALMIS.Manager.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pajtohem me deinstalimin e Auditimit të Almis Databazës.
        /// </summary>
        internal static string AlmisMessageBoxAgreeMessage {
            get {
                return ResourceManager.GetString("AlmisMessageBoxAgreeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deinstalimi i Auditimit.
        /// </summary>
        internal static string AlmisMessageBoxCaption {
            get {
                return ResourceManager.GetString("AlmisMessageBoxCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A pajtoheni për të deinstaluar Auditimin e databazës për ALMIS.
        ///Kjo nënkupton se do të deinstalohen të gjitha tabelat, të dhënat,
        ///views, procedurat dhe të gjitha infromacionet që lidhen me Auditim të ALMIS-it.
        ///Kliko checkboxin nëse pajtoheni për të vazhduar me deinstalim?
        ///.
        /// </summary>
        internal static string AlmisMessageBoxMessage {
            get {
                return ResourceManager.GetString("AlmisMessageBoxMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Almis Auditi u deinstalua me sukses!.
        /// </summary>
        internal static string AlmisUninstallingMessageBox {
            get {
                return ResourceManager.GetString("AlmisUninstallingMessageBox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Së pari duhet të pajtohesh duke klikuar checkboxin 
        ///për të vazhduar me deinstalim të Almis Audit Databasës
        ///      .
        /// </summary>
        internal static string AlmisUninstallingMessageBoxAgree {
            get {
                return ResourceManager.GetString("AlmisUninstallingMessageBoxAgree", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arkivimi i logut deshtoi.Provoni perseri....
        /// </summary>
        internal static string logArchivedFailMsgBox {
            get {
                return ResourceManager.GetString("logArchivedFailMsgBox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Logu u arkivua me sukses.
        /// </summary>
        internal static string logArchivedMsgBox {
            get {
                return ResourceManager.GetString("logArchivedMsgBox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fshierja e logut deshtoi.Provoni perseri....
        /// </summary>
        internal static string logDeletedFailMsgBox {
            get {
                return ResourceManager.GetString("logDeletedFailMsgBox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Logu u fshi me sukses.
        /// </summary>
        internal static string logDeletedMsgBox {
            get {
                return ResourceManager.GetString("logDeletedMsgBox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parakushtet janë të instaluara..
        /// </summary>
        internal static string prerequirementsMsgBox {
            get {
                return ResourceManager.GetString("prerequirementsMsgBox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ju lutem jepni te drejte te qasjes perdoruesit.
        /// </summary>
        internal static string userHasNoRightMsgBox {
            get {
                return ResourceManager.GetString("userHasNoRightMsgBox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Perdoruesi deshtoi te regjistrohet, ju lutem provoni perseri..
        /// </summary>
        internal static string userNotRegisteredMsgBox {
            get {
                return ResourceManager.GetString("userNotRegisteredMsgBox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Perdoruesi u regjistrua me sukses....
        /// </summary>
        internal static string userRegisteredMsgBox {
            get {
                return ResourceManager.GetString("userRegisteredMsgBox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Perdoruesi deshoti per tu çregjistruar. Ju lutem provoni perseri.
        /// </summary>
        internal static string userUnRegisteredFailMsgBox {
            get {
                return ResourceManager.GetString("userUnRegisteredFailMsgBox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Perdoruesi u çregjistrua me sukses....
        /// </summary>
        internal static string userUnRegisteredMsgBox {
            get {
                return ResourceManager.GetString("userUnRegisteredMsgBox", resourceCulture);
            }
        }
    }
}

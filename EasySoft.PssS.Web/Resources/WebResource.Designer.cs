﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasySoft.PssS.Web.Resources {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class WebResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal WebResource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EasySoft.PssS.Web.Resources.WebResource", typeof(WebResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 个人中心 的本地化字符串。
        /// </summary>
        public static string HomeIndex_Title {
            get {
                return ResourceManager.GetString("HomeIndex_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 爱原汁味的生活 的本地化字符串。
        /// </summary>
        public static string SystemName {
            get {
                return ResourceManager.GetString("SystemName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 立即登录 的本地化字符串。
        /// </summary>
        public static string UserLogin_LoginButton {
            get {
                return ResourceManager.GetString("UserLogin_LoginButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 手机号或密码错误，请重新输入。 的本地化字符串。
        /// </summary>
        public static string UserLogin_LoginError {
            get {
                return ResourceManager.GetString("UserLogin_LoginError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请输入您的手机号 的本地化字符串。
        /// </summary>
        public static string UserLogin_Moblie {
            get {
                return ResourceManager.GetString("UserLogin_Moblie", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请输入您的手机号。 的本地化字符串。
        /// </summary>
        public static string UserLogin_MoblieTip {
            get {
                return ResourceManager.GetString("UserLogin_MoblieTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请输入您的密码 的本地化字符串。
        /// </summary>
        public static string UserLogin_Password {
            get {
                return ResourceManager.GetString("UserLogin_Password", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请输入您的密码。 的本地化字符串。
        /// </summary>
        public static string UserLogin_PasswordTip {
            get {
                return ResourceManager.GetString("UserLogin_PasswordTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 用户登录 的本地化字符串。
        /// </summary>
        public static string UserLogin_Title {
            get {
                return ResourceManager.GetString("UserLogin_Title", resourceCulture);
            }
        }
    }
}

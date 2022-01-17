﻿#pragma checksum "..\..\..\..\..\Views\ViewForUsers\UserRegistrationWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A39352700C1646F4C160CF62D58FF11E00E649FE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Сафари.ViewModels;
using Сафари.Views.ViewForUsers;


namespace Сафари.Views.ViewForUsers {
    
    
    /// <summary>
    /// UserRegistrationWindow
    /// </summary>
    public partial class UserRegistrationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\Views\ViewForUsers\UserRegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Views\ViewForUsers\UserRegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\Views\ViewForUsers\UserRegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textLogin;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Views\ViewForUsers\UserRegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox textPass;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\Views\ViewForUsers\UserRegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox textPass2;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\Views\ViewForUsers\UserRegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textEmail;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\Views\ViewForUsers\UserRegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\..\Views\ViewForUsers\UserRegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnter;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Сафари;component/views/viewforusers/userregistrationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\ViewForUsers\UserRegistrationWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.textBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.btnLogin = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.textLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.textPass = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 34 "..\..\..\..\..\Views\ViewForUsers\UserRegistrationWindow.xaml"
            this.textPass.PasswordChanged += new System.Windows.RoutedEventHandler(this.PasswordBox_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textPass2 = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 42 "..\..\..\..\..\Views\ViewForUsers\UserRegistrationWindow.xaml"
            this.textPass2.PasswordChanged += new System.Windows.RoutedEventHandler(this.PasswordBox_PasswordChanged2);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.btnEnter = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


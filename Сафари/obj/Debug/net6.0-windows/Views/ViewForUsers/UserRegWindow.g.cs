﻿#pragma checksum "..\..\..\..\..\Views\ViewForUsers\UserRegWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2B487ED5FD071499C65B2B9B2E1B959E45E16E1A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using Сафари.ViewModels.ForUsers;
using Сафари.Views.ViewForUsers;


namespace Сафари.Views.ViewForUsers {
    
    
    /// <summary>
    /// UserRegWindow
    /// </summary>
    public partial class UserRegWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\..\Views\ViewForUsers\UserRegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxLog;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\Views\ViewForUsers\UserRegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passBoxPass;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\Views\ViewForUsers\UserRegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passBoxRepitPass;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\Views\ViewForUsers\UserRegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxEmail;
        
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
            System.Uri resourceLocater = new System.Uri("/Сафари;component/views/viewforusers/userregwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\ViewForUsers\UserRegWindow.xaml"
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
            
            #line 19 "..\..\..\..\..\Views\ViewForUsers\UserRegWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBoxLog = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.passBoxPass = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 22 "..\..\..\..\..\Views\ViewForUsers\UserRegWindow.xaml"
            this.passBoxPass.PasswordChanged += new System.Windows.RoutedEventHandler(this.PasswordBox_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.passBoxRepitPass = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 23 "..\..\..\..\..\Views\ViewForUsers\UserRegWindow.xaml"
            this.passBoxRepitPass.PasswordChanged += new System.Windows.RoutedEventHandler(this.PasswordBox_PasswordChanged2);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBoxEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\RemindPassword.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4DD39AF481CAFFF5BA02C3663264B263370C8835A593670D8979BB19C7191CCF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ExamMain;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace ExamMain {
    
    
    /// <summary>
    /// RemindPassword
    /// </summary>
    public partial class RemindPassword : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\RemindPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSecret;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\RemindPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxPassword;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\RemindPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOkey;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\RemindPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ExamMain;component/remindpassword.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RemindPassword.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtSecret = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\RemindPassword.xaml"
            this.txtSecret.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSecretChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtBoxPassword = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\RemindPassword.xaml"
            this.txtBoxPassword.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtPasswordChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnOkey = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\RemindPassword.xaml"
            this.btnOkey.Click += new System.Windows.RoutedEventHandler(this.CheckFor);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\RemindPassword.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.Cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


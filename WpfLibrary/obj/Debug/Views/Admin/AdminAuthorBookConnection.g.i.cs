﻿#pragma checksum "..\..\..\..\Views\Admin\AdminAuthorBookConnection.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6427B006D3F5011AE4C47AA691E14CAF05AE6BA5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfLibrary.Views;


namespace WpfLibrary.Views {
    
    
    /// <summary>
    /// AdminAuthorBookConnection
    /// </summary>
    public partial class AdminAuthorBookConnection : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Views\Admin\AdminAuthorBookConnection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBack;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Views\Admin\AdminAuthorBookConnection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAssign;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Views\Admin\AdminAuthorBookConnection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDelCon;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfLibrary;component/views/admin/adminauthorbookconnection.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Admin\AdminAuthorBookConnection.xaml"
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
            this.ButtonBack = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\Views\Admin\AdminAuthorBookConnection.xaml"
            this.ButtonBack.Click += new System.Windows.RoutedEventHandler(this.ButtonBack_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonAssign = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Views\Admin\AdminAuthorBookConnection.xaml"
            this.ButtonAssign.Click += new System.Windows.RoutedEventHandler(this.ButtonAssign_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonDelCon = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Views\Admin\AdminAuthorBookConnection.xaml"
            this.ButtonDelCon.Click += new System.Windows.RoutedEventHandler(this.ButtonDelCon_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


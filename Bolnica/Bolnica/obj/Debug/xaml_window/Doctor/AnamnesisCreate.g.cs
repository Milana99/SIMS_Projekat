﻿#pragma checksum "..\..\..\..\xaml_window\Doctor\AnamnesisCreate.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FD57563DA5DF2D9DA0D4FF650ED5684B9E57D14EA507B7A1589C97FD4A677616"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bolnica.Validation;
using Bolnica.xaml_window.Doctor;
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


namespace Bolnica.xaml_window.Doctor {
    
    
    /// <summary>
    /// AnamnesisCreate
    /// </summary>
    public partial class AnamnesisCreate : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\xaml_window\Doctor\AnamnesisCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTypeAnamnesis;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\xaml_window\Doctor\AnamnesisCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDemo;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\xaml_window\Doctor\AnamnesisCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDescriptionAnamnesis;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\xaml_window\Doctor\AnamnesisCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbOpinionForAnamnesis;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\..\xaml_window\Doctor\AnamnesisCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label btnPlus;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\..\xaml_window\Doctor\AnamnesisCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvDataBindingAnamnesis;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/xaml_window/doctor/anamnesiscreate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\xaml_window\Doctor\AnamnesisCreate.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.tbTypeAnamnesis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnDemo = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\xaml_window\Doctor\AnamnesisCreate.xaml"
            this.btnDemo.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbDescriptionAnamnesis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbOpinionForAnamnesis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 128 "..\..\..\..\xaml_window\Doctor\AnamnesisCreate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Therapy);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnPlus = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lvDataBindingAnamnesis = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            
            #line 161 "..\..\..\..\xaml_window\Doctor\AnamnesisCreate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Cancel);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 162 "..\..\..\..\xaml_window\Doctor\AnamnesisCreate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Ok);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


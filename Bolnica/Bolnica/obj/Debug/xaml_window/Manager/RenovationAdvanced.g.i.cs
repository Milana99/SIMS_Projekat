﻿#pragma checksum "..\..\..\..\xaml_window\Manager\RenovationAdvanced.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8BB0AB733B83E16AAADA516C588832F4A69591B97D8BDC4ACC56A08EEB03304C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bolnica.xaml_window.Manager;
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


namespace Bolnica.xaml_window.Manager {
    
    
    /// <summary>
    /// RenovationAdvanced
    /// </summary>
    public partial class RenovationAdvanced : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\xaml_window\Manager\RenovationAdvanced.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbRooms;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\xaml_window\Manager\RenovationAdvanced.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDateRenovationStart;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\xaml_window\Manager\RenovationAdvanced.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbStartTime;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\xaml_window\Manager\RenovationAdvanced.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDateRenovationEnd;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\xaml_window\Manager\RenovationAdvanced.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbEndTime;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\xaml_window\Manager\RenovationAdvanced.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDescriptionRenovation;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/xaml_window/manager/renovationadvanced.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\xaml_window\Manager\RenovationAdvanced.xaml"
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
            this.cbRooms = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.dpDateRenovationStart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.tbStartTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.dpDateRenovationEnd = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.tbEndTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbDescriptionRenovation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 41 "..\..\..\..\xaml_window\Manager\RenovationAdvanced.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_OK);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 42 "..\..\..\..\xaml_window\Manager\RenovationAdvanced.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


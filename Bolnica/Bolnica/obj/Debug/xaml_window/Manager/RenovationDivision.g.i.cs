﻿#pragma checksum "..\..\..\..\xaml_window\Manager\RenovationDivision.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C7A18E6ED4C57E94055CA7A810D2247F4380F37D44237A6FCA2C5B65F99B0192"
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
    /// RenovationSeparation
    /// </summary>
    public partial class RenovationSeparation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\xaml_window\Manager\RenovationDivision.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbRooms;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\xaml_window\Manager\RenovationDivision.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDateRenovationStart;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\xaml_window\Manager\RenovationDivision.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbStartTime;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\xaml_window\Manager\RenovationDivision.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDateRenovationEnd;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\xaml_window\Manager\RenovationDivision.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbEndTime;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\xaml_window\Manager\RenovationDivision.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvDataBindingRooms;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/xaml_window/manager/renovationdivision.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\xaml_window\Manager\RenovationDivision.xaml"
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
            this.lvDataBindingRooms = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            
            #line 67 "..\..\..\..\xaml_window\Manager\RenovationDivision.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Add_Room);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 70 "..\..\..\..\xaml_window\Manager\RenovationDivision.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Ok);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 71 "..\..\..\..\xaml_window\Manager\RenovationDivision.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

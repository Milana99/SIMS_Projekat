﻿#pragma checksum "..\..\..\..\xaml_window\Manager\RenovationSeparation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "61602B1677A1B1D0C4EC517084816DA1DC30E37DBC0723E7B84F9C52EC7E252E"
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
        
        
        #line 30 "..\..\..\..\xaml_window\Manager\RenovationSeparation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbRooms;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\xaml_window\Manager\RenovationSeparation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbArea;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\xaml_window\Manager\RenovationSeparation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbFloor;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\xaml_window\Manager\RenovationSeparation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDateRenovationStart;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\xaml_window\Manager\RenovationSeparation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbStartTime;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\xaml_window\Manager\RenovationSeparation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDateRenovationEnd;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\xaml_window\Manager\RenovationSeparation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbEndTime;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\xaml_window\Manager\RenovationSeparation.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/xaml_window/manager/renovationseparation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\xaml_window\Manager\RenovationSeparation.xaml"
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
            
            #line 30 "..\..\..\..\xaml_window\Manager\RenovationSeparation.xaml"
            this.cbRooms.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbRooms_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbArea = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lbFloor = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.dpDateRenovationStart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.tbStartTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.dpDateRenovationEnd = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.tbEndTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.lvDataBindingRooms = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            
            #line 73 "..\..\..\..\xaml_window\Manager\RenovationSeparation.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Add_Room);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 76 "..\..\..\..\xaml_window\Manager\RenovationSeparation.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Ok);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 77 "..\..\..\..\xaml_window\Manager\RenovationSeparation.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\xaml_window\Manager\StaticEquipmentRelocation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "39652A8E870B3B91C7A6144F2CB976D7ED3972635E42CC57592682ECD9FD7FC8"
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
    /// StaticEquipmentRelocation
    /// </summary>
    public partial class StaticEquipmentRelocation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\xaml_window\Manager\StaticEquipmentRelocation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbuIDStaticEq;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\xaml_window\Manager\StaticEquipmentRelocation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbuName;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\xaml_window\Manager\StaticEquipmentRelocation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbuStaticDescription;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\xaml_window\Manager\StaticEquipmentRelocation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpRelocation;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\xaml_window\Manager\StaticEquipmentRelocation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTime;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\xaml_window\Manager\StaticEquipmentRelocation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbuRoomStatic;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/xaml_window/manager/staticequipmentrelocation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\xaml_window\Manager\StaticEquipmentRelocation.xaml"
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
            this.lbuIDStaticEq = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lbuName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lbuStaticDescription = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.dpRelocation = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.tbTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.cbuRoomStatic = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 66 "..\..\..\..\xaml_window\Manager\StaticEquipmentRelocation.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Ok);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 67 "..\..\..\..\xaml_window\Manager\StaticEquipmentRelocation.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\xaml_window\Manager\DynamicEquipment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D071E69A28FA62BB1CBF812AB6FCBD7B103C2FCF70A8FA68EBDA04D39ACF4FFA"
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
    /// DynamicEquipment
    /// </summary>
    public partial class DynamicEquipment : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\xaml_window\Manager\DynamicEquipment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearch;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\xaml_window\Manager\DynamicEquipment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvDataBindingDynamicEq;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/xaml_window/manager/dynamicequipment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\xaml_window\Manager\DynamicEquipment.xaml"
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
            
            #line 25 "..\..\..\..\xaml_window\Manager\DynamicEquipment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Back);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.lvDataBindingDynamicEq = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            
            #line 41 "..\..\..\..\xaml_window\Manager\DynamicEquipment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Create);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 42 "..\..\..\..\xaml_window\Manager\DynamicEquipment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Delete);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 43 "..\..\..\..\xaml_window\Manager\DynamicEquipment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Increase);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 44 "..\..\..\..\xaml_window\Manager\DynamicEquipment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Decrease);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\xaml_window\Manager\StaticEquipment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B945F1D33E4E17B8A433B62AA04193AA26E579F32DCC0C3EB8F244BB74DCC86F"
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
    /// StaticEquipment
    /// </summary>
    public partial class StaticEquipment : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\..\xaml_window\Manager\StaticEquipment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearch;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\xaml_window\Manager\StaticEquipment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbRooms;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\xaml_window\Manager\StaticEquipment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvDataBindingStaticEq;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/xaml_window/manager/staticequipment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\xaml_window\Manager\StaticEquipment.xaml"
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
            
            #line 33 "..\..\..\..\xaml_window\Manager\StaticEquipment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Back);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\..\xaml_window\Manager\StaticEquipment.xaml"
            this.tbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbSearch_TextChanged);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\..\xaml_window\Manager\StaticEquipment.xaml"
            this.tbSearch.GotFocus += new System.Windows.RoutedEventHandler(this.tbSearch_GotFocus);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\..\xaml_window\Manager\StaticEquipment.xaml"
            this.tbSearch.LostFocus += new System.Windows.RoutedEventHandler(this.tbSearch_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbRooms = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\..\..\xaml_window\Manager\StaticEquipment.xaml"
            this.cbRooms.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbRooms_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lvDataBindingStaticEq = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            
            #line 62 "..\..\..\..\xaml_window\Manager\StaticEquipment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Create);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 68 "..\..\..\..\xaml_window\Manager\StaticEquipment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Delete);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 74 "..\..\..\..\xaml_window\Manager\StaticEquipment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Update);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 80 "..\..\..\..\xaml_window\Manager\StaticEquipment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Relocation);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\xaml_window\Doctor\DoctorHome.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "483236424DD3C768208DDC313A6161C200A6F6F39AC81DAD98CD979D1086603B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// DoctorHome
    /// </summary>
    public partial class DoctorHome : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\..\xaml_window\Doctor\DoctorHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Doctor_username;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\xaml_window\Doctor\DoctorHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Doctor_spec;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\xaml_window\Doctor\DoctorHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDate;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\xaml_window\Doctor\DoctorHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvDataBinding;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/xaml_window/doctor/doctorhome.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\xaml_window\Doctor\DoctorHome.xaml"
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
            this.Doctor_username = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Doctor_spec = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            
            #line 55 "..\..\..\..\xaml_window\Doctor\DoctorHome.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ListViewItem_Selected_1);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 57 "..\..\..\..\xaml_window\Doctor\DoctorHome.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ListViewItem_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 58 "..\..\..\..\xaml_window\Doctor\DoctorHome.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ListViewItem_Selected_hospital);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 61 "..\..\..\..\xaml_window\Doctor\DoctorHome.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Doctor_Logout);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dpDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 76 "..\..\..\..\xaml_window\Doctor\DoctorHome.xaml"
            this.dpDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dpDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lvDataBinding = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            
            #line 113 "..\..\..\..\xaml_window\Doctor\DoctorHome.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Delete);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 114 "..\..\..\..\xaml_window\Doctor\DoctorHome.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Create);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 115 "..\..\..\..\xaml_window\Doctor\DoctorHome.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Patient);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 116 "..\..\..\..\xaml_window\Doctor\DoctorHome.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Update);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\xaml_window\Doctor\AnamnesisTherapyAdd.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "12AF8825443810AB8358DBEBD0A8B010CB5193EEB2217880674533C3D5925952"
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
    /// AnamnesisTherapyAdd
    /// </summary>
    public partial class AnamnesisTherapyAdd : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\xaml_window\Doctor\AnamnesisTherapyAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbDrugName;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\xaml_window\Doctor\AnamnesisTherapyAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDrugQuantity;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\xaml_window\Doctor\AnamnesisTherapyAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDescriptionPrescription;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\xaml_window\Doctor\AnamnesisTherapyAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker tbStartDate;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\xaml_window\Doctor\AnamnesisTherapyAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker tbEndDate;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\xaml_window\Doctor\AnamnesisTherapyAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbDrugAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/xaml_window/doctor/anamnesistherapyadd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\xaml_window\Doctor\AnamnesisTherapyAdd.xaml"
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
            this.lbDrugName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.tbDrugQuantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbDescriptionPrescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbStartDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.tbEndDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.cbDrugAdd = ((System.Windows.Controls.ComboBox)(target));
            
            #line 94 "..\..\..\..\xaml_window\Doctor\AnamnesisTherapyAdd.xaml"
            this.cbDrugAdd.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbDrugAdd_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 98 "..\..\..\..\xaml_window\Doctor\AnamnesisTherapyAdd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Cancel);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 99 "..\..\..\..\xaml_window\Doctor\AnamnesisTherapyAdd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Ok);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


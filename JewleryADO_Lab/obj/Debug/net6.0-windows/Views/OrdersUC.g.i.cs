﻿#pragma checksum "..\..\..\..\Views\OrdersUC.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2A3337D0EEE3F9D4BE1D0D8262A84F781CC01B66"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using JewleryADO_Lab.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace JewleryADO_Lab.Views {
    
    
    /// <summary>
    /// OrdersUC
    /// </summary>
    public partial class OrdersUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\Views\OrdersUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid OrdersDataGrid;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\OrdersUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TotalEFTextBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\OrdersUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InsertEFButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\OrdersUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DateTimeEFTextBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\OrdersUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateEFButton;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Views\OrdersUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteEFButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/JewleryADO_Lab;component/views/ordersuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\OrdersUC.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.OrdersDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.TotalEFTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.InsertEFButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Views\OrdersUC.xaml"
            this.InsertEFButton.Click += new System.Windows.RoutedEventHandler(this.InsertEFButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DateTimeEFTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.UpdateEFButton = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\Views\OrdersUC.xaml"
            this.UpdateEFButton.Click += new System.Windows.RoutedEventHandler(this.UpdateEFButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DeleteEFButton = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\Views\OrdersUC.xaml"
            this.DeleteEFButton.Click += new System.Windows.RoutedEventHandler(this.DeleteEFButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

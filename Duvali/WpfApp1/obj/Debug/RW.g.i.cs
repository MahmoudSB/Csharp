﻿#pragma checksum "..\..\RW.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "873E1F1232A58F9CC764F6644DF4A83E3AE4D298"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// RW
    /// </summary>
    public partial class RW : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\RW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Bool;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\RW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pb_toggle;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\RW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pb_mome;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\RW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Int;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\RW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Real;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\RW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox6;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/rw.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RW.xaml"
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
            this.TB_Bool = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\RW.xaml"
            this.TB_Bool.KeyDown += new System.Windows.Input.KeyEventHandler(this.tbBoolEnterHndeler);
            
            #line default
            #line hidden
            
            #line 17 "..\..\RW.xaml"
            this.TB_Bool.LostFocus += new System.Windows.RoutedEventHandler(this.tbBoolLeaveHndeler);
            
            #line default
            #line hidden
            return;
            case 2:
            this.pb_toggle = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\RW.xaml"
            this.pb_toggle.Click += new System.Windows.RoutedEventHandler(this.Button_Click_toggle);
            
            #line default
            #line hidden
            return;
            case 3:
            this.pb_mome = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\RW.xaml"
            this.pb_mome.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Button_MD_mome);
            
            #line default
            #line hidden
            
            #line 19 "..\..\RW.xaml"
            this.pb_mome.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Button_MU_mome);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TB_Int = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\RW.xaml"
            this.TB_Int.KeyDown += new System.Windows.Input.KeyEventHandler(this.EnterHandler);
            
            #line default
            #line hidden
            
            #line 26 "..\..\RW.xaml"
            this.TB_Int.LostFocus += new System.Windows.RoutedEventHandler(this.LeaveHandler);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TB_Real = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\RW.xaml"
            this.TB_Real.KeyDown += new System.Windows.Input.KeyEventHandler(this.tbRealEnterHndeler);
            
            #line default
            #line hidden
            
            #line 33 "..\..\RW.xaml"
            this.TB_Real.LostFocus += new System.Windows.RoutedEventHandler(this.tbRealLeaveHndeler);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 37 "..\..\RW.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Read);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 38 "..\..\RW.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Write);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textBox6 = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

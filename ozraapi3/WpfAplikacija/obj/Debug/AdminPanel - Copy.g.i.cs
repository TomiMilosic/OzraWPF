﻿#pragma checksum "..\..\AdminPanel - Copy.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3214F53BEEB63AA2ED4B57977B56DE103825FF373181CE12A6EAD4D25C45767D"
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
using WpfAplikacija;


namespace WpfAplikacija {
    
    
    /// <summary>
    /// AdminPanel
    /// </summary>
    public partial class AdminPanel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\AdminPanel - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView SeznamAdminov;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AdminPanel - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UporabniskoImetxb;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AdminPanel - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GesloTxb;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AdminPanel - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idtxb;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AdminPanel - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DodajAdminabtn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AdminPanel - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PosodobiAdminabtn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AdminPanel - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IzbrisiAdminabtn;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAplikacija;component/adminpanel%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminPanel - Copy.xaml"
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
            this.SeznamAdminov = ((System.Windows.Controls.ListView)(target));
            
            #line 10 "..\..\AdminPanel - Copy.xaml"
            this.SeznamAdminov.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListView_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UporabniskoImetxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.GesloTxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.idtxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DodajAdminabtn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\AdminPanel - Copy.xaml"
            this.DodajAdminabtn.Click += new System.Windows.RoutedEventHandler(this.DodajAdminabtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PosodobiAdminabtn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\AdminPanel - Copy.xaml"
            this.PosodobiAdminabtn.Click += new System.Windows.RoutedEventHandler(this.PosodobiAdminabtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.IzbrisiAdminabtn = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\AdminPanel - Copy.xaml"
            this.IzbrisiAdminabtn.Click += new System.Windows.RoutedEventHandler(this.IzbrisiAdminabtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

﻿#pragma checksum "..\..\EN_Dogodki.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A4A0C2ECB8B5C8083C2F46E784E4F32AD39929D069F9B34A4009B1D0780B1554"
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
    /// EN_Dogodki
    /// </summary>
    public partial class EN_Dogodki : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\EN_Dogodki.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView SeznamDogodtkov;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\EN_Dogodki.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IDdogodkatxb;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\EN_Dogodki.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nazivdogodkatxb;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\EN_Dogodki.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox casdogodkatxb;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\EN_Dogodki.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DodajDogodek;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\EN_Dogodki.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UrediDogodekBtn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\EN_Dogodki.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IzbrisiDogodekbtn;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAplikacija;component/en_dogodki.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EN_Dogodki.xaml"
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
            this.SeznamDogodtkov = ((System.Windows.Controls.ListView)(target));
            
            #line 10 "..\..\EN_Dogodki.xaml"
            this.SeznamDogodtkov.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.SeznamDogodtkov_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.IDdogodkatxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Nazivdogodkatxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.casdogodkatxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DodajDogodek = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\EN_Dogodki.xaml"
            this.DodajDogodek.Click += new System.Windows.RoutedEventHandler(this.DodajDogodek_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UrediDogodekBtn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\EN_Dogodki.xaml"
            this.UrediDogodekBtn.Click += new System.Windows.RoutedEventHandler(this.UrediDogodekBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.IzbrisiDogodekbtn = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\EN_Dogodki.xaml"
            this.IzbrisiDogodekbtn.Click += new System.Windows.RoutedEventHandler(this.IzbrisiDogodekbtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\EN_PrijavljenUporabnik.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EED84690121F1D476D60F41EED1D9C28990BB2FEB0F775CE10412824B44ABAC3"
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
    /// EN_PrijavljenUporabnik
    /// </summary>
    public partial class EN_PrijavljenUporabnik : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\EN_PrijavljenUporabnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewIgralcev;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\EN_PrijavljenUporabnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IskanjeTxb;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\EN_PrijavljenUporabnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PodrobnostiSportnika;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\EN_PrijavljenUporabnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DodajSportnika;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\EN_PrijavljenUporabnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AdminBtn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\EN_PrijavljenUporabnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Dogodkibtn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\EN_PrijavljenUporabnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DodavanjeSportnikaDogdka;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAplikacija;component/en_prijavljenuporabnik.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EN_PrijavljenUporabnik.xaml"
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
            this.ListViewIgralcev = ((System.Windows.Controls.ListView)(target));
            
            #line 14 "..\..\EN_PrijavljenUporabnik.xaml"
            this.ListViewIgralcev.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListViewIgralcev_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 14 "..\..\EN_PrijavljenUporabnik.xaml"
            this.ListViewIgralcev.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListViewIgralcev_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.IskanjeTxb = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\EN_PrijavljenUporabnik.xaml"
            this.IskanjeTxb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.IskanjeTxb_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PodrobnostiSportnika = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DodajSportnika = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\EN_PrijavljenUporabnik.xaml"
            this.DodajSportnika.Click += new System.Windows.RoutedEventHandler(this.DodajSportnika_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AdminBtn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\EN_PrijavljenUporabnik.xaml"
            this.AdminBtn.Click += new System.Windows.RoutedEventHandler(this.AdminBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Dogodkibtn = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\EN_PrijavljenUporabnik.xaml"
            this.Dogodkibtn.Click += new System.Windows.RoutedEventHandler(this.Dogodkibtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DodavanjeSportnikaDogdka = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\EN_PrijavljenUporabnik.xaml"
            this.DodavanjeSportnikaDogdka.Click += new System.Windows.RoutedEventHandler(this.DodavanjeSportnikaDogdka_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


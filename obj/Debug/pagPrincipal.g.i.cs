﻿#pragma checksum "..\..\pagPrincipal.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EF422017D809DD8A54109B2B8B6B635DCDE16B4094A74FDB47F2D1FA4C8A2C21"
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
using appEventos;


namespace appEventos {
    
    
    /// <summary>
    /// pagPrincipal
    /// </summary>
    public partial class pagPrincipal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\pagPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxTiempo;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\pagPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btPerfil;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\pagPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxCarrera;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\pagPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbTiempo;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\pagPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbCarrera;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\pagPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbEventos;
        
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
            System.Uri resourceLocater = new System.Uri("/appEventos;component/pagprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\pagPrincipal.xaml"
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
            this.cbxTiempo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\pagPrincipal.xaml"
            this.cbxTiempo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.eventoCBX_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btPerfil = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.cbxCarrera = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.lbTiempo = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lbCarrera = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lbEventos = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\Moduli\UpisNovePotrosnje.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "49317253FF79FB2F9327FB217C7A101D9BA1AF6518ECF1BBCA131AC660BFCE39"
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
using WPF_UI.Moduli;


namespace WPF_UI.Moduli {
    
    
    /// <summary>
    /// UpisNovePotrosnje
    /// </summary>
    public partial class UpisNovePotrosnje : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Moduli\UpisNovePotrosnje.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userId;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Moduli\UpisNovePotrosnje.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userName;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Moduli\UpisNovePotrosnje.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userAddress;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Moduli\UpisNovePotrosnje.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userCity;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Moduli\UpisNovePotrosnje.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox brojiloId;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Moduli\UpisNovePotrosnje.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox potrosenoKw;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Moduli\UpisNovePotrosnje.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox mesecPotrosnje;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Moduli\UpisNovePotrosnje.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button upisPotrosnjebtn;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF UI;component/moduli/upisnovepotrosnje.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Moduli\UpisNovePotrosnje.xaml"
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
            this.userId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.userName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.userAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.userCity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.brojiloId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.potrosenoKw = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.mesecPotrosnje = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.upisPotrosnjebtn = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\Moduli\UpisNovePotrosnje.xaml"
            this.upisPotrosnjebtn.Click += new System.Windows.RoutedEventHandler(this.upisPotrosnjebtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


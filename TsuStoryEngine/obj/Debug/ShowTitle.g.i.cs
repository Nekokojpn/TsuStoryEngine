﻿#pragma checksum "..\..\ShowTitle.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8EE5CAB061D21855607E5B6B0455811B6F758CF7"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
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
using TsuStoryEngine;


namespace TsuStoryEngine {
    
    
    /// <summary>
    /// ShowTitle
    /// </summary>
    public partial class ShowTitle : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\ShowTitle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid STG;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ShowTitle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement me;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ShowTitle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TL;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ShowTitle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SKIPb;
        
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
            System.Uri resourceLocater = new System.Uri("/TsuStoryEngine;component/showtitle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ShowTitle.xaml"
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
            this.STG = ((System.Windows.Controls.Grid)(target));
            
            #line 11 "..\..\ShowTitle.xaml"
            this.STG.Loaded += new System.Windows.RoutedEventHandler(this.STG_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\ShowTitle.xaml"
            ((System.Windows.Media.Animation.Storyboard)(target)).Completed += new System.EventHandler(this.Storyboard_Completed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.me = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 4:
            this.TL = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.SKIPb = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\ShowTitle.xaml"
            this.SKIPb.Click += new System.Windows.RoutedEventHandler(this.SKIPb_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


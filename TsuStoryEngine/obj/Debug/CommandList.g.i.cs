﻿#pragma checksum "..\..\CommandList.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D464B8F9981562E2C386EBA14BC4B2D968AE2E50"
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
    /// CommandList
    /// </summary>
    public partial class CommandList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\CommandList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\CommandList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button QS1;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\CommandList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button QS2;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\CommandList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FOB;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\CommandList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SM;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\CommandList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HM;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\CommandList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowTitle;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\CommandList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Loadfile;
        
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
            System.Uri resourceLocater = new System.Uri("/TsuStoryEngine;component/commandlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CommandList.xaml"
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
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.QS1 = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\CommandList.xaml"
            this.QS1.Click += new System.Windows.RoutedEventHandler(this.QS1_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.QS2 = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\CommandList.xaml"
            this.QS2.Click += new System.Windows.RoutedEventHandler(this.QS2_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FOB = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\CommandList.xaml"
            this.FOB.Click += new System.Windows.RoutedEventHandler(this.FOB_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SM = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\CommandList.xaml"
            this.SM.Click += new System.Windows.RoutedEventHandler(this.SM_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.HM = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\CommandList.xaml"
            this.HM.Click += new System.Windows.RoutedEventHandler(this.HM_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ShowTitle = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\CommandList.xaml"
            this.ShowTitle.Click += new System.Windows.RoutedEventHandler(this.ShowTitle_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Loadfile = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\CommandList.xaml"
            this.Loadfile.Click += new System.Windows.RoutedEventHandler(this.Loadfile_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


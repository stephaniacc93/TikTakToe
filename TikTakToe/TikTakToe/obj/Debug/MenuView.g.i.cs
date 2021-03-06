﻿#pragma checksum "..\..\MenuView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B9EA83B22769FFB9753D7921894E683C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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


namespace TikTakToe {
    
    
    /// <summary>
    /// MenuView
    /// </summary>
    public partial class MenuView : MahApps.Metro.Controls.MetroContentControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\MenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Easy;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Med;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Hard;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\MenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Expert;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\MenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlayButton;
        
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
            System.Uri resourceLocater = new System.Uri("/TikTakToe;component/menuview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuView.xaml"
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
            this.Easy = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\MenuView.xaml"
            this.Easy.Click += new System.Windows.RoutedEventHandler(this.Difficulty_OnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Med = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\MenuView.xaml"
            this.Med.Click += new System.Windows.RoutedEventHandler(this.Difficulty_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Hard = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\MenuView.xaml"
            this.Hard.Click += new System.Windows.RoutedEventHandler(this.Difficulty_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Expert = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\MenuView.xaml"
            this.Expert.Click += new System.Windows.RoutedEventHandler(this.Difficulty_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PlayButton = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\MenuView.xaml"
            this.PlayButton.Click += new System.Windows.RoutedEventHandler(this.PlayButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


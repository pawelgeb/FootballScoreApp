﻿#pragma checksum "..\..\..\ScoreWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6930EC5A69E60B2C2AAB253A68D21798E95347A6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FootballScoreWPF;
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


namespace FootballScoreWPF {
    
    
    /// <summary>
    /// ScoreWindow
    /// </summary>
    public partial class ScoreWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\ScoreWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HomeName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\ScoreWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Score;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\ScoreWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AwayName;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\ScoreWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StadiumName;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FootballScoreWPF;component/scorewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ScoreWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.HomeName = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\ScoreWindow.xaml"
            this.HomeName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged_HomeTeam);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\ScoreWindow.xaml"
            this.HomeName.ContextMenuClosing += new System.Windows.Controls.ContextMenuEventHandler(this.HomeTeamName);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Score = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\ScoreWindow.xaml"
            this.Score.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged_Score);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AwayName = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\ScoreWindow.xaml"
            this.AwayName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged_AwayTeam);
            
            #line default
            #line hidden
            return;
            case 4:
            this.StadiumName = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\ScoreWindow.xaml"
            this.StadiumName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged_StadiumName);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 19 "..\..\..\ScoreWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ScorePublish);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

#pragma checksum "..\..\..\FlagManipulation.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B45BF7370FD8E26C2E7ABA2BDF3D857C12C5E7E4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CountryBallProject;
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


namespace CountryBallProject {
    
    
    /// <summary>
    /// FlagManipulation
    /// </summary>
    public partial class FlagManipulation : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\FlagManipulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FlagMoverLeft;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\FlagManipulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FlagMoverRight;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\FlagManipulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FlagMoverUp;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\FlagManipulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FlagMoverDown;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\FlagManipulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FlagReset;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\FlagManipulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FlagIncreaseWidth;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\FlagManipulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FlagDecreaseWidth;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\FlagManipulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FlagIncreaseHeight;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\FlagManipulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FlagDecreaseHeight;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\FlagManipulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FlagExpandSize;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\FlagManipulation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FlagCompressSize;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CountryBallProject;component/flagmanipulation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FlagManipulation.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FlagMoverLeft = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\FlagManipulation.xaml"
            this.FlagMoverLeft.Click += new System.Windows.RoutedEventHandler(this.FlagMoverLeft_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FlagMoverRight = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\FlagManipulation.xaml"
            this.FlagMoverRight.Click += new System.Windows.RoutedEventHandler(this.FlagMoverRight_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FlagMoverUp = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\FlagManipulation.xaml"
            this.FlagMoverUp.Click += new System.Windows.RoutedEventHandler(this.FlagMoverUp_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FlagMoverDown = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\FlagManipulation.xaml"
            this.FlagMoverDown.Click += new System.Windows.RoutedEventHandler(this.FlagMoverDown_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FlagReset = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\FlagManipulation.xaml"
            this.FlagReset.Click += new System.Windows.RoutedEventHandler(this.FlagReset_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FlagIncreaseWidth = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\FlagManipulation.xaml"
            this.FlagIncreaseWidth.Click += new System.Windows.RoutedEventHandler(this.FlagIncreaseWidth_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FlagDecreaseWidth = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\FlagManipulation.xaml"
            this.FlagDecreaseWidth.Click += new System.Windows.RoutedEventHandler(this.FlagDecreaseWidth_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.FlagIncreaseHeight = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\..\FlagManipulation.xaml"
            this.FlagIncreaseHeight.Click += new System.Windows.RoutedEventHandler(this.FlagIncreaseHeight_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.FlagDecreaseHeight = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\FlagManipulation.xaml"
            this.FlagDecreaseHeight.Click += new System.Windows.RoutedEventHandler(this.FlagDecreaseHeight_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.FlagExpandSize = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\FlagManipulation.xaml"
            this.FlagExpandSize.Click += new System.Windows.RoutedEventHandler(this.FlagExpandSize_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.FlagCompressSize = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\..\FlagManipulation.xaml"
            this.FlagCompressSize.Click += new System.Windows.RoutedEventHandler(this.FlagCompressSize_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


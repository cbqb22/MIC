﻿#pragma checksum "..\..\..\..\..\Controls\Animations\Indicator\SimpleIndicatorEx.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5411B251347CDDADD2CDB7CEDF32321F"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

using MIC.Wpf.Common.Actions;
using MIC.Wpf.Common.Triggers;
using MIC.Wpf.Controls.Animations.Indicator;
using Microsoft.Expression.Controls;
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
using System.Windows.Interactivity;
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


namespace MIC.Wpf.Controls.Animations.Indicator {
    
    
    /// <summary>
    /// SimpleIndicatorEx
    /// </summary>
    public partial class SimpleIndicatorEx : MIC.Wpf.Controls.Animations.Indicator.SimpleIndicator, System.Windows.Markup.IComponentConnector {
        
        
        #line 84 "..\..\..\..\..\Controls\Animations\Indicator\SimpleIndicatorEx.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\..\Controls\Animations\Indicator\SimpleIndicatorEx.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Expression.Controls.PathListBox pathListBox;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\..\..\Controls\Animations\Indicator\SimpleIndicatorEx.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse ellipse;
        
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
            System.Uri resourceLocater = new System.Uri("/MIC.Wpf;component/controls/animations/indicator/simpleindicatorex.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Controls\Animations\Indicator\SimpleIndicatorEx.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.pathListBox = ((Microsoft.Expression.Controls.PathListBox)(target));
            return;
            case 3:
            this.ellipse = ((System.Windows.Shapes.Ellipse)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


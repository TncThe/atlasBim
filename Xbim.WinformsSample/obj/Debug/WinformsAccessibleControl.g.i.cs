﻿#pragma checksum "..\..\WinformsAccessibleControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "578E543A5BB2D0B0BBD4F846CEE99E602076BCDEDB5E243676B85CCDBE9243CA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
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
using System.Windows.Forms.Integration;
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
using Xbim.Presentation;


namespace Xbim.WinformsSample {
    
    
    /// <summary>
    /// WinformsAccessibleControl
    /// </summary>
    public partial class WinformsAccessibleControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\WinformsAccessibleControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xbim.WinformsSample.WinformsAccessibleControl MainWindow;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\WinformsAccessibleControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainFrame;
        
        #line default
        #line hidden
        
        /// <summary>
        /// DrawingControl Name Field
        /// </summary>
        
        #line 9 "..\..\WinformsAccessibleControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public Xbim.Presentation.DrawingControl3D DrawingControl;
        
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
            System.Uri resourceLocater = new System.Uri("/Xbim.WinformsSample;component/winformsaccessiblecontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WinformsAccessibleControl.xaml"
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
            this.MainWindow = ((Xbim.WinformsSample.WinformsAccessibleControl)(target));
            return;
            case 2:
            this.MainFrame = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.DrawingControl = ((Xbim.Presentation.DrawingControl3D)(target));
            
            #line 15 "..\..\WinformsAccessibleControl.xaml"
            this.DrawingControl.SelectedEntityChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DrawingControl_SelectedEntityChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


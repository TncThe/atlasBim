﻿#pragma checksum "..\..\..\UI\BCFFileUI.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "64318C3B09C7CAFE27A6FA407FC79CF79B66F33DDA3E94DA3E09CF7938505082"
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
using Xbim.BCF.UI;


namespace Xbim.BCF.UI {
    
    
    /// <summary>
    /// BcfFileUi
    /// </summary>
    public partial class BcfFileUi : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\UI\BCFFileUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView T;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\UI\BCFFileUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xbim.BCF.UI.BcfInstanceUi SelInstance;
        
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
            System.Uri resourceLocater = new System.Uri("/XplorerPlugin.Bcf;component/ui/bcffileui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\BCFFileUI.xaml"
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
            this.T = ((System.Windows.Controls.ListView)(target));
            
            #line 16 "..\..\..\UI\BCFFileUI.xaml"
            this.T.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.t_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\UI\BCFFileUI.xaml"
            this.T.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.CameraEvent);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SelInstance = ((Xbim.BCF.UI.BcfInstanceUi)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

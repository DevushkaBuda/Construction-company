﻿#pragma checksum "..\..\..\..\Pages\ServicePages\AddServicePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CB2509D5D0384589EAFC542EB0FEF68E612BDB355495480051CDD29571912D8D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ConstructionCompany.Pages.ServicePages;
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


namespace ConstructionCompany.Pages.ServicePages {
    
    
    /// <summary>
    /// AddServicePage
    /// </summary>
    public partial class AddServicePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\Pages\ServicePages\AddServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Pages\ServicePages\AddServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UnitBox;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Pages\ServicePages\AddServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CostBox;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\Pages\ServicePages\AddServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ServislFinish;
        
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
            System.Uri resourceLocater = new System.Uri("/ConstructionCompany;component/pages/servicepages/addservicepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\ServicePages\AddServicePage.xaml"
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
            this.NameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\..\Pages\ServicePages\AddServicePage.xaml"
            this.NameBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.IsDigitIsLetter_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 43 "..\..\..\..\Pages\ServicePages\AddServicePage.xaml"
            this.NameBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.QuantityBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UnitBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 59 "..\..\..\..\Pages\ServicePages\AddServicePage.xaml"
            this.UnitBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.IsLetterAndPoint_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 60 "..\..\..\..\Pages\ServicePages\AddServicePage.xaml"
            this.UnitBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.QuantityBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CostBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\..\..\Pages\ServicePages\AddServicePage.xaml"
            this.CostBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.IsDigit_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 77 "..\..\..\..\Pages\ServicePages\AddServicePage.xaml"
            this.CostBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.QuantityBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ServislFinish = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\..\Pages\ServicePages\AddServicePage.xaml"
            this.ServislFinish.Click += new System.Windows.RoutedEventHandler(this.ServislFinish_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

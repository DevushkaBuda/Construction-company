﻿#pragma checksum "..\..\..\..\Pages\ServicePages\ServicePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5069567B468EF27153537647B59B2CC4AA4C9605DE9C2D899367C39E2C01B27E"
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
    /// ServicePage
    /// </summary>
    public partial class ServicePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Pages\ServicePages\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchName;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\ServicePages\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Searchbut;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Pages\ServicePages\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchClear;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Pages\ServicePages\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView View;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Pages\ServicePages\ServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
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
            System.Uri resourceLocater = new System.Uri("/ConstructionCompany;component/pages/servicepages/servicepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\ServicePages\ServicePage.xaml"
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
            
            #line 8 "..\..\..\..\Pages\ServicePages\ServicePage.xaml"
            ((ConstructionCompany.Pages.ServicePages.ServicePage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Searchbut = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Pages\ServicePages\ServicePage.xaml"
            this.Searchbut.Click += new System.Windows.RoutedEventHandler(this.Searchbut_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SearchClear = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\Pages\ServicePages\ServicePage.xaml"
            this.SearchClear.Click += new System.Windows.RoutedEventHandler(this.SearchClear_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.View = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.Delete = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\..\Pages\ServicePages\ServicePage.xaml"
            this.Delete.Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


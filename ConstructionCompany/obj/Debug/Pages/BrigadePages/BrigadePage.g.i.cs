﻿#pragma checksum "..\..\..\..\Pages\BrigadePages\BrigadePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8A4E189D15C27DF1B5D026ED28B02B514585C48AFCD84B2CA2B97CDB932E8EE5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ConstructionCompany.Pages.BrigadePages;
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


namespace ConstructionCompany.Pages.BrigadePages {
    
    
    /// <summary>
    /// BrigadePage
    /// </summary>
    public partial class BrigadePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Pages\BrigadePages\BrigadePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchName;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Pages\BrigadePages\BrigadePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBrig;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Pages\BrigadePages\BrigadePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Searchbut;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Pages\BrigadePages\BrigadePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchClear;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Pages\BrigadePages\BrigadePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView View;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Pages\BrigadePages\BrigadePage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ConstructionCompany;component/pages/brigadepages/brigadepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\BrigadePages\BrigadePage.xaml"
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
            
            #line 8 "..\..\..\..\Pages\BrigadePages\BrigadePage.xaml"
            ((ConstructionCompany.Pages.BrigadePages.BrigadePage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.SearchBrig = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Searchbut = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\Pages\BrigadePages\BrigadePage.xaml"
            this.Searchbut.Click += new System.Windows.RoutedEventHandler(this.Searchbut_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SearchClear = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\Pages\BrigadePages\BrigadePage.xaml"
            this.SearchClear.Click += new System.Windows.RoutedEventHandler(this.SearchClear_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.View = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.Delete = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\Pages\BrigadePages\BrigadePage.xaml"
            this.Delete.Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\EmployeeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18217BEAED3578242124631B3E70C43AA973849D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace WpfApp2 {
    
    
    /// <summary>
    /// EmployeeWindow
    /// </summary>
    public partial class EmployeeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SeasonComboBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ShoesRadioButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton BootsRadioButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SandalsRadioButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AssortmentComboBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl FootwearItemsControl;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FeedbackTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FeedbackMessageTextBox;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image FeedbackImage;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox OrderStatusListBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/employeewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EmployeeWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SeasonComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.ShoesRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.BootsRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.SandalsRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.AssortmentComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            
            #line 35 "..\..\..\EmployeeWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OrderButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 36 "..\..\..\EmployeeWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.peopleButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.FootwearItemsControl = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 9:
            this.FeedbackTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.FeedbackMessageTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 81 "..\..\..\EmployeeWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SendFeedbackButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.FeedbackImage = ((System.Windows.Controls.Image)(target));
            return;
            case 13:
            
            #line 83 "..\..\..\EmployeeWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UploadImageButton_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.OrderStatusListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 15:
            
            #line 98 "..\..\..\EmployeeWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateOrderStatusButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BB42724899F93B00CA69DA8BF8946AD1E38DB9924F09AB884FBC52B813EC6600"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DecrypterWPF;
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


namespace DecrypterWPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 345 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UploadButton;
        
        #line default
        #line hidden
        
        
        #line 352 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        
        #line 381 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ROT0;
        
        #line default
        #line hidden
        
        
        #line 382 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ROT1;
        
        #line default
        #line hidden
        
        
        #line 383 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxRegister;
        
        #line default
        #line hidden
        
        
        #line 384 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StatusRegisterTextBox;
        
        #line default
        #line hidden
        
        
        #line 387 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputTextBox;
        
        #line default
        #line hidden
        
        
        #line 404 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KeywordTextBox;
        
        #line default
        #line hidden
        
        
        #line 407 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Encode;
        
        #line default
        #line hidden
        
        
        #line 408 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Decode;
        
        #line default
        #line hidden
        
        
        #line 426 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConvertButton;
        
        #line default
        #line hidden
        
        
        #line 436 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OutputTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/DecrypterWPF;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.UploadButton = ((System.Windows.Controls.Button)(target));
            
            #line 345 "..\..\MainWindow.xaml"
            this.UploadButton.Click += new System.Windows.RoutedEventHandler(this.UploadButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 352 "..\..\MainWindow.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 370 "..\..\MainWindow.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestNavigate);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ROT0 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 381 "..\..\MainWindow.xaml"
            this.ROT0.Click += new System.Windows.RoutedEventHandler(this.ROT0_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ROT1 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 382 "..\..\MainWindow.xaml"
            this.ROT1.Click += new System.Windows.RoutedEventHandler(this.ROT1_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CheckBoxRegister = ((System.Windows.Controls.CheckBox)(target));
            
            #line 383 "..\..\MainWindow.xaml"
            this.CheckBoxRegister.Click += new System.Windows.RoutedEventHandler(this.CheckBoxRegister_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.StatusRegisterTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.InputTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 387 "..\..\MainWindow.xaml"
            this.InputTextBox.AddHandler(System.Windows.Controls.Primitives.ScrollBar.ScrollEvent, new System.Windows.Controls.Primitives.ScrollEventHandler(this.TextBox_Scroll));
            
            #line default
            #line hidden
            return;
            case 9:
            this.KeywordTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.Encode = ((System.Windows.Controls.RadioButton)(target));
            
            #line 407 "..\..\MainWindow.xaml"
            this.Encode.Click += new System.Windows.RoutedEventHandler(this.Encode_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Decode = ((System.Windows.Controls.RadioButton)(target));
            
            #line 408 "..\..\MainWindow.xaml"
            this.Decode.Click += new System.Windows.RoutedEventHandler(this.Decode_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 414 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.ConvertButton = ((System.Windows.Controls.Button)(target));
            
            #line 426 "..\..\MainWindow.xaml"
            this.ConvertButton.Click += new System.Windows.RoutedEventHandler(this.ConvertButton_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.OutputTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 436 "..\..\MainWindow.xaml"
            this.OutputTextBox.AddHandler(System.Windows.Controls.Primitives.ScrollBar.ScrollEvent, new System.Windows.Controls.Primitives.ScrollEventHandler(this.TextBox_Scroll));
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


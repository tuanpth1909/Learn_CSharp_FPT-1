﻿#pragma checksum "C:\Users\Hieu_iceTea\source\repos\U20.2\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0FF9E4F6DAD9CF1759109A097BD711FC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace U20._2
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 57
                {
                    this.MyComboBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // MainPage.xaml line 100
                {
                    this.MyToggleButton = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.MyToggleButton).Click += this.MyToggleButton_Click;
                }
                break;
            case 4: // MainPage.xaml line 104
                {
                    this.ToggleButtonResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // MainPage.xaml line 75
                {
                    this.MyListBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.MyListBox).SelectionChanged += this.ListBox_SelectionChanged;
                }
                break;
            case 6: // MainPage.xaml line 82
                {
                    this.ListBoxResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // MainPage.xaml line 65
                {
                    global::Windows.UI.Xaml.Controls.ComboBox element7 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)element7).SelectionChanged += this.ComboBox_SelectionChanged;
                }
                break;
            case 8: // MainPage.xaml line 70
                {
                    this.COmboBoxResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // MainPage.xaml line 46
                {
                    this.YesRadioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.YesRadioButton).Checked += this.RadioButton_Checked;
                }
                break;
            case 10: // MainPage.xaml line 50
                {
                    this.NoRadioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.NoRadioButton).Checked += this.RadioButton_Checked;
                }
                break;
            case 11: // MainPage.xaml line 54
                {
                    this.RadioButtonTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // MainPage.xaml line 33
                {
                    this.MyCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.MyCheckBox).Tapped += this.MyCheckBox_Tapped;
                }
                break;
            case 13: // MainPage.xaml line 36
                {
                    this.CheckBoxResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


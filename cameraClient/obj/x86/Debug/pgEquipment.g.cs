﻿#pragma checksum "C:\Users\caman\Documents\Visual Studio 2017\Projects\camerashop\cameraClient\pgEquipment.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B2BE833F0C5909596D7C0FBBB6A6E827"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cameraClient
{
    partial class pgEquipment : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // pgEquipment.xaml line 11
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // pgEquipment.xaml line 12
                {
                    this.tbBrand = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // pgEquipment.xaml line 13
                {
                    this.tbEquipmentInStock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // pgEquipment.xaml line 14
                {
                    this.lstquipment = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.lstquipment).DoubleTapped += this.Lstquipment_DoubleTapped;
                }
                break;
            case 6: // pgEquipment.xaml line 15
                {
                    this.rbPrice = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 7: // pgEquipment.xaml line 16
                {
                    this.tbBrandName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // pgEquipment.xaml line 17
                {
                    this.btnBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnBack).Click += this.btnBack_Click;
                }
                break;
            case 9: // pgEquipment.xaml line 18
                {
                    this.rbName1 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 10: // pgEquipment.xaml line 19
                {
                    this.tbSortBy = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // pgEquipment.xaml line 20
                {
                    this.tbMessages = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // pgEquipment.xaml line 21
                {
                    this.btnOrder = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnOrder).Click += this.BtnSelect_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


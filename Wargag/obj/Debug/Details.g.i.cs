﻿#pragma checksum "D:\work\projects\Wargag_new\Wargag\Wargag\Details.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2BE2B4663F9DD67F2EF0244FD4109897"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34014
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Wargag {
    
    
    public partial class Details : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button btnRating;
        
        internal System.Windows.Controls.TextBlock txtNickName;
        
        internal System.Windows.Controls.TextBlock txtTimeCreated;
        
        internal System.Windows.Documents.Run txtDescription;
        
        internal Microsoft.Phone.Controls.LongListSelector listSelector;
        
        internal System.Windows.Controls.Primitives.Popup sort;
        
        internal System.Windows.Controls.Button all_content;
        
        internal System.Windows.Controls.Button images;
        
        internal System.Windows.Controls.Button quotes;
        
        internal System.Windows.Controls.Button video;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Wargag;component/Details.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.btnRating = ((System.Windows.Controls.Button)(this.FindName("btnRating")));
            this.txtNickName = ((System.Windows.Controls.TextBlock)(this.FindName("txtNickName")));
            this.txtTimeCreated = ((System.Windows.Controls.TextBlock)(this.FindName("txtTimeCreated")));
            this.txtDescription = ((System.Windows.Documents.Run)(this.FindName("txtDescription")));
            this.listSelector = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("listSelector")));
            this.sort = ((System.Windows.Controls.Primitives.Popup)(this.FindName("sort")));
            this.all_content = ((System.Windows.Controls.Button)(this.FindName("all_content")));
            this.images = ((System.Windows.Controls.Button)(this.FindName("images")));
            this.quotes = ((System.Windows.Controls.Button)(this.FindName("quotes")));
            this.video = ((System.Windows.Controls.Button)(this.FindName("video")));
        }
    }
}

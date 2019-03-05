﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Xml.Linq;
using Microsoft.VisualStudio.Imaging;
using Microsoft.VisualStudio.Imaging.Interop;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using RapidXamlToolkit.Resources;
using RapidXamlToolkit.VisualStudioIntegration;
using RapidXamlToolkit.XamlAnalysis.Tags;

namespace RapidXamlToolkit.XamlAnalysis.Actions
{
    public class TextBoxPlaceholderAction : HardCodedStringAction
    {
        private TextBoxPlaceholderAction(string file, ITextView textView)
            : base(file, textView, Elements.TextBox, Attributes.PlaceholderText)
        {
        }

        public static TextBoxPlaceholderAction Create(HardCodedStringTag tag, string file, ITextView view)
        {
            var result = new TextBoxPlaceholderAction(file, view)
            {
                Tag = tag,
            };

            return result;
        }
    }
}
﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.


/* 项目“iNKORE.UI.WPF.Modern (net452)”的未合并的更改
在此之前:
using System.Windows;
在此之后:
using iNKORE.UI.WPF.Modern.Controls.IconElement;
using iNKORE.UI.WPF.Modern.Controls.IconElement.IconElement;
using System.Windows;
*/
using System.Windows;
using System.Windows.Media;
using iNKORE.UI.WPF.Modern.Controls;


namespace iNKORE.UI.WPF.Modern.Common
{
    /// <summary>
    /// Represents the base class for an icon source.
    /// </summary>
    public class IconSource : DependencyObject
    {
        /// <summary>
        /// Identifies the <see cref="Foreground"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.Register(
                nameof(Foreground),
                typeof(Brush),
                typeof(IconSource));

        /// <summary>
        /// Gets or sets a brush that describes the foreground color.
        /// </summary>
        /// <returns>
        /// The brush that paints the foreground of the control. The default is <see langword="null"/>, (a null brush) which is
        /// evaluated as Transparent for rendering.
        /// </returns>
        public Brush Foreground
        {
            get => (Brush)GetValue(ForegroundProperty);
            set => SetValue(ForegroundProperty, value);
        }

        /// <summary>
        /// Creates an icon UI element.
        /// </summary>
        /// <returns>An icon UI element.</returns>
        public IconElement CreateIconElement()
        {
            var element = CreateIconElementCore();
            return element;
        }

        /// <summary>
        /// Creates an icon UI element.
        /// </summary>
        /// <returns>An icon UI element.</returns>
        public virtual IconElement CreateIconElementCore() => null;
    }
}
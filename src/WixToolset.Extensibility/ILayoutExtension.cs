// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Extensibility
{
    /// <summary>
    /// Interface all layout extensions implement.
    /// </summary>
    public interface ILayoutExtension
    {
        /// <summary>
        /// Called before layout occurs.
        /// </summary>
        void PreLayout(ILayoutContext context);

        /// <summary>
        /// Called after all layout occurs.
        /// </summary>
        void PostLayout();
    }
}
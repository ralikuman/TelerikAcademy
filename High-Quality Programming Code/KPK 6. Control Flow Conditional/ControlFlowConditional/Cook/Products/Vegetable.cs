// <copyright file="Vegetable.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>

namespace ChefKitchen.Products
{
    using System;
    using System.Linq;

    /// <summary>
    /// Vegetable`s characteristics and actions.
    /// </summary>
    public class Vegetable
    {
        // Exercise 2 part 1
        
        /// <summary>
        /// Gets a value indicating whether the vegetable has been peeled.
        /// </summary>
        public bool HasNotBeenPeeled { get; private set; }
        
        /// <summary>
        /// Gets a value indicating whether the vegetable is rotten.
        /// </summary>
        public bool IsRotten { get; private set; }
    }
}

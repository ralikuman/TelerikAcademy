// <copyright file="Size.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>

namespace RefactorWithProperName
{
    using System;
    using System.Linq;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                this.height = value;
            }
        }
    }
}

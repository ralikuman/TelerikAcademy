// <copyright file="Chef.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>

namespace ChefKitchen
{
    using System;
    using System.Linq;
    using ChefKitchen.Products;
    using ChefKitchen.Tableware;

    /// <summary>
    /// Class Cook implement methods to prepare a meal.
    /// </summary>
    public class Chef
    {
        /// <summary>
        /// Method which call all methods which are necessary to cook.
        /// </summary>
        public void Cook()
        {
            Bowl bowl;
            bowl = this.GetBowl();

            Potato potato = this.GetPotato();
            
            // Exercise 2 part 1
            if (potato != null)
            {
                if (!(potato.HasNotBeenPeeled && potato.IsRotten))
                {
                    this.Peel(potato);
                    this.Cut(potato);
                    bowl.AddVegetable(potato);
                }
            }

            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);
            bowl.AddVegetable(carrot);
        }

        /// <summary>
        /// Create new Bowl.
        /// </summary>
        /// <returns>Return new bowl.</returns>
        private Bowl GetBowl()
        {
            Bowl bowl = new Bowl();
            return bowl;
        }

        /// <summary>
        /// Create new potato.
        /// </summary>
        /// <returns>Return new potato.</returns>
        private Potato GetPotato()
        {
            Potato potato = new Potato();
            return potato;
        }
        
        /// <summary>
        /// Get new carrot.
        /// </summary>
        /// <returns>Return new carrot.</returns>
        private Carrot GetCarrot()
        {
            Carrot carrot = new Carrot();
            return carrot;
        }

        /// <summary>
        /// Peel vegetable.
        /// </summary>
        /// <param name="vegetable">Vegetable which will be peel.</param>
        private void Peel(Vegetable vegetable)
        {
            // TODO: peel vetetable
        }

        /// <summary>
        /// Cut vegetable.
        /// </summary>
        /// <param name="vegetable">Vegetable which will be cut.</param>
        private void Cut(Vegetable vegetable)
        {
            // TODO: cut vetetable
        }
    }
}
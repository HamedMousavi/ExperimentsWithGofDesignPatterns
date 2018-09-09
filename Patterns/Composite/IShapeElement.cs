// -----------------------------------------------------------------------
// <copyright file="IShapeElement.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Patterns.Composite
{
    using System;
    using System.Collections.Generic;
    
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface IShapeElement : IEnumerable<IShapeElement>
    {
        /// <summary>
        /// Adds a child to the composite element
        /// </summary>
        /// <param name="child"></param>
        void Add(IShapeElement child);

        /// <summary>
        /// Removes a child from a composite element
        /// </summary>
        /// <param name="child"></param>
        void Remove(IShapeElement child);


        IShapeElement GetElement(int index);


        void Draw();

        string Name { get; set; }
    }
}

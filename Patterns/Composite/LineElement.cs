// -----------------------------------------------------------------------
// <copyright file="LineElement.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Patterns.Composite
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class LineElement : IShapeElement
    {
        public LineElement(string name)
        {
            Name = name;
        }

        public void Add(IShapeElement child)
        {
            throw new InvalidOperationException("A line doesn't have any children.");
        }

        public void Remove(IShapeElement child)
        {
            throw new InvalidOperationException("A line doesn't have any children.");
        }


        public IShapeElement GetElement(int index)
        {
            throw new InvalidOperationException("A line doesn't have any children.");
        }

        public IEnumerator<IShapeElement> GetEnumerator()
        {
            throw new InvalidOperationException("A line doesn't have any children.");
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new InvalidOperationException("A line doesn't have any children.");
        }


        public void Draw()
        {
            System.Diagnostics.Debug.WriteLine($"{Name}: Drawing...");
        }


        public string Name { get; set; }
    }
}

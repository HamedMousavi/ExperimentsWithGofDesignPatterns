// -----------------------------------------------------------------------
// <copyright file="Canvas.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Patterns.Composite
{
    using System.Collections.Generic;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Canvas : IShapeElement
    {
        private readonly List<IShapeElement> _items;

        public Canvas(string name)
        {
            Name = name;
            _items = new List<IShapeElement>();
        }
        
        public void Add(IShapeElement child)
        {
            _items.Add(child);
        }

        public void Remove(IShapeElement child)
        {
            _items.Remove(child);
        }


        public IShapeElement GetElement(int index)
        {
            return _items[index];
        }

        public IEnumerator<IShapeElement> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }


        public void Draw()
        {
            System.Diagnostics.Debug.WriteLine($"{Name}: Drawing...");
            foreach (var shape in this)
            {
                shape.Draw();
            }
            System.Diagnostics.Debug.WriteLine($"{Name}: Done.");
        }


        public string Name { get; set; }
    }
}

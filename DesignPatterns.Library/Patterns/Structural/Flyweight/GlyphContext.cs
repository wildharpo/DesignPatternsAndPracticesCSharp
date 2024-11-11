using System.Drawing;

namespace DesignPatterns.Library.Patterns.Structural.Flyweight
{
    public class GlyphContext
    {
        private int _index;
        private SortedSet<Tuple<int, Font>> _bTree;
        private List<Font> _fontCollection;

        public GlyphContext()
        {
            _bTree = new SortedSet<Tuple<int, Font>>();
        }

        public void Next(int step = 1) 
        {
            _index += step;
        }
        
        public void Insert(int quantity = 1) 
        {
            var updatedBinaryTree = new SortedSet<Tuple<int, Font>>();
            var runningCharacterCount = 0;

            for (var i = 0; i < _bTree.Count(); ++i)
            {
                runningCharacterCount += _bTree.ElementAt(i).Item1;
                if (runningCharacterCount <= _index)
                    continue;
                else
                {
                    var originalNode = _bTree.ElementAt(i);
                    var updatedNode = new Tuple<int, Font>(originalNode.Item1 + quantity, originalNode.Item2);
                }
            }

            _bTree = updatedBinaryTree;
        }

        public Font GetFont() 
        {
            var runningCharacterCount = 0;

            for (var i = 0; i < _bTree.Count(); ++i)
            {
                runningCharacterCount += _bTree.ElementAt(i).Item1;
                if (runningCharacterCount <= _index)
                    continue;
                else
                    return _bTree.ElementAt(i).Item2;
            }

            throw new Exception("Font not found for current index");
        }
        
        public void SetFont(Font font, int span = 1)
        {
            _bTree.Add(new Tuple<int, Font>(span, font));
        }
    }
}

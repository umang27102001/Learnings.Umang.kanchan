

namespace Indexers
{
    public class Indexers
    {
        public Rectangle[] Rect=new Rectangle[4];
        public Rectangle this[int index] 
        {
            get => Rect[index];
            set => Rect[index] = value;
        }
    }
}



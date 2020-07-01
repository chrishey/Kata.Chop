using System.Linq;

namespace Kata.Chop
{
    public class Chop
    {
        public int Find(int intToFind, int[] array)
        {
            var position = array.ToList().FindIndex(x=> x == intToFind);

            return position;
        }
    }
}

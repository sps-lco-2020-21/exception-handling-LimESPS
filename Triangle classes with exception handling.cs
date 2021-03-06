using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry1.lib
{
    
    public class Triangle
        
    {
        int _sideA; //member variables
        int _sideB;
        int _sideC;
        public Triangle(int a, int b, int c)
        {
            _sideA = a;
            _sideB = b;
            _sideC = c;
        }
        public Triangle(int e) : this(e, e, e)
        {

        }
        public bool IsRightAngled()
        {
            return (_sideA * _sideA + _sideB * _sideB == _sideC * _sideC);
        }
        public int perimeter()
        {
            return _sideA + _sideB + _sideC;
        }
        public void TriangleException(int a)
        {
            throw new ArgumentException($"Triangle is invalid, {a} is larger than sum of the 2 other sides");
        }
        public void IsValid()
        {
            List<int> lengths = new List<int> { _sideA, _sideB, _sideC };
            foreach(int item in lengths)
            {
                if (item > lengths.Sum() - item)
                {
                    TriangleException(item);
                }
            }
        }
    }
}

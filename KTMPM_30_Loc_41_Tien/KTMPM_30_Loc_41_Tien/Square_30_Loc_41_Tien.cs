using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KTMPM_30_Loc_41_Tien;


namespace KTMPM_30_Loc_41_Tien
{
   public class Square_30_Loc_41_Tien
    {
        public double SideLength { get; private set; }

        public Square_30_Loc_41_Tien(double sideLength)
        {
            if (sideLength <= 0)
                throw new ArgumentException("Độ dài cạnh phải lớn hơn 0");
            SideLength = sideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength;
        }

        public double GetPerimeter()
        {
            return 4 * SideLength;
        }

        public bool IsValidSquare()
        {
            return SideLength > 0;
        }

        public void Scale(double factor)
        {
            if (factor <= 0)
                throw new ArgumentException("Hệ số phải lớn hơn 0");
            SideLength *= factor;
        }
    }
}

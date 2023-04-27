using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformC
{
    public class transformationC
    {
        public static void pictureFinal(byte[] pictureNew, int[] toChange, int size, int x)
        {
            int k, j;
            for (int i = 0; i < size; i += 2)
            {
                k = toChange[i] * 3 - 3;
                j = toChange[i + 1];
                pictureNew[k + j * x * 3] = (byte)((pictureNew[k - 3 + j * x * 3] + pictureNew[k + 3 + j * x * 3]) / 2);
                pictureNew[k + 1 + j * x * 3] = (byte)((pictureNew[k - 2 + j * x * 3] + pictureNew[k + 4 + j * x * 3]) / 2);
                pictureNew[k + 2 + j * x * 3] = (byte)((pictureNew[k - 1 + j * x * 3] + pictureNew[k + 5 + j * x * 3]) / 2);
            }
        }
    }
}

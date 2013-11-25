using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ChooseAndCopy
{
    class OtherResources
    {
        public static void Write(Stream from, Stream to)
        {
            for (int a = from.ReadByte(); a != -1; a = from.ReadByte())
                to.WriteByte((byte)a);
        }
    }
}

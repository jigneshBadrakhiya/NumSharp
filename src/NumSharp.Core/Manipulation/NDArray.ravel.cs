﻿using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace NumSharp
{
    public partial class NDArray
    {
        public NDArray ravel()
        {
            return reshape(Storage.Shape.Size);
        }
    }
}

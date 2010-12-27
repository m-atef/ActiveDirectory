﻿using System;
using System.DirectoryServices;

namespace Landpy.ActiveDirectory.Entity.Attribute
{
    public class ByteAttribute : BaseAttribute<byte[]>
    {
        public ByteAttribute(ResultPropertyValueCollection resultPropertyValueCollection)
            : base(resultPropertyValueCollection)
        {
            if (resultPropertyValueCollection != null &&
                resultPropertyValueCollection.Count > 0 &&
                resultPropertyValueCollection[0] != null)
            {
                this.value = (byte[])resultPropertyValueCollection[0];
            }
        }
    }
}
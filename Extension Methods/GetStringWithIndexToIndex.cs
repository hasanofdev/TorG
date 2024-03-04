using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorG.Extension_Methods;

internal static class GetStringWithIndexToIndexEx
{
    public static string GetStringWithIndexToIndex(this string @this)
    {

        string newstr="";

        if(@this == null) throw new ArgumentNullException(nameof(@this));
        else if(@this.Length == 0) throw new ArgumentException(nameof(@this));

        for (int i = 0; i < @this.Length; i++)
        {
            if (i == 95)
                return newstr;
            else
                newstr += @this[i];
        }

        return newstr;
    }
}
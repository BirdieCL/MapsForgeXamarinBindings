using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Object = Java.Lang.Object;

namespace Org.Mapsforge.Core.Model
{
    public partial class Tag : Java.Lang.IComparable
    {
        public int CompareTo(Object another)
        {
            return this.CompareTo(another as Tag);
        }
    }

    public partial class Point : Java.Lang.IComparable
    {
        public int CompareTo(Object another)
        {
            return this.CompareTo(another as Point);
        }
    }

    public partial class LatLong : Java.Lang.IComparable
    {
        public int CompareTo(Object another)
        {
            return this.CompareTo(another as LatLong);
        }
    }
}
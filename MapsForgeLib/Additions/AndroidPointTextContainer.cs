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
using Org.Mapsforge.Core.Mapelements;
using Object = Java.Lang.Object;

namespace Org.Mapsforge.Map.Android.Graphics
{
    public partial class AndroidPointTextContainer
    {
        public override int CompareTo(Object another)
        {
            return this.CompareTo(another as MapElementContainer);
        }
    }
}
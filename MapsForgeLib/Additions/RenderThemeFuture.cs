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
using Java.Util.Concurrent;

namespace Org.Mapsforge.Map.Rendertheme.Rule
{
    public partial class RenderThemeFuture
    {
        public partial class RenderThemeCallable : global::Java.Lang.Object, global::Java.Util.Concurrent.ICallable
        {
            Java.Lang.Object ICallable.Call()
            {
                return this.Call();
            }
        }
    }
}
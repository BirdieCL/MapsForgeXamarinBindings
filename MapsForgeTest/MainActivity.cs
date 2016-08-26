using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.IO;
using Org.Mapsforge.Core.Model;
using Org.Mapsforge.Map.Android.Graphics;
using Org.Mapsforge.Map.Android.Util;
using Org.Mapsforge.Map.Android.View;
using Org.Mapsforge.Map.Datastore;
using Org.Mapsforge.Map.Layer.Cache;
using Org.Mapsforge.Map.Layer.Renderer;
using Org.Mapsforge.Map.Reader;
using Org.Mapsforge.Map.Rendertheme;

namespace MapsForgeTest
{
    [Activity(Label = "MapsForgeTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private MapView mapView;
        private ITileCache tileCache;
        private TileRendererLayer tileRendererLayer;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView(Resource.Layout.Main);

            AndroidGraphicFactory.CreateInstance(Application);

            this.mapView = new MapView(this);
            SetContentView(this.mapView);

            this.mapView.Clickable = true;
            this.mapView.MapScaleBar.Visible = true;
            this.mapView.SetBuiltInZoomControls(true);
            this.mapView.SetZoomLevelMin(10);
            this.mapView.SetZoomLevelMax(20);
            this.tileCache = AndroidUtil.CreateTileCache(this, "mapcache", mapView.Model.DisplayModel.TileSize, 1f, this.mapView.Model.FrameBufferModel.OverdrawFactor);

            MapDataStore mapDataStore = new MapFile(new File(Android.OS.Environment.ExternalStorageDirectory, "chile.map"));
            this.tileRendererLayer = new TileRendererLayer(tileCache, mapDataStore, this.mapView.Model.MapViewPosition, AndroidGraphicFactory.Instance);
            tileRendererLayer.SetXmlRenderTheme(InternalRenderTheme.Osmarender);

            this.mapView.LayerManager.Layers.Add(tileRendererLayer);

            mapView.SetCenter(new LatLong(-33.44, -70.68));
            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.MyButton);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }

        protected override void OnDestroy()
        {
            mapView.DestroyAll();
            AndroidGraphicFactory.ClearResourceMemoryCache();
            base.OnDestroy();
        }
    }
}


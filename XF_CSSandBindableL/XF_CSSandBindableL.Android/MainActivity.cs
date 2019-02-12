using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XF_CSSandBindableL.Droid
{
    [Activity(Label = "XF_CSSandBindableL", 
        Icon = "@mipmap/icon", 
        Theme = "@style/MainTheme", 
        MainLauncher = false, 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            // DEBUG GORILLA PLAYER EN ANDROID
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            var forceXamlOnlyTypeLoading = new[]
            {
                typeof(ImageCircle.Forms.Plugin.Abstractions.CircleImage),
            };
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            // LOTTIE FORMS Init() PARA Android
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //AnimationViewRenderer.Init();
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            LoadApplication(new App());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.StyleSheets;
using Xamarin.Forms.Xaml;

namespace XF_CSSandBindableL.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BlogPage : ContentPage
    {
        public BlogPage()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == true)
            {
                this.Resources.Add(StyleSheet.FromAssemblyResource(
                     IntrospectionExtensions.GetTypeInfo(typeof(BlogPage)).Assembly,
                     "XF_CSSandBindableL.Styles.CustomThemeStyle.css"));
            }
            else
            {
                this.Resources.Add(StyleSheet.FromAssemblyResource(
                     IntrospectionExtensions.GetTypeInfo(typeof(BlogPage)).Assembly,
                     "XF_CSSandBindableL.Styles.ClassicThemeStyle.css"));
            }
        }
    }
}
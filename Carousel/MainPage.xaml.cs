using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Carousel
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            Button btn;
            InitializeComponent();
            var NarutoPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Наруто Узумаки",
                            FontSize = Device.GetNamedSize ( NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "narutoo.jpg"
                        },

                        new Label
                        {
                            Text = "Клан: Узумаки" + " Мать: Узумаки Кушина" + " Отец: Намиказе Минато" + "Супер техника: Finger Jitsu/Тысячелетие боли",
                            FontSize = Device.GetNamedSize ( NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Button
                        {
                             Text = "Тест: Кто ты из Наруто?",
                             BackgroundColor = Color.Green
                        }

                    }
                }
            };
            /*Uri uri = new Uri("https://2x2tv.ru/blog/which-naruto/");
            await Browser.OpenAsync(uri);*/
            var SasukePage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Саске Учиха",
                            FontSize = Device.GetNamedSize ( NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "sasuke.webp"
                        }

                    }
                }
            };
            var SakuraPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Сакура Харуно",
                            FontSize = Device.GetNamedSize ( NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "Sakura.jpg"
                        }
                    }
                }
            };
            var KakashiPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Какаши Хатаке",
                            FontSize = Device.GetNamedSize ( NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "Kakashi.jpg"
                        }
                    }
                }
            };
            btn = new Button
            {

            };


            Children.Add(NarutoPage);
            Children.Add(SasukePage);
            Children.Add(SakuraPage);
            Children.Add(KakashiPage);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Carousel
{
    public partial class MainPage : CarouselPage
    {

        public MainPage()
        {
            Button btn1 = new Button
            {
                Text = "Тест: Кто ты из Наруто?",
                BackgroundColor = Color.Green
            };
            btn1.Clicked += Btn1_Clicked;
            Button btn2 = new Button
            {
                Text = "Тест: Кто ты из Наруто?",
                BackgroundColor = Color.Green
            };
            btn2.Clicked += Btn2_Clicked;
            Button btn3 = new Button
            {
                Text = "Тест: Кто ты из Наруто?",
                BackgroundColor = Color.Green
            };
            btn3.Clicked += Btn3_Clicked;
            Button btn4 = new Button
            {
                Text = "Тест: Кто ты из Наруто?",
                BackgroundColor = Color.Green
            };
            btn4.Clicked += Btn4_Clicked;

            //InitializeComponent();
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
                            Text = "Шиноби Деревни Скрытого Листа. Главный персонаж вселенной. В день своего рождения он стал хранить в себе Девятихвостого Демона-Лиса — судьба, из-за которой он стал изгоем для большей части людей в Конохе на протяжении всего своего детства.",
                            FontSize = Device.GetNamedSize ( NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        btn1
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
                        },
                        new Label
                        {
                            Text = "Один из последних выживших членов клана Учиха из Деревни Скрытого Листа. После того, как его старший брат Итачи вырезал весь их клан, Саске поставил перед собой жизненную цель отомстить за клан и семью, убив Итачи.",
                            FontSize = Device.GetNamedSize ( NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        btn2
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
                        },
                        new Label
                        {
                            Text = "Просто Девушка и все, слишком много информации про неё не будет, извиняюсь.",
                            FontSize = Device.GetNamedSize ( NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        btn3
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
                        },
                        new Label
                        {
                            Text = "Прикольный мужик с красным глазом, учитель Наруто, Саске и Сакуры. Человек года по NG. Никто не видел его рот.",
                            FontSize = Device.GetNamedSize ( NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        btn4
                    }
                }
            };
            Children.Add(NarutoPage);
            Children.Add(SasukePage);
            Children.Add(SakuraPage);
            Children.Add(KakashiPage);
        }

        private async void Btn4_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://2x2tv.ru/blog/which-naruto/");
            await Browser.OpenAsync(uri);
        }

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://2x2tv.ru/blog/which-naruto/");
            await Browser.OpenAsync(uri);
        }

        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://2x2tv.ru/blog/which-naruto/");
            await Browser.OpenAsync(uri);
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://2x2tv.ru/blog/which-naruto/");
            await Browser.OpenAsync(uri);
        }
    }
}

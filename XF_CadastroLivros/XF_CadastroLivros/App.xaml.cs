﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XF_CadastroLivros.Model;

namespace XF_CadastroLivros
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();

            MainPage = new NavigationPage(new View.Livro.PaginaInicial());

        }

        static Livro livroModel;

        public static Livro LivroModel
        {

            get
            {

                if (livroModel == null)
                {

                    livroModel = new Livro();

                }

                return livroModel;

            }

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

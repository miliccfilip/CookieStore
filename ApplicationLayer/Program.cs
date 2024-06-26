﻿using BusinessLayer;
using DataLayer;
using Microsoft.Extensions.DependencyInjection;
using PresentationLayer;
using Shared.BusinessInterface;
using Shared.DataInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ApplicationLayer
{




    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var login = serviceProvider.GetRequiredService<Login>();
                Application.Run(login);
            }

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<IArticleBusiness, ArticleBusiness>();
            services.AddScoped<IBillRepository, BillRepository>();
            services.AddScoped<IBillBusiness, BillBusiness>();
            services.AddScoped<IBillItemRepository, BillItemRepository>();
            services.AddScoped<IBillItemBusiness, BillItemBusiness>();
            services.AddScoped<IStuffRepository, StuffRepository>();
            services.AddScoped<IStuffBusiness, StuffBusiness>();
            services.AddScoped<Login>();
        }


    }


}
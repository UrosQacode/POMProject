﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static OrangeProject.Driver.WebDrivers;

namespace OrangeProject.Driver
{

        public static class WebDrivers
        {
            public static IWebDriver? Instance { get; set; }


            public static void Initialize()
            {
                Instance = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                Instance.Manage().Window.Maximize();
                Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
                Instance.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            }


            public static void CleanUp()
            {
                Instance?.Quit();
            }

        }
    }



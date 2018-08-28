﻿using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{        
    static IWebDriver driver = new ChromeDriver("/Users/matthewrizzini/Desktop/Visual Studio C# Projects/SeleniumC#/SettingUpEnvironment/bin/Debug/netcoreapp2.0");
    static IWebElement radioButton;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/radio-button-test/";
        string[] option = {"1", "3", "5"};

        driver.Navigate().GoToUrl(url);

        for (var i = 0; i < option.Length; i++)
        {
            radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=\"radio\"]:nth-child(" + option[i] + ""));

            if (radioButton.GetAttribute("checked") == "true")
            {
                System.Console.WriteLine("The " + (i + 1) + " radio button is checked");
            }
            else
            {
                System.Console.WriteLine("This is one of the unchecked radio buttons");
            }
        }





        driver.Quit();
    }


}

﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Drivers;

public class BrowserDriver : IDisposable
{
    private readonly Lazy<IWebDriver> _currentWebDriverLazy;
    private bool _isDisposed;

    public BrowserDriver()
    {
        _currentWebDriverLazy = new Lazy<IWebDriver>(CreateWebDriver);
    }

    public IWebDriver Current => _currentWebDriverLazy.Value;

    private IWebDriver CreateWebDriver()
    {
        var chromeDriverService = ChromeDriverService.CreateDefaultService();

        var chromeOptions = new ChromeOptions();

        var chromeDriver = new ChromeDriver(chromeDriverService, chromeOptions);

        chromeDriver.Navigate().GoToUrl("https://www.saucedemo.com/");

        Thread.Sleep(3000);

        return chromeDriver;
    }

    public void Dispose()
    {
        if (_isDisposed)
        {
            return;
        }

        if (_currentWebDriverLazy.IsValueCreated)
        {
            Current.Quit();
        }

        _isDisposed = true;
    }
}
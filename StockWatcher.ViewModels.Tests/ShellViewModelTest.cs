// <copyright file="ShellViewModelTest.cs">Copyright ©  2021</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;
using StockWatcher.Services.Interfaces;
using StockWatcher.ViewModels.ViewModels;

namespace StockWatcher.ViewModels.ViewModels.Tests
{
    /// <summary>This class contains parameterized unit tests for ShellViewModel</summary>
    [PexClass(typeof(ShellViewModel))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestFixture]
    public partial class ShellViewModelTest
    {
        /// <summary>Test stub for .ctor(IAuthenticationService, INavigationService, ILogService, IThemeService)</summary>
        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public ShellViewModel ConstructorTest(
            IAuthenticationService authenticationService,
            INavigationService navigationService,
            ILogService logService,
            IThemeService themeService
        )
        {
            ShellViewModel target = new ShellViewModel
                                        (authenticationService, navigationService, logService, themeService);
            return target;
            // TODO: add assertions to method ShellViewModelTest.ConstructorTest(IAuthenticationService, INavigationService, ILogService, IThemeService)
        }

        /// <summary>Test stub for get_IsDarkThemeEnabled()</summary>
        [PexMethod]
        public bool IsDarkThemeEnabledGetTest([PexAssumeUnderTest]ShellViewModel target)
        {
            bool result = target.IsDarkThemeEnabled;
            return result;
            // TODO: add assertions to method ShellViewModelTest.IsDarkThemeEnabledGetTest(ShellViewModel)
        }

        /// <summary>Test stub for set_IsDarkThemeEnabled(Boolean)</summary>
        [PexMethod]
        public void IsDarkThemeEnabledSetTest([PexAssumeUnderTest]ShellViewModel target, bool value)
        {
            target.IsDarkThemeEnabled = value;
            // TODO: add assertions to method ShellViewModelTest.IsDarkThemeEnabledSetTest(ShellViewModel, Boolean)
        }

        /// <summary>Test stub for get_IsLightThemeEnabled()</summary>
        [PexMethod]
        public bool IsLightThemeEnabledGetTest([PexAssumeUnderTest]ShellViewModel target)
        {
            bool result = target.IsLightThemeEnabled;
            return result;
            // TODO: add assertions to method ShellViewModelTest.IsLightThemeEnabledGetTest(ShellViewModel)
        }

        /// <summary>Test stub for set_IsLightThemeEnabled(Boolean)</summary>
        [PexMethod]
        public void IsLightThemeEnabledSetTest([PexAssumeUnderTest]ShellViewModel target, bool value)
        {
            target.IsLightThemeEnabled = value;
            // TODO: add assertions to method ShellViewModelTest.IsLightThemeEnabledSetTest(ShellViewModel, Boolean)
        }

        /// <summary>Test stub for get_IsLoggedIn()</summary>
        [PexMethod]
        public bool IsLoggedInGetTest([PexAssumeUnderTest]ShellViewModel target)
        {
            bool result = target.IsLoggedIn;
            return result;
            // TODO: add assertions to method ShellViewModelTest.IsLoggedInGetTest(ShellViewModel)
        }

        /// <summary>Test stub for set_IsLoggedIn(Boolean)</summary>
        [PexMethod]
        public void IsLoggedInSetTest([PexAssumeUnderTest]ShellViewModel target, bool value)
        {
            target.IsLoggedIn = value;
            // TODO: add assertions to method ShellViewModelTest.IsLoggedInSetTest(ShellViewModel, Boolean)
        }

        /// <summary>Test stub for get_Title()</summary>
        [PexMethod]
        public string TitleGetTest([PexAssumeUnderTest]ShellViewModel target)
        {
            string result = target.Title;
            return result;
            // TODO: add assertions to method ShellViewModelTest.TitleGetTest(ShellViewModel)
        }

        /// <summary>Test stub for set_Title(String)</summary>
        [PexMethod]
        public void TitleSetTest([PexAssumeUnderTest]ShellViewModel target, string value)
        {
            target.Title = value;
            // TODO: add assertions to method ShellViewModelTest.TitleSetTest(ShellViewModel, String)
        }
    }
}

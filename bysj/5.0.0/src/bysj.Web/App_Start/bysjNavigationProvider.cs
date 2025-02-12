﻿using Abp.Application.Navigation;
using Abp.Localization;
using bysj.Authorization;

namespace bysj.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class bysjNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", bysjConsts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-home",
                        requiresAuthentication: true
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Tenants",
                        L("Tenants"),
                        url: "#tenants",
                        icon: "fa fa-globe",
                        requiredPermissionName: PermissionNames.Pages_Tenants
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Users",
                        L("Users"),
                        url: "#users",
                        icon: "fa fa-users",
                        requiredPermissionName: PermissionNames.Pages_Users
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Roles",
                        L("Roles"),
                        url: "#users",
                        icon: "fa fa-tag",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Approval",
                        L("Approval"),
                        url: "#users",
                        icon: "fa fa-tag",
                        requiresAuthentication:true
                    )
                )
                 .AddItem(
                    new MenuItemDefinition(
                        "Suggest",
                        L("Suggest"),
                        url: "#users",
                        icon: "fa fa-tag",
                        requiresAuthentication: true
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Register",
                        L("Register"),
                        url: "#users",
                        icon: "fa fa-tag",
                        requiresAuthentication: true
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Files",
                        L("Files"),
                        url: "#users",
                        icon: "fa fa-tag",
                        requiresAuthentication: true
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Report",
                        L("Report"),
                        url: "#users",
                        icon: "fa fa-tag",
                        requiresAuthentication: true
                    )
                )
                 .AddItem(
                    new MenuItemDefinition(
                        "Class",
                        L("Class"), 
                        url: "#users",
                        icon: "fa fa-tag",
                        requiresAuthentication: true
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", bysjConsts.LocalizationSourceName),
                        url: "#/about",
                        icon: "fa fa-info"
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, bysjConsts.LocalizationSourceName);
        }
    }
}

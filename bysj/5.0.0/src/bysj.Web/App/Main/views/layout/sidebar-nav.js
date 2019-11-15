(function () {
    var controllerId = 'app.views.layout.sidebarNav';
    angular.module('app').controller(controllerId, [
        '$rootScope', '$state', 'appSession',
        function ($rootScope, $state, appSession) {
            var vm = this;

            vm.menuItems = [
                createMenuItem(App.localize("HomePage"), "", "home", "home"),
                createMenuItem(App.localize("用户管理"), "Pages.Users", "person", "users"),
                createMenuItem(App.localize("角色管理"), "Pages.Roles", "local_offer", "roles"),
                createMenuItem(App.localize("课程类型管理"), "Pages.Tenants", "business", "tenants"),
                createMenuItem(App.localize("班级管理"), "", "people", "class"),
                createMenuItem(App.localize("课程资料"), "", "present_to_all", "files"),
                createMenuItem(App.localize("培训报名"), "", "flag", "register"),
                createMenuItem(App.localize("报名审批"), "", "info", "approval"),
                createMenuItem(App.localize("建议反馈"), "", "message", "suggest")

                //createMenuItem(App.localize("MultiLevelMenu"), "", "menu", "", [
                //    createMenuItem("ASP.NET Boilerplate", "", "", "", [
                //        createMenuItem("Home", "", "", "https://aspnetboilerplate.com/?ref=abptmpl"),
                //        createMenuItem("Templates", "", "", "https://aspnetboilerplate.com/Templates?ref=abptmpl"),
                //        createMenuItem("Samples", "", "", "https://aspnetboilerplate.com/Samples?ref=abptmpl"),
                //        createMenuItem("Documents", "", "", "https://aspnetboilerplate.com/Pages/Documents?ref=abptmpl")
                //    ]),
                //    createMenuItem("ASP.NET Zero", "", "", "", [
                //        createMenuItem("Home", "", "", "https://aspnetzero.com?ref=abptmpl"),
                //        createMenuItem("Description", "", "", "https://aspnetzero.com/?ref=abptmpl#description"),
                //        createMenuItem("Features", "", "", "https://aspnetzero.com/?ref=abptmpl#features"),
                //        createMenuItem("Pricing", "", "", "https://aspnetzero.com/?ref=abptmpl#pricing"),
                //        createMenuItem("Faq", "", "", "https://aspnetzero.com/Faq?ref=abptmpl"),
                //        createMenuItem("Documents", "", "", "https://aspnetzero.com/Documents?ref=abptmpl")
                //    ])
                //])
            ];

            vm.showMenuItem = function (menuItem) {
                if (menuItem.permissionName) {
                    return abp.auth.isGranted(menuItem.permissionName);
                }

                return true;
            }

            function createMenuItem(name, permissionName, icon, route, childItems) {
                return {
                    name: name,
                    permissionName: permissionName,
                    icon: icon,
                    route: route,
                    items: childItems
                };
            }
        }
    ]);
})();
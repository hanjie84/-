﻿var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('bysj');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);
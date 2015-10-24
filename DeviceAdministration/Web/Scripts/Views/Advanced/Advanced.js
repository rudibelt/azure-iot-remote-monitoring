IoTApp.createModule('IoTApp.Advanced', function () {
    "use strict";

    var backButtonId;
    var contentId;
    var subheadId;

    var init = function init(config) {
        backButtonId = config.backButtonId;
        contentId = config.contentId;
        subheadId = config.subheadId;

        $(backButtonId).hide();
    }

    var initSubView = function initSubView(config) {
        $(subheadId).text(config.subheadContent);
        if (config.goBackUrl) {
            $(backButtonId).show();
            $(backButtonId).off('click').click(function () {
                $(contentId).load(config.goBackUrl);
            });
        } else {
            $(backButtonId).hide();
        }
    };

    var redirecToPartial = function redirecToPartial(partialUrl) {
        $(contentId).load(partialUrl);
    }

    return {
        init : init,
        initSubView: initSubView,
        redirecToPartial: redirecToPartial
    };
}, [jQuery]);
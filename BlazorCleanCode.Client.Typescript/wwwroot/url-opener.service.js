"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.UrlOpenerService = void 0;
var UrlOpenerService = /** @class */ (function () {
    function UrlOpenerService() {
    }
    UrlOpenerService.prototype.openExternalLink = function (url) {
        window.open(url, '_blank');
    };
    UrlOpenerService.load = function () {
        window['UrlOpenerService'] = new UrlOpenerService();
    };
    return UrlOpenerService;
}());
exports.UrlOpenerService = UrlOpenerService;
UrlOpenerService.load();
//# sourceMappingURL=url-opener.service.js.map
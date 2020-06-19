"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const url_opener_service_1 = require("../../BlazorCleanCode.Client.Typescript/wwwroot/url-opener.service");
describe('UrlOpenerService', () => {
    describe('@openExternalLink', () => {
        it('should open a new window with the given link', () => {
            const url = 'https://bracketshow.com';
            spyOn(window, 'open');
            const service = new url_opener_service_1.UrlOpenerService();
            service.openExternalLink(url);
            expect(window.open).toHaveBeenCalledWith(url, '_blank');
        });
    });
    describe('@load', () => {
        it('should add the service in the window', () => {
            //spyOn(window, 'Object').and.callThrough();
            url_opener_service_1.UrlOpenerService.load();
            expect(window['UrlOpenerService']).toBeInstanceOf(url_opener_service_1.UrlOpenerService);
            //expect(window['UrlOpenerService']).toHaveBeenCalled();
        });
    });
});
//# sourceMappingURL=url-opener.spec.js.map
import { UrlOpenerService } from '../../BlazorCleanCode.Client.Typescript/wwwroot/url-opener.service';

describe('UrlOpenerService', () => {
    describe('@openExternalLink', () => {
        it('should open a new window with the given link', () => {
            const url = 'https://bracketshow.com';
            spyOn(window, 'open');
            const service = new UrlOpenerService();

            service.openExternalLink(url);

            expect(window.open).toHaveBeenCalledWith(url, '_blank');
        });
    });

    describe('@load', () => {
        it('should add the service in the window', () => {
            UrlOpenerService.load();

            expect(window['UrlOpenerService']).toBeInstanceOf(UrlOpenerService);
        });
    });
});


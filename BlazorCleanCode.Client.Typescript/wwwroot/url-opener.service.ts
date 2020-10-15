

export class UrlOpenerService {
    openExternalLink(url: string): void {
        window.open(url, "_blank");
    }

    static load(): void {
        window['UrlOpenerService'] =
            new UrlOpenerService();
    }
}

UrlOpenerService.load();

function onClick(event, args) {
    var customerWindow = window,
        browser = customerWindow.navigator.appCodeName,
        isMozillaFirefox = (browser === "Mozilla");

    if (isMozillaFirefox) {
        alert("Yes");
    } else {
        alert("No");
    }
}
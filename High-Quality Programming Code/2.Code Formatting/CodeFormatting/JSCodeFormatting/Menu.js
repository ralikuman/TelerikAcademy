/**
 * 1. Use http://jsbeautifier.org/ for first formatting
 * 2. Google JavaScript Style Guide
 * a) Comment Syntax: The JSDoc syntax is based on JavaDoc
 * b) Line Length: 
 * Each line of text in your code should be at most 80 characters long
 * Change macimal character in JS Hint to 80
 * c) JS Hint: ecal is evil 
 * d) JS Hint: ['ToolTip'] is better written in dot notation.
 * Replace with: document.layers.ToolTip.visibility == 'show'
 * e) For consistency single-quotes (') are preferred to double-quotes (")
 */

(function () {
    'use strict';

    var browserName = navigator.appName,
        addScroll = false,
        pointX = 0,
        pointY = 0,
        theLayer;

    if ((navigator.userAgent.indexOf('MSIE 5') > 0) ||
            (navigator.userAgent.indexOf('MSIE 6')) > 0) {
        addScroll = true;
    }



    if (browserName === 'Netscape') {
        document.captureEvents(Event.MOUSEMOVE);
    }

    function mouseMove(evn) {
        if (browserName == 'Netscape') {
            pointX = evn.pageX - 5;
            pointY = evn.pageY;
        } else {
            pointX = event.x - 5;
            pointY = event.y;
        }

        if (browserName === 'Netscape') {
            if (document.layers.ToolTip.visibility === 'show') {
                popTip();
            }
        } else {
            if (document.all.ToolTip.style.visibility === 'visible') {
                popTip();
            }
        }
    }

    document.onmousemove = mouseMove();

    function popTip() {
        if (browserName === 'Netscape') {
            theLayer = document.layers.ToolTip;
            if ((pointX + 120) > window.innerWidth) {
                pointX = window.innerWidth - 150;
            }
            theLayer.left = pointX + 10;
            theLayer.top = pointY + 15;
            theLayer.visibility = 'show';
        } else {
            theLayer = document.all.ToolTip;
            if (theLayer) {
                pointX = event.x - 5;
                pointY = event.y;
                if (addScroll) {
                    pointX = pointX + document.body.scrollLeft;
                    pointY = pointY + document.body.scrollTop;
                }
                if ((pointX + 120) > document.body.clientWidth) {
                    pointX = pointX - 150;
                }
                theLayer.style.pixelLeft = pointX + 10;
                theLayer.style.pixelTop = pointY + 15;
                theLayer.style.visibility = 'visible';
            }
        }
    }

    function HideTip() {
        if (browserName === 'Netscape') {
            document.layers.ToolTip.visibility = 'hide';
        } else {
            document.all.ToolTip.style.visibility = 'hidden';
        }
    }

    function HideMenu1() {
        if (browserName === 'Netscape') {
            document.layers.menu1.visibility = 'hide';
        } else {
            document.all.menu1.style.visibility = 'hidden';
        }
    }

    function ShowMenu1() {
        if (browserName === 'Netscape') {
            theLayer = document.layers.menu1;
            theLayer.visibility = 'show';
        } else {
            theLayer = document.all.menu1;
            theLayer.style.visibility = 'visible';
        }
    }

    function HideMenu2() {
        if (browserName == 'Netscape') {
            document.layers.menu2.visibility = 'hide';
        } else {
            document.all.menu2.style.visibility = 'hidden';
        }
    }

    function ShowMenu2() {
        if (browserName == 'Netscape') {
            theLayer = document.layers.menu2;
            theLayer.visibility = 'show';
        } else {
            theLayer = document.all.menu2;
            theLayer.style.visibility = 'visible';
        }
    }
})();
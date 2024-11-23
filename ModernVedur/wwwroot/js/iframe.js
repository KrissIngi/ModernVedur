var VI;
if (VI == undefined) {
    VI = {};
}
VI.ifrm = {};
VI.ifrm.host = "https://www.vedur.is";
VI.ifrm.dispWStations = function (_1) {
    var w = 600;
    var h = 0;
    var a = "";
    var _2 = (VI.ifrm.lang) ? VI.ifrm.lang : "is";
    switch (VI.ifrm.area) {
        case 101:
            h = 630;
            a = "island";
            break;
        case 111:
            h = 646;
            a = "ho";
            break;
        case 1:
            h = 680;
            a = "fa";
            break;
        case 2:
            h = 600;
            a = "br";
            break;
        case 3:
            h = 620;
            a = "ve";
            break;
        case 4:
            h = 640;
            a = "nv";
            break;
        case 5:
            h = 640;
            a = "na";
            break;
        case 6:
            h = 790;
            a = "ag";
            break;
        case 7:
            h = 740;
            a = "af";
            break;
        case 8:
            h = 590;
            a = "sa";
            break;
        case 9:
            h = 640;
            a = "su";
            break;
        case 10:
            h = 640;
            a = "mi";
            break;
        case 1301:
            h = 580;
            a = "djup";
            break;
        default:
            VI.ifrm.write("<p>Unknown area while displaying weather stations</p>");
            return;
    }
    var _3 = VI.ifrm.host + "/ifr/w?area=" + a + "&lang=" + _2 + "&type=";
    switch (_1) {
        case "wst":
            _3 += "stwin_forec";
            break;
        case "wst-txt":
            _3 += "stwin_txt";
            break;
        case "wst-obs":
            _3 += "stwin_obs";
            break;
    }
    VI.ifrm.write("<iframe src=\"" + _3 + "\" width=\"" + w + "px\" height=\"" + h + "px\" id=\"vi_ifrm\" name=\"vi_ifrm\" scrolling=\"no\" frameborder=\"no\" marginwidth=\"0\" marginheight=\"0\"></iframe>");
};
VI.ifrm.dispWElements = function (_4) {
    var w = 600;
    var h = 0;
    var a = "";
    var _5 = (VI.ifrm.lang) ? VI.ifrm.lang : "is";
    switch (VI.ifrm.area) {
        case 101:
            h = 635;
            a = "island";
            break;
        case 111:
            h = 675;
            a = "ho";
            break;
        case 1:
            h = 650;
            a = "fa";
            break;
        case 2:
            h = 685;
            a = "br";
            break;
        case 3:
            h = 685;
            a = "ve";
            break;
        case 4:
            h = 750;
            a = "nv";
            break;
        case 5:
            h = 685;
            a = "na";
            break;
        case 6:
            h = 800;
            a = "ag";
            break;
        case 7:
            h = 800;
            a = "af";
            break;
        case 8:
            h = 615;
            a = "sa";
            break;
        case 9:
            h = 650;
            a = "su";
            break;
        case 10:
            h = 630;
            a = "mi";
            break;
        default:
            VI.ifrm.write("<p>Unknown area while displaying weather elements</p>");
            return;
    }
    var _6 = VI.ifrm.host + "/ifr/m?type=forec-grp&area=" + a + "&lang=" + _5;
    VI.ifrm.write("<iframe src=\"" + _6 + "\" width=\"" + w + "px\" height=\"" + h + "px\" id=\"vi_ifrm\" name=\"vi_ifrm\" scrolling=\"no\" frameborder=\"no\" marginwidth=\"0\" marginheight=\"0\"></iframe>");
};
VI.ifrm.displayWeather = function () {
    switch (VI.ifrm.type) {
        case "wst":
        case "wst-txt":
        case "wst-obs":
            VI.ifrm.dispWStations(VI.ifrm.type);
            break;
        case "wel":
            VI.ifrm.dispWElements(VI.ifrm.type);
            break;
        default:
            VI.ifrm.write("<p>Unknown weather type</p>");
    }
};
VI.ifrm.write = function (_7) {
    document.write(_7);
};


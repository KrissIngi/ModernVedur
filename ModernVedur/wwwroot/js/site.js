// Custom JS code for Weather page.
// Function used to show the map when clicking 'Sýna kort' used with transition for better UI experience.
function showMap() {
    var mapDiv = document.getElementById('MapColumn');
    mapDiv.classList.add('show');
    document.getElementById('ShowButton').style.display = 'none';
    document.getElementById('HideButton').style.display = '';
}

// Function used to hide the map when clicking 'Fela kort' used with transition for better UI experience.
function hideMap() {
    var mapDiv = document.getElementById('MapColumn');
    mapDiv.classList.remove('show');
    document.getElementById('ShowButton').style.display = '';
    document.getElementById('HideButton').style.display = 'none';
}

// Function used to show the future weather when clicking 'Spá næstu daga' used with transition for better UI experience.
function showFutureWeather() {
    var mapDiv = document.getElementById('FutureWeatherColumn');
    mapDiv.classList.add('show');
    document.getElementById('showFutureButton').style.display = 'none';
    document.getElementById('hideFutureButton').style.display = '';
}

// Function used to hide the map when clicking 'Fela kort' used with transition for better UI experience.
function hideFutureWeather() {
    var mapDiv = document.getElementById('FutureWeatherColumn');
    mapDiv.classList.remove('show');
    document.getElementById('showFutureButton').style.display = '';
    document.getElementById('hideFutureButton').style.display = 'none';
}
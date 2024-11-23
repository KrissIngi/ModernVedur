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
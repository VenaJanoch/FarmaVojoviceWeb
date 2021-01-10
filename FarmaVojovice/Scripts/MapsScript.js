var center = SMap.Coords.fromWGS84(13.5016917, 49.4656666);
var m = new SMap(JAK.gel("mapa"), center, 13);
m.addDefaultLayer(SMap.DEF_BASE).enable();
m.addDefaultControls();

var layer = new SMap.Layer.Marker();
m.addLayer(layer);
layer.enable();

var card = new SMap.Card();
card.getHeader().innerHTML = "<strong>Farma Vojovice</strong>";
card.getBody().innerHTML = "Naleznete nás na adrese Vojovice 6, Prodejna přístupná při odbočení z hlavní cesty"

var options = {
    title: "Farma Vojovice, Vojovice 6"
};

var marker = new SMap.Marker(center, "myMarker", options);
marker.decorate(SMap.Marker.Feature.Card, card);
layer.addMarker(marker);

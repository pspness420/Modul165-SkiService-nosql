// Wartet darauf, dass die gesamte Seite geladen ist
window.addEventListener("load", () => {
  // Wählt das Loader-Element aus
  const loader = document.querySelector(".loader");

  // Fügt die Klasse "loader--hidden" hinzu, um das Ausblenden des Loaders zu starten
  loader.classList.add("loader--hidden");

  // Sobald der Übergangseffekt (transition) abgeschlossen ist
  loader.addEventListener("transitionend", () => {
      // Entfernt das Loader-Element aus dem DOM
      document.body.removeChild(loader);
  });
});

# Ski-Service Management Projekt

## Projektbeschreibung
Das Ski-Service Management Projekt wurde entwickelt, um die internen Abläufe des Jetstream-Ski-Service zu digitalisieren. Die Web-API bietet Funktionalitäten für die Verwaltung von Serviceaufträgen sowie die Authentifizierung und Autorisierung von Mitarbeitern. Das Backend-System ermöglicht die Bearbeitung und Verwaltung von Aufträgen sowie die Integration mit einer Datenbank für die Speicherung und Verarbeitung relevanter Daten.

---

## Features

### Allgemeine Funktionen
- Benutzer-Login mit Authentifizierung via JWT
- Rollenbasierter Zugriff (Admin, Mitarbeiter, Kunde)
- Serviceaufträge anzeigen, erstellen, aktualisieren und löschen
- Filterung von Aufträgen nach Priorität
- Statusänderung eines Auftrags (Offen, InArbeit, Abgeschlossen)
- Datenbankstruktur in 3. Normalform mit referenzieller Integrität

### Endpunkte der API
#### Authentifizierung
- **POST** `/api/auth/register`: Benutzer registrieren
- **POST** `/api/auth/login`: Benutzer einloggen

#### Benutzerverwaltung (nur für Admins)
- **GET** `/api/auth/users`: Alle Benutzer abrufen
- **PUT** `/api/auth/{id}`: Benutzerrolle aktualisieren
- **DELETE** `/api/auth/{id}`: Benutzer löschen

#### Auftragsmanagement
- **GET** `/api/auftrag`: Alle Aufträge abrufen
- **GET** `/api/auftrag/{id}`: Spezifischen Auftrag abrufen
- **POST** `/api/auftrag`: Neuen Auftrag erstellen
- **PUT** `/api/auftrag/{id}`: Auftrag aktualisieren
- **DELETE** `/api/auftrag/{id}`: Auftrag löschen

### Optional umgesetzte Erweiterungen
- Bearbeitung aller Datenfelder eines Auftrags
- Rollenbasierte Anzeige von Funktionen (Admin-Bereich, Mitarbeiter-Bereich, Kunden-Bereich)

---

## Technologie-Stack
- **Programmiersprache:** C#
- **Framework:** ASP.NET Core 6.0
- **Datenbank:** MS SQL Server
- **ORM:** Entity Framework Core
- **API-Dokumentation:** Swagger (OpenAPI)
- **Test-Tool:** Postman
- **Versionierung:** GitHub Repository

---

## Installation und Setup

### Voraussetzungen
- Visual Studio Code (VS Code)
- .NET SDK 6.0 oder höher
- MS SQL Server
- Postman
- Git

### Schritte
1. **Repository klonen**:
   ```bash
   git clone https://github.com/Yannnnck/Modul295-SkiService-Server-main
   cd Modul295-SkiService-Server-main
   ```
2. **Datenbank konfigurieren**:
   - Passe die Verbindungszeichenfolge in der Datei `appsettings.json` an:
     ```json
     "ConnectionStrings": {
         "DefaultConnection": "Server=DEIN_SERVER;Database=SkiServiceDB;User Id=BENUTZER;Password=PASSWORT;"
     }
     ```
3. **Datenbank migrieren**:
   ```bash
   dotnet ef database update
   ```
4. **Projekt starten**:
   ```bash
   dotnet run
   ```
5. **Swagger-Dokumentation aufrufen**:
   - Gehe zu `http://localhost:5000/swagger` im Browser.
6. **Visual Studio Code verwenden**:
   - Öffne das Projekt in VS Code:
     ```bash
     code .
     ```
   - Stelle sicher, dass alle Abhängigkeiten installiert sind (z. B. durch die integrierte Terminalkonsole von VS Code).
   - Starte die Anwendung mit dem VS Code-Debugger.

---

## Tests
- **Postman Collection**: Eine Sammlung von API-Tests ist vorhanden und kann zur Validierung der Endpunkte verwendet werden.
- **Unit Tests**: Implementiert für kritische Funktionen im Backend.

---

## Datenbankdesign
- Tabellen:
  - **Benutzer**: Verwaltung von Login-Daten und Rollen (Admin, Mitarbeiter, Kunde)
  - **Serviceaufträge**: Speicherung aller Auftragsinformationen
- Beziehungen:
  - 1:n Beziehung zwischen Benutzer und Aufträgen (ein Benutzer kann mehrere Aufträge erstellen/bearbeiten)

---

## API-Dokumentation
Swagger ist integriert und stellt die Dokumentation für alle API-Endpunkte bereit. Es ermöglicht eine einfache Testung und Visualisierung der API-Funktionalitäten.

---

## Verbesserungsmöglichkeiten
- Implementierung einer Login-Sperre nach mehreren Fehlversuchen
- Zusätzliche Protokollierung aller API-Operationen
- Erweiterung um Benutzerkommentare und personalisierte Auftragslisten
- Bereitstellung einer erweiterten Testabdeckung

---

## Autor
**Yannick, Tunahan, Felipe**

Dieses Projekt wurde als Teil der Modularbeit 295 erstellt. Feedback und Verbesserungen sind willkommen!

Enough... I have endured... more than enough... I ask you forgive me, dearest Herr Müller... Ahhhhhh...
![Ski-Service Übersicht](https://static.wikia.nocookie.net/eldenring/images/3/30/ER_Custom_Icon_Lord_of_Frenzied_Flame.png/revision/latest?cb=20240625085300)
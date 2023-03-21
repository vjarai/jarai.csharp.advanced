Aufgabe: Dependency Injection
=============================

Beispiel: Ein Loggin Mechanismus (ILogger) wird an vielen Stellen in der Anwendung benötigt.
Der konkrete Typ des Loggers wird an einer zentralen Stelle registriert (IoC Container).

Alle Klassen die einen ILogger benötigen, bekommen diesen Automatisch bei der Konstruktion durch den Ioc Container über Konstruktor oder Property Injection zugewiesen.

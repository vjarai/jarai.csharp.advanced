Aufgabe: Adapter Pattern
========================

Erstellen Sie die Klassen Brief und Drucker.
Erstellen Sie in der Klasse Brief die Eigenschaft Text und einen Construktor der diese initialisiert.
Erstellen Sie in der Klasse Brief die Methode SendenAn(Drucker d), welche auf dem Drucker den Text Druckt().
Erstellen Sie in der Klasse Drucker die Methode Drucken(string text), die den Text ausgiebt.
Testen Sie die Anwendung mit einem kleinen Hauptprogramm (Main).

Aufgabe:
=======
Erstellen Sie eine Klasse PdfCreator mit der Methode CreatePdf(string txt) die ein (nur simuliertes) PDF ausgiebt.
Erweitern Sie die Anwendung so, dass ein Brief an den PdfCreator gesendet werden kann.

Variante1 (schlecht, da wartungsausfwändig):
============================================
Überladen Sie in der Klasse Brief die Methode SendTo(), so dass der Brief auch an den PdfCreator gesendet werden kann.


Variante2 (Adapter Pattern)
===========================
Ermöglichen Sie es, einen Brief auf dem PdfCreator auszugeben, ohne die Klassen Brief und Drucker zu ändern.



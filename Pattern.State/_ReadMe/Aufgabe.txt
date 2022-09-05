Aufgabe: State Pattern
======================

Ein "altmodisches" Telefon soll drei Zustände einnehmen können:
- Hörer aufgelegt (getrennt)
- Hörer abgehoben (bereit zum wählen)
- Verbunden (bereit zum sprechen oder auflegen)

Das Telefon stellt diese Funktionen zur Verfügung:
- AnnehmenAnruf (nur im Zustand aufgelegt)
- Abheben (nur im Zustand aufgelegt)
- Wählen (nur im Zustand abgehoben)
- Sprechen (nur im Zustand verbunden)
- Auflegen (nur im Zustand verbunden)

Bei allen Fehlbedienungen soll eine Fehlermeldung erscheinen 
(z.B. "Wählen nur im abgehobenen Zustand möglich").

Erstellen Sie die Klasse Telefon mit allen fünf Funktionen.
Erstellen Sie ein Klassendiagramm.
Implementieren Sie das Zustandsabhängige Verhalten des Telfons ohne eine Kontrollstruktur (if, switch, etc.) zu verwenden.





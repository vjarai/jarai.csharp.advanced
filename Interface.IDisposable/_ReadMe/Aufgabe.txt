Das Interface IDisposable wird immer in Verbindung mit einem using Block verwendet.
Beim verlassen des using Blocks wird die Methode Dispose aufgerufen.
In der Dispose Methode werden üblicherweise die angeforderten Resourcen freigegeben (Close).
Der Vorteil eines suing Blcoks liegt darin, das die Resourcen dann auch bei einer Exception freigegeben werden (ohne dass ein finally Block erforderlich ist).
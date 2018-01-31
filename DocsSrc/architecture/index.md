# Board game architecture

* How are your board game build?

-----------------------------------------------------
* Which components does your application consist of?

Tre Views:

* Login: Där fyller användaren in sina uppgifter som tex användarnamn och email.
* Game: Där har vi vår GUI för spelet och som visar användarnas resultat, symbol och användarnamn.
* GameOver: Spelaren som vunnit visar en sida med ett meddelande om att nästa match påbörjas.

En Controllers:

* TicTacToeController: Den består av fyra st ActionResults.
-Login: Den returnerar Login Viewn.

-PreGame: Den tar emot två argument ( userName och email ) den kollar även om det inte finns befintliga spel och i så fall skapar ett.
Den kollar också användarens (SessionID) och kan ge ett meddelande ifall det finns mer än två spelare i spelet.
Allt som händer i PreGame dirigeras om till ( Game View ).

-Game: Det börjar med att den tar emot ett argument ( fieldID ) och visar användarens namn i (Game Viewn). Sedan har vi olika villkor som kollar 
hur många spelare man är i spelet och om man är den aktiva eller inte, på så sätt turas man om i spelet med att placera respektive symboler. 
När spelet i slut återställs spelet pånytt genom metoden ResetGameBoard() som finns i TicTacToe-klassen.

-GameOver: Där har vi ett meddelande som talar om för vinnaren att personen vann och påbörjar en ny omgång. 


Content Mapp:
I den har vi våra bilder, (symboler) och css filer som vi använder för att bygga upp GUI.


GameEngine: 
Är vårat klass bibliotek som består av fyra klasser:

-GameBoard: Som har en lista med strängar av (Fields) och en konstruktor samt en metod som lägger upp de vita bilderna som till vårat brädspel.

-GameInformation: Där har vi information som behövs under spelets gång som ex variablerna "GameOver, Ties, DisplayName".

-Player: Där har vi flera variabler ex "Name, ID, Symbol..." och en konstruktor med några av de propperties i klassen.

-TicTacToe: Denna klass är vår "Main" som vi har våra metoder för att köra programmet och dess logik.


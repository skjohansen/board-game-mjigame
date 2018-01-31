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







TicTacToe klassen 


- TicTacToe klasen innehåller tre instancevariabler och en lista av instance av Player. instance variaberna är 

1, Gameboard har ny instance
2, Player har ny instance
3, GameInformation har ny instance 


Alla fyra instancer  är public och körs i konstrukturen. 

- TicTacToe klassen har sex methoder. och de är Följande; 

1, JoinGame ; metoden är en void metod som gör att ny spekare ansluta sig med sin användare namn, sessionID och epost . vilkoret är om Players.Count är zero avslutar först spellaren om Players.Count  är ett avslutar andra spellaren. Annars är det en undantag. 

2, MakeMove (); metoden är en void metod som fyler field med Spelarens Symbol. tilex. om första spelaren är x fyler varje tryck på första spelaren x. Om andra spelaren symbol är O fyler O för varie tryck.

3, CheckIfGameIsOver () ; är en boolisk metod som kollar om spelat är slut eller inte. Vilkoret är att den kollar om tre rader eller kolumner är samma symbol retunerar true. Om inte är samma tre field samma symbol retunerar false. Och när någon vinner visar en text som congratulerar vinnaren.

4, TogglePlayer() ; är en void metod som  kollar statud på spelaren. Dvs kollar den vem är active. 

5, ResetGameBoard(); är en void metode som återfyller igen med tom bilder med foreach loop. 

6,  SetDisplayName () ;  är en void metod visar användare namn med en sessionID. 


-Tutti i progetti contenuti nella cartella sono stati sviluppati con c# su visual studio.

-Dreadful Destinies - Sinister Seas è un'avventura testuale di genere horror, però la versione consegnata qui non è completa. Tutti i comandi sono funzionanti, però il tutto è da considerarsi una demo vista l'esperienza di   
      gioco particolarmente breve

-GetOffMyDungeon.cs non è completo, manca l'implementazione del movimento e dell'attacco; ogni truppa avrebbe dovuto avere il suo range di movimento e di attacco, oltre che un'abilità unica pensata a monte.
   IMPORTANTE IMPORTANTE IMPORTANTE
      * La prima cosa che si deve fare PRIMA di premere qualsiasi tasto è zoomare indietro, altrimenti il gioco non visualizza a schermo tutto come dovrebbe
      * Ogni comando può essere annullato scrivendo 'indietro'
   Sono state implementati le seguenti features:
      * Ogni truppa è contraddistinta da dei punteggi diversi
      * Ogni turno, un giocatore può spendere un tot mana pari a 100 * il round corrente (fino a un massimo di 500 unità al quinto round). Questa riserva di mana si ricarica ad ogni turno.
      * Ogni giocatore dispone di una riserva globale di mana pari a 1000 unità, esaurite le quali non potrà più richiamare delle truppe
      * E' stata implementata l'evocazione di un'unità tenendo conto delle caselle disponibili per l'evocazione e quelle già occupate da altro
      * Ogni giocatore ha a disposizione 3 pool, che sono la mano, il campo e la pool d'estreazione. All'inizio della partita, il gioco estrae cinque unità e compone la mano del giocatore. Il giocatore può effettuare delle 
        evocazioni dalla pool mano usando il comando apposito. Il gioco finisce quando la pool campo di almeno un giocatore e' vuota
      * Ogni giocatore, una volta per turno, può utilizzare il comando rimescola mano per rimpolpare le unità che ha in mano
      * I comandi DEVONO essere digitati per intero (spazi inclusi) e vengono processati dal gioco premendo invio
      * I comandi funzionanti sono 'evoca unità', 'seleziona unità', 'rimescola mano' e 'passa turno'

-Tris.cs ha dei comandi intuitivi: a turno i giocatori devono inserire il numero della casella numerata dove vogliono inserire il rispettivo simbolo

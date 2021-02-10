# Svaren på frågorna

## ​F0.1 Hur​ ​fungerar​ ​stacken​ ​och​ ​heapen​?​ ​Förklara​ ​gärna​ ​med​ ​exempel​ ​eller​ ​skiss​ ​på​ ​dess grundläggande​ ​funktion

S: Stacken är en linjär struktur där värdena lagras tillfälligt -- när kodsnuten som anväder variabeln har körts kastas den bara bort från stacken automatiskt. Heapen är en hierarkisk struktur där värdena kan lagras en längre tid och som måste rensas då och då. Värdetyper kan lagras både på stacken eller på heapen, beroende på var de används, medan referenstyper lagras alltid på heapen. Fysiska minnet på stacke allokeras statiskt i kontinuerliga block som beror på storleken av det värdet som ska lagras där, medan minnet på heapen allokeras dynamiskt, och kan allokeras nästan "hur som helst", så länge det finns lediga minnesceller. Därför kan inte variabler lagrade på stacken öka eller minska i storlek, medan variablerna lagrade på heapen kan växa eller krympa med behov.

## F0.2. ​Vad​ ​är​ ​Value​ ​Types​ ​repsektive​ ​Reference​ ​Types​ ​och​ ​vad​ ​skiljer​ ​dem​ ​åt?

S: Value Types är variabler vars värde lagras tillsammans med själva variabeln, medan Reference Types är variabler som är referenser (eller pekare) till en minnesaddress på heapen där själva värdet lagras. När en värdetyp tilldelas en annan variabel så kopieras dess värde till den nya variabeln. När en värdetyp skickas till en metod som parameter så kopieras värdet av den första variabeln till en ny tillfällig variablen och det är den nya kopian som metoden opererar på medan det ursprungliga värdet förblir oberoende. Med en referenstyp tilldelas en ny variabeln så är det bara refensen som kopieras och därefter pekar båda till samma minnesplats. När en referensvariabeln skickas som en parameter i en metod så sker samma sak -- referensen till den address i minnet där variabelns värde ligger kopieras och skickas till metoden som därefter opererar på samma minne som den ursprungliga variabeln pekade på.

## F0.3 Följande​ ​metoder​ ​(​se​ ​bild​ ​nedan​)​ ​genererar​ ​olika​ ​svar.​ ​Den​ ​första​ ​returnerar​ ​3,​ ​den andra​ ​returnerar​ ​4,​ ​varför?

S: Den första metoden opererar med `int` som är en Value type. Så när kompilatorn påträffar satsen `y=x` så kopieras x's värde till y. Variabeln y innehåller alltså en kopia av et värde som x hade när satsen exekverades. Påföljande tilldelning till y ändrar därför *inte* värdet på x. Den andra metoden opererar med `MyInt` klassen som är en Reference type. Så när kompilatorn påträffar satsen `y=x` så så är det *referensen* till x som kopieras till y. Variabeln y innehåller nu referensen till samma ställe som x pekar på, så vid nästa tilldelning till y ändras värdet på den plats i minnet som refereas av både y och x.

## F1.2 ​När​ ​ökar​ ​listans​ ​kapacitet?​ ​(Alltså​ ​den​ ​underliggande​ ​arrayens​ ​storlek)

S: När den nuvarande kapaciteten överskrids.

## F1.3 ​Med​ ​hur​ ​mycket​ ​ökar​ ​kapaciteten?

S: Kapaciteten dubblas.

## F1.4 Varför​ ​ökar​ ​inte​ ​listans​ ​kapacitet​ ​i​ ​samma​ ​takt​ ​som​ ​element​ ​läggs​ ​till?

S: Den underliggande strukturen i listan är en array. När kapaciteten ska ökas så måste hela arrayen kopieras till en ny array med den önskade kapaciteten. Det är en dyr operation både tidsmässigt och minnesmässigt.

## F1.5 ​Minskar​ ​kapaciteten​ ​när​ ​element​ ​tas​ ​bort​ ​ur​ ​listan?

S: Nej.

## F1.6 När​ ​är​ ​det​ ​då​ ​fördelaktigt​ ​att​ ​använda​ ​en​ ​egendefinierad​ ​array​ ​istället​ ​för​ ​en​ ​lista?

S: När man vet i förväg hur många element arrayen ska innehålla.

## F2.1 Simulera​ ​ännu​ ​en​ ​gång​ ​ICA-kön​ ​på​ ​papper.​ ​Denna​ ​gång​ ​med​ ​en​ stack​.​ ​Varför​ ​är​ ​det inte​ ​så​ ​smart​ ​att​ ​använda​ ​en​ ​stack​ ​i​ ​det​ ​här​ ​fallet?

S: För att en stack följer Först-in-sist-ut principen, så med en stack kommer den person som ställde sig sist i kön att expedieras först, medan vi vill i det här fallet att den som stått i kön längst expedieras snarast.

## F6.1 (Extra) Utgå​ ​ifrån​ ​era​ ​nyvunna​ ​kunskaper​ ​om​ ​iteration,​ ​rekursion​ ​och​ ​minneshantering.​ ​Vilken​ ​av ovanstående​ ​funktioner​ ​är​ ​mest​ ​minnesvänlig​ ​och​ ​varför?

S: I C# liksom i många andra imperativa språk, är det mer minnessparande att använda iteration. Anledningen till det är att varje ny anrop av en metod eller funktion sparar saker på stacken och om en metod anropar sig själv flera tusen gånger så kan stacken bli ganska belastad. I vissa andra språk -- speciellt i många funktionella språk -- så finns något som heter "tail call optimization". Det är en teknik som kan optimisera rekursion om den det rekusriva anropet ligger sist.

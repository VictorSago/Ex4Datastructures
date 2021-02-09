# Svaren på frågorna

## ​F0.1 Hur​ ​fungerar​ ​stacken​ ​och​ ​heapen​?​ ​Förklara​ ​gärna​ ​med​ ​exempel​ ​eller​ ​skiss​ ​på​ ​dess grundläggande​ ​funktion

S:

## F0.2. ​Vad​ ​är​ ​Value​ ​Types​ ​repsektive​ ​Reference​ ​Types​ ​och​ ​vad​ ​skiljer​ ​dem​ ​åt?

S: Value Types skickas till metoder som värden, medan Reference Types skickas som referenser till den plats i minnet där värdet ligger.

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

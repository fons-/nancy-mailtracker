# Het Plan

Ik ben dus een server aan het schrijven die het volgende doet:
- Het genereert een unieke link wanneer een gebruiker er een nodig heeft (wanneer een nieuwe mail gestuurd wordt). Deze links (bv http://mailtrack.tk/i/1234.png) verwijzen eigenlijk allemaal naar dezelfde afbeelding (een 1x1 witte/transparante pixel). Deze combinatie van gebruiker, email en link wordt in een DB opgeslagen.
- Het houdt alle GET request van de vorm /i/****.png bij, en slaat dan de tijd en het IP adres op in een DB.
En misschien komt hier later nog bij:
- In plaats van een 1x1 transparante pixel kan elke foto gebruikt worden die de gebruiker uploadt. De gebruiker mag dan bv 10 fotos op zijn/haar account hebben staan (en dus geuploadt worden met een interface), en bij elke mail die gestuurd wordt kan een van deze fotos gekozen worden. Misschien wordt het zelfs een redirect bij grote foto's: fotos staan eigenlijk op imgur en mijn server downloadt ze _on the fly_ wanneer er een request is.

Idealiter is dit allemaal een chrome extension voor gmail/hotmail die alles achter de schermen doet, maar ik heb echt geen zin om een extension te schrijven. (Doe het vooral als je daar interesse in hebt!)

## Fons wat moet ik nou doen?
Wat *jij* dus kan doen is een web interface hiervoor schrijven. Wat je als gebruiker doet wanneer je een mail wil sturen:
1. Ga naar mailtrack.tk (ofzo). Als je niet bent ingelogd krijg je een redirect naar mailtrack.tk/login. _Je moet dus een login page schrijven, die een error kan geven: "Combination username/password incorrect."_
2. Als je geen account hebt kan je vanaf mailtrack.tk/login een link volgen naar mailtrack.tk/signup. _Je moet dus een signup page schrijven, met alleen cruciale info: email en password_
3. Je komt nu op mailtrack.tk/dash. Hier ga ik later op in. Hier ergens is een knop: "Create new tracker". Als je hierop klikt kom je in een soort setup wizard, met een paar stappen. (Het liefst zijn deze stappen allen in 1 html page, zodat je geen refresh krijgt. Stappen kunnen bv onder elkaar, of na elkaar als een slideshow.)
..1. Eerste stap: kies uit een van je 10 images (of minder) en geef het een naam (e.g. "mailtje naar mam"). 
..2. Tweede stap: je ziet de tracker image met een duidelijke border. Dit moet een vaste grootte hebben (anders zou je de 1x1 foto niet zien). Hier onder staat de instructie: "Copy pastsa this image into your e-mail xx". 
..3. Derde stap: een knop "Start tracking". Deze knop wordt disabled als je erop klikt.
4. Je schrijft je mail in gmail/hotmail, en dan volg je stap 1 en 2 van het vorige puntje. Deze foto plak je in je mail, en je stuurt hem. Dan druk je op start tracking.

Weetje misschien kunnen die drie stappen ook in 1 scherm idk.

Verder moet je nog een interface schrijven waarmee je al je trackers in een overzicht ziet. Centraal is hier: foto, naam en "seen/not seen" met vinkjes.

Iets met bootstrap zou ik cool vinden. :)

Voila!

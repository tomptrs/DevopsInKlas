using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LBI_DAL.Models;
using System.Collections;
using System.IO;

namespace LBI_DAL
{
    public class DBInitializer
    {
        public static void Initialize(LBIContext context)
        {
            context.Database.EnsureCreated();
            if (!context.HappinessDb.Any())
            {
                AddHappiness("Teken een groot vraagteken en schrijf daarin waaraan jij twijfelt. Teken daarna een groot uitroepteken en schrijf daarin waarin jij gelooft.", context);
                AddHappiness("Doe gewoon iets vriendelijks voor een ander zonder iets terug te verwachten. Je weet dat op een dag een ander dat ook voor jou zal doen.", context);
                AddHappiness("Breng vandaag de mensen aan het lachen. En ga goed na welke effecten dit heeft op anderen én op jou.", context);
                AddHappiness("Zorg ervoor dat je minstens drie goede eigenschappen kan noemen van elk familielid en elke kennis die je niet mag.", context);
                AddHappiness("Focus je vandaag op wat je graag doet, waar je van houdt en wat je hoopt.", context);
                AddHappiness("Ga vandaag op zoek naar dat ene talent van je dat nog wat verborgen zit. Geef het een kans om te groeien.", context);
                AddHappiness("Bekijk vandaag de anderen op deze manier: ze hebben een talent en iets belangrijks te zeggen. Ontdek het.", context);
                AddHappiness("Teken een steen en schrijf er een last op die je moet dragen. Teken drie ballonnen aan de steen met woorden die je met de last leren leven, ook al zal de steen daardoor niet van plaats veranderen.", context);
                AddHappiness("Begin de dag met iets waar je al lang tegen op ziet. De rest van de dag zal extra meevallen.", context);
                AddHappiness("Verras vandaag iemand door te geven.", context);
                AddHappiness("Voel je weerstand tegen iets wat je wilt ondernemen? Bekijk die weerstand als een kracht om je plan door te voeren.", context);
                AddHappiness("Zoek een foto op uit je kindertijd. Welke positieve eigenschappen van dat kind heb je onderweg verloren? Pak ze weer op.", context);
                AddHappiness("Teken twee ballonnen. Schrijf in de ene ballon iets wat je durft te hopen voor jezelf en in de andere iets wat je hoopt voor een ander.", context);
                AddHappiness("Wanneer had je het gevoel dat ze iets in jou kapot wilden maken? Ga voor jezelf na hoe je daar sterker uit bent gekomen. Gebruik die kracht.", context);
                AddHappiness("Welke mens waarvan je erg verschilt ontmoet je vandaag? Ga na wat jullie toch wel gemeenschappelijk hebben.", context);
                AddHappiness("Houd vandaag van uur tot uur bij wat je precies doet. Hoeveel procent van je tijd zou je eigenlijk anders willen invullen? Wat houdt je precies tegen?", context);
                AddHappiness("Laat je vandaag van je sterkste kant zien: vraag om hulp.", context);
                AddHappiness("Noem twee belangrijke keuzes in je leven. Wat zeggen die over jezelf?", context);
                AddHappiness("Observeer. Concentreer je vandaag op minsten drie momenten waarop je denk: dat is grappig. Er sluimert een ontdekking in.", context);
                AddHappiness("Kies vandaag een film, een kunstwerk of een muziekstuk en geniet er extra van.", context);
                AddHappiness("Teken je eigen schaduw en schrijf erin wat je verbergt voor jezelf of voor anderen.", context);
                AddHappiness("Teken enkele wegen die anderen je liever hadden zien gaan. Teken dan je eigen weg.", context);
                AddHappiness("Wanneer liep er laatst iets fout? Wat heb je daaruit opgepikt en geleerd?", context);
                AddHappiness("Teken een veld en verdeel het in vier stukken. Plaats in elk deel van het veld iets waarvoor je dankbaar bent in je leven.", context);
                AddHappiness("Ga vandaag op zoek naar het allereenvoudigste wat jou gelukkig maakt.", context);
                AddHappiness("Verstop je verdriet niet. Geef het woorden. Praat erover met jezelf en met anderen. Maar laat het je leven niet bepalen.", context);
                AddHappiness("Probeer vandaag iemand iets op een voorzichtige manier te leren.", context);
                AddHappiness("Waar kijk je vandaag een beetje tegenop? Doe het toch maar. En beleef er plezier aan.", context);
                AddHappiness("Vandaag zij we bijzonder zuinig met woorden. Schrap al het overbodige wat je wilt zeggen of schrijven en houd het essentiële over.", context);
                AddHappiness("Wat zou jij vandaag kunnen doen om een andere mens gelukkiger te maken? Doe het!", context);
                AddHappiness("Vul in: ‘Ik wil … zijn.’ Vervang de eerste woorden nu door ‘Ik ben …’. Herhaal het vandaag minstens 20 keer als een mantra. (En handel ernaar!)", context);
                AddHappiness("Zoek een leuke en recente foto van jezelf. Bedenk er een positief onderschrift bij dat begint met ik.", context);
                AddHappiness("Schrijf vandaag twee eigenschappen van jezelf op die je hebt leren aanvaarden. Schrijf daarna een eigenschap op die je zou willen veranderen.", context);
                AddHappiness("Schrijf een probleem waar je mee zit in een cirkel. Maak daar het hart van een bloem van. Zet in elk bloemblad iets positief dat ook met het probleem te maken heeft. Verbreed je blik.", context);
                AddHappiness("Welk liedje of muziekstuk heeft jouw leven (een beetje) veranderd? Luister er vandaag nog eens naar.", context);
                AddHappiness(" Waar ben je misschien niet zo goed in, maar ben je wel bijzonder sterk voor gemotiveerd? Ga ervoor!", context);
                AddHappiness("Pieker vandaag. Maak je zorgen. Maar niet langer dan een halfuur. Daarna doe je het hek rond je zorgen weer dicht. Nieuwe afspraak: morgen zelfde tijd.", context);
                AddHappiness("Noem één situatie waarin je enthousiasme je echt vooruit heeft gebracht. Verras vandaag anderen met jouw enthousiasme.", context);
                AddHappiness("Welke drie dingen zullen anderen over jou onthouden?", context);
                AddHappiness("Wat zou jij willen uitvinden?", context);
                AddHappiness("Trek je vandaag niets aan van wat anderen van je denken.", context);
                AddHappiness("We zijn er nooit te oud voor. Vertel vandaag iemand een verhaal, lees er een, lees er een voor of schrijf er een.", context);
                AddHappiness("Dans vandaag. Met iemand of met jezelf.", context);
                AddHappiness("Met wie ben jij geneigd om je te vergelijken? Misschien tijd om daarmee te stoppen.", context);
                AddHappiness("Met wie deel jij vaak je geluk? Zoek iemand op waarmee je je geluk nog niet zo vaak gedeeld hebt.", context);
                AddHappiness("Wat waren de twee gelukkigste momenten van de voorbije week?", context);
                AddHappiness("Waarin heb je al enkele keren gefaald? Probeer er een lijn in te zien en er een les uit te trekken.", context);
                AddHappiness("Roddel vandaag met plezier over de goede eigenschappen van mensen die je kent.", context);
                AddHappiness("Probeer (ondanks alles) eens drie goede eigenschappen te noemen van een mens die je niet mag.", context);
                AddHappiness("Maak het vandaag ergens tien minuten volledig stil. En luister naar de stem in jezelf. Benieuwd naar wat je zal horen.", context);
                AddHappiness("Draai vandaag twee keer je tong om voor je iets zegt.", context);
                AddHappiness("Vertrouwen geven en krijgen maakt mensen gelukkig. Met wie zou jij over persoonlijke problemen kunnen en willen spreken? En wie vertrouwt jou?  Probeer het uit.", context);
                AddHappiness("Laat je vandaag verwonderen door de namen die we aan de dingen geven. Waarom heet een stoel een stoel? Noem de dingen vandaag eens anders.", context);
                AddHappiness("Stel jezelf een helder en duidelijk doel. Plak je er meteen aan vast als een postzegel aan een brief. Houd je doel voor ogen tot je er bent.", context);
                AddHappiness("Maak een cartoon van enkele mensen die je goed kent en vergroot daarin hun buitengewone eigenschappen.", context);
                AddHappiness("Door welke dringende zaken, plannen en verlangen laat jij je deze week opjagen? Neem even tijd voor jezelf of om een stap terug te zetten.", context);
                AddHappiness("Zing vandaag. Zo veel en waar je kan.", context);
                AddHappiness("Stel vandaag een daad die overmorgen nog het vermelden waard is.", context);
                AddHappiness("Wie kan in jouw omgeving nog een positief duwtje gebruiken? Geef het!", context);
                AddHappiness("Vervang jaloezie (vergelijking met anderen) door ambitie (vergelijking met jezelf). Formuleer minstens één persoonlijke ambitie in één zin.", context);
                AddHappiness("Tel vandaag de vrolijke mensen die je ontmoet. Bingo voor elk vijfde streepje!", context);
                AddHappiness("Bekijk vandaag wat je gewoonlijk negatief bekijkt eens positief.", context);
                AddHappiness("Doe vandaag iets aardigs voor iemand in de buurt.", context);
                AddHappiness("Ontdek minstens één gekte in jezelf. Wat zou je daar nog meer mee kunnen doen?", context);
                AddHappiness("Noem twee mensen bij naam die je kent en gelukkig zijn.", context);
                AddHappiness("Bij wie heb jij het gevoel dat je echt verstaan en begrepen wordt? Zoek die mens op.", context);
                AddHappiness("Vraag vandaag aan iemand om je spiegel te zijn. Wat ziet hij als hij jou ziet? (Deze opdracht tonen is een goed excuus.)", context);
                AddHappiness("Teken twee voetstappen. Zet in de ene iets wat je het best durft en in de andere iets waarin je misschien te voorzichtig bent.", context);
                AddHappiness("Welke vrienden en omgevingen stimuleren je in de positieve richting? Zoek die op en laat de negatieve links liggen.", context);
                AddHappiness("Teken een bloem met zeven blaadjes. Schrijf in het midden een van je kerneigenschappen en op elk blaadje eigenschappen die er stilaan bij zijn gekomen.", context);
                AddHappiness("Meer hoeft het niet te zijn. Vandaag is jouw Dag van het Vriendelijke Gebaar voor een Ander.", context);
                AddHappiness("Sluit vandaag eindelijk vriendschap met jezelf.", context);
                AddHappiness("Wat heb jij de voorbije dagen gedaan dat je gelukkig maakt? Denk na over een nieuwe daad.", context);
                AddHappiness("Wat dreig je op te geven? Probeer het nog één keer.", context);
                AddHappiness("Welke wens heb jij voor een kind dat vandaag in een ander deel van de wereld geboren wordt? Maak een geboortekaartje", context);
                AddHappiness("Wat zou je kunnen bedenken zodat méér mensen gelukkig zijn?", context);
                AddHappiness("Vraag vandaag aan minstens twee mensen wat hen gelukkig maakt.", context);
                AddHappiness("Doe vandaag iets gebeuren waar je zelf of iemand anders van opkijkt.", context);
                AddHappiness("Noem twee attitudes, gedragingen of houdingen die het jou moeilijk maken om gelukkig te zijn. Schrap er vanaf vandaag eentje van.", context);
                AddHappiness("Ga vandaag bij een raam staan en bekijk even waarom je daar wel graag bent.", context);
                AddHappiness("Leg het vandaag wat minder uit en luister wat meer. Toon begrip voor de ander, kijk hem aan, vat zijn woorden samen en vraag of je hemt goed hebt begrepen.", context);
                AddHappiness("Maak vandaag een lijstje van minstens tien woorden die omschrijven wie jij echt bent. Dat is meer dan je naam en je studie.", context);
                AddHappiness("Doe vandaag iets wat je nog nooit hebt gedaan.", context);
                AddHappiness("Ontdek vandaag vijf bijzonder kleine dingen die best gelukkig maken.", context);
                AddHappiness("Noem één van je zwaktes. Bekijk hoe je daar ook een sterkte van kan maken.", context);
                AddHappiness("Kies er vandaag gewoon voor om gelukkig te zijn.", context);
                AddHappiness("Beslis vandaag hoe je een klus of een plan dat al veel te lang aansleept afwerkt. Stel een realistische deadline vast.", context);
                AddHappiness("Besteed vandaag extra aandacht aan wie meestal stil is en weinig zegt.", context);
                AddHappiness("Kies een spreekwoord dat jouw levensmotto zou kunnen zijn. Hang het ergens op.", context);
                AddHappiness("Vorm vandaag een persoonlijke mening over een actueel onderwerp. Misschien is het niet je eerdere mening of een die anderen van jou zouden verwachten.", context);
                AddHappiness("Bekijk even je eigen situatie. Zet jezelf dan in het midden van een cirkel en maak een rustige beweging van 360 graden. Welke nieuwe mogelijkheden zie je?", context);
                AddHappiness("Is er nog iemand bij wie jij je wilt verontschuldigen? Doe het vandaag.", context);
                AddHappiness("Maak vandaag een lijstje met drie namen van mensen waardoor je geworden bent wie je bent. Als het mogelijk is om hen te bedanken, doe dat dan.", context);
                AddHappiness("Tel vandaag enkele keren gedurende één minuut de slagen van je hart.", context);
                AddHappiness("Noem twee omstandigheden waaraan je je ergert en die je (voorlopig) niet kan veranderen. Probeer er het positieve van in te zien.", context);
                AddHappiness("Doe vandaag iets onnozels. Misschien vind je wel iemand die wil meedoen.", context);
            };

            if (!context.CategoryDb.Any())
            {
                AddCat("Basis", context);
                AddCat("Sociaal", context);
                AddCat("Relaxerende activiteit", context);
                AddCat("Gewone activiteit", context);
                AddCat("Ongewone activiteit", context);
                AddCat("Tijd dodende activiteit", context);
            }

            if (!context.UsersDb.Any())
            {
                MomentKader m1 = AddMomentKader("het project is goed verloepn", "blij", "moe", context);
                List<MomentKader> momentKader = new List<MomentKader>();
                momentKader.Add(m1); 

                EigenNetwerk e1 = AddEigenNetwerk("joe", "joe@gmail.com", "04629", context);
                List<EigenNetwerk> eigenNetwerk = new List<EigenNetwerk>();
                eigenNetwerk.Add(e1); 


                Goals g1 = AddGoal("Meer drinken", DateTime.Now, new DateTime(2019, 10, 30), 5, 10, context);
                Goals g2 = AddGoal("Meer ontspanning", DateTime.Now, new DateTime(2019, 11, 05), 5, 20, context);
                Goals g3 = AddGoal("Meer slapen", DateTime.Now, new DateTime(2019, 11, 25), 0, 5, context);
                List<Goals> goals = new List<Goals>();
                goals.Add(g1);
                goals.Add(g2);
                goals.Add(g3);


                UserCategory c1 = AddUserCat(1, "rgb(0,0,255)", context);
                UserCategory c2 = AddUserCat(2, "rgb(255,0,0)", context);
                UserCategory c3 = AddUserCat(3, "rgb(0,128,0)", context);
                UserCategory c4 = AddUserCat(4, "rgb(255,255,0)", context);
                UserCategory c5 = AddUserCat(5, "rgb(255,165,0)", context);
                UserCategory c6 = AddUserCat(6, "rgb(139,69,19)", context);
                List<UserCategory> categories = new List<UserCategory>();
                categories.Add(c1);
                categories.Add(c2);
                categories.Add(c3);
                categories.Add(c4);
                categories.Add(c5);
                categories.Add(c6);

                var i1 = new AgendaItem()
                {
                    Description = "School :(",
                    StartDate = new DateTime(2019, 11, 22, 8, 30, 0),
                    EndDate = new DateTime(2019, 11, 22, 10, 30, 0),
                    UserCategoryId = 1
                };

                var i12 = new AgendaItem()
                {
                    Description = "slaap",
                    StartDate = new DateTime(2019, 11, 22, 12, 30, 0),
                    EndDate = new DateTime(2019, 11, 22, 18, 0, 0),
                    UserCategoryId = 3
                };

                var i13 = new AgendaItem()
                {
                    Description = "werk",
                    StartDate = new DateTime(2019, 11, 22, 00, 30, 0),
                    EndDate = new DateTime(2019, 11, 22, 7, 00, 0),
                    UserCategoryId = 6
                };
                var i2 = new AgendaItem()
                {
                    Description = "Ook School :(",
                    StartDate = new DateTime(2019, 11, 22, 8, 30, 0),
                    EndDate = new DateTime(2019, 11, 23, 10, 30, 0),
                    UserCategoryId = 1
                };
                var i3 = new AgendaItem()
                {
                    Description = "Toch wel weer school zekers :(",
                    StartDate = new DateTime(2019, 11, 22, 8, 30, 0),
                    EndDate = new DateTime(2019, 11, 24, 10, 30, 0),
                    UserCategoryId = 1
                };
                List<AgendaItem> ies = new List<AgendaItem>();
                ies.Add(i1);
                ies.Add(i12);
                ies.Add(i13);

                Agenda a1 = AddAgenda(new DateTime(2019, 11, 22, 12, 00, 00), ies, context);
                ies.Clear();
                ies.Add(i2);
                Agenda a2 = AddAgenda(new DateTime(2019, 11, 23, 12, 00, 00), ies, context);
                ies.Clear();
                ies.Add(i3);
                Agenda a3 = AddAgenda(new DateTime(2019, 11, 24, 12, 00, 00), ies, context);
                List<Agenda> agendas = new List<Agenda>();
                agendas.Add(a1);
                agendas.Add(a2);
                agendas.Add(a3);

                List<UserHappiness> happy = new List<UserHappiness>();
                var happiness = context.HappinessDb.ToList();
                foreach (var h in happiness)
                {
                    UserHappiness hap = new UserHappiness();
                    hap.HappinessId = h.Id;
                    hap.UserId = 1;
                    hap.Status = false; 
                    happy.Add(hap); 
                }; 

                UserHappiness uH1 = new UserHappiness { HappinessId = 1, UserId = 1 };
                UserHappiness uH2 = new UserHappiness { HappinessId = 10, UserId = 1 };

                List<UserHappiness> userHappiness = new List<UserHappiness>();
                userHappiness.Add(uH1);
                userHappiness.Add(uH2); 

                //context.AddRange(
                //    new UserHappiness { Happiness = context.HappinessDb.SingleOrDefault(h => h.Id == 1), UserId = 1 },
                //    new UserHappiness { Happiness = context.HappinessDb.SingleOrDefault(h => h.Id == 10), UserId = 1 }
                //    );

                AddUser("yenthe huysmans", "yenthe7@gmail.com", "google-oauth2|105105055291641855283", momentKader, eigenNetwerk, goals, categories, agendas, happy, context);
            }

            if (!context.MindfulnessDb.Any())
            {
                AddMindfulness("Ademhalingsoefeningen", "Adem is zo vanzelfsprekend. Het is er altijd en je hoeft er niets speciaal voor te doen. Desondanks kan je je ook bewust worden van je ademhaling en dit als een middel gebruiken om rustig te worden, bijvoorbeeld op een heel drukke dag , net voor je een toets moeten maken en je zenuwachtig bent. Ademhalingsoefeningen helpen om onaangename gevoelens los te laten en verhogen je concentratie.", context);
                AddMindfulness("Aandacht aan specifieke momenten", "Doorheen een dag maak je zoveel mee. Soms is het belangrijk om hier even bij stil te staan. De tijd gaat al zo snel. Hierdoor heb je soms geen tijd om je ervan bewust te worden welke aangename alsook onaangename momenten je meemaakt. Met deze oefening roep je een halt toe aan al de drukke bezigheden.Aan de hand van deze tabel leggen we de aandacht op je gedachten, emoties en lichaam. Elk onderdeel kan anders aanvoelen. Hierbij is het belangrijk om stil te staan bij wat de situatie met je doet.", context);
                AddMindfulness("Aandacht voor het NU", "Je staat er niet bij stil dat je doorheen de dag heel veel activiteiten uitvoert op automatische piloot. Je bent niet meer bewust bezig met hoe je bijvoorbeeld eet,  tanden poets, fietst, … . Het is ook belangrijk dat je hier een keer bij stil staat en je aandacht hebt voor het nu. Deze oefening zal geen extra tijd vragen. Je hoeft gewoon je aandacht te richten op wat je aan het doen bent, je ervaart bewuster wat er gebeurt." , context);
                AddMindfulness("Aandacht voor het lichaam", "bodyscan", context);
                AddMindfulness("Extra", "Een gezonde geest in een gezond lichaam", context);
            }
          
           if (!context.Externe_bronDb.Any())
            {
                AddBron("Awel luistert naar kinderen en jongeren.", "Awel.png", "https://awel.be/", "brievenbus@awel.be", true, "Gratis en anoniem op 102. Ma-za: 16-22u", "https://awel.be/forum", "Chat met AWEL : Ma-za 18-22u", "https://awel.be/babbel#chat", context);
                AddBron("Gaan de dingen niet zoals je wil? Het JAC is er voor jou.", "Jac.png", "https://www.caw.be/jac/", "https://www.caw.be/jac/contacteer-ons/mail/", false, null, null, "Chat met JAC: Ma-vr 13-19 u", "https://www.caw.be/jac/contacteer-ons/chat/", context);
                AddBron("Praten over hoe je je voelt op school of thuis? Vragen over je studies, je gezondheid of het medisch onderzoek? Je kan gratis en anoniem bij het CLB terecht voor info of begeleiding.", "CLB.png", "https://www.onderwijskiezer.be/v2/clb/clb_zoek.php", null, false, null, null, "Chat met CLB: Ma/di/do 17-21u, Wo 14-21u", "https://www.clbchat.be", context);
                AddBron("In een OverKop-huis kan je als jongere gewoon binnen en buiten lopen en allerlei leuke activiteiten doen. Het is een veilige plek waar je ook een luisterend oor vindt en beroep kan doen op professionele therapeutische hulp.", "OverKop.png", "https://overkop.be", "info@overkop.be", true, null, null, null, null, context);
                AddBron("Therapeutische begeleiding • jongeren 10 – 20 jaar • anoniem • onmiddellijk • kortdurend • gratis • met of zonder afspraak", "Tejo.png", "https://tejo.be", null, false, null, null, null, null, context);
                AddBron("Praat bij Tele-Onthaal over wat jou bezighoudt. Soms moet je al je moed bijeen rapen voor een gesprek. Of vraag je je af of zo’n gesprek wel veilig is. Om het voor jou zo makkelijk mogelijk te maken om te praten, houden we de drempel zo laag mogelijk.", "TeleOnthaal.png", "https://www.tele-onthaal.be", null, false, "Bel 106. 24u op 24, 7d op 7", null, "Chat elke avond en woens - en zondagnamiddag", null, context);
                AddBron("Dringend nood aan een gesprek?", "ZelfmoordLijn.png", "https://www.zelfmoord1813.be", "https://email.zelfmoord1813.be/", false, "Bel nu 1813. 24/7 beschikbaar", null, "elke dag van 18u30 – 22u", null, context);
            }
            
            if (!context.QuotesDb.Any())
            {
                AddQuotes("Ik wil alles worden wat ik kan worden.", "", context);
                AddQuotes("De drie basis voorwaarden voor geluk zijn: iets hebben om te doen, iets hebben om van te houden en iets hebben om op te hopen.", "", context);
                AddQuotes("Gelukkig is hij die leert dragen wat hij niet kan veranderen.", "", context);
                AddQuotes("Geluk zit niet in hebben of krijgen, alleen in geven.", "", context);
                AddQuotes("Elk kind is een kunstenaar. Het probleem is er een te blijven.", "", context);
                AddQuotes("Pessimisten hebben geen hoop voor zichzelf , noch voor anderen.", "", context);
                AddQuotes("Wat me niet kapot maakt, maakt me sterker.", "", context);
                AddQuotes("Je tijd is beperkt. Verspil hem niet door het leven van anderen te leiden. Er is geen enkele reden om niet de weg van je hart te volgen.", "", context);
                AddQuotes("Om hulp vragen is geen teken van zwakte maar van kracht.", "", context);
                AddQuotes("In plaats van te klagen dat we niet alles hebben wat we willen, kunnen we beter dankbaar zijn dat we niet alles krijgen wat we verdienen.", "", context);
                AddQuotes("De keuzes die we maken vertellen veel meer over ons dan de mogelijkheden die we hebben.", "", context);
                AddQuotes("De ontmoeting met een goed mens blijft een herinner voor het leven.", "", context);
                AddQuotes("Dankbare mensen zijn als vruchtbare velden. Zij geven wat ze ontvangen tienvoudig terug.", "", context);
                AddQuotes("Eenvoud is het hoogste wat je kan bereiken.", "", context);
                AddQuotes("Als je geen verdriet hebt ervaren, kan je ook geen geluk appreciëren.", "", context);
                AddQuotes("Het is gemakkelijker om iemand iets te bevelen dan om iemand iets te leren.", "", context);
                AddQuotes("Het geheim van geluk ligt niet in het doen waar je plezier in hebt, maar in plezier hebben in wat je doet.", "", context);
                AddQuotes("Wie niet naar geluk zoekt, zal het gemakkelijker vinden. Wie ernaar zoekt, vergeet vaak dat de beste manier om gelukkig te zijn, zit in het zoeken naar geluk voor anderen.", "", context);
                AddQuotes("Iemand werkt me op de zenuwen. Ik denk dat ik het ben.", "", context);
                AddQuotes("Wat weet je van de woestijn als je telkens alleen naar dezelfde zandkorrel kijkt?", "", context);
                AddQuotes("Motivatie wint bijna altijd van talent.", "", context);
                AddQuotes("Met geluk valt niet te lachen", "", context);
                AddQuotes("We kopen dingen die we niet nodig hebben met geld dat we niet hebben om indruk te maken op mensen die we niet kunnen uitstaan.", "", context);
                AddQuotes("Bied weerstand aan wie fout is en bijstand aan wie goed is. ", "", context);
                AddQuotes("Geluk is alleen maar echt als het gedeeld geluk is.", "", context);
                AddQuotes("Veel mensen lopen het geluk mis, niet omdat ze het niet vinden maar omdat ze geen tijd nemen om ervan te genieten.", "", context);
                AddQuotes("Ooit geprobeerd. Ooit gefaald. Geen probleem. Probeer opnieuw. Faal opnieuw. Faal beter.", "", context);
                AddQuotes("Een uitgang is gewoon een ingang die je in de andere richting neemt.", "", context);
                AddQuotes("Als het pijn doet om kritiek te geven op je vrienden, mag je dat doen. Maar als je er ook maar het kleinste plezier aan beleeft, wordt het tijd om je mond te houden.", "", context);
                AddQuotes("Volg niet de ideeën van anderen, maar leer te luisteren naar de stem in jezelf.", "", context);
                AddQuotes("Iemand die niemand vertrouwt, wordt door niemand vertrouwd.", "", context);
                AddQuotes("De dingen zijn niet wat ze lijken, ze zijn zelfs niet wat wij ze noemen.", "", context);
                AddQuotes("Iedereen is normaal tot je hem leert kennen.", "", context);
                AddQuotes("Alles komt op tijd voor wie weet hoe hij moet wachten.", "", context);
                AddQuotes("Omdat we in het heden leven, moeten we elke dag vieren in het besef dat we zelf geschiedenis worden door elke daad die we stellen.", "", context);
                AddQuotes("Er is maar één ding mooier dan gelukkig zijn. Dat is anderen helpen om ook gelukkig te zijn.", "", context);
                AddQuotes("Winnen doe je niet door anderen voorbij te streven, maar jezelf.", "", context);
                AddQuotes("Het duidelijkste teken van wijsheid is vrolijkheid.", "", context);
                AddQuotes("Ons (on)geluk hangt meer af van hoe we naar de gebeurtenissen in ons leven kijken dan van die gebeurtenissen zelf.", "", context);
                AddQuotes("Het is gemakkelijker om van de mensheid te houden dan van je buurman.", "", context);
                AddQuotes("Voordat je iets wilt hebben, kan je beter nagaan hoe gelukkig de mensen zijn die het al bezitten.", "", context);
                AddQuotes("Er is maar één mens die mij ooit begrepen heeft en hij verstond mij niet.", "", context);
                AddQuotes("Het is moeilijk om je eigen gezicht te zien zonder een spiegel. ", "", context);
                AddQuotes("Het is beter fouten te maken op het vlak van durf dan op het vlak van voorzichtigheid.", "", context);
                AddQuotes("De tijd verandert ons niet maar ontplooit ons.", "", context);
                AddQuotes("Je merkt niet of het winter of zomer is als je gelukkig bent.", "", context);
                AddQuotes("We hebben geen grotere vijand dan onszelf.", "", context);
                AddQuotes("Onze grootste zwakheid ligt in opgeven. De succesvolste weg is altijd nog één keer proberen.", "", context);
                AddQuotes("Er worden vandaag, zoals elke dag, wereldwijd ongeveer 370.000 mensen geboren. Ze hebben elk een eigen boodschap voor ons.", "", context);
                AddQuotes("Niemand kan volmaakt vrij zijn als niet alle mensen vrij zijn. Niemand kan volmaakt gelukkig zijn als niet alle mensen gelukkig zijn.", "", context);
                AddQuotes("Ik zou willen dat mensen konden bereiken wat ze denken dat hen gelukkig maakt, om dan te beseffen dat daarin het geluk niet zit.", "", context);
                AddQuotes("Sommige mensen willen dat het gebeurt, sommigen wensen dat het gebeurt, anderen doen het gebeuren.", "", context);
                AddQuotes("Een gelukkig mens zit niet in een gelukkig stel omstandigheden maar heeft een gelukkig stel attitudes.", "", context);
                AddQuotes("Waar ik ook ben, ik ga altijd bij een raam staan te verlangen ergens anders te zijn.", "", context);
                AddQuotes("Als we het maar blijven uitleggen, stoppen we met elkaar te begrijpen.", "", context);
                AddQuotes("De werkelijke perfectie van de mens ligt niet in wat hij heeft maar in wat hij is.", "", context);
                AddQuotes("Je leert lopen door te doen en te vallen. Ik ben bereid om wat dan ook één keer te proberen.", "", context);
                AddQuotes("Sommige mensen willen ook nog boter op hun geluk.", "", context);
                AddQuotes("Waarom brengen mensen hun tijd op een droevige manier door als ze dat ook op een gelukkige manier kunnen doen?", "", context);
                AddQuotes("Je helpt je geluk vooruit door de gewoonte aan te leren om mogelijkheden te zien", "", context);
                AddQuotes("Meer mensen zouden zich moeten verontschuldigen en meer mensen zouden die verontschuldigingen moeten aanvaarden, als ze oprecht bedoeld zijn.", "", context);
                AddQuotes("Ik denk dat elke mens een eindig aantal hartslagen heeft. Ik ben niet van plan om er daarvan veel te verliezen.", "", context);
                AddQuotes("Als mensen nooit iets onnozels deden, zou er nooit iets intelligents gebeuren. ", "", context);

                //AddQuotes("‘Ik wil alles worden wat ik kan worden.’ Katherine Mansfield, Nieuw-Zeelands schrijfster", "Ga vandaag op zoek naar dat ene talent van je dat nog wat verborgen zit. Geef het een kans om te groeien.", context);
            }
            //context.SaveChanges();
        }

        private static void AddCat(string v, LBIContext context)
        {
            var c = new Category()
            {
                Name = v
            };
            context.CategoryDb.Add(c); 
        }

        private static Agenda AddAgenda(DateTime date, List<AgendaItem> i, LBIContext _context)
        {
            var a = new Agenda()
            {
                Date = date,
                AgendaItems = new List<AgendaItem>() 
            };
            foreach(var element in i)
            {
                a.AgendaItems.Add(element); 
            }
            return a; 
           
        }

        private static UserCategory AddUserCat(int id, string color, LBIContext _context)
        {
            var c = new UserCategory()
            {
                IdealValue = 0,
                CategoryId = id, 
                Color = color, 
            };
            return c; 
        }
        private static Goals AddGoal(string _goal, DateTime _beginTime, DateTime _endTime, int _progress, int _amount, LBIContext _context)
        {
            var gl = new Goals()
            {
                Goal = _goal,
                BeginTime = _beginTime,
                EndTime = _endTime,
                Progress = _progress,
                Amount = _amount,
                Percentage = (double)_progress/(double)_amount
            };
            return gl; 
        }
        private static EigenNetwerk AddEigenNetwerk(string Name, string Email, string Nummer, LBIContext _context)
        {
            var n = new EigenNetwerk()
            {
                Name = Name,
                Email = Email,
                Nummer = Nummer
            };
            return n; 
        }

        private static void AddBron(string _description, string _icon, string _site, string _mail, bool _isMail,  string _phone, string _forum, string _chat, string _chatLink, LBIContext _context )
        {
            var bron = new Externe_bron()
            {
                Description = _description,
                SmallDescription = _description.Substring(0,30) + "...",
                Icone = "https://lifebalanceimprovement.azurewebsites.net/assets/" + _icon,
                Site = _site,
                Mail = _mail,
                IsMail = _isMail,
                Phone = _phone,
                Forum = _forum,
                Chat = _chat,
                ChatLink = _chatLink
            };
            _context.Externe_bronDb.Add(bron);
            _context.SaveChanges();
        }
        
        private static void AddQuotes(string _quote, string _tip, LBIContext _context)
        {
            var quote = new Quotes()
            {
                quote = _quote,
                tip = _tip
            };
            _context.QuotesDb.Add(quote);
            _context.SaveChanges();
        }
        private static MomentKader AddMomentKader(string _gedachte, string _emotie, string _lichaam, LBIContext _context)
        {
            var momentkader = new MomentKader()
            {
                Emotie = _emotie,
                Gedachte = _gedachte,
                Lichaam = _lichaam
            };
            return momentkader; 
        }
        private static void AddMindfulness(string _title, string _description, LBIContext _context)
        {
            var mindfulness = new Mindfulness()
            {
                Title = _title,
                Description = _description
            };
            _context.MindfulnessDb.Add(mindfulness);
            _context.SaveChanges();
        }

        private static void AddHappiness(string _description, LBIContext _context)
        {
            //nakijken ofdat de lengte wel hoger is dan 30 anders is smal description gelijk aan description
            var happiness = new Happiness();
            if (_description.Length > 30) {
                happiness = new Happiness()
                {
                    SmallDescription = _description.Substring(0, 30) + "...",
                    Description = _description
            };
            }
            else
            {
                happiness = new Happiness()
                {
                    SmallDescription = _description,
                    Description = _description
                };
            }
            _context.HappinessDb.Add(happiness);
            _context.SaveChanges();

        }

        public static void AddUser(string name, string email, string guid, List<MomentKader> momentKader, List<EigenNetwerk> eigenNetwerk, List<Goals> goals, List<UserCategory> categories, List<Agenda> agendas, List<UserHappiness> userHappiness, LBIContext _context)
        {
            var user = new Users()
            {
                GUID = guid,
                Name = name,
                Note = "",
                FirstLoginStats = false,
                MomentKaders = momentKader, 
                EigenNetwerken = eigenNetwerk, 
                Goals = goals, 
                UserCategories = categories, 
                Agendas = agendas, 
                UserHappiness = userHappiness
            };
            _context.UsersDb.Add(user);
            _context.SaveChanges();
        }
    }
}

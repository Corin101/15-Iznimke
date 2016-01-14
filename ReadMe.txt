Iznimke
=======

HvatanjeIznimke
---------------
Ilustracija odvajanja glavne logike od dijela koji hvata i obra�uje iznimku
te oporavlja program.


TijekIzvodjenja
---------------
Ispis tijeka izvo�enja try-catch-finally blokova


FltarIznimki
------------
Primjer filtra iznimki.


BacanjeIznimkeUPozvanojMetodi
-----------------------------
Primjer izvo�enja try-catch-finally kada je iznimka ba�ena unutar pozvane metode.


RukovateljNeobradjenihIznimki
----------------------------
Primjer definiranja obrade UnhandledException doga�aja
Ovo omogu�ava da zapi�emo sve neuhva�ene iznimke (npr. u log datoteku), 
no program �e jo� uvijek imati unhandled exception!


IznimkeWinForms
---------------
Primjer pona�anja WinForms aplikacije kod neobra�ene iznimke.


IznimkePerfMon
--------------
Program generira iznimke u odre�enim vremenskim intervalima da bismo
ih mogli pratiti u PERFMON aplikaciji
TODO: 
1. Izgraditi program IznimkePerfmon
2. Pokrenut program iz Windows (ne iz Visual Studija)
3. U Windowsima potra�iti program PerfMon (Performance Monitor) te ga pokrenuti
4. U PerfMon-u kliknuti na crveni + i u popisu broja�a potra�iti .NET CLR Exceptions
5. Pro�iriti stavku .NET CLR Exceptions i u njoj odabrati "# of Exceps Thrown"" 
6. U popisu objekata potra�iti i selektirati "IznimkePerfMon" te pritisnuti tipku Add
7. U programu IznimkePerfmon pritisnuti tipku za bacanje iznimki te pratiti prikaz u PerfMonu


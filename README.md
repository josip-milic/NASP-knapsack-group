Sveučilište u Zagrebu<br>
<a href="http://www.fer.unizg.hr">Fakultet elektrotehnike i računarstva</a>

# <a href="http://www.fer.unizg.hr/predmet/nasp">Napredni algoritmi i strukture podataka</a>

2015./2016.

# Tema projekta: Dinamičko programiranje (grupni problem naprtnjače)


(c) 2016 Josip Milić

*Verzija 1.0*

Datum: **07.12.2015.**<br>

###Opis projekta:
####Program dinamičkim programiranjem rješava problem u kojem svaka kategorija ima konačni broj podkategorija, a može se uzeti samo po jedan član tih podskupova.

Više informacija u <a href="https://github.com/josip-milic/NASP-knapsack-group/blob/master/NASP_LAB2_dinamicko_programiranje_0036456339">dokumentaciji.</a>

Programski jezik: C#

Opis korisničkog sučelja:

<img src="https://github.com/josip-milic/NASP-knapsack-group/blob/master/Slike/nasp_lab2_gui.png"></img>

Pomoću gumbiju se odabire i učitava datoteka s vrijednostima i cijena stvari.
Pomoću trećeg gumba može se saznati kako bi ta datoteka trebala izgledati (u
ovom dokumentu je opisan primjer filmske industrije, ali se program može koristiti
za bilo koji sličan problem koji sadrži stvari i grupe precizirane formatom
datoteke). Uz program su priložene datoteke primjeri.<br/><br/>
Učitavanjem datoteke se odmah pokreće rješavanje danog problema i zatim se
rješenje grafički prezentira pomoću tablice. <b>Crvenom</b> bojom se označava
element stvari koji se prvi uzima (gleda se od zadnjeg retka prema prvom). <b>Žutom</b>
bojom se označavaju elementi tablice koji su jednaki najboljem elementu
prethodne grupe za taj red. Primjerice na gornjoj slici, uzima se lijeva stvar jer se
za istu cijenu dobiva veća vrijednost. <b>Zelenom</b> bojom se označavaju elementi koji
su najbolji u redu i grupi koja se gleda i koji su nastali zbrajanjem vrijednosti stvari
i vrijednosti gornjeg elementa prethodne grupe. Stvari su tablicama označene
različitom bojom (parne grupe svjetlo plavom, a neparne bijelom bojom).
U listi su prezentirane uzimane stvari kao i imena grupa kojima pripadaju. Uz nju
su napisani maksimalno postignuti zbrojevi cijena za traženi zbroj cijena i ukupan
zbroj cijena odabranih stvari.<br/><br/>
U gornjoj tablici su prikazane stvari i njihove vrijednosti i cijene. Svaka vrijednost
i cijena se mogu mijenjati, kao i traženi zbroj cijena. Potrebno je pritisnuti gumbe
Osvježi kako bi se prihvatili novi podaci čime se pokreće novo računanje i
prezentacija rješenja.


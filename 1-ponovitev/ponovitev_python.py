# Naloga 1

import random
import os

def ugibanje():
    '''Program si izmisli število [1, 100], uporabnik ga ugiba.'''
    program = random.randint(1, 100)
    try:
        uporabnik = int(input('Vpiši število med 1 in 100: '))
    except:
        raise ValueError('Nisi vpisal števila.')
    while uporabnik != program:
        if uporabnik > program:
            print('MANJ')
        else:
            print('VEČ')
        try:
            uporabnik = int(input('Vpiši število med 1 in 100.'))
        except:
            raise ValueError('Nisi vpisal števila.')
    print('UGANIL SI :)')

# ugibanje()


# Naloga 2


# Naloga 3

def poisci_mapo(pot_do_mape):
    '''Vrne ime mape z največ datotekami in število datotek v njej.'''
    velikost = 0 # Velikost trenutne mape
    naj_podmapa = None
    naj_velikost_podmape = 0
    for datoteka in os.listdir(pot_do_mape):
        polno_ime = os.path.join(pot_do_mape, datoteka)
        if os.path.isfile(polno_ime):
            velikost += 1
        else: # Imenik
            ime_podmape, velikost_podmape = poisci_mapo(polno_ime)
            if velikost_podmape > naj_velikost_podmape:
                naj_velikost_podmape = velikost_podmape
                naj_podmapa = ime_podmape
    if velikost > naj_velikost_podmape:
        return pot_do_mape, velikost
    else:
        return naj_podmapa, naj_velikost_podmape

pot = os.path.join('C:', 'Program Files', 'Java')
print(poisci_mapo(pot))

# Naloga 4

def lego_kocke(sez_kock):
    '''Iz seznama lego kock naredi slovar {oblika : barva}.'''
    slovar_kock = dict()
    for kocka in sez_kock:
        (oblika, barva) = kocka.split('.')
        slovar_kocke = slovar_kock.get(oblika, dict())
        slovar_kocke[barva] = slovar_kocke.get(barva, 0) + 1
        slovar_kock[oblika] = slovar_kocke
    return slovar_kock

print(lego_kocke(['2x2.rdeca', '2x2.rdeca', 'nogice.modra', '2x2.modra']))



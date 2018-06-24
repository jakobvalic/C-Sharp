import time


def izrisi_sahovnico(sahovnica):
    '''Izriše šahovnico po vrsticah.'''
    for vr in sahovnica:
        print(vr)


def dovoljeno_polje(sahovnica, kraljica):
    '''Pove, ali je kraljica lahko na dovoljenem polju. Kraljica ima koordinate (i, j).'''
    if sahovnica[kraljica[0]][kraljica[1]] != 0:
        return False
    levo_desno_gor_dol = [(0,-1), (0,1), (1,0), (-1,0)]
    diagnale = [(-1,-1), (-1,1), (1,-1), (1, 1)]
    vektorji_premika = levo_desno_gor_dol + diagnale
    for vektor_premika in vektorji_premika:
        (i, j) = kraljica
        (i_vektorja, j_vektorja) = vektor_premika
        while 0 <= i + i_vektorja < len(sahovnica) and 0 <= j + j_vektorja < len(sahovnica):
            i += i_vektorja
            j += j_vektorja
            if sahovnica[i][j] != 0:
                return False
    return True


def postavljaj_kraljice(sahovnica):
    '''Postavlja kraljice in jih premika, dokler ne dobi nezasedenega prostora.
    Če ne more postaviti v določeno vrstico, pokliče fn za premikanje kraljic.'''
    (i_zadnje, j_zadnje) = poisci_zadnjo_kraljico(sahovnica)
    if i_zadnje == len(sahovnica) - 1: # Kot argument smo podali rešitev, s katero želimo nadaljevati iskaje še drugih rešitev.
        premakni_kraljico_za_eno_naprej(sahovnica)
    for i in range(i_zadnje + 1, len(sahovnica)):
        for j in range(len(sahovnica)):
            if dovoljeno_polje(sahovnica, (i,j)):
                # Dobili smo mesto, na katero lahko postavimo kraljico
                sahovnica[i][j] = KRALJICA
        # Če v trenutni vrstici nismo mogli postaviti kraljice, pokličemo funkcijo za premikanje kraljic
        if KRALJICA not in sahovnica[i]:
            return premakni_kraljico_za_eno_naprej(sahovnica) # pokličemo funkcijo za prestavljanje kraljic
    if KRALJICA not in sahovnica[0]: # Premaknili smo kraljico v prvi vrstici.
        return False
    return sahovnica



def poisci_zadnjo_kraljico(sahovnica):
    '''Vrne indeks zadnje kraljice. Če na šahovnici ni nobene kraljice, sproži izjemo.'''
    for i in range(len(sahovnica) - 1, -1, -1):
        vrstica = sahovnica[i]
        if KRALJICA in vrstica:
            return (i, vrstica.index(KRALJICA))
    return (-1, -1)

def premakni_kraljico_za_eno_naprej(sahovnica):
    '''Premakne kraljico na prvo prosto polje v vrstici. Vrne šahovnico s premaknejno kraljico.'''
    (i, j_zadnje) = poisci_zadnjo_kraljico(sahovnica)
    if (i, j_zadnje) == (-1, -1):
        # Prišli smo do situacije, kjer ni več kraljic na plošči.
        return sahovnica
    sahovnica[i][j_zadnje] = 0 # Odmaknemo kraljico
    for j in range(j_zadnje + 1, len(sahovnica)): # Premikamo kraljico naprej, na prvo prosto polje
        if dovoljeno_polje(sahovnica, (i, j)):
            sahovnica[i][j] = KRALJICA # Dobili smo prosto polje, na katero lahko postavimo kraljico
            return postavljaj_kraljice(sahovnica) # Postavljamo naprej kraljice
    # Zanka se je iztekla in v vrstici nismo dobili polja, na katerega bi lahko postavili kraljico.
    # Zato začnemo premikati kraljico, ki je v zgornji vrstici.
    return premakni_kraljico_za_eno_naprej(sahovnica)


KRALJICA = 1

# Podatki za preverjanje

riši = False
min_velikost = 4
max_velikost = 12
velikosti = range(min_velikost, max_velikost + 1)
for velikost_polja in velikosti:
    s0 = [[0 for _ in range(velikost_polja)] for _ in range(velikost_polja)]
    
    stevec_resitev = 1
    začetek = time.time()

    for _ in range(1000):
        resitev = postavljaj_kraljice(s0)
        if not resitev:
            break # Prva kraljica je šla dol s polja
        if riši:
            print("Rešitev številka {}:".format(stevec_resitev))
            izrisi_sahovnico(resitev)
            print()
        s0 = resitev
        stevec_resitev += 1

    print('Velikost polja: {}\nŠtevilo rešitev: {} \nČas: {}'.format(velikost_polja, stevec_resitev-1, time.time() - začetek))
    input('Pritisni ENTER za nadaljevanje\n')

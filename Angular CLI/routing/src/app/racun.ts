export interface IRacun {
    racunId: number,
    brojRacuna: string,
    klijentId: number,
    korisnikId: number,
    datum: Date,
    datumRacuna: Date,
    datumDospjeca: Date,
    skladisteUlazId: number,
    skladisteIzlazId: number,
    evidencijskiBroj: string,
    iznosRacuna: number,
    iznosPoreza: number,
    kupacId: number,
    vrstaPlacanjaId: number,
    godina: number,
    dokumentId: number,
    valutaId: number,
    placen: boolean,
    napomena: string
}
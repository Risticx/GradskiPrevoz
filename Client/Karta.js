export class Karta {
    constructor(id, brojKarte, vremeIzdavanja, cenaKarte, radnikIme, radnikPrezime) {
        this.id = id;
        this.brojKarte = brojKarte;
        this.vremeIzdavanja = vremeIzdavanja;
        this.cenaKarte = cenaKarte;
        this.radnikIme = radnikIme;
        this.radnikPrezime = radnikPrezime;
    }

    crtaj(host) {

        var tr = document.createElement("tr");
        host.appendChild(tr);
        
        var td = document.createElement("td");
        td.innerHTML = this.brojKarte;
        tr.appendChild(td);

        td = document.createElement("td");
        td.innerHTML = this.vremeIzdavanja;
        tr.appendChild(td);

        td = document.createElement("td");
        td.innerHTML = this.cenaKarte + " RSD";
        tr.appendChild(td);

        td = document.createElement("td");
        td.innerHTML = this.radnikIme;
        tr.appendChild(td);

        td = document.createElement("td");
        td.innerHTML = this.radnikPrezime;
        tr.appendChild(td);
        }
    }
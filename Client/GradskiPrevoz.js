import { Radnik } from "./Radnik.js";
import { Karta } from "./Karta.js";
export class GradskiPrevoz {

    constructor(listaLinija) {

        this.listaLinija = listaLinija;
        this.kont = null;
    }

    crtajRed(host)  {
        
        let red = document.createElement("div");
        red.classname= "red";
        host.appendChild(red);
        return red;
    }

    crtajFormu(host) {

        let se = document.getElementById("Linije");

        let op; 
        this.listaLinija.forEach(p => {
            op = document.createElement("option");
            op.innerHTML = p.brojLinije + ". " +p.nazivLinije;
            op.value = p.id;
            se.appendChild(op);
        })

        let btnIzaberi = document.getElementById("Nastavi");
        let btnKarte = document.getElementById("Karte");

        btnIzaberi.onclick=(ev)=>this.prikaziKonduktera();
        btnKarte.onclick=(ev)=>this.prikaziKarte();
    }


    prikaziKarte() {
        
        let karta = document.getElementById('Karta');
        karta.classList.add('d-none');

        let kondukter = document.getElementById('Kondukter');
        kondukter.classList.add('d-none');

        let karte = document.getElementById('KarteK');
        karte.classList.remove('d-none');

        let tabela = document.getElementById('tabela');
        karte.appendChild(tabela);
        
        let tabelabody = document.createElement("tbody");
        tabela.appendChild(tabelabody);

        fetch("https://localhost:5001/Karta/PreuzmiKarte")
            .then(p => {
                this.obrisiPrethodniSadrzaj()
                var telotabele = document.querySelector("tbody");
                p.json().then(karte => {
                    karte.forEach(karta => {
                        let k = new Karta(karta.id, karta.brojKarte, karta.vremeIzdavanja, karta.cenaKarte, karta.ime, karta.prezime);
                        k.crtaj(telotabele);
                    });
                })
            })
            
    }

    obrisiPrethodniSadrzaj() {
        var telotabele = document.querySelector("tbody");
        var roditelj = telotabele.parentNode;
        roditelj.removeChild(telotabele);

        telotabele = document.createElement("tbody");
        roditelj.appendChild(telotabele);
    }

    prikaziKonduktera() {

        let karta = document.getElementById('Karta');
        karta.classList.add('d-none');

        let karte = document.getElementById('KarteK');
        karte.classList.add('d-none');

        let kondukter = document.getElementById('Kondukter');
        kondukter.classList.remove('d-none');
        let kondukterKont = document.getElementById('KondukterKontainer');
        
        let optionEl = document.getElementById('Linije');
        var linijaID = optionEl.options[optionEl.selectedIndex].value;

        if(linijaID == "") return;
        
        let lblKondukter = document.getElementById('lblKondukter1');
        let red = this.crtajRed(kondukterKont);
        red.appendChild(lblKondukter);

        fetch("https://localhost:5001/GradskiPrevoz/PreuzmiRadnike/" + linijaID)
        .then(p => p.json())
        .then(data => {
            var radnik = data.ime + " " + data.prezime;
            lblKondukter.innerHTML = radnik;
        })

    
        let lblCena = document.getElementById("lblCenaKondukter");
        let red1 = this.crtajRed(kondukterKont);
        red1.appendChild(lblCena);

        var uCena;
        fetch("https://localhost:5001/GradskiPrevoz/PreuzmiCenu/" + linijaID)
        .then(p => p.json())
        .then(data => {
            var cena = data;
            lblCena.innerHTML = "Cena: " + cena + " RSD";
            uCena = cena;
        })
        
        let btnKupi = document.getElementById("btnKupi");
        let red2 = this.crtajRed(kondukterKont);
        red2.appendChild(btnKupi);

        btnKupi.onclick=(ev)=>this.stampajKartu(uCena);
    }

    stampajKartu(uCena) {

        let brojKarte = null;

        let kondukter = document.getElementById('Kondukter');
        kondukter.classList.add('d-none');

        let karte = document.getElementById('KarteK');
        karte.classList.add('d-none');

        let karta = document.getElementById('Karta');
        let kartaKont = document.getElementById('KartaKontainer');
        karta.classList.remove('d-none');
        var lblKondukter = document.getElementById('lblKondukter1').innerHTML;
        
        let lblKarta = document.getElementById("lblKartaP");
        let red0 = this.crtajRed(kartaKont);
        red0.appendChild(lblKarta);


        let lblZona = document.getElementById("lblZona");
        let red1 = this.crtajRed(kartaKont);
        red1.appendChild(lblZona);


        let lblBroj = document.getElementById("lblBrojKarta");
        let red = this.crtajRed(kartaKont);
        red.appendChild(lblBroj);

        fetch("https://localhost:5001/Karta/KartaMax/")
        .then(p => p.json())
        .then(data => {
            brojKarte = data;
            brojKarte += 1;
            lblBroj.innerHTML ="Broj karte: " + data;
        })

        let optionEl = document.getElementById('Linije');
        var linijaIme = optionEl.options[optionEl.selectedIndex].textContent;
        var linijaID = optionEl.options[optionEl.selectedIndex].value; 


        let lblLinija = document.getElementById("lblLinija");
        lblLinija.innerHTML = "Linija: " + linijaIme;
        let red2 = this.crtajRed(kartaKont);
        red2.appendChild(lblLinija);

        
        let lblDatum = document.getElementById("lblDatum");
        var dt = new Date();
        lblDatum.innerHTML = "Datum: " + dt.toDateString("");
        let red3 = this.crtajRed(kartaKont);
        red3.appendChild(lblDatum);

        
        let lblVreme = document.getElementById("lblVreme");
        var dt = new Date();
        lblVreme.innerHTML = "Vreme: " + dt.getHours() + ":" 
        + dt.getMinutes() + ":" + dt.getSeconds();
        let red4 = this.crtajRed(kartaKont);
        red4.appendChild(lblVreme);


        let lblReg = document.getElementById("lblReg");
        let red5 = this.crtajRed(kartaKont);
        red5.appendChild(lblReg);
        
        fetch("https://localhost:5001/Karta/PreuzmiReg/" + linijaID)
            .then(p => p.json())
            .then(data => {
                var registracija = data;
                lblReg.innerHTML = "Registarska oznaka: " + registracija; 
        })

        fetch("https://localhost:5001/Karta/PreuzmiZonu/" + linijaID)
        .then(p => p.json())
        .then(data => {
            var zona = data;
            lblZona.innerHTML = "Zona: " + zona; 
        })


        var lblkond = document.getElementById("lblKondukter");
        lblkond.innerHTML = "Kondukter: " + lblKondukter;
        let red6 = this.crtajRed(kartaKont);
        red6.appendChild(lblkond);

        
        let lblKartaK = document.getElementById("lblKartaK");
        let red7 = this.crtajRed(kartaKont);
        red7.appendChild(lblKartaK);

        
        fetch("https://localhost:5001/GradskiPrevoz/PreuzmiRadnike/" + linijaID)
        .then(p => p.json())
        .then(data => {
            var radnikID = data.id;
            fetch("https://localhost:5001/Karta/DodajKartu/" + brojKarte + "/" + uCena + "/" + radnikID,
            {
                method : "POST"
            });
        })
    }   
}
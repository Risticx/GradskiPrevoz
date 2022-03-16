import { GradskiPrevoz } from "./GradskiPrevoz.js";
import { Linija } from "./Linija.js";

var listaLinija = [];


fetch("https://localhost:5001/GradskiPrevoz/PreuzmiLinije")
.then(p => {
    p.json().then(linije => {
        linije.forEach(linija => {
            var l = new Linija(linija.id, linija.brojLinije, linija.nazivLinije);
            listaLinija.push(l);
        });

        var g = new GradskiPrevoz(listaLinija);
        g.crtajFormu(document.body);
    })
})


let EctoMorfo = document.getElementById("chkEctomorfo");
let MesoMorfo = document.getElementById("chkMesomorfo");
let EndoMorfo = document.getElementById("chkEndomorfo");

EctoMorfo.addEventListener("change", () => {
    MesoMorfo.disabled = !MesoMorfo.disabled;
    EndoMorfo.disabled = !EndoMorfo.disabled;
});

MesoMorfo.addEventListener("change", () => {
    EctoMorfo.disabled = !MesoMorfo.disabled;
    EndoMorfo.disabled = !EndoMorfo.disabled;
});

EndoMorfo.addEventListener("change", () => {
    EctoMorfo.disabled = !MesoMorfo.disabled;
    MesoMorfo.disabled = !EndoMorfo.disabled;
})
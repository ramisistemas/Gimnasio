let checkboxBasico = document.getElementById("basico");
let checkboxIntermedio = document.getElementById("intermedio");
let checkboxAvanzado = document.getElementById("avanzado");

checkboxBasico.addEventListener("change", () => {
    checkboxIntermedio.disabled = !checkboxIntermedio.disabled;
    checkboxAvanzado.disabled = !checkboxAvanzado.disabled;
});

checkboxIntermedio.addEventListener("change", () => {
    checkboxBasico.disabled = !checkboxBasico.disabled;
    checkboxAvanzado.disabled = !checkboxAvanzado.disabled;
});

checkboxAvanzado.addEventListener("change", () => {
    checkboxBasico.disabled = !checkboxBasico.disabled;
    checkboxIntermedio.disabled = !checkboxIntermedio.disabled;
})
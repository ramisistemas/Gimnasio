// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function uncheck() {
  var checkbox1 = document.getElementById("basico");
  var checkbox2 = document.getElementById("intermedio");
  var checkbox3 = document.getElementById("avanzado");
  checkbox1.onclick = function () {
    if (checkbox1.checked != false) {
      checkbox2.checked = null;
      checkbox3.checked = null;
    }
  };
  checkbox2.onclick = function () {
    if (checkbox2.checked != false) {
      checkbox1.checked = null;
      checkbox3.checked = null;
      
    }
  };
  checkbox3.onclick = function () {
    if (checkbox3.checked != false) {
      checkbox1.checked = null;
      checkbox2.checked = null;      
    }
  };
  
}
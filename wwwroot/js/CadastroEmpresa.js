$(document).ready(function () {

    defineNavbar();
    defineMascaraCampo();
});

function defineMascaraCampo() {
    $("#CNPJ").mask("00.000.000/0000-00");
}

function defineNavbar() {
    $("#hConsulta").removeClass("active");
    $("#hEmpresas").addClass("active");
    $("#hFornecedores").removeClass("active");
}
$(document).ready(function () {

    defineNavbar();
    defineMascaraCampo();

    let date = new Date();
    $("#DataNascimento").val(date.getFullYear().toString() + '-' + (date.getMonth() + 1).toString().padStart(2, 0) +
        '-' + date.getDate().toString().padStart(2, 0));

    $(".contatoBase").find(".inputNum").val("Default");
});

function getPessoaFisicaSelecionada() {

    return $("#p1").is(":checked");
}

function onTipoChanged() {
    let divPessoaFisica         =  $("#pessoaFisica");

    getPessoaFisicaSelecionada() ? divPessoaFisica.show() : divPessoaFisica.hide();
    defineMascaraCampo();
}

function defineMascaraCampo() {
    $("#CPF_CNPJ").val("");
    $("#CPF_CNPJ").mask(getPessoaFisicaSelecionada() ? "000.000.000-00" : "00.000.000/0000-00");
}

function defineNavbar() {
    $("#hConsulta").removeClass("active");
    $("#hEmpresas").removeClass("active");
    $("#hFornecedores").addClass("active");
}

function adicionarCamposTelefone() {
    let qtdTelefonesAtual = $(".telefone").length;
    let fieldset          = $(".contatoBase").clone();
    let divTelefones      = $("#divTelefones");

    fieldset.removeClass("contatoBase");

    $(fieldset).find(".inputNum").val("");

    $(fieldset).find(".labelNum").text(`Número do telefone ${qtdTelefonesAtual}`);

    $(fieldset).find(".inputNum").attr("id", `Telefones_${qtdTelefonesAtual}__NumeroTelefone`);
    $(fieldset).find(".inputNum").attr("name", `Telefones[${qtdTelefonesAtual}].NumeroTelefone`);

    $(fieldset).find(".spanNum").attr("data-valmsg-for", `Telefones[${qtdTelefonesAtual}].NumeroTelefone`);

    divTelefones.append(fieldset);
    fieldset.show();

    $(fieldset).find(".inputNum").focus(function () {
        $(".inputNum").mask("(00) 0000-00009");
    });

    $(fieldset).find(".inputNum").keyup(function () {

        let input = $(".inputNum");
        input.val().length <= 14 ? input.mask("(00) 0000-00009") : input.mask("(00) 00000-0009");
    });
}
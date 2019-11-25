$(document).ready(function () {

    $("#inputBusca").on("keyup", function () {

        var valorBusca = $(this).val().toLowerCase();
        var colunaSelecionada = $(".selBusca option:selected").val();

        var linhas = $("#bodyFornecedores tr");

        $('#bodyFornecedores tr').each(function () {
            var conteudo = $(this).find("td").eq(colunaSelecionada).text();   

            if (!conteudo.toLowerCase().includes(valorBusca))
                $(this).addClass("colunaForaFiltro");
            else
                $(this).removeClass("colunaForaFiltro");
        });

    });
});

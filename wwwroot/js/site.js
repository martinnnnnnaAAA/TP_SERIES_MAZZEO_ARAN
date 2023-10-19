// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function MostrarActores(IdSerie) {
    $.ajax(
        {
            url: '/Home/VerDetalleActoresAjax',
            data: { IdSerie: IdSerie },
            type: 'GET',
            dataType: 'json',
            success: 
                function(response){
                    console.log(response);
                    let texto="";
                    $("#TituloSerie").html("Actores de la Serie");
                    for (let elem of response)
                    {
                        texto+= "Nombre: " + elem.nombre + "<br>";
                    }
                    $("#info").html(texto);
            },
        });
}

function MostrarTemporadas(IdSerie) {
    $.ajax(
        {
            url: '/Home/VerDetalleTemporadasAjax',
            data: { IdSerie: IdSerie },
            type: 'GET',
            dataType: 'json',
            success: 
                function(response){
                    console.log(response);
                    let texto="";
                    $("#TituloSerie").html("Temporadas de la Serie");
                    for (let elem of response)
                    {
                        texto+= "Temporada: " + elem.numeroTemporada + "<br>";
                        texto+= "Titulo: " + elem.tituloTemporada + "<br>";

                    }
                    $("#info").html(texto);
            },
        });
}

function MostrarMasInfo(IdSerie) {
    $.ajax(
        {
            url: '/Home/VerDetalleSerieAjax',
            data: { IdSerie: IdSerie },
            type: 'GET',
            dataType: 'json',
            success: 
                function(response){
                    console.log(response);
                    let texto="";
                    $("#TituloSerie").html("Información de la Serie");
                    for (let elem of response)
                    {
                        texto+= "Nombre: " + elem.nombre + "<br>";
                        texto+= "Año de inicio: " + elem.añoInicio + "<br>";
                        texto+= "Sinopsis: " + elem.sinopsis + "<br>";


                    }
                    $("#info").html(texto);
            },
        });
}

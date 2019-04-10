
$(() => {
    $("#reverse").on('click', function () {
        const text = $("#text").val();
        $.get('/home/getReversed', { text}, function (tr) {
            $("#reversed").val(tr.Text);
        });
    })
});//
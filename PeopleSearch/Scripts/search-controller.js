$(document).ready(function () {
    $('#searchName').keypress(function () {
        var val = this.value;
        console.log(val);
    });
});
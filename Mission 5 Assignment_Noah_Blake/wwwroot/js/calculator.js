$(function () {
    $("#calcBtn").on("click", function () {
        const hours = parseFloat($("#hours").val());
        const rate = parseFloat($("#rate").val());

        if (isNaN(hours) || hours <= 0) {
            alert("Please enter a positive number of hours.");
            $("#total").val("");
            return;
        }

        const total = hours * rate;
        $("#total").val(total.toFixed(2));
    });
});

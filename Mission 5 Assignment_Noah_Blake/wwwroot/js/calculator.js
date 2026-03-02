$(function () {
    // Bind the click handler once the DOM is ready.
    $("#calcBtn").on("click", function () {
        const hours = parseFloat($("#hours").val());
        const rate = parseFloat($("#rate").val());

        // Guard clause: only positive numeric hour values are allowed.
        if (isNaN(hours) || hours <= 0) {
            alert("Please enter a positive number of hours.");
            $("#total").val("");
            return;
        }

        // Compute and display a currency-style value with two decimals.
        const total = hours * rate;
        $("#total").val(total.toFixed(2));
    });
});

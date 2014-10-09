(
function () {
    
    $(document).ready(function () {
        console.log("Binding datepickers to date fields");
        $('.date').each(function () {
            $(this).datepicker({ format: 'dd/mm/yyyy' });
        });
    });


}
());
$(document).ready(function)(){
    $(document).on("click", '.open-book-model', function (e) {
        e.preventDefault();
        var url=$(this).attr("href")
      
        fetch(url)
            .then(response => response.json())
            .then(modalHtml => {
              $("quickModal .modal-dialog").html(modalHtml)
            });

        $("quicModal").modal("show")



    })

    $(document).ready(function)(){
        $(document).on("click", '.open-book-model', function (e) {
            e.preventDefault();
            var url = $(this).attr("href")

            fetch(url)
                .then(response => response.json())
                .then(modalHtml => {
                    $("quickModal .modal-dialog").html(modalHtml)
                });

            $("quicModal").modal("show")



        })
   
})
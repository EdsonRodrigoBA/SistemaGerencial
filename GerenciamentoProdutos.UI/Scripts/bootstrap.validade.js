$.validator.setDefaults({

    highlight: function (element) {

        $(element).
            closest('.form-group').
            find('label, input, select, textarea, span').
            addClass('is-invalid')
    },
    unhighlight: function (element) {

        $(element).
            closest('.form-group').
            find('label, input, select, textarea, span').
            removeClass('is-invalid')
    },
})
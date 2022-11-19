

$('#main_button').on('click', function(){
    $('#hits_button').removeClass('selected_discount_header');
    $('#intr_button').removeClass('selected_discount_header');
    $('#news_button').removeClass('selected_discount_header');
    $(this).addClass('selected_discount_header');
});

$('#hits_button').on('click', function(){
    $('#main_button').removeClass('selected_discount_header');
    $('#intr_button').removeClass('selected_discount_header');
    $('#news_button').removeClass('selected_discount_header');
    $(this).addClass('selected_discount_header');
});

$('#intr_button').on('click', function(){
    $('#main_button').removeClass('selected_discount_header');
    $('#hits_button').removeClass('selected_discount_header');
    $('#news_button').removeClass('selected_discount_header');
    $(this).addClass('selected_discount_header');
});
$('#news_button').on('click', function(){
    $('#main_button').removeClass('selected_discount_header');
    $('#hits_button').removeClass('selected_discount_header');
    $('#intr_button').removeClass('selected_discount_header');
    $(this).addClass('selected_discount_header');
});


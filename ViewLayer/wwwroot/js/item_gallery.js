function imageGallery()
{
    const highlight=document.querySelector(".gallery_highlight");
    const previews = document.querySelectorAll(".gallery_preview img");

    previews.forEach(preview => {
        preview.addEventListener('click', function(){
            const smallSrc = this.src;
            highlight.src=smallSrc;
        });
    });

}

let minus = document.getElementById("minus_button")
let plus = document.getElementById("plus_button")
let count = document.getElementById("count_items")
let price = document.getElementById("item_price")


minus.addEventListener("click", function(){
    
    if(count.textContent <=1)
    {
        count.textContent = 1;
    }else
    {
        count.textContent=parseInt(count.textContent)-1;

    }
});
plus.addEventListener("click", function(){
    
    if(count.textContent >=999)
    {
        count.textContent = 1;
    }else
    {
        count.textContent=parseInt(count.textContent)+1;
        
    }
});
minus.addEventListener("click", function(){
    console.log()
    if(count.textContent <=1)
    {
        count.textContent = 1;
    }else
    {
        count.textContent-=1;
    }
});

imageGallery()


let button_desc = document.getElementById("button_desc")
let button_char = document.getElementById("button_char")
let button_ques = document.getElementById("button_question")

let div_desc = document.getElementById("more_item_description_desc")
let div_char = document.getElementById("more_item_description_char")
let div_ques = document.getElementById("more_item_description_question")


button_desc.addEventListener("click", function(){
    div_desc.style.display = "block";
    div_char.style.display = "none";
    div_ques.style.display = "none";
});



button_char.addEventListener("click", function(){
    div_desc.style.display = "none";
    div_char.style.display = "block";
    div_ques.style.display = "none";
});


button_ques.addEventListener("click", function(){
    div_desc.style.display = "none";
    div_char.style.display = "none";
    div_ques.style.display = "block";
});
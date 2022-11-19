setTimeout(100)
window.onload = function ()
{   
    
    let el = document.getElementById("index_items_cart")
    var count = parseInt(el.textContent);
    console.log(count)
    const boxes = document.querySelectorAll('.discount_compare');

   
    for (const box of boxes) {
    box.addEventListener('click', function handleClick() {
        console.log(count)
        if (box.classList.contains("discount_compare_fixed"))
        {
            count--;
            if (count >= 1)
            {
                el.style.background = "#337AB7";
            }else
            {
                el.style.background = "gray";
            }
            

            box.classList.remove('discount_compare_fixed');
            el.textContent = count;
        }else
        {
            count++;
            if (count >= 1)
            {
                el.style.background = "#337AB7";
            }
            if (count > 9)
            {
                el.textContent="9+"
            }else
            {
                el.textContent = count;    
            }
            
            
            box.classList.add('discount_compare_fixed');
            box.style.display = "block";
        }
    

});
}


}




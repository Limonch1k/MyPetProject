let disc = document.getElementById("discount_main")
let news = document.getElementById("discount_news")
let hits = document.getElementById("discount_hits")
let intr = document.getElementById("discount_intrests")

let disc_b = document.getElementById("main_button")
let news_b = document.getElementById("news_button")
let intr_b = document.getElementById("intr_button")
let hits_b = document.getElementById("hits_button")


document.getElementById("main_button").onclick = function ()
{
    disc.style.display = "block";
    disc.style.top = "0";

    news.style.display = "none";
    news.style.top = "-999px";
    
    hits.style.display = "none";
    hits.style.top = "-999px";
    
    intr.style.display = "none";
    intr.style.top = "-999px";
    
    console.log("1")
}


news_b.onclick = function ()
{
    news.style.display = "block";
    news.style.top = "0";

    disc.style.display = "none";
    disc.style.top = "-999px";
    
    hits.style.display = "none";
    hits.style.top = "-999px";
    
    intr.style.display = "none";
    intr.style.top = "-999px";
    console.log("2")
}

intr_b.onclick = function ()
{
    intr.style.display = "block";
    intr.style.top = "0";

    disc.style.display = "none";
    disc.style.top = "-999px";
    
    hits.style.display = "none";
    hits.style.top = "-999px";
    
    news.style.display = "none";
    news.style.top = "-999px";
    
    console.log("3")
}


hits_b.onclick = function ()
{
    hits.style.display = "block";
    hits.style.top = "0";

    disc.style.display = "none";
    disc.style.top = "-999px";
    
    intr.style.display = "none";
    intr.style.top = "-999px";
    
    news.style.display = "none";
    news.style.top = "-999px";
    
    console.log("4")
}



document.getElementById("search_wrapper").onclick = function ()    
{
  let elem = document.getElementById('search_bar')
  elem.style.display = 'block';
  elem.style.top = '0';
}




document.getElementById("exit_button").onclick = function (e) {
    e.preventDefault();
    let elem = document.getElementById('search_bar')
    elem.style.display = 'none';
    elem.style.top = '-999px';
}


document.getElementById("href_request_call").onclick = function ()
{
  document.getElementById("request_call").style.top = "10%";
  document.getElementById("request_call").style.display = "block";
  
  document.getElementById("bg").style.display = "block";
}

document.getElementById("close_request_call").onclick = function ()
{
  document.getElementById("request_call").style.display = "none";
  document.getElementById("request_call").style.top = "-999px";
  document.getElementById("bg").style.display = "none";
}

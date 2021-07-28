// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



document.getElementById('all-tag').addEventListener('click',function(e){
    document.getElementById("all-tag").classList.add('nav-weight');
    document.getElementById("clothing-tag").classList.remove('nav-weight');
    document.getElementById("sports-tag").classList.remove('nav-weight');
    document.getElementById("other-tag").classList.remove('nav-weight');
    var x1 = document.getElementById("sports1");
  if (x1.style.display === "none") {
    x1.style.display = "block";
  }
  var x2 = document.getElementById("sports2");
  if (x2.style.display === "none") {
    x2.style.display = "block";
  }

    var y1 = document.getElementById("clothing1");

    if (y1.style.display === "none") {
        y1.style.display = "block";
      }

      var y2 = document.getElementById("clothing2");

    if (y2.style.display === "none") {
        y2.style.display = "block";
      }

    var z1 = document.getElementById("other1");

    if (z1.style.display === "none") {
          z1.style.display = "block";
        }

    var z2 = document.getElementById("other2");

    if (z2.style.display === "none") {
          z2.style.display = "block";
        }
});


document.getElementById('clothing-tag').addEventListener('click',function(e){
    document.getElementById("all-tag").classList.remove('nav-weight');
    document.getElementById("clothing-tag").classList.add('nav-weight');
    document.getElementById("sports-tag").classList.remove('nav-weight');
    document.getElementById("other-tag").classList.remove('nav-weight');
    var y1 = document.getElementById("clothing1");

    if (y1.style.display === "none") {
        y1.style.display = "block";
      }

      var y2 = document.getElementById("clothing2");

    if (y2.style.display === "none") {
        y2.style.display = "block";
      }
    document.getElementById('sports1').style.display = 'none';
    document.getElementById('sports2').style.display = 'none';
    document.getElementById('other1').style.display = 'none';
    document.getElementById('other2').style.display = 'none';
});

document.getElementById('sports-tag').addEventListener('click',function(e){
    document.getElementById("all-tag").classList.remove('nav-weight');
    document.getElementById("clothing-tag").classList.remove('nav-weight');
    document.getElementById("sports-tag").classList.add('nav-weight');
    document.getElementById("other-tag").classList.remove('nav-weight');
    var x1 = document.getElementById("sports1");
  if (x1.style.display === "none") {
    x1.style.display = "block";
  }
  var x2 = document.getElementById("sports2");
  if (x2.style.display === "none") {
    x2.style.display = "block";
  }
    document.getElementById('clothing1').style.display = 'none';
    document.getElementById('clothing2').style.display = 'none';
    document.getElementById('other1').style.display = 'none';
    document.getElementById('other2').style.display = 'none';
});

document.getElementById('other-tag').addEventListener('click',function(e){
    document.getElementById("all-tag").classList.remove('nav-weight');
    document.getElementById("clothing-tag").classList.remove('nav-weight');
    document.getElementById("sports-tag").classList.remove('nav-weight');
    document.getElementById("other-tag").classList.add('nav-weight');
    var z1 = document.getElementById("other1");

    if (z1.style.display === "none") {
          z1.style.display = "block";
        }

    var z2 = document.getElementById("other2");

    if (z2.style.display === "none") {
          z2.style.display = "block";
        }
    document.getElementById('clothing1').style.display = 'none';
    document.getElementById('clothing2').style.display = 'none';
    document.getElementById('sports1').style.display = 'none';
    document.getElementById('sports2').style.display = 'none';
});


document.getElementById('submit').addEventListener('click',function(e){

  document.getElementById('form').style.display = 'none';
});

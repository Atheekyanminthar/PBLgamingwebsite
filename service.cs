@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@400;500&family=Roboto&display=swap');
*{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    
}
body{
    background: url(806443.jpg);
    font-family: 'Poppins', sans-serif;
    height: 350vh;
}
.headerlogo{
    height: 200px;
    width: auto;
}
.container{
    width: 100%;
    height: 100vh;
    background: linear-gradient(rgba(0,0,0,0.5),rgba(0,0,0,0.5)), url(mm);
    background-size: cover;
    background-position: center;
    background-attachment: fixed;
}
header{
    width: 100%;
    height: 10vh;
    background:rgba(0,0,0,0.5);
    display: flex;
    align-items: center;
    justify-content: space-between;
}
.logo{
    width: 300px;
    height: 10vh;
    background: #550381;
    display: flex;
    align-items: center;
    justify-content: center;
    color: #fff;
    clip-path: polygon(0 0, 100% 0, 64% 100%, 0% 100%);
    padding: 10px;
    line-height: 1.3rem;
}
.logo p{
    width: 130px;
    margin-left: 10px;
    font-size: 20px;
}
.logo .fas{
    font-size: 50px;
}
ul.navbar{
    display: flex;
    list-style: none;
}
ul.navbar li{
    width: 120px;
}
ul.navbar li a{
    text-decoration: none;
    color: #ff0000;
    font-weight: bold;
}
ul.navbar li a.active{
    color: #FEC53A;
}
ul.navbar li a:hover:not(.active){
    color: #ffff00;
}
#btn{
    width: 250px;
    height: 10vh;
    background: #ff0000;
    color: #000;
    outline: none;
    border: none;
    clip-path: polygon(35% 0, 100% 0, 100% 100%, 0% 100%);
    font-size: 1.2rem;
    font-weight: bold;
    text-align: right;
    padding-right: 40px;
}
#btn .fas{
    margin-right: 10px;
}
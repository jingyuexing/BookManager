/*
* @Author: admin
* @Date:   2021-06-22 03:25:58
* @Last Modified by:   admin
* @Last Modified time: 2021-06-22 03:56:32
*/
document.onreadystatechange=function(){
    if(document.readyState === "complete"){
        var listRoot = document.getElementsByClassName("navbar-list")[0];
        var content = [
            "图书管理系统",
            "借阅",
            "还书"
        ];
        for(let i=0;i<content.length;i++){
            var navbarList = document.createElement("li");
            navbarList.classList.add(["list-item"]);
            navbarList.innerText = content[i];
            listRoot.appendChild(navbarList);

        }
    }
}
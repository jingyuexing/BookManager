/*
* @Author: Jingyuexing
* @Date:   2021-06-21 20:07:48
* @Last Modified by:   Jingyuexing
* @Last Modified time: 2021-06-21 20:48:43
*/
using System;
namespace BookManager.DAO{
    enum Lang{
        zh_CN = 0,
        en_UK = 1,
        jp_JP = 2,
        ru_RU = 3,
        DE_DE = 4,
        fr_FR = 5
    }
    class Book:DAO{
        int id;
        string code;
        string name;
        string author;
        string press;
        int pages;
        float price;
        string cover;
        Lang language;
        string brief;
        string imageURL;
        string status;
        Book(){

        }
        public object create(){
            return new object();
        }
        public object read(){
            return new object();
        }
        public object update(){
            return new object();
        }
        public void delete(){

        }
    }
}
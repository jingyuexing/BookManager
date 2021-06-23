/*
* @Author: Jingyuexing
* @Date:   2021-06-21 20:03:08
* @Last Modified by:   Jingyuexing
* @Last Modified time: 2021-06-21 21:06:01
*/
namespace BookManager.DAO{
    class ReaderDao :DAO{
        /**
         * 读者编号/借书证号
         */
        int id;
        /**
         * 读者姓名
         */
        string name;
        /**
         * 读者类别
         */
        int sex;
        /**
         * 单位代码/单位名称
         */
        string dept;
        /**
         * 电话号码
         */
        string phone;
        /**
         * 电子邮箱
         */
        string email;
        /**
         * 读者登记日期
         */
        float dateReg;
        /**
         * 读者照片
         */
        string photo;
        char[] status;
        int borrowQty;
        string pwd;
        int adminroles;
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
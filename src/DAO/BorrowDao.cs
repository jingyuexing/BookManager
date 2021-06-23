/*
* @Author: Jingyuexing
* @Date:   2021-06-21 20:23:19
* @Last Modified by:   Jingyuexing
* @Last Modified time: 2021-06-21 20:45:00
*/

namespace BookManager.DAO{
    class Borrow: DAO{
        /**
         * 借书序号 主键
         */
        int borrowID;
        /**
         * 读者序号 外键
         */
        int readerID;
        /**
         * 图书序号 外键
         */
        int bookID;
        /**
         * 续借次数
         */
        int continuetimes;
        /**
         * 借书日期
         */
        string dateOut;
        /**
         * 应还日期
         */
        string dateRetPlan;
        /**
         * 实际还书日期
         */
        string dateRetAct;
        /**
         * 超期天数
         */
        int overDay;
        /**
         * 超期罚金
         */
        float overMoney;
        /**
         * 罚款金额
         */
        float punishMoney;
        /**
         * 是否已经还书
         */
        byte isReturn;
        /**
         * 借书操作员
         */
        string operatorLend;
        /**
         * 还书操作员
         */
        string operatorRet;
        Borrow(){
            this.isReturn = 0;
            this.continuetimes = 0;
        }
        public object create(){
            string sql = "insert ";
            return new object();
        }
        public object read(){
            return new object();
        }
        public object update(){
            string sql = "update ";
            return new object();
        }
        public void delete(){

        }
    }
}
/*
* @Author: Jingyuexing
* @Date:   2021-06-21 19:47:10
* @Last Modified by:   Jingyuexing
* @Last Modified time: 2021-06-21 20:02:17
*/
namespace BookManager.DAO{
    class ReaderTypeDAO :DAO{
        /**
         * 读者类别
         */
        private int rdType;
        /**
         * 读者类别名称
         */
        private char[] TypeName;
        /**
         * 可借书数量
         */
        private int canLendQty;
        /**
         * @type int
         */
        private int canLendDay;
        /**
         * @type int
         */
        private int canContinueTimes;
        /**
         * 罚款率 (元/天)
         */
        private float punishRate;
        /**
         * 证书有效年限 非空 0表示永久有效
         */
        private int dateValid;
        /**
         * [create description]
         * @return {object} [description]
         */
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
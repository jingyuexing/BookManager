/*
* @Author: Jingyuexing
* @Date:   2021-06-21 19:24:00
* @Last Modified by:   Jingyuexing
* @Last Modified time: 2021-06-21 19:57:39
*/
namespace BookManager.DAO{
    /**
     * 定义dao层接口
     */
    public interface DAO{
        object create();
        object read();
        object update();
        void delete();
    }
}
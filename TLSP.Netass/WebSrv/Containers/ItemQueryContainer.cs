

namespace TLSP.Netass.WebSrv
{

    [WebSrvApi]
    public class ItemQueryContainer
    {
        //public async Task<List<T>> QueryItemListByIDs<T>(List<string> ItemIdList) where T : EntityBase, new()
        //{

        //    List<List<string>> idListLists = ItemIdList.Split(50);

        //    List<T> result = new List<T>();

        //    foreach (List<string> list in idListLists)
        //    {
        //        result.AddRange((await ExecuteList<T>(new EntityIdListReuquest(list), "/item/query/search-by-ids")).entities);
        //    }
        //    return result;
        //}

        [WebSrvApi("/item-key/query/search-keys-by-item-list-v2",Method.Post,EncryptionType.NormalEncryption)]
        public PostEntityListDelegate<ItemAuthorityEntity, ItemAuthorityQueryRequest> QueryItemAuthorityList;


        [WebSrvApi("/item/query/available")]
        public PostEntityListDelegate<ItemEntity, ItemAvailableQueryRequest> QueryAvailable;

        [WebSrvApi("/item/query/search-by-iid")]
        public PostEntityDelegate<ItemEntity, ItemIDRequest> QueryItemByID;

        [WebSrvApi("/secondary-type/query/search-by-master-type")]
        public PostEntityListDelegate<ItemSecondaryTypeEntity, MasterTypeRequest> QuerySecondaryType;
    }
}

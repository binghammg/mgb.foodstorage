using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace mgb.foodstorage
{
    [ServiceContract]
    public interface IFoodStorage
    {
        [OperationContract]
        int GetCategoryId(string sBarCode);

        [OperationContract]
        void MapBarCodeToCategory(String sBarCode, int iCategoryId);

        [OperationContract]
        void AddItem(int CategoryId, string Description, string Barcode);

        [OperationContract]
        StoredItem[] GetItems(String sBarCode);

        [OperationContract]
        void RemoveItem(int iStoredItemId);

        [OperationContract]
        void UpdateItem();
                      
        [OperationContract]
        void AddThreshold();

        [OperationContract]
        void DeleteThreshold();

        [OperationContract]
        void UpdateThreshold();

        [OperationContract]
        void GetAllItems();
                
    }    
}

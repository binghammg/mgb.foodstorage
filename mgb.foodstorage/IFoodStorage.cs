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
        void AddItem(int CategoryId, string Description, string Barcode);
        
        [OperationContract]
        void DeleteItem();
        
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

        [OperationContract]
        void GetItem();
    }    
}

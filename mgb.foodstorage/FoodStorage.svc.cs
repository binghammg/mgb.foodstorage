using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace mgb.foodstorage
{    
    public class FoodStorage : IFoodStorage
    {
        public void AddItem(int CategoryId, string Description, string Barcode)
        {
            using (FoodStorageEntities fs = new FoodStorageEntities())
            {
                StoredItem si = new StoredItem();
                si.CategoryId = CategoryId;
                si.Description = Description;
                si.Barcode = Barcode;
                si.DateAdded = DateTime.Now;

                fs.StoredItems.Add(si);
            }
        }

        public void DeleteItem()
        {

        }

        public void UpdateItem()
        {

        }

        public void AddThreshold()
        {

        }

        public void DeleteThreshold()
        {

        }

        public void UpdateThreshold()
        {

        }

        public void GetAllItems()
        {

        }

        public void GetItem()
        {

        }
    }
}

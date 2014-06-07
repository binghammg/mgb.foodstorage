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
        public int GetCategoryId(string sBarCode)
        {
            using (FoodStorageEntities fs = new FoodStorageEntities())
            {
                var iCategoryId = (from CatBCMap 
                                   in fs.CatBarcodeMaps
                                   where CatBCMap.Barcode == sBarCode
                                   select CatBCMap.CategoryId
                                  );

                if (iCategoryId.Any())
                {
                    return Convert.ToInt32(iCategoryId);
                }
                else
                {
                    return -1;
                }
            }
        }

        public void MapBarCodeToCategory(String sBarCode, int iCategoryId)
        {
            using (FoodStorageEntities fs = new FoodStorageEntities())
            {
                CatBarcodeMap cbcm = new CatBarcodeMap();
                cbcm.Barcode = sBarCode;
                cbcm.CategoryId = iCategoryId;

                fs.CatBarcodeMaps.Add(cbcm);
                fs.SaveChanges();
            }
        }

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
                fs.SaveChanges();
            }
        }

        public StoredItem[] GetItems(String sBarCode)
        {            
            using (FoodStorageEntities fs = new FoodStorageEntities())
            {
                var Item = (from si
                            in fs.StoredItems
                            where si.Barcode == sBarCode                                    
                            select si);

                return Item.ToArray();
            }
        }

        public void RemoveItem(int iStoredItemId)
        {
            using(FoodStorageEntities fs = new FoodStorageEntities())
            {
                var Item = (from si
                            in fs.StoredItems
                            where si.StoredItemId == iStoredItemId
                            select si);
                
                Item.DateRemoved = DateTime.Now;  //**** TODO: How do I update this date?????
                fs.SaveChanges();
            }
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
    }
}

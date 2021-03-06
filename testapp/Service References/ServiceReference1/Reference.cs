﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testapp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IFoodStorage")]
    public interface IFoodStorage {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodStorage/AddItem", ReplyAction="http://tempuri.org/IFoodStorage/AddItemResponse")]
        void AddItem(int CategoryId, string Description, string Barcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodStorage/AddItem", ReplyAction="http://tempuri.org/IFoodStorage/AddItemResponse")]
        System.Threading.Tasks.Task AddItemAsync(int CategoryId, string Description, string Barcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodStorage/DeleteItem", ReplyAction="http://tempuri.org/IFoodStorage/DeleteItemResponse")]
        void DeleteItem();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodStorage/DeleteItem", ReplyAction="http://tempuri.org/IFoodStorage/DeleteItemResponse")]
        System.Threading.Tasks.Task DeleteItemAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodStorage/UpdateItem", ReplyAction="http://tempuri.org/IFoodStorage/UpdateItemResponse")]
        void UpdateItem();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodStorage/UpdateItem", ReplyAction="http://tempuri.org/IFoodStorage/UpdateItemResponse")]
        System.Threading.Tasks.Task UpdateItemAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodStorage/AddThreshold", ReplyAction="http://tempuri.org/IFoodStorage/AddThresholdResponse")]
        void AddThreshold();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodStorage/AddThreshold", ReplyAction="http://tempuri.org/IFoodStorage/AddThresholdResponse")]
        System.Threading.Tasks.Task AddThresholdAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodStorage/DeleteThreshold", ReplyAction="http://tempuri.org/IFoodStorage/DeleteThresholdResponse")]
        void DeleteThreshold();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodStorage/DeleteThreshold", ReplyAction="http://tempuri.org/IFoodStorage/DeleteThresholdResponse")]
        System.Threading.Tasks.Task DeleteThresholdAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodStorage/UpdateThreshold", ReplyAction="http://tempuri.org/IFoodStorage/UpdateThresholdResponse")]
        void UpdateThreshold();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodStorage/UpdateThreshold", ReplyAction="http://tempuri.org/IFoodStorage/UpdateThresholdResponse")]
        System.Threading.Tasks.Task UpdateThresholdAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodStorage/GetAllItems", ReplyAction="http://tempuri.org/IFoodStorage/GetAllItemsResponse")]
        void GetAllItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodStorage/GetAllItems", ReplyAction="http://tempuri.org/IFoodStorage/GetAllItemsResponse")]
        System.Threading.Tasks.Task GetAllItemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodStorage/GetItem", ReplyAction="http://tempuri.org/IFoodStorage/GetItemResponse")]
        void GetItem();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodStorage/GetItem", ReplyAction="http://tempuri.org/IFoodStorage/GetItemResponse")]
        System.Threading.Tasks.Task GetItemAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFoodStorageChannel : testapp.ServiceReference1.IFoodStorage, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FoodStorageClient : System.ServiceModel.ClientBase<testapp.ServiceReference1.IFoodStorage>, testapp.ServiceReference1.IFoodStorage {
        
        public FoodStorageClient() {
        }
        
        public FoodStorageClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FoodStorageClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FoodStorageClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FoodStorageClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddItem(int CategoryId, string Description, string Barcode) {
            base.Channel.AddItem(CategoryId, Description, Barcode);
        }
        
        public System.Threading.Tasks.Task AddItemAsync(int CategoryId, string Description, string Barcode) {
            return base.Channel.AddItemAsync(CategoryId, Description, Barcode);
        }
        
        public void DeleteItem() {
            base.Channel.DeleteItem();
        }
        
        public System.Threading.Tasks.Task DeleteItemAsync() {
            return base.Channel.DeleteItemAsync();
        }
        
        public void UpdateItem() {
            base.Channel.UpdateItem();
        }
        
        public System.Threading.Tasks.Task UpdateItemAsync() {
            return base.Channel.UpdateItemAsync();
        }
        
        public void AddThreshold() {
            base.Channel.AddThreshold();
        }
        
        public System.Threading.Tasks.Task AddThresholdAsync() {
            return base.Channel.AddThresholdAsync();
        }
        
        public void DeleteThreshold() {
            base.Channel.DeleteThreshold();
        }
        
        public System.Threading.Tasks.Task DeleteThresholdAsync() {
            return base.Channel.DeleteThresholdAsync();
        }
        
        public void UpdateThreshold() {
            base.Channel.UpdateThreshold();
        }
        
        public System.Threading.Tasks.Task UpdateThresholdAsync() {
            return base.Channel.UpdateThresholdAsync();
        }
        
        public void GetAllItems() {
            base.Channel.GetAllItems();
        }
        
        public System.Threading.Tasks.Task GetAllItemsAsync() {
            return base.Channel.GetAllItemsAsync();
        }
        
        public void GetItem() {
            base.Channel.GetItem();
        }
        
        public System.Threading.Tasks.Task GetItemAsync() {
            return base.Channel.GetItemAsync();
        }
    }
}

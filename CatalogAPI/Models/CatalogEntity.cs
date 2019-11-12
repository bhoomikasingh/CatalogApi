using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogAPI.Models
{
    public class CatalogEntity:TableEntity
    {
        public  CatalogEntity(string name, string id)
        {
            this.PartitionKey = name;
            this.RowKey = id;
        }
        public double Price { get; set; }
        public int Quantity { get; set; }
       // [BsonElement("reorderLevel")]
        public int ReorderLevel { get; set; }

       // [BsonElement("imageUrl")]
        public string ImageUrl { get; set; }

       // [BsonElement("manufacturingDate")]
        public DateTime ManufacturingDate { get; set; }

    }
}

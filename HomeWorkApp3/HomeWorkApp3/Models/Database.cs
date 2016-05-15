using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWorkApp3.Models
{
    public class Cache
    {
        string equipmentValue = "Equipment";


        public Cache()
        {
            FillWithEquipmentItems();
        }

        public void AddNewEquipmentItem(Equipment equipment)
        {
            var equipmentItems =             GetEquipmentItemsRows();
            var newEquipmentItems =          PushSingleItemToEnd(equipment, equipmentItems);
                                             OverwriteCacheWith(newEquipmentItems);
        }

        public List<Equipment> GetEquipmentItemsRows()
        {
            return (List<Equipment>)HttpContext.Current.Application[equipmentValue];
        }

        public void UpdateEquipmentItem(Equipment newItem)
        {
            var equipmentItems =    GetEquipmentItemsRows();
            var newEquipmentItems = ReplaceOldEquipmentItemWith(newItem, equipmentItems);
                                    OverwriteCacheWith(newEquipmentItems);

        }

        public void DeleteEquipmentItem(Equipment item)
        {
            var equipmentItems =    GetEquipmentItemsRows();
            var newEquipmentItems = DeleteEquipmentItemByID(item.ID, equipmentItems);
                                    OverwriteCacheWith(newEquipmentItems);
        }

        /****************************PRIVATE METHODS START HERE********************************************/

        public List<Equipment> DeleteEquipmentItemByID(int id, List<Equipment> equipmentItems)
        {
            var itemIndex = equipmentItems.FindIndex(e => e.ID == id);
            equipmentItems.RemoveAt(itemIndex);
            return equipmentItems;
        }

        private List<Equipment> ReplaceOldEquipmentItemWith(Equipment newItem, List<Equipment> equipmentItems)
        {
            var itemIndex = equipmentItems.FindIndex(e => e.ID == newItem.ID);
            equipmentItems.RemoveAt(itemIndex);
            equipmentItems.Insert(itemIndex, newItem);
            return equipmentItems;
        }



        private void OverwriteCacheWith(List<Equipment> items)
        {
            HttpContext.Current.Application[equipmentValue] = items;
        }

        private List<Equipment> PushSingleItemToEnd(Equipment equipment, List<Equipment> equipmentItems)
        {
            equipment.ID = GetLastEquipmentID(equipmentItems) + 1;
            equipmentItems.Add(equipment);
            return equipmentItems;
        }

        private int GetLastEquipmentID(List<Equipment> equipmentItems)
        {
            var lastEquipmentItem = equipmentItems[equipmentItems.Count() - 1];
            return lastEquipmentItem.ID;
        }

        private void FillWithEquipmentItems()
        {
            if (HttpContext.Current.Application[equipmentValue] == null)
            {
                var equipmentItems = new List<Equipment>();
                equipmentItems.Add(new Equipment()
                {
                    ID = 1,
                    Name = "ViewSonic IPS VX2770",
                    Description = "ViewSonic Monitor, 27 Inch, IPS",
                    Category = "Monitors",
                    AssignedTo = "Ben"
                });

                equipmentItems.Add(new Equipment()
                {
                    ID = 2,
                    Name = "Logitech Keyboard K360",
                    Description = "Wiress Keyboard, glossy black design",
                    Category = "Keyboards",
                    AssignedTo = "Mike"
                });

                equipmentItems.Add(new Equipment()
                {
                    ID = 3,
                    Name = "Samsung Galaxy S5",
                    Description = "Black Galaxy Phone, 64GB, 4G support",
                    Category = "Smartphones",
                    AssignedTo = "John"
                });

                equipmentItems.Add(new Equipment()
                {
                    ID = 4,
                    Name = "Pilot G2 Premium Pen",
                    Description = "Premium Ink pen.",
                    Category = "Pens",
                    AssignedTo = "Ben"
                });

                equipmentItems.Add(new Equipment()
                {
                    ID = 5,
                    Name = "Delux Ergonimic Chair",
                    Description = "Contemporary mesh high back home & office chair, designed to provide exceptional back support and to prevent body heat and moisture build up. Adjustable tilt tension ,seat height and armrest",
                    Category = "Chairs",
                    AssignedTo = "Mike"
                });

                HttpContext.Current.Application[equipmentValue] = equipmentItems;

            }         
        }
    }
}
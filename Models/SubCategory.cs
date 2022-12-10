﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMP_reseni.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Disabled { get; set; }
        public List<Items> Items { get; set; }

        public SubCategory()
        {
            this.Items = new List<Items>();
        }

        public void AddItem(Items item)
        {
            if (Items == null)
                Items = new List<Items>();
            //TryToSetItemId(item);
            Items.Add(item);
        }

        private void SetItemId(Items item)
        {
            if (Items.Count > 0)
            {
                int _maxId = Items.Max(o => o.Id);
                item.Id = _maxId + 1;
            }
            else
                item.Id = 1;
        }
        public List<string> GetItemNames(bool getDisabled = false)
        {
            List<string> output = new List<string>();
            foreach (Items i in Items)
                if (i.Disabled == false || (i.Disabled == true && getDisabled == true))
                    output.Add(i.Name);
            return output;
        }
        public Items FindItem(int itemId)
        {
            return this.Items.Find(f => f.Id == itemId);
        }
    }
}

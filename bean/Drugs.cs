using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drug_management_system.bean
{
    //药品实例类
    class Drugs
    {
        private string sName;//供货商名字
        private int did;//药物ID
        private string dName;//药物名称
        private Single dCost;//药物价格
        private Single dPrice;//药物售价
        private string dExplain;//用药说明
        private int dStock;//药品库存
        private int dSold;//已售出数量

        public string SName { get => sName; set => sName = value; }
        public int Did { get => did; set => did = value; }
        public string DName { get => dName; set => dName = value; }
        public Single DCost { get => dCost; set => dCost = value; }
        public Single DPrice { get => dPrice; set => dPrice = value; }
        public string DExplain { get => dExplain; set => dExplain = value; }
        public int DStock { get => dStock; set => dStock = value; }
        public int DSold { get => dSold; set => dSold = value; }
    }
}

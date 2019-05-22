using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdProject
{
    class classOrderValidate
    {

        string iid;
        string btchid;
        float sllprice;
        float peruint;
        float qntity;

        public string itemid
        {
            get { return iid; }
            set
            {
                iid = value;
            }
        }
        public string batchid
        {
            get
            {
                return btchid;
            }
            set
            {
                btchid = value;
            }
        }
        public float sellingprice
        {
            get
            {
                return sllprice;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Selling price cannot be negative.");
                }
                else if (value == 0)
                {
                    throw new Exception("Selling price cannot be 0.");
                }
                sllprice = value;
            }
        }
        public float costperunit
        {
            get
            {
                return peruint;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Cost per unit cannot be negative.");
                }
                else if (value == 0)
                {
                    throw new Exception("Cost per unit cannot be 0.");
                }
                peruint = value;
            }
        }
        public float quantity
        {
            get
            {
                return qntity;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Quantity cannot be negative.");
                }
                else if (value == 0)
                {
                    throw new Exception("Quantity per unit cannot be 0.");
                }
                qntity = value;
            }
        }
        public DateTime expiredate
        {
            get; set;
        }
    }
}

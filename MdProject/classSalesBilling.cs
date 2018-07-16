using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdProject
{
    class classSalesBilling
    {
        float amountpaid;
        float amounttobepaid;
        float creditamount;

        public float credit
        {
            get { return amounttobepaid - amountpaid; }
            set
            {

            }
        }
        public float amounttobepay
        {
            get { return amounttobepaid; }
            set
            {
                amounttobepaid = value;
            }
        }
        public float amountpay
        {
            get
            {
                return amountpaid;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("amount paying cannot be negative.");
                }
                else if (value > amounttobepaid)
                {
                    throw new Exception("Enter an amount less than amount to be paid");
                }
                amountpaid = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class MenuItem
    {
        public MenuItem()
        {

        }
        private long _id;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private float _price;

        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _active;

        public string Active
        {
            get { return _active; }
            set { _active = value; }
        }

        private DateTime _dateOfLaunch;

        public DateTime DateOfLaunch
        {
            get { return _dateOfLaunch; }
            set { _dateOfLaunch = value; }
        }

        private string _category;

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private string _freeDelivery;

        public string FreeDelivery
        {
            get { return _freeDelivery; }
            set { _freeDelivery = value; }
        }


    }
}

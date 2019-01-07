using System;

namespace Sabroso
{
    public class CustomAttribute : Attribute
    {
        private int id;
        private string description;
        public CustomAttribute(int id, string description)
        {
            this.id = id;
            this.description = description;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        

    }
}

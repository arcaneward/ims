using System.ComponentModel;
using System.Linq;

namespace IMS
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool RemoveAssociatedPart(int id)
        {
            return AssociatedParts.Remove(LookupAssociatedPart(id));
        }
        public Part LookupAssociatedPart(int id)
        {
            return AssociatedParts.FirstOrDefault(part => part.PartID == id);
        }

    }
}
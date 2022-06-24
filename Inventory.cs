using System.ComponentModel;
using System.Linq;

namespace IMS
{
    public static class Inventory
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        public static void AddProduct(Product product)
        {
            product.ProductID = GenerateProductId();
            Products.Add(product);
        }
        public static bool RemoveProduct(Product product)
        {
            return Products.Remove(product);
        }
        public static Product LookupProduct(int productId)
        {
            return Products.FirstOrDefault(product => product.ProductID == productId);
        }
        public static void UpdateProduct(int id, Product newProduct)

        {
            Products[Products.IndexOf(LookupProduct(id))] = newProduct;
        }
        public static void AddPart(Part part)
        {
            part.PartID = GeneratePartId();
            AllParts.Add(part);
        }
        public static bool DeletePart(Part part)
        {
            return AllParts.Remove(part);
        }
        public static Part LookupPart(int partId)
        {
            return AllParts.FirstOrDefault(part => part.PartID == partId);
        }
        public static void UpdatePart(int id, Part newPart)
        {
            AllParts[AllParts.IndexOf(LookupPart(id))] = newPart;
        }

        public static BindingList<Part> SearchParts(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm)) return AllParts;
            searchTerm = searchTerm.ToUpper();
            var results = AllParts.ToList().FindAll(part =>
            {
                var result = part.PartID.ToString().Contains(searchTerm) || part.Name.ToUpper().Contains(searchTerm);
                if (result) return true;
                if (!result && part is Inhouse inhouse)
                {
                    return inhouse.MachineID.ToString().Contains(searchTerm);
                }
                return (part as Outsourced).CompanyName.ToUpper().Contains(searchTerm);
            });
            return new BindingList<Part>(results);
        }
        public static BindingList<Product> SearchProducts(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm)) return Products;
            searchTerm = searchTerm.ToUpper();
            var results = Products.ToList().FindAll(product =>
            {
                return product.ProductID.ToString().Contains(searchTerm) || product.Name.ToUpper().Contains(searchTerm);
            });

            return new BindingList<Product>(results);
        }

        public static void PartData()
        {
            AddPart(new Inhouse()
            {
                Name = "Babbage Analyzer",
                InStock = 11,
                Price = 1000.00m,
                Min = 1,
                Max = 30,
                MachineID = 00001
            });

            AddPart(new Inhouse()
            {
                Name = "Kelvin Gyrostat",
                InStock = 13,
                Price = 1100.00m,
                Min = 1,
                Max = 30,
                MachineID = 00002
            });

            AddPart(new Inhouse()
            {
                Name = "Riemannian Manifold",
                InStock = 15,
                Price = 650.00m,
                Min = 1,
                Max = 30,
                MachineID = 00003
            });

            AddPart(new Outsourced()
            {
                Name = "Flux Capacitor",
                InStock = 10,
                Price = 1500.00m,
                Min = 1,
                Max = 30,
                CompanyName = "Pulse Electric"
            });

            AddPart(new Outsourced()
            {
                Name = "Maxwell Generator",
                InStock = 16,
                Price = 800.00m,
                Min = 1,
                Max = 30,
                CompanyName = "Pulse Electric"
            });
        }

        public static void ProductData()
        {
            AddProduct(new Product()
            {
                Name = "Time Machine - Black",
                InStock = 5,
                Price = 2500.00m,
                Min = 1,
                Max = 20
            });

            AddProduct(new Product()
            {
                Name = "Time Machine - Silver",
                InStock = 7,
                Price = 2500.00m,
                Min = 1,
                Max = 20
            });

            AddProduct(new Product()
            {
                Name = "Time Machine - White",
                InStock = 11,
                Price = 2500.00m,
                Min = 1,
                Max = 20
            });

            AddProduct(new Product()
            {
                Name = "Time Machine - Red",
                InStock = 3,
                Price = 2500.00m,
                Min = 1,
                Max = 20
            });
        }
        private static int NewProductId = 0;
        private static int NewPartId = 0;

        private static int GenerateProductId()
        {
            NewProductId++;
            return NewProductId;
        }
        private static int GeneratePartId()
        {
            NewPartId++;
            return NewPartId;
        }
    }
}
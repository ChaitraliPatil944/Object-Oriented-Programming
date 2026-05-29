#include<iostream>
#include<vector>
using namespace std;
 
//containment
//between InventoryManager and Product
//InventoryManager contains a vector of Product objects

namespace Catalog {

    class Product {
        private:
            string name;
            double price;

        public:
            Product(string name, double price) {
                this->name = name;
                this->price = price;
            }
            
            string getName() {
                return name;
            }
            
            double getPrice() {
                return price;
            }
    };

    class InventoryManager {

        private :
            vector<Product> products;

        public:
            void addProduct(Product& product) {
                cout << "Adding product: " << product.getName() << " with price: $" << product.getPrice() << endl;
                products.push_back(product); // adding product to the vector
                
            }

            void removeProduct() {
               products.pop_back(); // removing the last product from the vector
                cout << "Removing product: " << endl;
            }

            vector<Product> getAllProducts() {
                cout << "Getting all products in the catalog" << endl;
                return products; // returning the vector of products
            }   
    };

    class RecommendationEngine {
        public:
            void recommendProduct(string customerName) {
                cout << "Recommending products for customer: " << customerName << endl;


            }
    };

}

int main() {
    Catalog::InventoryManager inventoryManager;
    Catalog::Product product1("Laptop", 999.99);
    Catalog::Product product2("Smartphone", 499.99);

    inventoryManager.addProduct(product1);
    inventoryManager.addProduct(product2);

    vector<Catalog::Product> products = inventoryManager.getAllProducts();

    for ( auto& p : products) {
        cout << "Product: " << p.getName() << ", Price: $" << p.getPrice() << endl;
    }

    inventoryManager.removeProduct();

    return 0;
}   
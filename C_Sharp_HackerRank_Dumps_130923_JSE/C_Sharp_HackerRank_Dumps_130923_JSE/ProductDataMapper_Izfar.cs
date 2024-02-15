using System;
using System.Collections.Generic;

public class ProductDataManager
{
    public static List<List<string>> GetMatchingProducts(List<List<string>> products, List<List<string>> queries)
    {
        List<List<string>> result = new List<List<string>>();

        foreach (List<string> query in queries)
        {
            string type = query[0];
            string param = query[1];
            List<string> matchingProducts = new List<string>();

            if (type.Equals("Type1"))
            {
                foreach (List<string> product in products)
                {
                    if (product[2].Equals(param))
                    {
                        matchingProducts.Add(product[0]);
                    }
                }
            }
            else if (type.Equals("Type2"))
            {
                int price = int.Parse(param);
                foreach (List<string> product in products)
                {
                    int productPrice = int.Parse(product[1]);
                    if (productPrice < price)
                    {
                        matchingProducts.Add(product[0]);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (type.Equals("Type3"))
            {
                int price = int.Parse(param);
                for (int i = products.Count - 1; i >= 0; i--)
                {
                    List<string> product = products[i];
                    int productPrice = int.Parse(product[1]);
                    if (productPrice > price)
                    {
                        matchingProducts.Insert(0, product[0]);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            result.Add(matchingProducts);
        }

        return result;
    }
}

// Izfar - 12 TC PAss
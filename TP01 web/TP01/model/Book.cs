using System;
using System.Collections.Generic;
using System.Text;

namespace TP01.model
{
    class Book
    {
        private string name;
        private List<Author> authors;
        private double price;
        private int qty = 0;

        public Book(String name, List<Author> authors, double price)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
        }

        public Book(String name, List<Author> authors, double price, int qty)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.qty = qty;
        }

        public String getName()
        {
            return name;
        }

        public List<Author> getAuthors()
        {
            return authors;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public int getQty()
        {
            return this.qty;
        }

        public void setQty(int qty)
        {
            this.qty = qty;
        }

        public override string ToString()
        {
            String toString = "Book[name = " + name + ", authors = {";
            foreach(Author author in authors)
            {
                if (!author.Equals(authors[0])) {
                    toString += ", ";
                }
                toString += author.ToString();
            }
            toString += "}, price = " + price + ", qty = " + qty + "]";
            return toString;
        }

        public String getAuthorNames()
        {
            String authorNames = "";
            foreach(Author author in authors)
            {
                if (!author.Equals(authors[0]))
                {
                    authorNames += ", ";
                }
                authorNames += author.getName();
            }
            return authorNames;
        }
    }
}

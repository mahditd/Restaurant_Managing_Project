using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_learning_git_in_project
{
    enum Gender
    {
        Male,
        Female
    }
    enum Subscription
    {
        Gold,
        Silver,
        Bronze
    }
    class Customer
    {
        string userName;
        string password;
        string name;
        string phone;
        List<Food> foods = new List<Food>();
        List<Order> orders = new List<Order>();
        string postalCode;
        Gender Gender;
        List<Comment> comments = new List<Comment>();
        List<Complaint> complaints = new List<Complaint>();
    }
}

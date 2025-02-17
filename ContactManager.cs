namespace ContactManager
{
    public class Program
    {
        static List<Contact> contacts = new List<Contact>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Title = "ContactManagerMenu";

                Console.WriteLine("1. Add contact");
                Console.WriteLine("2. Edit contact");
                Console.WriteLine("3. Delete contact");
                Console.WriteLine("4. List all contacts");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        EditContact();
                        break;
                    case 3:
                        DeleteContact();
                        break;
                    case 4:
                        ListContacts();
                        break;
                    case 5: return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        static void AddContact()
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Email address: ");
            string emailAddress = Console.ReadLine();

            contacts.Add(new Contact(firstName, lastName, phoneNumber, emailAddress));
            Console.WriteLine("Contact added successfully.");
        }
        static void EditContact()
        {
            Console.Write("Enter index of contact to edit: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < contacts.Count)
            {
                Contact contactToEdit = contacts[index];
                Console.Write("New first name: ");
                contactToEdit.Firstname = Console.ReadLine();
                Console.Write("New last name: ");
                contactToEdit.LastName = Console.ReadLine();
                Console.Write("New phone number: ");
                contactToEdit.PhoneNumber = Console.ReadLine();
                Console.Write("New email address: ");
                contactToEdit.Email = Console.ReadLine();

                Console.WriteLine("Contact updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
        static void DeleteContact()
        {
            Console.Write("Enter index of contact to delete: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < contacts.Count)
            {
                contacts.RemoveAt(index);
                Console.WriteLine("Contact deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        static void ListContacts()
        {
            if (contacts.Count > 0)
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact);
                }
            }
            else
            {
                Console.WriteLine("No contacts found.");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHandler
{
    static public class SQL
    {
        static string conStr = "Data Source = kotorsprylar.database.windows.net; Initial Catalog = Kontorsprylar; Integrated Security = False; User ID = grupp6; Password=Academy2016;Connect Timeout = 60; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        static public void AddNewCustomer(string name, string email, string password, string address, string phone, string orgnr)
        {
            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand();

            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spCreateCustomer";

            SqlParameter paramName = new SqlParameter("@name", SqlDbType.VarChar, 255);
            paramName.Value = name;
            myCommand.Parameters.Add(paramName);

            SqlParameter paramEmail = new SqlParameter("@email", SqlDbType.VarChar, 255);
            paramEmail.Value = email;
            myCommand.Parameters.Add(paramEmail);


            SqlParameter paramPassword = new SqlParameter("@password", SqlDbType.VarChar, 255);
            paramPassword.Value = password;
            myCommand.Parameters.Add(paramPassword);


            SqlParameter paramAddress = new SqlParameter("@address", SqlDbType.VarChar, 255);
            paramAddress.Value = address;
            myCommand.Parameters.Add(paramAddress);


            SqlParameter paramPhone = new SqlParameter("@phone", SqlDbType.VarChar, 255);
            paramPhone.Value = phone;
            myCommand.Parameters.Add(paramPhone);


            SqlParameter paramOrgNr = new SqlParameter("@orgnr", SqlDbType.VarChar, 255);
            paramOrgNr.Value = orgnr;
            myCommand.Parameters.Add(paramOrgNr);

            SqlParameter paramID = new SqlParameter("@new_id", SqlDbType.Int);
            paramID.Direction = ParameterDirection.Output;
            myCommand.Parameters.Add(paramID);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // TODO: Hur kan vi skicka för exception-meddelande?

            }
            finally
            {
                myConnection.Close();
            }
        }

        public static Admin GetAdmin(string email, string password)
        {
            Admin tmpAdmin = null;

            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand();

            string strCmd = $"select * from Admins where Email='{email}' and Password='{password}'";

            myCommand.CommandText = strCmd;
            myCommand.Connection = myConnection;

            try
            {
                myConnection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string name = myReader["Name"].ToString();
                    int id = Convert.ToInt32(myReader["AID"]);
                    tmpAdmin = new Admin(name, email, password, id);
                }
            }
            catch (Exception ex)
            {
                // Response.Write($"<script>alert('{ex.Message}');</script>");
            }
            finally
            {
                myConnection.Close();
            }

            return tmpAdmin;
        }

        static public void AddNewAdmin(string name, string email, string password)
        {
            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand();

            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spCreateAdmin";

            SqlParameter paramName = new SqlParameter("@name", SqlDbType.VarChar, 255);
            paramName.Value = name;
            myCommand.Parameters.Add(paramName);

            SqlParameter paramEmail = new SqlParameter("@email", SqlDbType.VarChar, 255);
            paramEmail.Value = email;
            myCommand.Parameters.Add(paramEmail);


            SqlParameter paramPassword = new SqlParameter("@password", SqlDbType.VarChar, 255);
            paramPassword.Value = password;
            myCommand.Parameters.Add(paramPassword);

            SqlParameter paramID = new SqlParameter("@new_id", SqlDbType.Int);
            paramID.Direction = ParameterDirection.Output;
            myCommand.Parameters.Add(paramID);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // TODO: Hur kan vi skicka för exception-meddelande?

            }
            finally
            {
                myConnection.Close();
            }
        }
        static public void AddNewProduct(string name, decimal price, string description, string pictureLink)
        {
            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand();

            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spCreateProduct";

            SqlParameter paramName = new SqlParameter("@name", SqlDbType.VarChar, 255);
            paramName.Value = name;
            myCommand.Parameters.Add(paramName);

            SqlParameter paramEmail = new SqlParameter("@price", SqlDbType.Money, 255);
            paramEmail.Value = price;
            myCommand.Parameters.Add(paramEmail);

            SqlParameter paramPassword = new SqlParameter("@description", SqlDbType.VarChar, 255);
            paramPassword.Value = description;
            myCommand.Parameters.Add(paramPassword);

            SqlParameter paramPictureLink = new SqlParameter("@pictureLink", SqlDbType.VarChar, 255);
            paramPictureLink.Value = pictureLink;
            myCommand.Parameters.Add(paramPictureLink);

            SqlParameter paramID = new SqlParameter("@new_id", SqlDbType.Int);
            paramID.Direction = ParameterDirection.Output;
            myCommand.Parameters.Add(paramID);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                myConnection.Close();
            }
        }

        static public List<Customer> LoadCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Clear();

            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand();

            string strCmd = "select * from Customers order by Name";

            myCommand.CommandText = strCmd;
            myCommand.Connection = myConnection;

            try
            {
                myConnection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    customers.Add(new Customer(myReader["Name"].ToString(), myReader["Email"].ToString(), myReader["Password"].ToString(), Convert.ToInt32(myReader["CID"]), myReader["Address"].ToString(), myReader["Phone"].ToString(), myReader["OrgNr"].ToString())); 
                }
            }
            catch (Exception ex)
            {
                // TODO: Vad kan vi skicka för exception-meddelande?
            }
            finally
            {
                myConnection.Close();
            }

            return customers;
        }

        static public List<Product> LoadProducts()
        {
            List<Product> products = new List<Product>();
            products.Clear();

            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand();

            string strCmd = "select * from Products order by Name";

            myCommand.CommandText = strCmd;
            myCommand.Connection = myConnection;

            try
            {
                myConnection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    products.Add(new Product(myReader["Name"].ToString(), Convert.ToInt32(myReader["Price"]), Convert.ToInt32(myReader["PID"]), myReader["Description"].ToString(), myReader["PictureLink"].ToString()));
                }
            }
            catch (Exception ex)
            {
                // TODO: Hur kan vi skicka för exception-meddelande?
            }
            finally
            {
                myConnection.Close();
            }

            return products;
        }

        static public List<Admin> LoadAdmins()
        {
            List<Admin> admins = new List<Admin>();
            admins.Clear();

            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand();

            string strCmd = "select * from Admins order by Name";

            myCommand.CommandText = strCmd;
            myCommand.Connection = myConnection;

            try
            {
                myConnection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    admins.Add(new Admin(myReader["Name"].ToString(), myReader["Email"].ToString(), myReader["Password"].ToString(), Convert.ToInt32(myReader["AID"])));
                }
            }
            catch (Exception ex)
            {
                // TODO: Vad kan vi skicka för exception-meddelande?
            }
            finally
            {
                myConnection.Close();
            }

            return admins;
        }

        static public Customer GetCustomer(string email, string password)
        {
            Customer tmpCustomer = null;

            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand();

            string strCmd = $"select * from Customers where Email='{email}' and Password='{password}'";

            myCommand.CommandText = strCmd;
            myCommand.Connection = myConnection;

            try
            {
                myConnection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string name = myReader["Name"].ToString();
                    string address = myReader["Address"].ToString();
                    string phone = myReader["Phone"].ToString();
                    string orgNr = myReader["OrgNr"].ToString();
                    int id = Convert.ToInt32(myReader["CID"]);
                    tmpCustomer = new Customer(name, email, password, id, address, phone, orgNr);
                }
            }
            catch (Exception ex)
            {
                // Response.Write($"<script>alert('{ex.Message}');</script>");
            }
            finally
            {
                myConnection.Close();
            }

            return tmpCustomer;
        }
        static public Customer GetCustomer(int id)
        {
            Customer tmpCustomer = null;

            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand();

            string strCmd = $"select * from Customers where CID='{id}'";

            myCommand.CommandText = strCmd;
            myCommand.Connection = myConnection;

            try
            {
                myConnection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string name = myReader["Name"].ToString();
                    string email = myReader["Email"].ToString();
                    string password = myReader["Password"].ToString();
                    string address = myReader["Address"].ToString();
                    string phone = myReader["Phone"].ToString();
                    string orgNr = myReader["OrgNr"].ToString();
                    tmpCustomer = new Customer(name, email, password, id, address, phone, orgNr);
                }
            }
            catch (Exception ex)
            {
                // Response.Write($"<script>alert('{ex.Message}');</script>");
            }
            finally
            {
                myConnection.Close();
            }

            return tmpCustomer;
        }
        static public Product GetProduct(int PID)
        {
            Product tmpProduct = null;

            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand();

            string strCmd = $"select * from Products where PID='{PID}'";

            myCommand.CommandText = strCmd;
            myCommand.Connection = myConnection;

            try
            {
                myConnection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string name = myReader["Name"].ToString();
                    decimal price = Convert.ToDecimal(myReader["Price"]);
                    string description = myReader["Description"].ToString();
                    string pictureLink = myReader["PictureLink"].ToString();
                    int id = Convert.ToInt32(myReader["PID"]);
                    tmpProduct = new Product(name, price, id, description, pictureLink);
                }
            }
            catch (Exception ex)
            {
                // Response.Write($"<script>alert('{ex.Message}');</script>");
            }
            finally
            {
                myConnection.Close();
            }

            return tmpProduct;
        }
        static public void DeleteCustomer(int id)
        {
            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand();


            string strCmd = $"delete from Customers where CID={id}";

            myCommand.CommandText = strCmd;
            myCommand.Connection = myConnection;
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // TODO: Hur kan vi skicka för exception-meddelande?

            }
            finally
            {
                myConnection.Close();
            }
        }
        static public void UpdateCustomer(string name, string email, string address, string phone, string orgnr, int id)
        {
            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand();

            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spUpdateCustomer";

            SqlParameter paramName = new SqlParameter("@name", SqlDbType.VarChar, 255);
            paramName.Value = name;
            myCommand.Parameters.Add(paramName);

            SqlParameter paramEmail = new SqlParameter("@email", SqlDbType.VarChar, 255);
            paramEmail.Value = email;
            myCommand.Parameters.Add(paramEmail);

            SqlParameter paramAddress = new SqlParameter("@address", SqlDbType.VarChar, 255);
            paramAddress.Value = address;
            myCommand.Parameters.Add(paramAddress);


            SqlParameter paramPhone = new SqlParameter("@phone", SqlDbType.VarChar, 255);
            paramPhone.Value = phone;
            myCommand.Parameters.Add(paramPhone);


            SqlParameter paramOrgNr = new SqlParameter("@orgnr", SqlDbType.VarChar, 255);
            paramOrgNr.Value = orgnr;
            myCommand.Parameters.Add(paramOrgNr);

            SqlParameter paramID = new SqlParameter("@cid", SqlDbType.Int);
            paramID.Value = id;
            myCommand.Parameters.Add(paramID);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // TODO: Hur kan vi skicka för exception-meddelande?

            }
            finally
            {
                myConnection.Close();
            }
        }
        static public void UpdateProduct(string name, decimal price, string description, string pictureLink, int id)
        {
            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand();

            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spUpdateProduct";

            SqlParameter paramName = new SqlParameter("@name", SqlDbType.VarChar, 255);
            paramName.Value = name;
            myCommand.Parameters.Add(paramName);

            SqlParameter paramPrice = new SqlParameter("@price", SqlDbType.Money, 255);
            paramPrice.Value = price;
            myCommand.Parameters.Add(paramPrice);

            SqlParameter paramDescription = new SqlParameter("@description", SqlDbType.VarChar, 255);
            paramDescription.Value = description;
            myCommand.Parameters.Add(paramDescription);


            SqlParameter paramPicLink = new SqlParameter("@pictureLink", SqlDbType.VarChar, 255);
            paramPicLink.Value = pictureLink;
            myCommand.Parameters.Add(paramPicLink);


            SqlParameter paramID = new SqlParameter("@pid", SqlDbType.Int);
            paramID.Value = id;
            myCommand.Parameters.Add(paramID);
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // TODO: Hur kan vi skicka för exception-meddelande?

            }
            finally
            {
                myConnection.Close();
            }
        }

        static public void DeleteProduct(int id)
        {
            SqlConnection myConnection = new SqlConnection(conStr);
            SqlCommand myCommand = new SqlCommand();


            string strCmd = $"delete from Products where PID={id}";

            myCommand.CommandText = strCmd;
            myCommand.Connection = myConnection;
            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // TODO: Hur kan vi skicka för exception-meddelande?

            }
            finally
            {
                myConnection.Close();
            }
        }

    }
}

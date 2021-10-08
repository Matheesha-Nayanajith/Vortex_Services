using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Vortex_Services.Models
{
    public class Methods
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Git\Vortex_Services\Vortex_Services\Vortex_Services\Vortex.mdf;Integrated Security=True";
       
        public string vehNo, name, address, checkIn, checkOut, desc;
        public int phone, ODOm;
        public bool state = false;

        //data retrive
        public void setVehicleNo(String vNo)
        {
            this.vehNo = vNo;
        }
        public string getVehicleNo()
        {
            return vehNo;
        }

        public void setName(String nam)
        {
            this.name = nam;
        }
        public string getName()
        {
            return name;
        }

        public void setPhone(int contact)
        {
            this.phone = contact;
        }
        public int getPhone()
        {
            return phone;
        }

        public void setAddress(String add)
        {
            this.address = add;
        }
        public string getAddress()
        {
            return address;
        }

        public void setCheckIn(String cIn)
        {
            this.checkIn = cIn;
        }
        public string getCheckIn()
        {
            return checkIn;
        }

        public void setCheckOut(String cOut)
        {
            this.checkOut = cOut;
        }
        public string getCheckOut()
        {
            return checkOut;
        }

        public void setODO(int odo)
        {
            this.ODOm = odo;
        }
        public int getODO()
        {
            return ODOm;
        }

        public void setDescription(String des)
        {
            this.desc = des;
        }
        public string getDescription()
        {
            return desc;
        }



        //Check In Method
        public bool CheckIn()
        {

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string qInsert = "INSERT INTO CheckIn VALUES(@Vehicle_No, @Name, @Phone_No, " +
                "@Address, @Check_in, @Check_out, @ODO_meter, @Description)";
            SqlCommand cmd = new SqlCommand(qInsert, connection);

            cmd.Parameters.AddWithValue("@Vehicle_No", vehNo);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Phone_No", phone);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@Check_in", checkIn);
            cmd.Parameters.AddWithValue("@Check_out", checkOut);
            cmd.Parameters.AddWithValue("@ODO_meter", ODOm);
            cmd.Parameters.AddWithValue("@Description", desc);


            try
            {
                cmd.ExecuteNonQuery();
                return state = true;
            }
            catch (SqlException)
            {

                return state = false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

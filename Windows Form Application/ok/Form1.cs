using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ok
{
    public partial class Form1 : Form


    {
        DataTable dt = new DataTable();

        IFirebaseConfig config = new FirebaseConfig
        {

            AuthSecret = "twxP9wo2ngpBpu5yQzgWRCNT7BVCM4HH7jAoXbfz",
            BasePath = "https://gndi-system.firebaseio.com/"
        };

        IFirebaseClient client;
        private object response;
        private object dg;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
           /* IFirebaseConfig config = new FirebaseConfig
            {

                AuthSecret = "j3dLwz3zDqjLL78BMBumv1iql9Fz2ESLu1n5lnF1",
                BasePath = "https://college-7d8726.firebaseio.com/"
            };*/


            client = new FireSharp.FirebaseClient(config);
          /*  Information info = new Information();
            var data = await client.GetTaskAsync(path: "Information");
            Dictionary<string, I> employees = data.ResultAs<Dictionary<string, Information>>();

            foreach (var Data in employees)
            {
                dataGridView1.Rows.Add(Information.Value.homeID, Data.Value.CitizenID, Data.Value.Name, Data.Value.NIC,
                    Data.Value.Birthday, Data.Value.gender, Data.Value.Maritaul_status_ID, Data.Value.email, Data.Value.Nationality,
                    Data.Value.job, Data.Value.village, Data.Value.Allowance, Data.Value.Landpolicy, Data.Value.house_type, Data.Value.water_type,
                    Data.Value.Disability, Data.Value.power_supply, Data.Value.toilets, Data.Value.education_qulification);

            }*/


            if (client != null)
            {
                MessageBox.Show("Connection is eshtablished");

            }
            dt.Columns.Add("homeID");
            dt.Columns.Add("CitizenID");
            dt.Columns.Add("Name");
            dt.Columns.Add("NIC");
            dt.Columns.Add("Birthday");
            dt.Columns.Add("gender");
            dt.Columns.Add("Maritaul_status_ID");
            dt.Columns.Add("email");
            dt.Columns.Add("Nationality");
            dt.Columns.Add("job");
            dt.Columns.Add("village");
            dt.Columns.Add("Allowance");
            dt.Columns.Add("Landpolicy");
            dt.Columns.Add("house_type");
            dt.Columns.Add("water_type");
            dt.Columns.Add("Disability");
            dt.Columns.Add("power_supply");
            dt.Columns.Add("toilets");
            dt.Columns.Add("education_qulification");

            dataGridView1.DataSource = dt;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            FirebaseResponse resp = await client.GetTaskAsync("counter/node");
            Counter_class get = resp.ResultAs<Counter_class>();

            MessageBox.Show(get.cnt);

            var data = new Data
            {
               

                homeID = (Convert.ToInt32(get.cnt) + 1).ToString(),
                CitizenID = textBox2.Text,
                Name = textBox3.Text,
                NIC = textBox4.Text,
                Birthday = textBox5.Text,
                gender = textBox6.Text,
                Maritaul_status_ID = textBox7.Text,
                email = textBox8.Text,
                Nationality = textBox9.Text,
                job = textBox10.Text,
                village = textBox15.Text,
                Allowance = textBox14.Text,
                Landpolicy = textBox13.Text,
                house_type = textBox12.Text,
                water_type = textBox11.Text,
                Disability = textBox20.Text,
                power_supply = textBox19.Text,
                toilets = textBox18.Text,
                education_qulification = textBox16.Text

            };

            SetResponse response = await client.SetTaskAsync("Information/" + data.homeID, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Data inserted" + result.homeID);

            var obj = new Counter_class
            {
                cnt = data.homeID
            };

            SetResponse response1 = await client.SetTaskAsync("counter/node", obj);
            export();
            /*FirebaseResponse resp = await client.GetTaskAsync("counter/node");
            Counter_class get = resp.ResultAs<Counter_class>();

            MessageBox.Show(get.cnt);

            var data = new Data
            {
               
                homeID = (Convert.ToInt32(get.cnt) + 1).ToString(),
                CitizenID = textBox2.Text,
                Name = textBox3.Text,
                NIC = textBox4.Text,
                Birthday = textBox5.Text,
                gender = textBox6.Text,
                Maritaul_status_ID = textBox7.Text,
                email = textBox8.Text,
                Nationality = textBox9.Text,
                job = textBox10.Text,
                village = textBox15.Text,
                Allowance = textBox14.Text,
                Landpolicy = textBox13.Text,
                house_type = textBox12.Text,
                water_type = textBox11.Text,
                Disability = textBox20.Text,
                power_supply = textBox19.Text,
                toilets = textBox18.Text,
                education_qulification = textBox16.Text

            };

            SetResponse response = await client.SetTaskAsync("Information/" + data.homeID, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Data inserted" + result.homeID);
            
            var obj = new Counter_class
            {
                cnt = data.homeID
            };

            SetResponse response1 = await client.SetTaskAsync("counter/node", obj);*/
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetTaskAsync("Information/" + textBox1.Text);
            Data obj = response.ResultAs<Data>();


            textBox1.Text = obj.homeID;
            textBox2.Text = obj.CitizenID;
            textBox3.Text = obj.Name;
            textBox4.Text = obj.NIC;
            textBox5.Text = obj.Birthday;
            textBox6.Text = obj.gender;
            textBox7.Text = obj.Maritaul_status_ID;
            textBox8.Text = obj.email;
            textBox9.Text = obj.Nationality;
            textBox10.Text = obj.job;
            textBox15.Text = obj.village;
            textBox14.Text = obj.Allowance;
            textBox13.Text = obj.Landpolicy;
            textBox12.Text = obj.house_type;
            textBox11.Text = obj.water_type;
            textBox20.Text = obj.Disability;
            textBox19.Text = obj.power_supply;
            textBox18.Text = obj.toilets;
            textBox16.Text = obj.education_qulification;

            MessageBox.Show("Data Retrive succesfully");
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                homeID = textBox1.Text,
                CitizenID = textBox2.Text,
                Name = textBox3.Text,
                NIC = textBox4.Text,
                Birthday = textBox5.Text,
                gender = textBox6.Text,
                Maritaul_status_ID = textBox7.Text,
                email = textBox8.Text,
                Nationality = textBox9.Text,
                job = textBox10.Text,
                village = textBox15.Text,
                Allowance = textBox14.Text,
                Landpolicy = textBox13.Text,
                house_type = textBox12.Text,
                water_type = textBox11.Text,
                Disability = textBox20.Text,
                power_supply = textBox19.Text,
                toilets = textBox18.Text,
                education_qulification = textBox16.Text

            };

            FirebaseResponse response = await client.UpdateTaskAsync("Information/" + textBox1.Text, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Data Update successfully" + result.homeID);
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Information/" + textBox1.Text);
            MessageBox.Show("Data Delete successfully" + textBox1.Text);
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            export();
        }
        private async void export()
        {
            dt.Rows.Clear();
            int i = 0;
            FirebaseResponse resp1 = await client.GetTaskAsync("counter/node");
            Counter_class obj1 = resp1.ResultAs<Counter_class>();
            int cnt = Convert.ToInt32(obj1.cnt);


           

            while (true)
            {
                if(i==cnt)
                {
                    break;
                }

                i++;
                try
                {
                    FirebaseResponse resp2 = await client.GetTaskAsync("Information/"+i);
                    Data obj2 = resp2.ResultAs<Data>();
                    DataRow row = dt.NewRow();

                    /*foreach (DataRow item in dtdepartment.Rows)
           {
               int n = departmentdataGridView1.Rows.Add();
               departmentdataGridView1.Rows[n].Cells[0].Value = item["D_ID"].ToString();
               departmentdataGridView1.Rows[n].Cells[1].Value = item["D_name"].ToString();
               departmentdataGridView1.Rows[n].Cells[2].Value = item["Desicnation"].ToString();

           }*/




            row["homeID"] = obj2.homeID;
                    row["CitizenID"] = obj2.CitizenID;
                    row["Name"] = obj2.Name;
                    row["NIC"] = obj2.NIC;
                    row["Birthday"] = obj2.Birthday;
                    row["gender"] = obj2.gender;
                    row["Maritaul_status_ID"] = obj2.Maritaul_status_ID;
                    row["email"] = obj2.email;
                    row["Nationality"] = obj2.Nationality;
                    row["job"] = obj2.job;
                    row["village"] = obj2.village;
                    row["Allowance"] = obj2.Allowance;
                    row["Landpolicy"] = obj2.Landpolicy;
                    row["house_type"] = obj2.house_type;
                    row["water_type"] = obj2.water_type;
                    row["Disability"] = obj2.Disability;
                    row["power_supply"] = obj2.power_supply;
                    row["toilets"] = obj2.toilets;
                    row["education_qulification"] = obj2.education_qulification;
                    

                    dt.Rows.Add(row);

                    
                }
                catch
                {


                }

            }


            MessageBox.Show(cnt.ToString());

        }
           /* 

            FirebaseResponse resp = client.Get(@"counter");
            int counter = int.Parse(resp.ResultAs<string>());
            for (int i = 0; i < counter; i++)
            {
                FirebaseResponse resp2 = client.Get(@"homeID" + i);
                string homeID = resp2.ResultAs<string>();

                dataGridView1.Rows
            }


        }
    
      /* private async void export2() { 
        Counter_class XClass = new Counter_class();
        FirebaseResponse firebaseResponse = await client.GetTaskAsync("Counter/node");
        string JsTxt = response.obj2;
                if (JsTxt == "null")
                {

                    return ;
                }

        dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(JsTxt);
        var list = new List<Counter_class>();
                foreach (var itemDynamic in data)
                {
                  list.Add(JsonConvert.DeserializeObject<Counter_class> 
                  (((JProperty)itemDynamic).Value.ToString()));
                }
            // Now you have a list  you can loop through to put it at any suitable Visual  
            //control 


           /* foreach (DataRow item in dtdepartment.Rows)
            {
                int n = departmentdataGridView1.Rows.Add();
                departmentdataGridView1.Rows[n].Cells[0].Value = item["D_ID"].ToString();
                departmentdataGridView1.Rows[n].Cells[1].Value = item["D_name"].ToString();
                departmentdataGridView1.Rows[n].Cells[2].Value = item["Desicnation"].ToString();

            }
        */


           /* foreach (Counter_class _Xcls in list)
            {
                Invoke((MethodInvoker)delegate {
                    DataGridViewRow row=(DataGridViewRow)dg.Rows[0].Clone();
                    row.Cells[0].Value = _Xdcls...
                    row.Cells[1].Value = Xdcls...
                    row.Cells[2].Value = Xdcls...
                

                    ......
                    dg.Insert(0, row);

                }
}*/

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

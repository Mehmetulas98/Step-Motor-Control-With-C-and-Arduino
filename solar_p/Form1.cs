using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace solar_p
{
    public partial class Form1 : Form
    {
        int spray_pump_feed_rate;

        List<string> liste = new List<string>();

         
        string fileContent="";
        string filePath ="";

        string defaultY = "G91 Y";
        string defaultZ = "G91 Z";
        string defaultX = "G91 X";

        string F = "F";
        string Yas;



        string speedAxis;
        string gönd_data;
        //
        int step_size_value;
        int axis_moves_speed;
        //
        //
        string g_code;
        string current_g_code = "";
        //
        //////////////////////////// 
        string start_point_value;
        string end_point_value;
        string axis_value;
        string speed_value;

        ////////////////////////////
        bool isConnected = false;
        String[] ports;
        SerialPort port;
        public Form1()
        {
            InitializeComponent();
            disableControls();
            getAvailableComPorts();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                }
            }



        }

        private void combobox_connect_button_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                combobox_connect_button.Image = Image.FromFile("C:\\Users\\akdum\\OneDrive\\Masaüstü\\solar_p\\Esinotek_ui\\disconnect_1.png");
                connectToArduino();

                liste.Add("G28");
            }
            else
            {
                disconnectFromArduino();
                combobox_connect_button.Image = Image.FromFile("C:\\Users\\akdum\\OneDrive\\Masaüstü\\solar_p\\Esinotek_ui\\connect.png");
            }
        }
        private void connectToArduino()
        {
            
            try
            {
                isConnected = true;
                string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
                port = new SerialPort(selectedPort, 115200, Parity.None, 8, StopBits.One);
                port.Open();
                enableControls();
            }
            catch
            {
                MessageBox.Show("Lütfen Arduino Bağla.");
            }
             
            
             
            //button1.Text = "Disconnect";
            
        }
        private void disconnectFromArduino()
        {
            
            try
            {
                isConnected = false;
                port.Close();
                //button1.Text = "Connect";
                disableControls();
                resetDefaults();
            }
            catch
            {
                MessageBox.Show("dfdfd");
            }
           
        }
        private void resetDefaults()
        {
            //checkBox1.Checked = false;
            //checkBox2.Checked = false;
            //checkBox3.Checked = false;
            //textBox1.Text = "";

        }
        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }
        private void enableControls()
        {
            start_point_text.Enabled = true;
            end_point_text.Enabled = true;
            speed_text.Enabled = true;
            axis_box.Enabled = true;
            send_button.Enabled = true;
            spray_set_button.Enabled = true;
            delete_button.Enabled = true;
            upload_button.Enabled = true;
            save_button.Enabled = true;
            start_button.Enabled = true;
            pause_button.Enabled = true;
            spray_bar.Enabled = true;
            left_button.Enabled = true;
            right_button.Enabled = true;
            up_button.Enabled = true;
            down_button.Enabled = true;
            step_size_box.Enabled = true;
            step_size_button.Enabled = true;
            axis_moves_set_speed_button.Enabled = true;
            axis_speed_moves.Enabled = true;
            send_nozzle_to_home_button.Enabled = true;
            



        }
        private void disableControls()
        {
            start_point_text.Enabled = false;
            end_point_text.Enabled = false;
            speed_text.Enabled = false;
            axis_box.Enabled = false;
            send_button.Enabled = false;
            spray_set_button.Enabled = false;
            delete_button.Enabled = false;
            upload_button.Enabled = false;
            save_button.Enabled = false;
            start_button.Enabled = false;
            pause_button.Enabled = false;
            spray_bar.Enabled = false;
            left_button.Enabled = false;
            right_button.Enabled = false;
            up_button.Enabled = false;
            down_button.Enabled = false;
            step_size_box.Enabled = false;
            step_size_button.Enabled = false;
            axis_moves_set_speed_button.Enabled = false;
            axis_speed_moves.Enabled = false;
            send_nozzle_to_home_button.Enabled = false;


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //////////////////////////////////////////////////////////////////////////////////////////
        private void send_button_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                current_g_code = axis_value + "" + start_point_value + "  to  " + axis_value + end_point_value + "     Speed " + speed_value + "mm/min";


              
                
                
                 

                g_code_list_box.Items.Add(current_g_code);
                // Text to G-Code

                //g_code =  buraya sıralı halde gelicek
                g_code = "G01" + axis_value + end_point_value + F + speed_value;

                liste.Add(g_code);

                Console.WriteLine(liste[0]);
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            string[] arr = new string[g_code_list_box.Items.Count];
            for (int i = 0; i < g_code_list_box.Items.Count; i++)
                {
                    arr[i] = g_code_list_box.Items[i].ToString();
                //Console.WriteLine(arr[i].ToString());
                }
            for (int i = 0; i < g_code_list_box.Items.Count+1; i++)
                {
                port.WriteLine(liste[i]);
                }

            // Burada "arr" boşaltılır.
            arr = null;
        }
        private void pause_button_Click(object sender, EventArgs e)
        {
            // Buraya gcode gelicek
            port.WriteLine("M08");
             
        }
        
        //////////////////////////////////////////////////////////////////////////////////////////////
        private void start_point_text_TextChanged(object sender, EventArgs e)
        {

        }
        private void end_point_text_TextChanged(object sender, EventArgs e)
        {

        }
        private void speed_box_text_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void start_point_text_TextChanged_1(object sender, EventArgs e)
        {
            if(isConnected== true)
            {  
                start_point_value = start_point_text.Text;
                try
                {
                    Convert.ToInt32(start_point_value);
                }
                catch
                {
                }
            }
        }
        private void end_point_text_TextChanged_1(object sender, EventArgs e)
        {
            if (isConnected == true)
            {
                end_point_value = end_point_text.Text;
                try
                {
                    Convert.ToInt32(end_point_value);
                }
                catch
                {
                }
                
            }
        }
        private void speed_text_TextChanged(object sender, EventArgs e)
        {
            if (isConnected == true)
            {
                speed_value = speed_text.Text;
                try
                {
                    Convert.ToInt32(speed_value);
                }
                catch
                {
                }

            }
        }
        private void axis_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isConnected == true)
            {
                axis_value = axis_box.Text;   
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void gcode_text_TextChanged(object sender, EventArgs e)
        {

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void delete_button_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                g_code_list_box.Items.Clear();
                
            }
        }
        private void upload_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
                foreach (string line in lines)
                {
                    liste.Add(line);
                    g_code_list_box.Items.Add(line);
                }
            }
        }
        private void save_button_Click(object sender, EventArgs e)
        {
            //g_code_list_box buradaki kodları txt dosyası olarak kaydedicek
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TXT Dosyalar|*.txt";
            saveFileDialog.Title= "Save G-code";
            saveFileDialog.ShowDialog();
            StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
             
            for(int i = 0; i < liste.Count; i++)
            {
                sw.WriteLine(liste[i]);
            }
            sw.Close();
            MessageBox.Show("Save completed");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void up_button_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                try
                {
                    speedAxis = axis_speed_moves.Text;
                    Yas = step_size_box.Text;
                    if((speedAxis == "") && (Yas == "")){
                        MessageBox.Show(" Speed or step size are didn't entered.");
                    }
                    else
                    {
                        port.WriteLine(defaultY + Yas + F + speedAxis);
                    }
                }
                catch
                {
                    MessageBox.Show("Error Up");
                }
               
            }
        }

        private void left_button_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                try
                {
                    speedAxis = axis_speed_moves.Text;
                    Yas = step_size_box.Text;
                    if ((speedAxis == "") && (Yas == ""))
                    {
                        MessageBox.Show(" Speed or step size are didn't entered.");
                    }
                    else
                    {
                        port.WriteLine(defaultX + Yas + F + speedAxis);
                    }
                }
                catch
                {
                    MessageBox.Show("Error Left");
                }
            }
        }

        private void right_button_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                try
                {
                    speedAxis = axis_speed_moves.Text;
                    Yas = step_size_box.Text;
                    if ((speedAxis == "") && (Yas == ""))
                    {
                        MessageBox.Show(" Speed or step size are didn't entered.");
                    }
                    else
                    {
                        port.WriteLine(defaultY + Yas + "-" + F + speedAxis);
                    }
                }
                catch
                {
                    MessageBox.Show("Error Right");
                }
            }
        }

        private void down_button_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                try
                {
                    speedAxis = axis_speed_moves.Text;
                    Yas = step_size_box.Text;
                    if ((speedAxis == "") && (Yas == ""))
                    {
                        MessageBox.Show(" Speed or step size are didn't entered.");
                    }
                    else
                    {
                        port.WriteLine(defaultY + "-" + Yas + F + speedAxis);
                    }
                }
                catch
                {
                    MessageBox.Show("Error Down");
                }

            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            spray_bar.Maximum = 100;
            spray_bar.Maximum = 10;
        }
        private void spray_set_button_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                spray_feed_rate.Text=Convert.ToString(spray_bar.Value);
            }

        }
        private void send_nozzle_to_home_button_Click(object sender, EventArgs e)
        {
            // When push "SEND" button on bottom right, motor goes home position.
            // G28 is gcode for send home function.
            port.WriteLine("G28");
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void axis_moves_set_speed_button_Click(object sender, EventArgs e)
        {
            try
            {
                axis_moves_speed = Convert.ToInt32(axis_speed_moves.Text);
            }
            catch
            {
                MessageBox.Show("Moves speed Value didn't entered");
            }
        }
        private void step_size_button_Click(object sender, EventArgs e)
        {
            try
            {
                step_size_value = Convert.ToInt32(step_size_box.Text);
            }
            catch
            {
                MessageBox.Show("Step Size Value didn't entered");
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void g_code_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void spray_feed_rate_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }




        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}

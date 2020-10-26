namespace solar_p
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start_point_text = new System.Windows.Forms.TextBox();
            this.end_point_text = new System.Windows.Forms.TextBox();
            this.speed_text = new System.Windows.Forms.TextBox();
            this.axis_box = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.upload_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.send_nozzle_text = new System.Windows.Forms.TextBox();
            this.axis_moves_text = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.axis_speed_moves = new System.Windows.Forms.TextBox();
            this.axis_moves_set_speed_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.spray_bar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.g_code_list_box = new System.Windows.Forms.ListBox();
            this.spray_feed_rate = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.delete_button = new System.Windows.Forms.Button();
            this.step_size_button = new System.Windows.Forms.Button();
            this.step_size_box = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.send_nozzle_to_home_button = new System.Windows.Forms.Button();
            this.down_button = new System.Windows.Forms.Button();
            this.right_button = new System.Windows.Forms.Button();
            this.left_button = new System.Windows.Forms.Button();
            this.up_button = new System.Windows.Forms.Button();
            this.spray_set_button = new System.Windows.Forms.Button();
            this.combobox_connect_button = new System.Windows.Forms.Button();
            this.send_button = new System.Windows.Forms.Button();
            this.pause_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.spray_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start_point_text
            // 
            this.start_point_text.Location = new System.Drawing.Point(59, 158);
            this.start_point_text.Name = "start_point_text";
            this.start_point_text.Size = new System.Drawing.Size(100, 22);
            this.start_point_text.TabIndex = 5;
            this.start_point_text.TextChanged += new System.EventHandler(this.start_point_text_TextChanged_1);
            // 
            // end_point_text
            // 
            this.end_point_text.Location = new System.Drawing.Point(165, 158);
            this.end_point_text.Name = "end_point_text";
            this.end_point_text.Size = new System.Drawing.Size(100, 22);
            this.end_point_text.TabIndex = 6;
            this.end_point_text.TextChanged += new System.EventHandler(this.end_point_text_TextChanged_1);
            // 
            // speed_text
            // 
            this.speed_text.Location = new System.Drawing.Point(271, 158);
            this.speed_text.Name = "speed_text";
            this.speed_text.Size = new System.Drawing.Size(100, 22);
            this.speed_text.TabIndex = 7;
            this.speed_text.TextChanged += new System.EventHandler(this.speed_text_TextChanged);
            // 
            // axis_box
            // 
            this.axis_box.DisplayMember = "x";
            this.axis_box.FormattingEnabled = true;
            this.axis_box.Items.AddRange(new object[] {
            "X",
            "Y"});
            this.axis_box.Location = new System.Drawing.Point(377, 156);
            this.axis_box.Name = "axis_box";
            this.axis_box.Size = new System.Drawing.Size(121, 24);
            this.axis_box.TabIndex = 9;
            this.axis_box.SelectedIndexChanged += new System.EventHandler(this.axis_box_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(59, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 15);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Select Port";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // upload_button
            // 
            this.upload_button.Location = new System.Drawing.Point(177, 525);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(75, 23);
            this.upload_button.TabIndex = 15;
            this.upload_button.Text = "Upload";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(271, 525);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 16;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // send_nozzle_text
            // 
            this.send_nozzle_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.send_nozzle_text.Location = new System.Drawing.Point(1053, 576);
            this.send_nozzle_text.Name = "send_nozzle_text";
            this.send_nozzle_text.Size = new System.Drawing.Size(183, 15);
            this.send_nozzle_text.TabIndex = 24;
            this.send_nozzle_text.Text = "Send Nozzle to Home";
            this.send_nozzle_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // axis_moves_text
            // 
            this.axis_moves_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.axis_moves_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.axis_moves_text.Location = new System.Drawing.Point(957, 228);
            this.axis_moves_text.Name = "axis_moves_text";
            this.axis_moves_text.Size = new System.Drawing.Size(151, 31);
            this.axis_moves_text.TabIndex = 25;
            this.axis_moves_text.Text = "Axis Moves";
            this.axis_moves_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.AcceptsReturn = true;
            this.textBox6.AllowDrop = true;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(940, 576);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 15);
            this.textBox6.TabIndex = 27;
            this.textBox6.Text = "Set speed ";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // axis_speed_moves
            // 
            this.axis_speed_moves.Location = new System.Drawing.Point(940, 597);
            this.axis_speed_moves.Name = "axis_speed_moves";
            this.axis_speed_moves.Size = new System.Drawing.Size(100, 22);
            this.axis_speed_moves.TabIndex = 28;
            this.axis_speed_moves.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // axis_moves_set_speed_button
            // 
            this.axis_moves_set_speed_button.Location = new System.Drawing.Point(953, 625);
            this.axis_moves_set_speed_button.Name = "axis_moves_set_speed_button";
            this.axis_moves_set_speed_button.Size = new System.Drawing.Size(75, 23);
            this.axis_moves_set_speed_button.TabIndex = 29;
            this.axis_moves_set_speed_button.Text = "OK";
            this.axis_moves_set_speed_button.UseVisualStyleBackColor = true;
            this.axis_moves_set_speed_button.Click += new System.EventHandler(this.axis_moves_set_speed_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Start Point";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 776);
            this.splitter1.TabIndex = 31;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 776);
            this.splitter2.TabIndex = 32;
            this.splitter2.TabStop = false;
            // 
            // spray_bar
            // 
            this.spray_bar.Location = new System.Drawing.Point(460, 312);
            this.spray_bar.Name = "spray_bar";
            this.spray_bar.Size = new System.Drawing.Size(270, 56);
            this.spray_bar.TabIndex = 33;
            this.spray_bar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(456, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Spray Pump Feed Rate (ml/min)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "End Point";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Axis";
            // 
            // g_code_list_box
            // 
            this.g_code_list_box.FormattingEnabled = true;
            this.g_code_list_box.ItemHeight = 16;
            this.g_code_list_box.Location = new System.Drawing.Point(87, 293);
            this.g_code_list_box.Name = "g_code_list_box";
            this.g_code_list_box.Size = new System.Drawing.Size(262, 164);
            this.g_code_list_box.TabIndex = 39;
            this.g_code_list_box.SelectedIndexChanged += new System.EventHandler(this.g_code_list_box_SelectedIndexChanged);
            // 
            // spray_feed_rate
            // 
            this.spray_feed_rate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.spray_feed_rate.Location = new System.Drawing.Point(736, 312);
            this.spray_feed_rate.Name = "spray_feed_rate";
            this.spray_feed_rate.Size = new System.Drawing.Size(100, 15);
            this.spray_feed_rate.TabIndex = 40;
            this.spray_feed_rate.Text = "0";
            this.spray_feed_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spray_feed_rate.TextChanged += new System.EventHandler(this.spray_feed_rate_TextChanged);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(87, 525);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 41;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // step_size_button
            // 
            this.step_size_button.Location = new System.Drawing.Point(832, 625);
            this.step_size_button.Name = "step_size_button";
            this.step_size_button.Size = new System.Drawing.Size(75, 23);
            this.step_size_button.TabIndex = 42;
            this.step_size_button.Text = "OK";
            this.step_size_button.UseVisualStyleBackColor = true;
            this.step_size_button.Click += new System.EventHandler(this.step_size_button_Click);
            // 
            // step_size_box
            // 
            this.step_size_box.Location = new System.Drawing.Point(822, 597);
            this.step_size_box.Name = "step_size_box";
            this.step_size_box.Size = new System.Drawing.Size(100, 22);
            this.step_size_box.TabIndex = 43;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(822, 576);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 15);
            this.textBox1.TabIndex = 44;
            this.textBox1.Text = "Step Size";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::solar_p.Properties.Resources.axis;
            this.pictureBox1.Location = new System.Drawing.Point(899, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // send_nozzle_to_home_button
            // 
            this.send_nozzle_to_home_button.Image = global::solar_p.Properties.Resources.send1;
            this.send_nozzle_to_home_button.Location = new System.Drawing.Point(1084, 597);
            this.send_nozzle_to_home_button.Name = "send_nozzle_to_home_button";
            this.send_nozzle_to_home_button.Size = new System.Drawing.Size(118, 35);
            this.send_nozzle_to_home_button.TabIndex = 23;
            this.send_nozzle_to_home_button.UseVisualStyleBackColor = true;
            this.send_nozzle_to_home_button.Click += new System.EventHandler(this.send_nozzle_to_home_button_Click);
            // 
            // down_button
            // 
            this.down_button.Image = global::solar_p.Properties.Resources.Down;
            this.down_button.Location = new System.Drawing.Point(976, 447);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(75, 80);
            this.down_button.TabIndex = 22;
            this.down_button.UseVisualStyleBackColor = true;
            this.down_button.Click += new System.EventHandler(this.down_button_Click);
            // 
            // right_button
            // 
            this.right_button.Image = global::solar_p.Properties.Resources.right;
            this.right_button.Location = new System.Drawing.Point(1053, 370);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(75, 76);
            this.right_button.TabIndex = 21;
            this.right_button.UseVisualStyleBackColor = true;
            this.right_button.Click += new System.EventHandler(this.right_button_Click);
            // 
            // left_button
            // 
            this.left_button.Image = global::solar_p.Properties.Resources.left;
            this.left_button.Location = new System.Drawing.Point(899, 370);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(75, 76);
            this.left_button.TabIndex = 20;
            this.left_button.UseVisualStyleBackColor = true;
            this.left_button.Click += new System.EventHandler(this.left_button_Click);
            // 
            // up_button
            // 
            this.up_button.BackColor = System.Drawing.Color.Transparent;
            this.up_button.ForeColor = System.Drawing.Color.Transparent;
            this.up_button.Image = global::solar_p.Properties.Resources.up;
            this.up_button.Location = new System.Drawing.Point(976, 293);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(75, 75);
            this.up_button.TabIndex = 19;
            this.up_button.UseVisualStyleBackColor = false;
            this.up_button.Click += new System.EventHandler(this.up_button_Click);
            // 
            // spray_set_button
            // 
            this.spray_set_button.Image = global::solar_p.Properties.Resources.set;
            this.spray_set_button.Location = new System.Drawing.Point(555, 370);
            this.spray_set_button.Name = "spray_set_button";
            this.spray_set_button.Size = new System.Drawing.Size(69, 32);
            this.spray_set_button.TabIndex = 18;
            this.spray_set_button.UseVisualStyleBackColor = true;
            this.spray_set_button.Click += new System.EventHandler(this.spray_set_button_Click);
            // 
            // combobox_connect_button
            // 
            this.combobox_connect_button.Image = global::solar_p.Properties.Resources.connect;
            this.combobox_connect_button.Location = new System.Drawing.Point(195, 46);
            this.combobox_connect_button.Name = "combobox_connect_button";
            this.combobox_connect_button.Size = new System.Drawing.Size(101, 32);
            this.combobox_connect_button.TabIndex = 12;
            this.combobox_connect_button.UseVisualStyleBackColor = true;
            this.combobox_connect_button.Click += new System.EventHandler(this.combobox_connect_button_Click);
            // 
            // send_button
            // 
            this.send_button.Image = global::solar_p.Properties.Resources.Send;
            this.send_button.Location = new System.Drawing.Point(504, 150);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(120, 38);
            this.send_button.TabIndex = 10;
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // pause_button
            // 
            this.pause_button.Image = global::solar_p.Properties.Resources.pause;
            this.pause_button.Location = new System.Drawing.Point(504, 580);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(169, 52);
            this.pause_button.TabIndex = 1;
            this.pause_button.UseVisualStyleBackColor = true;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // start_button
            // 
            this.start_button.Image = global::solar_p.Properties.Resources.start;
            this.start_button.Location = new System.Drawing.Point(504, 525);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(169, 49);
            this.start_button.TabIndex = 0;
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1281, 776);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.step_size_box);
            this.Controls.Add(this.step_size_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.spray_feed_rate);
            this.Controls.Add(this.g_code_list_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spray_bar);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axis_moves_set_speed_button);
            this.Controls.Add(this.axis_speed_moves);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.axis_moves_text);
            this.Controls.Add(this.send_nozzle_text);
            this.Controls.Add(this.send_nozzle_to_home_button);
            this.Controls.Add(this.down_button);
            this.Controls.Add(this.right_button);
            this.Controls.Add(this.left_button);
            this.Controls.Add(this.up_button);
            this.Controls.Add(this.spray_set_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.upload_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.combobox_connect_button);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.axis_box);
            this.Controls.Add(this.speed_text);
            this.Controls.Add(this.end_point_text);
            this.Controls.Add(this.start_point_text);
            this.Controls.Add(this.pause_button);
            this.Controls.Add(this.start_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spray_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button pause_button;
        private System.Windows.Forms.TextBox start_point_text;
        private System.Windows.Forms.TextBox end_point_text;
        private System.Windows.Forms.TextBox speed_text;
        private System.Windows.Forms.ComboBox axis_box;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Button combobox_connect_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button spray_set_button;
        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.Button left_button;
        private System.Windows.Forms.Button right_button;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.Button send_nozzle_to_home_button;
        private System.Windows.Forms.TextBox send_nozzle_text;
        private System.Windows.Forms.TextBox axis_moves_text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox axis_speed_moves;
        private System.Windows.Forms.Button axis_moves_set_speed_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TrackBar spray_bar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox g_code_list_box;
        private System.Windows.Forms.TextBox spray_feed_rate;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button step_size_button;
        private System.Windows.Forms.TextBox step_size_box;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


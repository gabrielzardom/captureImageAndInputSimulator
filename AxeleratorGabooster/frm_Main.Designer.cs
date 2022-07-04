
namespace AxeleratorGabooster
{
    partial class frm_Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmr_configurator = new System.Windows.Forms.Timer(this.components);
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_ai = new System.Windows.Forms.Button();
            this.lbl_buttons = new System.Windows.Forms.Label();
            this.lbl_str_controls = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_str_mode = new System.Windows.Forms.Label();
            this.lbl_mouseX = new System.Windows.Forms.Label();
            this.lbl_mouseY = new System.Windows.Forms.Label();
            this.lbl_int_x = new System.Windows.Forms.Label();
            this.lbl_int_y = new System.Windows.Forms.Label();
            this.tmr_ai = new System.Windows.Forms.Timer(this.components);
            this.lbl_addional = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmr_configurator
            // 
            this.tmr_configurator.Tick += new System.EventHandler(this.tmr_configurator_Tick);
            // 
            // btn_config
            // 
            this.btn_config.Location = new System.Drawing.Point(25, 25);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(75, 25);
            this.btn_config.TabIndex = 0;
            this.btn_config.Text = "CONFIG";
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // btn_ai
            // 
            this.btn_ai.Location = new System.Drawing.Point(125, 25);
            this.btn_ai.Name = "btn_ai";
            this.btn_ai.Size = new System.Drawing.Size(75, 25);
            this.btn_ai.TabIndex = 1;
            this.btn_ai.Text = "AI";
            this.btn_ai.UseVisualStyleBackColor = true;
            this.btn_ai.Click += new System.EventHandler(this.btn_ai_Click);
            // 
            // lbl_buttons
            // 
            this.lbl_buttons.AutoSize = true;
            this.lbl_buttons.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buttons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_buttons.Location = new System.Drawing.Point(225, 25);
            this.lbl_buttons.Name = "lbl_buttons";
            this.lbl_buttons.Size = new System.Drawing.Size(120, 32);
            this.lbl_buttons.TabIndex = 2;
            this.lbl_buttons.Text = "Buttons:";
            // 
            // lbl_str_controls
            // 
            this.lbl_str_controls.AutoSize = true;
            this.lbl_str_controls.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_str_controls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_str_controls.Location = new System.Drawing.Point(350, 25);
            this.lbl_str_controls.Name = "lbl_str_controls";
            this.lbl_str_controls.Size = new System.Drawing.Size(129, 32);
            this.lbl_str_controls.TabIndex = 3;
            this.lbl_str_controls.Text = "Controls.";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_status.Location = new System.Drawing.Point(25, 75);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(104, 32);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "Status:";
            // 
            // lbl_str_mode
            // 
            this.lbl_str_mode.AutoSize = true;
            this.lbl_str_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_str_mode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_str_mode.Location = new System.Drawing.Point(150, 75);
            this.lbl_str_mode.Name = "lbl_str_mode";
            this.lbl_str_mode.Size = new System.Drawing.Size(94, 32);
            this.lbl_str_mode.TabIndex = 5;
            this.lbl_str_mode.Text = "Mode.";
            // 
            // lbl_mouseX
            // 
            this.lbl_mouseX.AutoSize = true;
            this.lbl_mouseX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mouseX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_mouseX.Location = new System.Drawing.Point(25, 125);
            this.lbl_mouseX.Name = "lbl_mouseX";
            this.lbl_mouseX.Size = new System.Drawing.Size(127, 32);
            this.lbl_mouseX.TabIndex = 6;
            this.lbl_mouseX.Text = "MouseX:";
            // 
            // lbl_mouseY
            // 
            this.lbl_mouseY.AutoSize = true;
            this.lbl_mouseY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mouseY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_mouseY.Location = new System.Drawing.Point(25, 175);
            this.lbl_mouseY.Name = "lbl_mouseY";
            this.lbl_mouseY.Size = new System.Drawing.Size(127, 32);
            this.lbl_mouseY.TabIndex = 7;
            this.lbl_mouseY.Text = "MouseY:";
            // 
            // lbl_int_x
            // 
            this.lbl_int_x.AutoSize = true;
            this.lbl_int_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_int_x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_int_x.Location = new System.Drawing.Point(150, 125);
            this.lbl_int_x.Name = "lbl_int_x";
            this.lbl_int_x.Size = new System.Drawing.Size(83, 32);
            this.lbl_int_x.TabIndex = 8;
            this.lbl_int_x.Text = "Int_x.";
            // 
            // lbl_int_y
            // 
            this.lbl_int_y.AutoSize = true;
            this.lbl_int_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_int_y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_int_y.Location = new System.Drawing.Point(150, 175);
            this.lbl_int_y.Name = "lbl_int_y";
            this.lbl_int_y.Size = new System.Drawing.Size(83, 32);
            this.lbl_int_y.TabIndex = 9;
            this.lbl_int_y.Text = "Int_y.";
            // 
            // tmr_ai
            // 
            this.tmr_ai.Tick += new System.EventHandler(this.tmr_ai_Tick);
            // 
            // lbl_addional
            // 
            this.lbl_addional.AutoSize = true;
            this.lbl_addional.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_addional.Location = new System.Drawing.Point(25, 225);
            this.lbl_addional.Name = "lbl_addional";
            this.lbl_addional.Size = new System.Drawing.Size(128, 32);
            this.lbl_addional.TabIndex = 10;
            this.lbl_addional.Text = "Addition:";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_info.Location = new System.Drawing.Point(150, 225);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(70, 32);
            this.lbl_info.TabIndex = 11;
            this.lbl_info.Text = "Info.";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.lbl_addional);
            this.Controls.Add(this.lbl_int_y);
            this.Controls.Add(this.lbl_int_x);
            this.Controls.Add(this.lbl_mouseY);
            this.Controls.Add(this.lbl_mouseX);
            this.Controls.Add(this.lbl_str_mode);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_str_controls);
            this.Controls.Add(this.lbl_buttons);
            this.Controls.Add(this.btn_ai);
            this.Controls.Add(this.btn_config);
            this.Name = "frm_Main";
            this.Text = "AxeleratorGabooster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr_configurator;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_ai;
        private System.Windows.Forms.Label lbl_buttons;
        private System.Windows.Forms.Label lbl_str_controls;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_str_mode;
        private System.Windows.Forms.Label lbl_mouseX;
        private System.Windows.Forms.Label lbl_mouseY;
        private System.Windows.Forms.Label lbl_int_x;
        private System.Windows.Forms.Label lbl_int_y;
        private System.Windows.Forms.Timer tmr_ai;
        private System.Windows.Forms.Label lbl_addional;
        private System.Windows.Forms.Label lbl_info;
    }
}


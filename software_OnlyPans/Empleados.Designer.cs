﻿
namespace software_OnlyPans
{
    partial class Empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnenviar = new System.Windows.Forms.Button();
            this.rbtnaliñado = new System.Windows.Forms.RadioButton();
            this.rbtnnoaliñado = new System.Windows.Forms.RadioButton();
            this.rbtnespecial = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaliñado = new System.Windows.Forms.TextBox();
            this.txtnoaliñado = new System.Windows.Forms.TextBox();
            this.txtespecial = new System.Windows.Forms.TextBox();
            this.rtxtresultado = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btncerrarsesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(731, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cedula";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(87, 153);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(175, 22);
            this.txtcedula.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "tipo de pan";
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(148, 395);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 11;
            this.btnenviar.Text = "enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // rbtnaliñado
            // 
            this.rbtnaliñado.AutoCheck = false;
            this.rbtnaliñado.AutoSize = true;
            this.rbtnaliñado.Location = new System.Drawing.Point(10, 4);
            this.rbtnaliñado.Name = "rbtnaliñado";
            this.rbtnaliñado.Size = new System.Drawing.Size(75, 21);
            this.rbtnaliñado.TabIndex = 12;
            this.rbtnaliñado.Text = "aliñado";
            this.rbtnaliñado.UseVisualStyleBackColor = true;
            this.rbtnaliñado.Click += new System.EventHandler(this.rtbnaliñadoclick);
            // 
            // rbtnnoaliñado
            // 
            this.rbtnnoaliñado.AutoCheck = false;
            this.rbtnnoaliñado.AutoSize = true;
            this.rbtnnoaliñado.Location = new System.Drawing.Point(10, 6);
            this.rbtnnoaliñado.Name = "rbtnnoaliñado";
            this.rbtnnoaliñado.Size = new System.Drawing.Size(95, 21);
            this.rbtnnoaliñado.TabIndex = 13;
            this.rbtnnoaliñado.Text = "no aliñado";
            this.rbtnnoaliñado.UseVisualStyleBackColor = true;
            this.rbtnnoaliñado.Click += new System.EventHandler(this.rbtnnoaliñadoclick);
            // 
            // rbtnespecial
            // 
            this.rbtnespecial.AutoCheck = false;
            this.rbtnespecial.AutoSize = true;
            this.rbtnespecial.Location = new System.Drawing.Point(10, 3);
            this.rbtnespecial.Name = "rbtnespecial";
            this.rbtnespecial.Size = new System.Drawing.Size(81, 21);
            this.rbtnespecial.TabIndex = 14;
            this.rbtnespecial.Text = "especial";
            this.rbtnespecial.UseVisualStyleBackColor = true;
            this.rbtnespecial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtnespecialclick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "cantidad";
            // 
            // txtaliñado
            // 
            this.txtaliñado.Location = new System.Drawing.Point(261, 257);
            this.txtaliñado.Name = "txtaliñado";
            this.txtaliñado.Size = new System.Drawing.Size(100, 22);
            this.txtaliñado.TabIndex = 16;
            // 
            // txtnoaliñado
            // 
            this.txtnoaliñado.Location = new System.Drawing.Point(261, 285);
            this.txtnoaliñado.Name = "txtnoaliñado";
            this.txtnoaliñado.Size = new System.Drawing.Size(100, 22);
            this.txtnoaliñado.TabIndex = 17;
            // 
            // txtespecial
            // 
            this.txtespecial.Location = new System.Drawing.Point(261, 313);
            this.txtespecial.Name = "txtespecial";
            this.txtespecial.Size = new System.Drawing.Size(100, 22);
            this.txtespecial.TabIndex = 18;
            // 
            // rtxtresultado
            // 
            this.rtxtresultado.Location = new System.Drawing.Point(458, 62);
            this.rtxtresultado.Name = "rtxtresultado";
            this.rtxtresultado.Size = new System.Drawing.Size(276, 273);
            this.rtxtresultado.TabIndex = 19;
            this.rtxtresultado.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(87, 70);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(175, 22);
            this.txtnombre.TabIndex = 21;
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.Location = new System.Drawing.Point(666, 405);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(108, 23);
            this.btncerrarsesion.TabIndex = 22;
            this.btncerrarsesion.Text = "cerrar sesión";
            this.btncerrarsesion.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnaliñado);
            this.panel1.Location = new System.Drawing.Point(87, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 25);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnnoaliñado);
            this.panel2.Location = new System.Drawing.Point(87, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 30);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtnespecial);
            this.panel3.Location = new System.Drawing.Point(87, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 30);
            this.panel3.TabIndex = 26;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncerrarsesion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxtresultado);
            this.Controls.Add(this.txtespecial);
            this.Controls.Add(this.txtnoaliñado);
            this.Controls.Add(this.txtaliñado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.RadioButton rbtnaliñado;
        private System.Windows.Forms.RadioButton rbtnnoaliñado;
        private System.Windows.Forms.RadioButton rbtnespecial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtaliñado;
        private System.Windows.Forms.TextBox txtnoaliñado;
        private System.Windows.Forms.TextBox txtespecial;
        private System.Windows.Forms.RichTextBox rtxtresultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btncerrarsesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
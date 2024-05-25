namespace AudioCombiner
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLoadCustomer;
        private System.Windows.Forms.Button btnLoadWindow;
        private System.Windows.Forms.Button btnLoadNumber;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnLoadCustomer = new Button();
            btnLoadWindow = new Button();
            btnLoadNumber = new Button();
            btnPlay = new Button();
            txtCustomerName = new TextBox();
            lblCustomerName = new Label();
            SuspendLayout();
            // 
            // btnLoadCustomer
            // 
            btnLoadCustomer.Location = new Point(12, 12);
            btnLoadCustomer.Name = "btnLoadCustomer";
            btnLoadCustomer.Size = new Size(200, 35);
            btnLoadCustomer.TabIndex = 0;
            btnLoadCustomer.Text = "Cargar Cliente";
            btnLoadCustomer.UseVisualStyleBackColor = true;
            btnLoadCustomer.Click += btnLoadCustomer_Click;
            // 
            // btnLoadWindow
            // 
            btnLoadWindow.Location = new Point(218, 12);
            btnLoadWindow.Name = "btnLoadWindow";
            btnLoadWindow.Size = new Size(200, 35);
            btnLoadWindow.TabIndex = 1;
            btnLoadWindow.Text = "Cargar Ventana";
            btnLoadWindow.UseVisualStyleBackColor = true;
            btnLoadWindow.Click += btnLoadWindow_Click;
            // 
            // btnLoadNumber
            // 
            btnLoadNumber.Location = new Point(433, 12);
            btnLoadNumber.Name = "btnLoadNumber";
            btnLoadNumber.Size = new Size(200, 35);
            btnLoadNumber.TabIndex = 2;
            btnLoadNumber.Text = "Cargar Número";
            btnLoadNumber.UseVisualStyleBackColor = true;
            btnLoadNumber.Click += btnLoadNumber_Click;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(218, 73);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(200, 37);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "Reproducir";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(12, 73);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(200, 27);
            txtCustomerName.TabIndex = 4;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(12, 50);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(139, 20);
            lblCustomerName.TabIndex = 5;
            lblCustomerName.Text = "Nombre del Cliente";
            // 
            // Form1
            // 
            ClientSize = new Size(668, 142);
            Controls.Add(lblCustomerName);
            Controls.Add(txtCustomerName);
            Controls.Add(btnPlay);
            Controls.Add(btnLoadNumber);
            Controls.Add(btnLoadWindow);
            Controls.Add(btnLoadCustomer);
            Name = "Form1";
            Text = "Audio Combiner";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

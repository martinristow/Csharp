namespace WindowsFormsApp24
{
    partial class Form1
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
            this.btnPresmetaj = new System.Windows.Forms.Button();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPresmetaj
            // 
            this.btnPresmetaj.Location = new System.Drawing.Point(480, 109);
            this.btnPresmetaj.Name = "btnPresmetaj";
            this.btnPresmetaj.Size = new System.Drawing.Size(75, 23);
            this.btnPresmetaj.TabIndex = 0;
            this.btnPresmetaj.Text = "button1";
            this.btnPresmetaj.UseVisualStyleBackColor = true;
            this.btnPresmetaj.Click += new System.EventHandler(this.btnPresmetaj_Click);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(379, 219);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(44, 16);
            this.lblRezultat.TabIndex = 1;
            this.lblRezultat.Text = "label1";
            this.lblRezultat.Click += new System.EventHandler(this.lblRezultat_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(193, 148);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(100, 22);
            this.txtString.TabIndex = 2;
            this.txtString.TextChanged += new System.EventHandler(this.txtString_TextChanged);
            this.txtString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtString_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.btnPresmetaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPresmetaj;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.TextBox txtString;
    }
}


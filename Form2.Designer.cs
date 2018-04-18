//Tyler Clark
//Alexander Marquette
namespace InsulinPump
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.needleBtn = new System.Windows.Forms.Button();
            this.lowBattBtn = new System.Windows.Forms.Button();
            this.insulinFailureBtn = new System.Windows.Forms.Button();
            this.insulinMissingBtn = new System.Windows.Forms.Button();
            this.sensorFailureBtn = new System.Windows.Forms.Button();
            this.needleFailBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TESTING/SIMULATION PURPOSES ONLY";
            // 
            // needleBtn
            // 
            this.needleBtn.Location = new System.Drawing.Point(100, 42);
            this.needleBtn.Name = "needleBtn";
            this.needleBtn.Size = new System.Drawing.Size(111, 41);
            this.needleBtn.TabIndex = 1;
            this.needleBtn.Text = "Simulate Needle Removal";
            this.needleBtn.UseVisualStyleBackColor = true;
            this.needleBtn.Click += new System.EventHandler(this.needleBtn_Click);
            // 
            // lowBattBtn
            // 
            this.lowBattBtn.Location = new System.Drawing.Point(100, 89);
            this.lowBattBtn.Name = "lowBattBtn";
            this.lowBattBtn.Size = new System.Drawing.Size(111, 41);
            this.lowBattBtn.TabIndex = 2;
            this.lowBattBtn.Text = "Simulate Low Battery";
            this.lowBattBtn.UseVisualStyleBackColor = true;
            this.lowBattBtn.Click += new System.EventHandler(this.lowBattBtn_Click);
            // 
            // insulinFailureBtn
            // 
            this.insulinFailureBtn.Location = new System.Drawing.Point(100, 136);
            this.insulinFailureBtn.Name = "insulinFailureBtn";
            this.insulinFailureBtn.Size = new System.Drawing.Size(111, 41);
            this.insulinFailureBtn.TabIndex = 4;
            this.insulinFailureBtn.Text = "Simulate Insulin Failure";
            this.insulinFailureBtn.UseVisualStyleBackColor = true;
            this.insulinFailureBtn.Click += new System.EventHandler(this.insulinFailureBtn_Click);
            // 
            // insulinMissingBtn
            // 
            this.insulinMissingBtn.Location = new System.Drawing.Point(217, 136);
            this.insulinMissingBtn.Name = "insulinMissingBtn";
            this.insulinMissingBtn.Size = new System.Drawing.Size(111, 41);
            this.insulinMissingBtn.TabIndex = 5;
            this.insulinMissingBtn.Text = "Simulate Missing Insulin";
            this.insulinMissingBtn.UseVisualStyleBackColor = true;
            this.insulinMissingBtn.Click += new System.EventHandler(this.insulinMissingBtn_Click);
            // 
            // sensorFailureBtn
            // 
            this.sensorFailureBtn.Location = new System.Drawing.Point(217, 89);
            this.sensorFailureBtn.Name = "sensorFailureBtn";
            this.sensorFailureBtn.Size = new System.Drawing.Size(111, 41);
            this.sensorFailureBtn.TabIndex = 6;
            this.sensorFailureBtn.Text = "Simulate Sensor Failure";
            this.sensorFailureBtn.UseVisualStyleBackColor = true;
            this.sensorFailureBtn.Click += new System.EventHandler(this.sensorFailureBtn_Click);
            // 
            // needleFailBtn
            // 
            this.needleFailBtn.Location = new System.Drawing.Point(217, 42);
            this.needleFailBtn.Name = "needleFailBtn";
            this.needleFailBtn.Size = new System.Drawing.Size(111, 41);
            this.needleFailBtn.TabIndex = 7;
            this.needleFailBtn.Text = "Simulate Needle Failure";
            this.needleFailBtn.UseVisualStyleBackColor = true;
            this.needleFailBtn.Click += new System.EventHandler(this.needleFailBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(161, 183);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(111, 41);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Reset All Data";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 240);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.needleFailBtn);
            this.Controls.Add(this.sensorFailureBtn);
            this.Controls.Add(this.insulinMissingBtn);
            this.Controls.Add(this.insulinFailureBtn);
            this.Controls.Add(this.lowBattBtn);
            this.Controls.Add(this.needleBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Testing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button needleBtn;
        private System.Windows.Forms.Button lowBattBtn;
        private System.Windows.Forms.Button insulinFailureBtn;
        private System.Windows.Forms.Button insulinMissingBtn;
        private System.Windows.Forms.Button sensorFailureBtn;
        private System.Windows.Forms.Button needleFailBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}
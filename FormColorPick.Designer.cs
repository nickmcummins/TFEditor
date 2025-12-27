namespace TFEditor {
   partial class FormColorPick {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">True if managed resources should be disposed; otherwise, False.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support.
      /// The contents of this method should not be modified with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.labelColor = new System.Windows.Forms.Label();
         this.button_OK = new System.Windows.Forms.Button();
         this.button_Cancel = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // labelColor
         // 
         this.labelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.labelColor.Location = new System.Drawing.Point(12, 9);
         this.labelColor.Name = "labelColor";
         this.labelColor.Size = new System.Drawing.Size(210, 38);
         this.labelColor.TabIndex = 0;
         // 
         // button_OK
         // 
         this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.button_OK.Location = new System.Drawing.Point(12, 72);
         this.button_OK.Name = "button_OK";
         this.button_OK.Size = new System.Drawing.Size(86, 31);
         this.button_OK.TabIndex = 1;
         this.button_OK.Text = "OK";
         this.button_OK.UseVisualStyleBackColor = true;
         // 
         // button_Cancel
         // 
         this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.button_Cancel.Location = new System.Drawing.Point(136, 72);
         this.button_Cancel.Name = "button_Cancel";
         this.button_Cancel.Size = new System.Drawing.Size(86, 31);
         this.button_Cancel.TabIndex = 2;
         this.button_Cancel.Text = "Cancel";
         this.button_Cancel.UseVisualStyleBackColor = true;
         // 
         // FormColorPick
         // 
         this.AcceptButton = this.button_OK;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.button_Cancel;
         this.ClientSize = new System.Drawing.Size(234, 130);
         this.ControlBox = false;
         this.Controls.Add(this.button_Cancel);
         this.Controls.Add(this.button_OK);
         this.Controls.Add(this.labelColor);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Name = "FormColorPick";
         this.Text = "Set transparent color";
         this.Load += new System.EventHandler(this.FormColorPick_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label labelColor;
      private System.Windows.Forms.Button button_OK;
      private System.Windows.Forms.Button button_Cancel;
   }
}
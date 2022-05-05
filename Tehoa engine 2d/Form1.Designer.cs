using System;

namespace Tehoa_engine_2d
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SceneItems = new System.Windows.Forms.ListBox();
            this.OpenScene = new System.Windows.Forms.Button();
            this.SaveScene = new System.Windows.Forms.Button();
            this.CreateObject = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.inputBoxName = new System.Windows.Forms.TextBox();
            this.SaveObject = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SceneItems
            // 
            this.SceneItems.FormattingEnabled = true;
            this.SceneItems.Location = new System.Drawing.Point(1062, 12);
            this.SceneItems.Name = "SceneItems";
            this.SceneItems.Size = new System.Drawing.Size(370, 524);
            this.SceneItems.TabIndex = 0;
            this.SceneItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SceneItems_MouseDoubleClick);
            // 
            // OpenScene
            // 
            this.OpenScene.Location = new System.Drawing.Point(12, 630);
            this.OpenScene.Name = "OpenScene";
            this.OpenScene.Size = new System.Drawing.Size(75, 23);
            this.OpenScene.TabIndex = 1;
            this.OpenScene.Text = "Open scene";
            this.OpenScene.UseVisualStyleBackColor = true;
            this.OpenScene.Click += new System.EventHandler(this.OpenScene_Click);
            // 
            // SaveScene
            // 
            this.SaveScene.Location = new System.Drawing.Point(93, 630);
            this.SaveScene.Name = "SaveScene";
            this.SaveScene.Size = new System.Drawing.Size(75, 23);
            this.SaveScene.TabIndex = 2;
            this.SaveScene.Text = "Save scene";
            this.SaveScene.UseVisualStyleBackColor = true;
            this.SaveScene.Click += new System.EventHandler(this.SaveScene_Click);
            // 
            // CreateObject
            // 
            this.CreateObject.Location = new System.Drawing.Point(9, 90);
            this.CreateObject.Name = "CreateObject";
            this.CreateObject.Size = new System.Drawing.Size(121, 23);
            this.CreateObject.TabIndex = 3;
            this.CreateObject.Text = "Create object";
            this.CreateObject.UseVisualStyleBackColor = true;
            this.CreateObject.Click += new System.EventHandler(this.CreateObject_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(136, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(920, 524);
            this.dataGridView1.TabIndex = 5;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Text",
            "Sprite"});
            this.comboBoxType.Location = new System.Drawing.Point(9, 38);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 6;
            this.comboBoxType.Text = "Sprite";
            // 
            // inputBoxName
            // 
            this.inputBoxName.Location = new System.Drawing.Point(9, 12);
            this.inputBoxName.Name = "inputBoxName";
            this.inputBoxName.Size = new System.Drawing.Size(121, 20);
            this.inputBoxName.TabIndex = 7;
            this.inputBoxName.Text = "Name";
            // 
            // SaveObject
            // 
            this.SaveObject.Location = new System.Drawing.Point(1357, 542);
            this.SaveObject.Name = "SaveObject";
            this.SaveObject.Size = new System.Drawing.Size(75, 23);
            this.SaveObject.TabIndex = 8;
            this.SaveObject.Text = "Save object";
            this.SaveObject.UseVisualStyleBackColor = true;
            this.SaveObject.Click += new System.EventHandler(this.SaveObject_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "th";
            this.saveFileDialog1.FileName = "Scene";
            this.saveFileDialog1.Filter = "Tehoa files (*.th)|*.th";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "th";
            this.openFileDialog1.FileName = "Scene";
            this.openFileDialog1.Filter = "Tehoa files (*.th)|*.th";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 665);
            this.Controls.Add(this.SaveObject);
            this.Controls.Add(this.inputBoxName);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CreateObject);
            this.Controls.Add(this.SaveScene);
            this.Controls.Add(this.OpenScene);
            this.Controls.Add(this.SceneItems);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

  

        #endregion

        private System.Windows.Forms.ListBox SceneItems;
        private System.Windows.Forms.Button OpenScene;
        private System.Windows.Forms.Button SaveScene;
        private System.Windows.Forms.Button CreateObject;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox inputBoxName;
        private System.Windows.Forms.Button SaveObject;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


﻿namespace Tehoa_engine_2d
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
            this.LoadScene = new System.Windows.Forms.Button();
            this.CreateObject = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            // 
            // OpenScene
            // 
            this.OpenScene.Location = new System.Drawing.Point(12, 630);
            this.OpenScene.Name = "OpenScene";
            this.OpenScene.Size = new System.Drawing.Size(75, 23);
            this.OpenScene.TabIndex = 1;
            this.OpenScene.Text = "Open scene";
            this.OpenScene.UseVisualStyleBackColor = true;
            // 
            // LoadScene
            // 
            this.LoadScene.Location = new System.Drawing.Point(93, 630);
            this.LoadScene.Name = "LoadScene";
            this.LoadScene.Size = new System.Drawing.Size(75, 23);
            this.LoadScene.TabIndex = 2;
            this.LoadScene.Text = "Load scene";
            this.LoadScene.UseVisualStyleBackColor = true;
            // 
            // CreateObject
            // 
            this.CreateObject.Location = new System.Drawing.Point(24, 363);
            this.CreateObject.Name = "CreateObject";
            this.CreateObject.Size = new System.Drawing.Size(89, 23);
            this.CreateObject.TabIndex = 3;
            this.CreateObject.Text = "Create object";
            this.CreateObject.UseVisualStyleBackColor = true;
            this.CreateObject.Click += new System.EventHandler(this.CreateObject_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(118, 329);
            this.listBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(136, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(920, 524);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 665);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CreateObject);
            this.Controls.Add(this.LoadScene);
            this.Controls.Add(this.OpenScene);
            this.Controls.Add(this.SceneItems);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SceneItems;
        private System.Windows.Forms.Button OpenScene;
        private System.Windows.Forms.Button LoadScene;
        private System.Windows.Forms.Button CreateObject;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


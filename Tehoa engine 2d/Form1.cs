using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehoa_engine_2d
{
    public partial class Form1 : Form
    {
        private List<GameObject> objetOnScene = new List<GameObject>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateObject_Click(object sender, EventArgs e)
        {
            objetOnScene.Add(new GameObject
            {
                Position = new Vector2(2,3),
                Name = inputBoxName.Text,
                Type = comboBoxType.Text,
                SpritePath = "c:/Hiu"
            });
            UpdateList();
        }

        private void UpdateList()
        {
            SceneItems.Items.Clear();
            foreach (var item in objetOnScene)
            {
                SceneItems.Items.Add(item.Name+" (Type: "+item.Type+")");
            }
        }
    }
}

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
                position = new Vector2(2,3),
                name = "Test",
                spritePath = "c:/Hiu"
            });
            UpdateList();
        }

        private void UpdateList()
        {
            SceneItems.Items.Clear();
            for (int i = 0; i < objetOnScene.Count; i++)
            {
                SceneItems.Items.Add(objetOnScene[i].name);
            }
        }
    }
}

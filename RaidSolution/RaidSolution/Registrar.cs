using RaidSolution.Ferramentas;
using RaidSolution.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaidSolution
{
    public partial class Registrar : Form
    {
        private readonly GravarHeroiDB gravarHeroiDB; 
        public Registrar()
        {
            InitializeComponent();
            gravarHeroiDB = new GravarHeroiDB();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            var hero = new Heroi();
            hero.Nome = txt_nome.Text;
            if (rbtn_Void.Enabled)
            {
                hero.Tipo = "Void";
            }
            if (rbtn_spirit.Enabled)
            {
                hero.Tipo = "Spirit";
            }
            if (rbtn_Magic.Enabled)
            {
                hero.Tipo = "Magic";
            }
            if (rbtn_Force.Enabled)
            {
                hero.Tipo = "Force";
            }
            hero.HP = Convert.ToInt32(txt_hp.Text);
            hero.Attack = Convert.ToInt32(txt_attack.Text);
            hero.Defense = Convert.ToInt32(txt_defense.Text);
            hero.Speed = Convert.ToInt32(txt_speed.Text);
            hero.Resistence = Convert.ToInt32(txt_resistence.Text);
            hero.Accuracy = Convert.ToInt32(txt_accuracy.Text);
            hero.Spider = Convert.ToDouble(txt_spider.Text);
            hero.ClanBoss = Convert.ToDouble(txt_clanboss.Text);
            hero.Dragon = Convert.ToDouble(txt_dragon.Text);
            hero.IceGolem = Convert.ToDouble(txt_icegolem.Text);
            hero.FireKnight = Convert.ToDouble(txt_fireknight.Text);
            gravarHeroiDB.Add(hero);

            txt_nome.Text = "";
            txt_accuracy.Text = "";
            txt_attack.Text = "";
            txt_clanboss.Text = "";
            txt_defense.Text = "";
            txt_dragon.Text = "";
            txt_fireknight.Text = "";
            txt_hp.Text = "";
            txt_icegolem.Text = "";
            txt_resistence.Text = "";
            txt_speed.Text = "";
            txt_spider.Text = "";
            lbl_sucesso.Text = "Heroi gravado com sucesso!";
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

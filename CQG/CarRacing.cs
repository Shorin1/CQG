using CQG.Models;
using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Spatial;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WMPLib;

namespace CQG
{
    public partial class Form1 : Form
    {

        private const string IMG_PATH = @"Img\";

        private readonly Game _game = new Game();
        private readonly Thread _gameThread;

        public Form1()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(OnApplicationExit);

            typeof(DataGridView).InvokeMember(
                "DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null,
                layout,
                new object[] { true });

            scoreLabel.BackColor = Color.Transparent;
            hiScoreLabel.BackColor = Color.Transparent;
            speedLabel.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            healthLabel.BackColor = Color.Transparent;
            goalLabel.BackColor = Color.Transparent;

            CreateLayout();

            ThreadStart threadStart = new ThreadStart(StartGame);
            _gameThread = new Thread(threadStart);
            _gameThread.Start();
        }

        private void CreateLayout()
        {

            for (int i = 0; i < 10; i++)
            {
                DataGridViewImageColumn column = new DataGridViewImageColumn() { Width = 20 };
                column.Image = Image.FromFile(IMG_PATH + "white.png");
                layout.Columns.Add(column);
            }

            for (int i = 0; i < 20; i++)
            {
                DataGridViewRow row = new DataGridViewRow() { Height = 20 };
                layout.Rows.Add(row);
            }
        }

        private void StartGame()
        {
            NewGame();

            while (true)
            {
                Thread.Sleep(150 - _game.Speed * 10);
                _game.Tick();

                if (_game.Status == Models.Enums.GameStatus.Crash)
                    NewGame();

                SetScore(_game.Score.ToString());
                SetHiScore(_game.HiScore.ToString());
                SetHeahlt(_game.Health.ToString());
                SetGoal(_game.Goals.ToString());
                SetSpeed(_game.Speed.ToString());

                for (int i = 0; i < 10; i++) // x
                {
                    for (int j = 0; j < 20; j++) // y
                    {
                        if (_game.Layout.BlockIsOccupied[i, j])
                        {
                            layout.Rows[j].Cells[i].Value = Image.FromFile(IMG_PATH + "black.png");
                        }
                        else
                        {
                            layout.Rows[j].Cells[i].Value = Image.FromFile(IMG_PATH + "white.png");
                        }
                    }
                }
            }
        }

        private void SetScore(string value)
        {
            scoreLabel.Invoke(new Action<string>((s) => scoreLabel.Text = s), value);
        }

        private void SetHiScore(string value)
        {
            hiScoreLabel.Invoke(new Action<string>((s) => hiScoreLabel.Text = s), value);
        }

        private void SetHeahlt(string value)
        {
            healthLabel.Invoke(new Action<string>((s) => healthLabel.Text = s + "/4"), value);
        }

        private void SetGoal(string value)
        {
            goalLabel.Invoke(new Action<string>((s) => goalLabel.Text = s + "/50"), value);
        }

        private void SetSpeed(string value)
        {
            speedLabel.Invoke(new Action<string>((s) => speedLabel.Text = s), value);
        }

        private void NewGame()
        {
            for (int i = 19; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    Thread.Sleep(5);
                    layout.Rows[i].Cells[j].Value = Image.FromFile(IMG_PATH + "black.png");
                }
            }
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'd' || e.KeyChar == 'в')
                _game.MovePlayerCarRight();
            else if (e.KeyChar == 'a' || e.KeyChar == 'ф')
                _game.MovePlayerCarLeft();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            _gameThread.Abort();
        }
    }
}

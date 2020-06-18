using CQG.Models.Cars;
using CQG.Models.Enums;
using System;
using System.IO;

namespace CQG.Models
{
    public class Game
    {
        private const int DEFAULT_CREATE_ENEMY_INTERVAL = 9;
        private const int DEFAULT_BORDER_TICK_INTERVAL = 4;

        private const int DEFAULT_HEALTH = 4;

        public Layout Layout { get; private set; } = new Layout();
        public int HiScore { get; private set; }
        public int Score { get; private set; }
        public int Goals { get; private set; }
        public int Speed { get; private set; } = 1;
        public int Health { get; private set; } = DEFAULT_HEALTH;
        public GameStatus Status { get; private set; }

        private int _createEnemyInterval = 0;
        private int _borderTickInterval = 0;

        private bool _movingPlayerCarLeft = false;
        private bool _movingPlayerCarRight = false;

        private readonly Random _random = new Random();

        public Game()
        {
            HiScore = GetHiScore();
        }

        public void NewGame()
        {
            Layout.Player.SetDefaultPoisition();
            Layout.Enemies.Clear();
            Health--;

            if (Health == 0)
            {
                if (Score > HiScore)
                {
                    HiScore = Score;
                    SaveResult(Score.ToString());
                }

                Score = 0;
                Goals = 0;
                Speed = 0;
                Health = DEFAULT_HEALTH;
            }
        }

        public void Tick()
        {
            if (_movingPlayerCarLeft)
            {
                Layout.Player.MoveLeft();
                _movingPlayerCarLeft = false;
            }

            if (_movingPlayerCarRight)
            {
                Layout.Player.MoveRight();
                _movingPlayerCarRight = false;
            }

            foreach (Enemy enemy in Layout.Enemies)
                enemy.Tick();

            RemoveInvisibleCars();

            if (IsCrash())
            {
                Status = GameStatus.Crash;
                NewGame();
            }
            else
            {
                Status = GameStatus.Game;
            }

            foreach (Enemy enemy in Layout.Enemies)
            {
                if (enemy.Blocks[0].Y == Layout.Player.Blocks[6].Y)
                {
                    Goals++;
                    Score += 100 + 150 * (Speed - 1);
                }
            }

            _createEnemyInterval--;

            if (_createEnemyInterval <= 0)
            {
                int ranValue = _random.Next(2);

                if (ranValue == 1)
                {
                    CreateEnemy();
                    _createEnemyInterval = DEFAULT_CREATE_ENEMY_INTERVAL;
                }
            }

            if (Goals == 50 && Speed != 10)
            {
                Speed++;
                Goals = 0;
            }

            Layout.Clear();
            DrawBorders();
            DrawPlayerCar();
            DrawEnemyCars();
        }

        public void MovePlayerCarLeft()
        {
            if (!_movingPlayerCarRight)
                _movingPlayerCarLeft = true;
        }

        public void MovePlayerCarRight()
        {
            if (!_movingPlayerCarLeft)
                _movingPlayerCarRight = true;
        }

        private void CreateEnemy()
        {
            Enemy enemy = new Enemy();
            Layout.Enemies.Add(enemy);
        }

        private void RemoveInvisibleCars()
        {
            for (int i = 0; i < Layout.Enemies.Count; i++)
                if (Layout.Enemies[i].LifeTime == 0)
                    Layout.Enemies.RemoveAt(i);
        }

        private void DrawBorders()
        {
            for (int i = 19; i >= 0; i--)
            {
                while (i >= 0 && _borderTickInterval < DEFAULT_BORDER_TICK_INTERVAL)
                {
                    Layout.BlockIsOccupied[0, i] = true;
                    Layout.BlockIsOccupied[9, i] = true;
                    _borderTickInterval++;
                    i--;
                }

                if (i >= 0)
                {
                    Layout.BlockIsOccupied[0, i] = false;
                    Layout.BlockIsOccupied[9, i] = false;
                }

                if (_borderTickInterval == DEFAULT_BORDER_TICK_INTERVAL)
                    _borderTickInterval = 0;
            }

            _borderTickInterval++;
        }

        private void DrawPlayerCar()
        {
            foreach (Block block in Layout.Player.Blocks)
                Layout.BlockIsOccupied[block.X, block.Y] = true;
        }

        private void DrawEnemyCars()
        {
            foreach (Enemy enemy in Layout.Enemies)
                foreach (Block block in enemy.Blocks)
                    if (block.Y >= 0 && block.Y < 20)
                        Layout.BlockIsOccupied[block.X, block.Y] = true;
        }

        private bool IsCrash()
        {
            foreach (Enemy enemy in Layout.Enemies)
                foreach (Block enemyBlock in enemy.Blocks)
                    foreach (Block playerBlock in Layout.Player.Blocks)
                        if (enemyBlock.X == playerBlock.X &&
                            enemyBlock.Y == playerBlock.Y)
                            return true;

            return false;
        }

        private int GetHiScore()
        {
            StreamReader sr;

            try
            {
                sr = new StreamReader("hiScore.txt");
            }
            catch
            {
                File.Create("hiScore.txt");
                return 0;
            }

            string line = sr.ReadLine();
            sr.Close();
            return int.Parse(line);
        }

        private void SaveResult(string value)
        {
            StreamWriter sw = new StreamWriter("hiScore.txt", false);
            sw.WriteLine(value);
            sw.Close();
        }
    }
}

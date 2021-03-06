﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SnakeGameTester
{
	public partial class Form1 : Form
	{
		#region Fields

		public static SnakeHead head;
		public static SnakeSection lastAdded;
		public static Queue<SnakeSection> snakeQueue = new Queue<SnakeSection>();
		private int foodX;
		private int foodY;
		private Graphics g;
		private bool nomnomnom = false;

		#endregion Fields

		#region Constructors

		public Form1()
		{
			InitializeComponent();
			g = pbxPlayArea.CreateGraphics();
			nomnomnom = true;
			head = new SnakeHead();
			snakeQueue.Enqueue(head);
			lastAdded = snakeQueue.ElementAt(snakeQueue.Count - 1);
			lastAdded.SnakeSetup();
			foodGenNew();
		}

		#endregion Constructors

		#region Methods

		private void button1_Click(object sender, EventArgs e)
		{
			snakeQueue.Enqueue(new SnakeBody());
			lastAdded = snakeQueue.ElementAt(snakeQueue.Count - 1);
			lastAdded.previous = snakeQueue.ElementAt(snakeQueue.Count - 2);
			lastAdded.X = lastAdded.previous.LastX;
			lastAdded.Y = lastAdded.previous.LastY;
		}

		private bool collision()
		{
			foreach (SnakeSection part in snakeQueue)
			{
				if (part.GetType() != head.GetType() && part.X == head.X && part.Y == head.Y)
				{
					return true;
				}
			}
			if (head.X < 0 || head.X >= pbxPlayArea.Width - 32 ||
				head.Y < 0 || head.Y >= pbxPlayArea.Height - 32)
			{
				return true;
			}
			return false;
		}

		private bool consumedFood()
		{
			if (snakeQueue.First().X == foodX && snakeQueue.First().Y == foodY)
			{
				nomnomnom = true;
				snakeQueue.Enqueue(new SnakeBody());
				lastAdded = snakeQueue.ElementAt(snakeQueue.Count - 1);
				lastAdded.previous = snakeQueue.ElementAt(snakeQueue.Count - 2);
				lastAdded.X = lastAdded.previous.LastX;
				lastAdded.Y = lastAdded.previous.LastY;
			}
			else
			{
				nomnomnom = false;
			}
			return nomnomnom;
		}

		private void foodGenNew()
		{
			Brush selBrush = new SolidBrush(Color.Purple);
			foodX = new Random().Next(0, pbxPlayArea.Width / 32) * 32;
			foodY = new Random().Next(0, pbxPlayArea.Height / 32) * 32;
			g.FillRectangle(selBrush, foodX, foodY, 32, 32);
		}

		private void foodPersist()
		{
			Brush selBrush = new SolidBrush(Color.Purple);
			g.FillRectangle(selBrush, foodX, foodY, 32, 32);
		}

		private void frmZ2B_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.S:
				case Keys.Down:
					if (head.LastMove != Direction.up)
					{
						SnakeGameInfo.lastKey = Keys.Down;
					}
					break;

				case Keys.A:
				case Keys.Left:
					if (head.LastMove != Direction.right)
					{
						SnakeGameInfo.lastKey = Keys.Left;
					}
					break;

				case Keys.D:
				case Keys.Right:
					if (head.LastMove != Direction.left)
					{
						SnakeGameInfo.lastKey = Keys.Right;
					}
					break;

				case Keys.W:
				case Keys.Up:
					if (head.LastMove != Direction.down)
					{
						SnakeGameInfo.lastKey = Keys.Up;
					}
					break;

				default:
					break;
			}
		}

		private void frmZ2B_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			e.IsInputKey = true;
		}

		private void timerTicker_Tick(object sender, EventArgs e)
		{
			g.Clear(Color.ForestGreen);
			if (collision())
			{
				timerTicker.Stop();
				MessageBox.Show("Game Over");
			}
			if (consumedFood())
			{
				foodGenNew();
				nomnomnom = false;
			}
			else
			{
				foodPersist();
			}
			foreach (SnakeSection part in snakeQueue)
			{
				part.LastX = part.X;
				part.LastY = part.Y;

				switch (part.NextMove)
				{
					case Direction.up:
						part.Y -= 32;
						break;

					case Direction.down:
						part.Y += 32;
						break;

					case Direction.left:
						part.X -= 32;
						break;

					case Direction.right:
						part.X += 32;
						break;

					default:
						break;
				}
				g.DrawImage(part.image, part.X, part.Y, 32, 32);
			}
		}
		#endregion Methods

		private void Form1_KeyDown( object sender, KeyEventArgs e )
		{
			switch (e.KeyCode)
			{
				case Keys.A:
				case Keys.Left:
					SnakeGameInfo.lastKey = Keys.Left;
				 break;
				case Keys.Right:
				case Keys.D:
				 SnakeGameInfo.lastKey = Keys.Right;
				 break;
				case Keys.Up:
				case Keys.W:
				 SnakeGameInfo.lastKey = Keys.Up;
				 break;
				case Keys.Down:
				case Keys.S:
				 SnakeGameInfo.lastKey = Keys.Down;
				 break;
				case Keys.Space:
				 break;
				default:
				 break;
			}
		}
	}
}
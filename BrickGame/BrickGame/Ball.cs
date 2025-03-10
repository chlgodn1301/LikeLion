using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BrickGame
{
    public class Ball
    {
        BallData m_tBall = new BallData();

        // C# 공의 방향 배열 정의
        int[,] g_WallCollision = new int[4, 6]
        {
            {  3,  2, -1, -1, -1,  4 },
            { -1, -1, -1, -1,  2,  1 },
            { -1,  5,  4, -1, -1, -1 },
            { -1, -1,  1,  0,  5, -1 }
        };


        Bar m_pBar;
        //Bar 클래스 가져오기
        public void SetBar(Bar bar) { m_pBar = bar; }

        public BallData GetBall() { return m_tBall; }
        public void SetX(int x) { m_tBall.nX += x; }
        public void SetY(int y) { m_tBall.nY += y; }
        public void SetBall(BallData tBall) { m_tBall = tBall; }
        public void SetReady(int Ready) { m_tBall.nReady = Ready; }



        // 움직일 bar
        // block

        public void ScreenWall()
        {
            Program.GotoXY(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Program.GotoXY(0, 1);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 2);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 3);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 4);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 5);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 6);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 7);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 8);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 9);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 10);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 11);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 12);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 13);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 14);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 15);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 16);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 17);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 18);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 19);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 20);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 21);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 22);
            Console.Write("┃                                                                             ┃");
            Program.GotoXY(0, 23);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

        }


        public int Collision(int x, int y)
        {
            // 벽 충돌
            if (y == 0)
            {
                m_tBall.nDirect = g_WallCollision[0, m_tBall.nDirect];
                return 1;   // 공의 방향이 바뀌면 1 리턴
            }
            if (x == 1)
            {
                m_tBall.nDirect = g_WallCollision[1, m_tBall.nDirect];
                return 1;
            }
            if (x == 77)
            {
                m_tBall.nDirect = g_WallCollision[2, m_tBall.nDirect];
                return 1;
            }
            if (y == 23)
            {
                m_tBall.nDirect = g_WallCollision[3, m_tBall.nDirect];
                return 1;
            }


            //Bar충돌처리
            if (x >= m_pBar.m_tBar.nX[0] && x <= m_pBar.m_tBar.nX[2] + 1 &&
                y == (m_pBar.m_tBar.nY)) //바 위 충돌
            {
                if (m_tBall.nDirect == 1)
                    m_tBall.nDirect = 2;
                else if (m_tBall.nDirect == 2)
                    m_tBall.nDirect = 1;
                else if (m_tBall.nDirect == 5)
                    m_tBall.nDirect = 4;
                else if (m_tBall.nDirect == 4)
                    m_tBall.nDirect = 5;

                return 1; //방향이 바뀐다.
            }

            if (x >= m_pBar.m_tBar.nX[0] && x <= m_pBar.m_tBar.nX[2] + 1 &&
              y == (m_pBar.m_tBar.nY + 1)) //바 아래 충돌
            {
                if (m_tBall.nDirect == 1)
                    m_tBall.nDirect = 2;
                else if (m_tBall.nDirect == 2)
                    m_tBall.nDirect = 1;
                else if (m_tBall.nDirect == 5)
                    m_tBall.nDirect = 4;
                else if (m_tBall.nDirect == 4)
                    m_tBall.nDirect = 5;

                return 1; //방향이 바뀐다.
            }


            return 0;
        }

        



        public void Initialize()
        {
            m_tBall.nReady = 0; // 공 안움직임 1 움직임 0
            m_tBall.nDirect = 1;
            m_tBall.nX = 30;
            m_tBall.nY = 10;

            // 커서 안보이게 하기
            Console.CursorVisible = false;
        }


        public void Progress()
        {
            if (m_tBall.nReady == 0)    // 0 움직임
            {
                // 공의 방향에 따른 스위치문
                switch (m_tBall.nDirect)
                {
                    case 0: // 위
                        if(Collision(m_tBall.nX, m_tBall.nY - 1) == 0)
                            m_tBall.nY--;
                        break;
                    case 1: // 오른쪽 위
                        if (Collision(m_tBall.nX + 1, m_tBall.nY - 1) == 0)
                        {
                            m_tBall.nX++;
                            m_tBall.nY--;
                        }
                        break;
                    case 2:  // 오른쪽 아래
                        if (Collision(m_tBall.nX + 1, m_tBall.nY + 1) == 0)
                        {
                            m_tBall.nX++;
                            m_tBall.nY++;
                        }
                        break;
                    case 3:  // 아래
                        if (Collision(m_tBall.nX , m_tBall.nY + 1) == 0)
                        {
                            m_tBall.nY++;
                        }
                        break;
                    case 4:  // 왼쪽 아래
                        if (Collision(m_tBall.nX - 1, m_tBall.nY + 1) == 0)
                        {
                            m_tBall.nX--;
                            m_tBall.nY++;
                        }
                        break;
                    case 5:  // 왼쪽 위
                        if (Collision(m_tBall.nX - 1, m_tBall.nY - 1) == 0)
                        {
                            m_tBall.nX--;
                            m_tBall.nY--;
                        }
                        break;
                }
            }
        }


        public void Render()
        {
            ScreenWall();
            Program.GotoXY(m_tBall.nX, m_tBall.nY);
            Console.Write("●");
        }

        public void Release() { }

    }




}

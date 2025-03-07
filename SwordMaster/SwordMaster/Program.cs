using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

class SwordMaster
{
    static int score = 0;
    static int playerPosition;
    static int playerHealth = 3;
    static List<Enemy> enemies = new List<Enemy>();
    static Random random = new Random();
    static bool isGameRunning = true;
    static string playerCharacter = @"   O
  /|\
   |
  / \";  // 더 자세한 플레이어 모양
    static string enemyLeftCharacter = @"   O |
  {|-|
   |
  / \";  // 왼쪽에서 오는 적
    static string enemyRightCharacter = @"  | O
  |-|}
    |
   / \";  // 오른쪽에서 오는 적
    static bool isAttacking = false;
    static bool isAttackingLeft = false;
    static int attackAnimationFrame = 0;
    static Thread inputThread;
    static string[] leftAttackFrames = new string[]
    {
        @" | O
 ┼/|
   |
  / \",  // 왼쪽 공격 시작
        @"\  O
 ╳/|
   |
  / \"   // 왼쪽 공격 완료
    };
    static string[] rightAttackFrames = new string[]
    {
        @"   O |
   |\┼
   |
  / \",  // 오른쪽 공격 시작
        @"   O  /
   |\╳
   |
  / \"   // 오른쪽 공격 완료
    };
    static string[] leftSlashEffect = new string[]
    {
        "",
        "",
        ""
    };
    static string[] rightSlashEffect = new string[]
    {
        "",
        "",
        ""
    };
    static string ground = "________________________________________________________________________________";
    static string[] underGround = new string[]
    {
        "· ˙  .  ·  . ·   ˙  .  · .  ˙   .  · ˙  .  ·  . · ˙  .  ·  . ·   ˙  .  · .  ˙   .  · ˙  .  ·  . · ",
        " .  ·  . · ˙  .  ·  . ·   ˙  .  · .  ˙   .  ·  . · ˙  .  ·  . ·   ˙  .  · .  ˙   .  ·  . · ˙  . ",
        "˙  .  · .  ˙   .  · ˙  .  ·  . ·   ˙  .  · . ˙  . · ˙  .  ·  . ·   ˙  .  · .  ˙   .  · ˙  .  · ",
        " · ˙  .  ·  . ·   ˙  .  · .  ˙   .  · ˙  .  ·  . · ˙  .  ·  . ·   ˙  .  · .  ˙   .  · ˙  .  · ",
        ".  ˙   .  · ˙  .  ·  . ·   ˙  .  · .  ˙   .  ·  . · ˙  .  ·  . ·   ˙  .  · .  ˙   .  · ˙  .  ."
    };
    static int lastEnemySpawnTime = 0;
    static int enemySpawnInterval = 200; // 0.2초로 수정
    static int minEnemyDistance = 8; // 적들 사이 최소 간격을 8로 수정
    static int spawnChance = 60; // 40% 확률로 적 생성
    static int lastSpawnTime = 0;  // 마지막 적 생성 시간
    static int minSpawnInterval = 800;  // 최소 적 생성 간격 (0.8초)
    static string titleArt = @"




          ███████╗██╗    ██╗ ██████╗ ██████╗ ██████╗ 
          ██╔════╝██║    ██║██╔═══██╗██╔══██╗██╔══██╗
          ███████╗██║ █╗ ██║██║   ██║██████╔╝██║  ██║
          ╚════██║██║███╗██║██║   ██║██╔══██╗██║  ██║
          ███████║╚███╔███╔╝╚██████╔╝██║  ██║██████╔╝
          ╚══════╝ ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═╝╚═════╝ 
                    ███╗   ███╗ █████╗ ███████╗████████╗███████╗██████╗ 
                    ████╗ ████║██╔══██╗██╔════╝╚══██╔══╝██╔════╝██╔══██╗
                    ██╔████╔██║███████║███████╗   ██║   █████╗  ██████╔╝
                    ██║╚██╔╝██║██╔══██║╚════██║   ██║   ██╔══╝  ██╔══██╗
                    ██║ ╚═╝ ██║██║  ██║███████║   ██║   ███████╗██║  ██║
                    ╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝



                          ⚔️  검술의 달인이 되어보세요 ⚔️
    ";

    static object consoleLock = new object();
    static bool isGameOver = false;  // 게임 오버 상태 추적을 위한 새로운 변수

    class Enemy
    {
        public int Position { get; set; }
        public bool IsLeftSide { get; set; }

        public Enemy(bool isLeft)
        {
            IsLeftSide = isLeft;
            Position = isLeft ? 0 : Console.WindowWidth - 5;
        }

        public void Move()
        {
            if (IsLeftSide)
                Position++;
            else
                Position--;
        }

        public bool IsCollidingWithPlayer(int playerPos)
        {
            return Math.Abs(Position - playerPos) < 3;
        }
    }

    static void ShowTitleScreen()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(titleArt);
        Console.ResetColor();
        Console.WriteLine("\n");
        Console.WriteLine("                          진행하려면 ENTER를 입력해주세요.");

        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        ShowMenu();
    }

    static void ShowMenu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n\n\n\n\n\n\n\n\n                                   게임 설명\n");
        Console.ResetColor();
        Console.WriteLine("                       ← → 화살표 키로 적들을 처치하세요!");
        Console.WriteLine("\n                       좌우에서 다가오는 적들을 주의하세요.");
        Console.WriteLine("\n                       적과 부딪히면 체력이 감소합니다.");
        Console.WriteLine("\n                       최대한 많은 적을 처치하여 높은 점수를 노려보세요!");
        Console.WriteLine("\n\n\n                       게임을 시작하려면 ENTER를 누르세요...");

        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
    }

    static void SetupConsole()
    {
        try
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;
            Console.SetWindowSize(90, 30);
            Console.SetBufferSize(90, 30);
            Console.Title = "Sword Master";
        }
        catch (Exception)
        {
            Console.WindowWidth = Math.Min(90, Console.LargestWindowWidth);
            Console.WindowHeight = Math.Min(30, Console.LargestWindowHeight);
            Console.CursorVisible = false;
        }
    }

    static void HandleInput()
    {
        while (isGameRunning)
        {
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.LeftArrow && !isAttacking)
            {
                isAttacking = true;
                isAttackingLeft = true;
                attackAnimationFrame = 0;
                bool hitEnemy = false;
                foreach (var enemy in enemies.ToArray())
                {
                    if (enemy.IsLeftSide && Math.Abs(enemy.Position - playerPosition) < 7)
                    {
                        enemies.Remove(enemy);
                        score += 100;
                        hitEnemy = true;
                    }
                }
                PlayAttackAnimation(true);
            }
            else if (key == ConsoleKey.RightArrow && !isAttacking)
            {
                isAttacking = true;
                isAttackingLeft = false;
                attackAnimationFrame = 0;
                bool hitEnemy = false;
                foreach (var enemy in enemies.ToArray())
                {
                    if (!enemy.IsLeftSide && Math.Abs(enemy.Position - playerPosition) < 7)
                    {
                        enemies.Remove(enemy);
                        score += 100;
                        hitEnemy = true;
                    }
                }
                PlayAttackAnimation(false);
            }
            else if (key == ConsoleKey.Escape)
            {
                isGameRunning = false;
            }
        }
    }

    static void PlayAttackAnimation(bool isLeft)
    {
        if (isGameOver) return;  // 게임 오버 상태면 애니메이션 실행하지 않음

        isAttacking = true;
        isAttackingLeft = isLeft;
        attackAnimationFrame = 0;

        lock (consoleLock)
        {
            DrawGame();  // 첫 프레임 즉시 그리기
        }
        Thread.Sleep(100);

        if (isGameOver)
        {
            isAttacking = false;
            return;  // 게임 오버 상태면 두 번째 프레임 진행하지 않음
        }

        attackAnimationFrame = 1;
        lock (consoleLock)
        {
            DrawGame();  // 두 번째 프레임 그리기
        }
        Thread.Sleep(100);

        isAttacking = false;
        if (!isGameOver)  // 게임 오버가 아닐 때만 마지막 상태 그리기
        {
            lock (consoleLock)
            {
                DrawGame();  // 공격 종료 후 기본 상태로 돌아가기
            }
        }
    }

    static void UpdateGame()
    {
        try
        {
            List<Enemy> enemiesToRemove = new List<Enemy>();
            bool playerWasHit = false;

            foreach (var enemy in enemies)
            {
                enemy.Move();

                // 적이 플레이어와 충돌하면 체력 감소
                if (enemy.IsCollidingWithPlayer(playerPosition))
                {
                    playerHealth--;
                    playerWasHit = true;
                    enemiesToRemove.Add(enemy);
                    continue;
                }

                // 적이 플레이어를 지나치면 제거
                if ((enemy.IsLeftSide && enemy.Position > playerPosition + 5) ||
                    (!enemy.IsLeftSide && enemy.Position < playerPosition - 5))
                {
                    enemiesToRemove.Add(enemy);
                }
            }

            // 안전하게 적 제거
            lock (consoleLock)
            {
                foreach (var enemy in enemiesToRemove)
                {
                    enemies.Remove(enemy);
                }
            }

            // 피격 후 체력 체크
            if (playerWasHit && playerHealth <= 0)
            {
                isGameOver = true;
            }
        }
        catch (Exception)
        {
            // 예외 발생 시 조용히 처리
        }
    }

    static void DrawGame()
    {
        lock (consoleLock)
        {
            Console.Clear();

            // Draw UI frame
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("+==================================================================+");
            Console.WriteLine("|                                                                  |");
            Console.WriteLine("+==================================================================+");

            // Draw score and health with colors
            Console.SetCursorPosition(2, 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Score: {score}");

            Console.SetCursorPosition(Console.WindowWidth - 20, 1);
            Console.Write("Health: ");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < playerHealth; i++)
            {
                Console.Write("♥ ");
            }
            Console.ResetColor();

            // Draw ground and underground
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int groundY = Console.WindowHeight / 2 + 4;
            Console.SetCursorPosition(0, groundY);
            Console.WriteLine(ground.PadRight(Console.WindowWidth, '_'));

            // Draw underground texture
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i < underGround.Length; i++)
            {
                string repeatedPattern = underGround[i];
                while (repeatedPattern.Length < Console.WindowWidth)
                {
                    repeatedPattern += underGround[i];
                }
                Console.SetCursorPosition(0, groundY + i + 1);
                Console.Write(repeatedPattern.Substring(0, Console.WindowWidth));
            }
            Console.ResetColor();

            // Draw player with attack animation
            string[] playerLines;
            if (isAttacking)
            {
                playerLines = (isAttackingLeft ? leftAttackFrames[attackAnimationFrame] : rightAttackFrames[attackAnimationFrame]).Split('\n');

                // Draw slash effect with color
                string[] slashEffect = isAttackingLeft ? leftSlashEffect : rightSlashEffect;
                int effectX = isAttackingLeft ? playerPosition - 6 : playerPosition + 4;
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int i = 0; i < slashEffect.Length; i++)
                {
                    Console.SetCursorPosition(effectX, Console.WindowHeight / 2 - 1 + i);
                    Console.Write(slashEffect[i]);
                }
                Console.ResetColor();
            }
            else
            {
                playerLines = playerCharacter.Split('\n');
            }

            // Draw player
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < playerLines.Length; i++)
            {
                Console.SetCursorPosition(playerPosition, Console.WindowHeight / 2 - 1 + i);
                Console.Write(playerLines[i]);
            }

            // Draw enemies with color
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var enemy in enemies)
            {
                string[] enemyLines = (enemy.IsLeftSide ? enemyLeftCharacter : enemyRightCharacter).Split('\n');
                for (int i = 0; i < enemyLines.Length; i++)
                {
                    Console.SetCursorPosition(enemy.Position, Console.WindowHeight / 2 - 1 + i);
                    Console.Write(enemyLines[i]);
                }
            }
        }
    }

    static bool CanSpawnEnemy(bool isLeft)
    {
        // 최소 생성 간격 체크
        if (Environment.TickCount - lastSpawnTime < minSpawnInterval)
        {
            return false;
        }

        foreach (var enemy in enemies)
        {
            if (enemy.IsLeftSide == isLeft)
            {
                // 같은 방향에서 오는 적들 사이의 간격 체크
                if (isLeft && enemy.Position < minEnemyDistance)
                    return false;
                if (!isLeft && enemy.Position > Console.WindowWidth - minEnemyDistance)
                    return false;
            }
        }
        return true;
    }

    static void ResetGame()
    {
        if (inputThread != null && inputThread.IsAlive)
        {
            inputThread.Join();
        }

        score = 0;
        playerHealth = 3;
        enemies.Clear();
        playerPosition = (Console.WindowWidth / 2) - 2;
        isAttacking = false;
        isAttackingLeft = false;
        attackAnimationFrame = 0;
        isGameRunning = true;
        isGameOver = false;
        lastEnemySpawnTime = Environment.TickCount;
        lastSpawnTime = Environment.TickCount;  // 마지막 생성 시간 초기화
        enemySpawnInterval = 200;
    }

    static void GameOver()
    {
        isGameOver = true;
        isGameRunning = false;
        Thread.Sleep(100);

        lock (consoleLock)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 2);
            Console.WriteLine("========================================");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 1);
            Console.WriteLine($"         GAME OVER! 최종 점수 : {score}");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2);
            Console.WriteLine("========================================");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 24, Console.WindowHeight / 2 + 2);
            Console.WriteLine("'R'을 눌러 재시작 하거나, ENTER 를 눌러 종료하세요.");
            Console.ResetColor();
        }

        while (true)
        {
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.R)
            {
                ResetGame();
                return;
            }
            else if (key == ConsoleKey.Enter)
            {
                Environment.Exit(0);
                return;
            }
        }
    }

    static void Main()
    {
        SetupConsole();
        ShowTitleScreen();
        ResetGame();

        while (true)
        {
            inputThread = new Thread(HandleInput);
            inputThread.Start();

            while (isGameRunning)
            {
                int currentTime = Environment.TickCount;

                if (!isGameOver)  // 게임 오버가 아닐 때만 적 생성 및 업데이트
                {
                    // 적 생성 타이밍 조절
                    if (currentTime - lastEnemySpawnTime > enemySpawnInterval)
                    {
                        if (random.Next(100) < spawnChance)
                        {
                            bool isLeft = random.Next(2) == 0;  // 랜덤하게 방향 선택
                            if (CanSpawnEnemy(isLeft))
                            {
                                enemies.Add(new Enemy(isLeft));
                                lastSpawnTime = Environment.TickCount;  // 마지막 생성 시간 업데이트
                            }
                        }
                        lastEnemySpawnTime = currentTime;
                    }

                    UpdateGame();
                    DrawGame();
                }

                Thread.Sleep(50);

                if (playerHealth <= 0)
                {
                    GameOver();
                    if (!isGameRunning)
                    {
                        if (inputThread != null && inputThread.IsAlive)
                        {
                            inputThread.Join();
                        }
                        return;
                    }
                    break;
                }
            }

            if (!isGameRunning)
            {
                if (inputThread != null && inputThread.IsAlive)
                {
                    inputThread.Join();
                }
                break;
            }
        }
    }
}

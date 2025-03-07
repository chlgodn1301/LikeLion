using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

class SwordMaster
{
    static int score = 0;
    static int combo = 0;
    static int maxCombo = 0;
    static int playerPosition;
    static int playerHealth = 3;
    static List<Enemy> enemies = new List<Enemy>();
    static Random random = new Random();
    static bool isGameRunning = true;
    static int gameTime = 0; // 게임 진행 시간 추적
    static bool isPlayerHit = false; // 플레이어 피격 상태
    static int playerHitAnimationTime = 0; // 피격 애니메이션 타이머
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
        "---===≡≡≡",
        "  --===≡≡",
        "    --===≡"
    };
    static string[] rightSlashEffect = new string[]
    {
        "≡≡≡===---",
        "≡≡===--  ",
        "≡===--    "
    };
    static string[] hitEffect = new string[]
    {
        "★",
        "☆",
        "✧"
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
    static int spawnChance = 40; // 40% 확률로 적 생성
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

                        ⚔️  검술의 달인이 되어보세요  ⚔️
    ";

    static object consoleLock = new object();

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
        Console.WriteLine("\n\n");
        Console.WriteLine("                                  Press ENTER to continue...");

        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        ShowMenu();
    }

    static void ShowMenu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n\n                                     게임 설명\n");
        Console.ResetColor();
        Console.WriteLine("                         ← → 화살표 키로 적들을 처치하세요!");
        Console.WriteLine("\n                         좌우에서 다가오는 적들을 주의하세요.");
        Console.WriteLine("                         적과 부딪히면 체력이 감소합니다.");
        Console.WriteLine("\n                         최대한 많은 적을 처치하여 고득점을 노려보세요!");
        Console.WriteLine("\n\n                         게임을 시작하려면 ENTER를 누르세요...");

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
                    if (enemy.IsLeftSide && Math.Abs(enemy.Position - playerPosition) < 5)
                    {
                        enemies.Remove(enemy);
                        hitEnemy = true;
                        combo++;
                        maxCombo = Math.Max(maxCombo, combo);
                        // 콤보와 거리에 따른 점수 계산
                        int distance = Math.Abs(enemy.Position - playerPosition);
                        int baseScore = 100;
                        int comboBonus = (combo - 1) * 50;
                        int proximityBonus = (5 - distance) * 20;
                        score += baseScore + comboBonus + proximityBonus;
                    }
                }
                if (!hitEnemy) combo = 0;
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
                    if (!enemy.IsLeftSide && Math.Abs(enemy.Position - playerPosition) < 5)
                    {
                        enemies.Remove(enemy);
                        hitEnemy = true;
                        combo++;
                        maxCombo = Math.Max(maxCombo, combo);
                        // 콤보와 거리에 따른 점수 계산
                        int distance = Math.Abs(enemy.Position - playerPosition);
                        int baseScore = 100;
                        int comboBonus = (combo - 1) * 50;
                        int proximityBonus = (5 - distance) * 20;
                        score += baseScore + comboBonus + proximityBonus;
                    }
                }
                if (!hitEnemy) combo = 0;
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
        isAttacking = true;
        isAttackingLeft = isLeft;
        attackAnimationFrame = 0;

        DrawGame();  // 첫 프레임 즉시 그리기
        Thread.Sleep(100);

        attackAnimationFrame = 1;
        DrawGame();  // 두 번째 프레임 그리기
        Thread.Sleep(100);

        isAttacking = false;
        DrawGame();  // 공격 종료 후 기본 상태로 돌아가기
    }

    static void UpdateGame()
    {
        try
        {
            gameTime++;
            List<Enemy> enemiesToRemove = new List<Enemy>();
            
            // 시간에 따른 적 이동 속도 증가
            float speedMultiplier = 1.0f + (gameTime / 5000.0f);
            
            foreach (var enemy in enemies)
            {
                // 기본 이동에 속도 승수 적용
                if (enemy.IsLeftSide)
                    enemy.Position += (int)(1 * speedMultiplier);
                else
                    enemy.Position -= (int)(1 * speedMultiplier);
                
                if (enemy.IsCollidingWithPlayer(playerPosition))
                {
                    playerHealth--;
                    isPlayerHit = true;
                    playerHitAnimationTime = 10; // 피격 애니메이션 시간 설정
                    combo = 0; // 피격 시 콤보 리셋
                    enemiesToRemove.Add(enemy);
                    continue;
                }
                
                if ((enemy.IsLeftSide && enemy.Position > playerPosition + 5) ||
                    (!enemy.IsLeftSide && enemy.Position < playerPosition - 5))
                {
                    enemiesToRemove.Add(enemy);
                    combo = 0; // 적을 놓치면 콤보 리셋
                }
            }

            foreach (var enemy in enemiesToRemove)
            {
                enemies.Remove(enemy);
            }

            // 피격 애니메이션 업데이트
            if (isPlayerHit)
            {
                playerHitAnimationTime--;
                if (playerHitAnimationTime <= 0)
                {
                    isPlayerHit = false;
                }
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

            // Draw combo
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Combo: {combo} (Max: {maxCombo})");

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

            // 플레이어 피격 효과
            Console.ForegroundColor = isPlayerHit ? 
                (playerHitAnimationTime % 2 == 0 ? ConsoleColor.Red : ConsoleColor.White) : 
                ConsoleColor.White;
        }
    }

    static bool CanSpawnEnemy(bool isLeft)
    {
        foreach (var enemy in enemies)
        {
            if (enemy.IsLeftSide == isLeft)
            {
                // 같은 방향에서 오는 적들 사이의 간격만 체크
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
        playerPosition = (Console.WindowWidth / 2) - 2;  // 플레이어 위치는 그대로 유지
        isAttacking = false;
        isAttackingLeft = false;
        attackAnimationFrame = 0;
        isGameRunning = true;
        lastEnemySpawnTime = Environment.TickCount;
        enemySpawnInterval = 200;
    }

    static void GameOver()
    {
        isGameRunning = false;
        Thread.Sleep(100);

        lock (consoleLock)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 2);
            Console.WriteLine("========================================");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 1);
            Console.WriteLine($"         GAME OVER! Final Score: {score}");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2);
            Console.WriteLine("========================================");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 + 2);
            Console.WriteLine("    Press 'R' to restart or ENTER to exit");
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
                isGameRunning = false;
                Environment.Exit(0); // 프로그램 즉시 종료
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
                
                // 시간에 따른 스폰 간격 감소
                int currentSpawnInterval = Math.Max(100, enemySpawnInterval - (gameTime / 500));
                
                if (currentTime - lastEnemySpawnTime > currentSpawnInterval)
                {
                    if (random.Next(100) < spawnChance)
                    {
                        bool isLeft = random.Next(2) == 0;
                        if (CanSpawnEnemy(isLeft))
                        {
                            enemies.Add(new Enemy(isLeft));
                        }
                    }
                    lastEnemySpawnTime = currentTime;
                }

                UpdateGame();
                DrawGame();
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

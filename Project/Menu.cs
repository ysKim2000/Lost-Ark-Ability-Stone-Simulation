using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project
{
    class Menu
    {
        Output output = new Output();
        Random random = new Random();
        IncreaseAbility ability1 = new IncreaseAbility();
        IncreaseAbility ability2 = new IncreaseAbility();
        DecreaseAbility ability3 = new DecreaseAbility();
        Chance chance = new Chance();

        public void First()
        {
            int opp = 0;
            bool mainout = false;

            while (true)
            {
                Console.WriteLine("\n┌────────────────────────  돌깎기 게임 ─────────────────────────┐\n│\t\t\t\t\t\t\t\t│");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("│\t");
                    if (i == 0)
                    {
                        if (ability1.Name != null)
                            Console.Write(ability1.Name + (ability1.Name.Length <= 3 ? "\t" : ""));
                        else
                            Console.Write("\t");
                    }
                    else if (i == 1)
                    {
                        if (ability2.Name != null)
                            Console.Write(ability2.Name + (ability2.Name.Length <= 3 ? "\t" : ""));
                        else
                            Console.Write("\t");
                    }
                    else
                    {
                        if (ability3.Name != null)
                            Console.Write(ability3.Name + (ability3.Name.Length <= 3 ? "\t" : ""));
                        else
                            Console.Write("\t");
                    }
                    Console.Write("\t     ");
                    if (opp != 0)
                    {
                        for (int j = 0; j < opp; j++)
                        {
                            Console.Write("◈ ");
                        }
                        if (opp == 6)
                            Console.Write("\t\t\t│");
                        else
                            Console.Write(opp == 8 ? "\t\t│" : "\t│");
                    }
                    else
                        Console.Write("\t\t\t\t\t│");
                    Console.WriteLine();
                }
                Console.WriteLine("│\t\t\t\t\t\t\t\t│\n└───────────────────────────────────────────────────────────────┘");
                Console.WriteLine("\n1. 세공");
                Console.WriteLine("2. 설정(세공기회)");
                Console.WriteLine("3. 설정(각인종류)");
                Console.WriteLine("4. 초기화");
                Console.WriteLine("5. 종료");
                Console.Write("선택: ");

                int result = output.NumCheck(1, 5);

                if (result == 0)
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }
                switch (result)
                {
                    case 1:
                        if (ability1.Name != null && ability2.Name != null && ability3.Name != null)
                        {
                            if (opp != 0)
                            {
                                Console.Clear();
                                Second();
                            }
                            else
                            {
                                Console.WriteLine("\n\n아직 세공 기회를 설정하지 않았습니다!");
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n\n아직 각인을 전부 설정하지 않았습니다!");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        break;
                    case 2:
                        Console.Clear();
                        WorkOpportunityScreen();
                        opp = ability1.Opportunity;
                        break;
                    case 3:
                        Console.Clear();
                        AbilityScreen();
                        break;
                    case 4:
                        ability1.Name = null;
                        ability2.Name = null;
                        ability3.Name = null;
                        opp = 0;
                        break;
                    case 5:
                        Console.Clear();
                        mainout = true;
                        break;
                }
                if (mainout)
                    break;
                Console.Clear();
            }
        }

        public void WorkOpportunityScreen()
        {
            int workopp = 0;

            while (true)
            {
                Console.WriteLine("   6   |   8   |   9   |   10   ");
                Console.Write("중에 선택: ");
                bool abilitynumcheck = int.TryParse(Console.ReadLine(), out workopp);
                if (abilitynumcheck)
                {
                    if (workopp != 6 && workopp < 8 || workopp > 10)
                    {
                        Console.WriteLine("\n범위 내에서 선택해주세요.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("\n범위 내에서 선택해주세요.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            ability1.Opportunity = workopp;
            ability2.Opportunity = workopp;
            ability3.Opportunity = workopp;
        }

        public void AbilityScreen()
        {
            bool first = false;
            while (true)
            {
                Console.WriteLine("1. 증가 능력");
                Console.WriteLine("2. 증가 능력");
                Console.WriteLine("3. 감소 능력");
                Console.WriteLine("4. 나가기");
                Console.Write("선택: ");

                int result = output.NumCheck(1, 4);

                if (result == 0)
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }
                else if (result == 4)
                    break;
                if ((result == 1 && ability1.Name != null) || (result == 2 && ability2.Name != null) || (result == 3 && ability3.Name != null))
                {
                    while (true)
                    {
                        Console.Write("\n\n이미 선택됐습니다. 다시 선택하겠습니까? (y or n) :");
                        string again = Console.ReadLine();
                        if (again == "y")
                        {
                            Console.Clear();
                            break;
                        }
                        else if (again == "n")
                        {
                            Console.Clear();
                            first = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n잘못 입력했습니다.");
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("1. 증가 능력");
                            Console.WriteLine("2. 증가 능력");
                            Console.WriteLine("3. 감소 능력");
                            Console.WriteLine("4. 나가기");
                            Console.WriteLine("선택: ");
                            continue;
                        }
                    }
                    if (first)
                        continue;
                }
                Console.Clear();
                if (result == 1)
                    ability1.SelectAbility(ability2.Name);
                else if (result == 2)
                    ability2.SelectAbility(ability1.Name);
                else if (result == 3)
                    ability3.SelectAbility(null);
            }
        }

        public void Second()
        {
            chance.InitialValue = 75;
            chance.Max = 75;
            chance.Min = 25;
            chance.PlusMinus = 10;
            int opp = ability1.Opportunity;
            ability1.Success = new int?[opp];
            ability2.Success = new int?[opp];
            ability3.Success = new int?[opp];
            int abilitynum = 0;

            while (true)
            {
                Console.WriteLine("┌───────────────────────────  세 공 ─────────────────── {0,0}%─────┐", chance.InitialValue);

                Console.Write("│  1. ");
                Console.Write(ability1.Name + (ability1.Name.Length >= 6 ? "\t " : "\t\t "));
                for (int i = 0; i < opp; i++)
                {
                    if (ability1.Success[i] == null)
                        Console.Write("◈ ");
                    else
                        Console.Write(ability1.Success[i] == 0 ? "◆ " : "◇ ");
                }
                if (abilitynum == 1)
                {
                    if (opp == 6)
                        Console.Write("\t");
                    if (ability1.Success[ability1.Sub - 1] == 0)
                        Console.Write("\t성공\t│");
                    else
                        Console.Write("\t실패\t│");
                }
                else
                {
                    if (opp == 6)
                        Console.Write("\t\t\t│");
                    else
                        Console.Write("\t\t│");
                }
                Console.Write("\n├───────────────────────────────────────────────────────────────┤\n│  2. ");
                Console.Write(ability2.Name + (ability2.Name.Length >= 6 ? "\t " : "\t\t "));
                for (int i = 0; i < opp; i++)
                {
                    if (ability2.Success[i] == null)
                        Console.Write("◈ ");
                    else
                        Console.Write(ability2.Success[i] == 0 ? "◆ " : "◇ ");
                }
                if (abilitynum == 2)
                {
                    if (opp == 6)
                        Console.Write("\t");
                    if (ability2.Success[ability2.Sub - 1] == 0)
                        Console.Write("\t성공\t│");
                    else
                        Console.Write("\t실패\t│");
                }
                else
                {
                    if (opp == 6)
                        Console.Write("\t\t\t│");
                    else
                        Console.Write("\t\t│");
                }
                Console.Write("\n├───────────────────────────────────────────────────────────────┤\n│  3. ");
                Console.Write(ability3.Name + (ability3.Name.Length >= 6 ? "\t " : "\t\t "));
                for (int i = 0; i < opp; i++)
                {
                    if (ability3.Success[i] == null)
                        Console.Write("◈ ");
                    else
                        Console.Write(ability3.Success[i] == 0 ? "◆ " : "◇ ");
                }
                if (abilitynum == 3)
                {
                    if (opp == 6)
                        Console.Write("\t");
                    if (ability3.Success[ability3.Sub - 1] == 0)
                        Console.Write("\t성공\t│");
                    else
                        Console.Write("\t실패\t│");
                }
                else
                {
                    if (opp == 6)
                        Console.Write("\t\t\t│");
                    else
                        Console.Write("\t\t│");
                }
                Console.WriteLine("\n└───────────────────────────────────────────────────────────────┘");
                //모든 각인의 세공이 완료됐을 때, 결과 창으로 이동
                if (ability1.Success[opp - 1] != null && ability2.Success[opp - 1] != null && ability3.Success[opp - 1] != null)
                {
                    ability1.Sub = 0;
                    ability2.Sub = 0;
                    ability3.Sub = 0;
                    Thread.Sleep(1000);
                    Console.Clear();
                    ResultScreen();
                    break;
                }
                Console.WriteLine("\n\n1. 1번 세공");
                Console.WriteLine("2. 2번 세공");
                Console.WriteLine("3. 3번 세공");
                Console.WriteLine("4. 초기화");
                Console.WriteLine("5. 나가기");
                Console.Write("\n\n세공하고 싶은 능력을 선택: ");
                int result = output.NumCheck(1, 5);
                if (result == 0)
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }
                else if (result == 5)
                {
                    ability1.Sub = 0;
                    ability2.Sub = 0;
                    ability3.Sub = 0;
                    Console.Clear();
                    break;
                }
                switch (result)
                {
                    case 1:
                        //각인의 세공이 끝났는지 확인(2, 3도 동일)
                        if (ability1.Success[opp - 1] == null)
                        {
                            chance = ability1.Work(chance);
                            abilitynum = 1;
                        }
                        else
                        {
                            Console.WriteLine("\n\n1번 각인의 세공이 끝났습니다.");
                            abilitynum = 0;
                            Thread.Sleep(1000);
                        }
                        break;
                    case 2:
                        if (ability2.Success[opp - 1] == null)
                        {
                            chance = ability2.Work(chance);
                            abilitynum = 2;
                        }
                        else
                        {
                            Console.WriteLine("\n\n2번 각인의 세공이 끝났습니다.");
                            abilitynum = 0;
                            Thread.Sleep(1000);
                        }
                        break;
                    case 3:
                        if (ability3.Success[opp - 1] == null)
                        {
                            chance = ability3.Work(chance);
                            abilitynum = 3;
                        }
                        else
                        {
                            Console.WriteLine("\n\n3번 각인의 세공이 끝났습니다.");
                            abilitynum = 0;
                            Thread.Sleep(1000);
                        }
                        break;
                    case 4:
                        for (int i = 0; i < opp; i++)
                        {
                            ability1.Success[i] = null;
                            ability2.Success[i] = null;
                            ability3.Success[i] = null;
                        }
                        ability1.Sub = 0;
                        ability2.Sub = 0;
                        ability3.Sub = 0;
                        chance.InitialValue = 75;
                        abilitynum = 0;
                        break;
                }
                Console.Clear();
            }
        }
        public void ResultScreen()
        {
            int count;
            int opp = ability1.Opportunity;
            Console.WriteLine("\n┌────────────────  결과 ────────────────┐\n│\t\t\t\t\t│");
            for (int i = 0; i < 3; i++)
            {
                count = 0;
                if (i == 0)
                {
                    Console.Write("│   {0,0}", ability1.Name);
                    for (int j = 0; j < opp; j++)
                        if (ability1.Success[j] == 0)
                            count += 1;
                    if (ability1.Name.Length <= 6)
                        Console.Write("\t\t");
                    else
                        Console.Write("\t");
                    Console.Write("◆ (성공) x {0,0}\t│", count);
                }
                else if (i == 1)
                {
                    Console.Write("│   {0,0}", ability2.Name);
                    for (int j = 0; j < opp; j++)
                        if (ability2.Success[j] == 0)
                            count += 1;
                    if (ability2.Name.Length <= 6)
                        Console.Write("\t\t");
                    else
                        Console.Write("\t");
                    Console.Write("◆ (성공) x {0,0}\t│", count);
                }
                else
                {
                    Console.Write("│   {0,0}", ability3.Name);
                    for (int j = 0; j < opp; j++)
                        if (ability3.Success[j] == 0)
                            count += 1;
                    if (ability3.Name.Length <= 6)
                        Console.Write("\t\t");
                    else
                        Console.Write("\t");
                    Console.Write("◆ (성공) x {0,0}\t│", count);
                }
                Console.WriteLine("\n│\t\t\t\t\t│");
            }
            Console.WriteLine("└───────────────────────────────────────┘\n\nEnter 눌러주세요...");
            Console.ReadLine();
        }
    }
}
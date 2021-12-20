using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project
{
    interface IAbility
    {
        string Name { get; set; }
        // 각인 이름
        int Opportunity { get; set; }
        // 각인 세공 횟수
        void SelectAbility(string over);
        // 한 가지 각인 선택, 매개변수는 동일한 각인 선택했는지 확인하기 위해
    }
    interface IUpgrade
    {
        int Sub { get; set; }
        //몇번째 세공인지
        int?[] Success { get; set; }
        //몇번 성공, 실패했는지 기록
        Chance Work(Chance chance);
        //세공작업
    }
    class Ability
    {
        protected string[] increase = { "각성", "강령술", "강화 방패", "결투의 대가", "구슬동자", "굳은 의지", "급소 타격", "기습의 대가", "달인의 저력", "돌격대장", "마나의 흐름", "마나 회복 증가", "바리케이드", "번개의 분노", "부러진 뼈", "분쇄의 주먹", "불굴", "선수필승", "슈퍼 차지", "승부사", "실드 관통", "안정된 상태", "약자무시", "여신의 가호", "에테르 강화", "예리한 둔기", "원한", "위기 모면", "저주받은 인형", "정기 흡수", "중갑 착용", "최대 마나 증가", "탈출의 명수", "폭발물 전문가" };
        protected string[] decrease = { "공격력 감소", "공격속도 감소", "방어력 감소", "이동속도 감소" };
        // 좋은 각인과 나쁜 각인 종류
    }
    class IncreaseAbility : Ability, IAbility, IUpgrade
    {
        public string Name { get; set; }
        public int Opportunity { get; set; }
        public int Sub { get; set; }
        public int?[] Success { get; set; }
        public void SelectAbility(string over)
        {
            int selectnum;
            while (true)
            {
                Console.WriteLine("\n-----------------------------------증가 능력-----------------------------------\n");
                for (int i = 0; i < increase.Length / 3 + 1; i++)
                {
                    if (i == 11)
                    {
                        Console.WriteLine("\t34. {0,0}\n", increase[33]);
                        break;
                    }
                    Console.Write("\t{0,0}. {1,0}", i * 3 + 1, increase[i * 3]);
                    if (i == 0)
                        Console.Write("\t");
                    Console.Write("\t\t{0,0}. {1,0}", i * 3 + 2, increase[i * 3 + 1]);
                    if (i != 9 && i != 10)
                        Console.Write("\t");
                    Console.WriteLine("\t{0,0}. {1,0}\n", i * 3 + 3, increase[i * 3 + 2]);
                }
                Console.Write("선택: ");
                bool abilityselect = int.TryParse(Console.ReadLine(), out selectnum);
                if (abilityselect)
                {
                    if (selectnum >= 1 && selectnum <= 34)
                    {
                        if (over != increase[selectnum - 1])
                        {
                            this.Name = increase[selectnum - 1];
                            //객체의 Name에 선택한 좋은 각인 대입
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n\n중복된 각인(능력)은 설정할 수 없습니다.");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\n범위 내에서 선택해주세요.");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("\n\n범위 내에서 선택해주세요.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            Console.Clear();
        }
        public Chance Work(Chance chance)
        {
            bool success;
            this.Sub += 1;
            success = chance.prob();
            if (success)
                this.Success[this.Sub - 1] = 0;
            else
                this.Success[this.Sub - 1] = 1;
            return chance;
        }
    }
    class DecreaseAbility : Ability, IAbility, IUpgrade
    {
        public string Name { get; set; }
        public int Opportunity { get; set; }
        public int Sub { get; set; }
        public int?[] Success { get; set; }
        public void SelectAbility(string over)
        {
            int selectnum;
            while (true)
            {
                Console.WriteLine("\n-----------------------------------감소 능력-----------------------------------\n");
                Console.WriteLine("\t1. {0,0}\t\t2. {1,0}\t3.{2,0}\n", decrease[0], decrease[1], decrease[2]);
                Console.WriteLine("\t4. {0,0}\n", decrease[3]);
                Console.Write("선택: ");
                bool abilityselect = int.TryParse(Console.ReadLine(), out selectnum);
                if (abilityselect)
                {
                    if (selectnum >= 1 && selectnum <= 4)
                    {
                        this.Name = decrease[selectnum - 1];
                        //객체의 Name에 선택한 나쁜 각인 대입
                        break;
                    }
                    Console.WriteLine("\n\n범위 내에서 선택해주세요.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\n\n범위 내에서 선택해주세요.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            Console.Clear();
        }
        public Chance Work(Chance chance)
        {
            bool success;
            this.Sub += 1;
            success = chance.prob();
            if (success)
                this.Success[this.Sub - 1] = 0;
            else
                this.Success[this.Sub - 1] = 1;
            return chance;
        }
    }
}

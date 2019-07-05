# CookieClicker

## 1.Опис на играта

Се работи за idle игра со многу едноставен концепт, кој последнава година е се поактуелен во светот на флеш-игрите на интернет, како и  во игрите за мобилната индустрија. Идејата на idle игрите е таква што играчот прво почнува од нула „парички“ или било каква друга валута,
 за потоа со купување додатоци и нови надградби пасивно почнува да заработува многу повеќе. Ова е типичен пример на принцип на снежна топка, каде 
со секоја наредна надградба се зголемува профитот добиен во една секунда. Главната цел на овој тип игри е дека играчот може да ја остави играта уклучена и да прави било која друга активност, додека таа автоматски ги зголемува неговите парички. Секако, колку е играчот поактивен, толку побрзо ќе расте заработувачката. Инспирацијата за оваа апликација е добиена од истоимената игра на [линк](https://orteil.dashnet.org/cookieclicker/), но самата имплементација и сите ефекти се направени самостојно.

![Оригиналната игра](https://i.kinja-img.com/gawker-media/image/upload/s--JNu4Td2L--/c_scale,f_auto,fl_progressive,q_80,w_800/kggronat2bhshdyycncx.png "Оригиналната игра")

## 2.Како се игра

Во оваа апликација, валутата се колачиња и целта на играчот е да добие што повеќе од нив. Со секој клик врз големото колаче во средина на формата, бројот на колачиња се зголемува за еден. Истовремено, кога се почнува нова игра, се активира тајмер кој секоја секунда додава едно колаче. Купувајќи ги надградбите кои се од три вида:
- прст (Finger)
- бабичка (Grandma)
- робот (Robot) <br/>

играчот го зголемува бројот на колачиња произведени во секунда. Секако, надградбите што повеќе произведуваат колачиња се поскапи, но после многу кратко време лесно се сфаќа дека е далеку поефикасно да се почека за поголема инвестиција, отколку веднаш да се потроши се. Со секое купување цената на таа надградба се зголемува, но истовремено и произведените колачиња во секунда. Исто така, постојат и копчиња со кои може да се купат пет надградби одеднаш со фиксна цена за едно, притоа заштедувајќи многу . Во позадината на формата постојано паѓаат колачиња, почнувајќи од рандом позиција. Самата позадина е направена на интерактивен принцип, со тоа што колку повеќе колачиња во секунда се произведуваат, толку повеќе колачиња почнуваат да „врнат“.

## 3.Имплементација

Главната класа во играта е CookieGame, каде се пресметува колку колачиња има играчот во моментот и колку се произведуваат во секунда. Дополнително, во оваа класа е напишан и кодот со кој се трошат колачиња кога играчот ќе купи надградба, и се запишува промената која е направена. Исто така, клучна е и класата за самото колаче, која се вика Cookie, во која има имплементирано повеќе слики кои доловуваат ефект на кликање. 
За секој вид на надградба, вклучително и опцијата да се додадат пет одеднаш, создадени се шест посебни класи кои се наоѓаат во фолдерот PowerUps. Постои и општа класа за PowerUp која ги прави претходно споменатите шест класи многу поедноставни. Во класата PowerUpRates се пресметани цените за секоја надградба и како тие се зголемуваат, користејќи константи од класата Constants.
Анимацијата со која врнат колачиња е направена во класите Fall и FallDoc, во кои колачето се третира како топче кое паѓа.

## 4.Колачиња што паѓаат

Целта ни беше во позадината на играта да врнат колачиња во зависност од тоа колкаво производство во секунда има играчот. Ова го имплементиравме со користење на едноставна техника каде се генерираат колачиња на произволна ширина на екранот и потоа вертикално се движат надоле, како да паѓаат. Потоа, предизвикот беше да се поврзе производството како нумеричка вредност (cookieGame.ClicksPerSecond) со самото генерирање на колачиња. Тоа успеавме да го направиме во кодот:
```
void timerFall_Tick(object sender, EventArgs e)
        {
            int module = 10;

            if (Math.Ceiling(cookieGame.ClicksPerSecond) > 2)
                module = 8;
            if (Math.Ceiling(cookieGame.ClicksPerSecond) > 5)
                module = 5;
            if (Math.Ceiling(cookieGame.ClicksPerSecond) > 7)
                module = 3;
            if (Math.Ceiling(cookieGame.ClicksPerSecond) > 10)
                module = 2;
            if (Math.Ceiling(cookieGame.ClicksPerSecond) > 30)
                module = 1;
            if (generateFall % module == 0)
            {
                int x = random.Next(2 * Fall.RADIUS, Width - (Fall.RADIUS * 2));
                int y = -Fall.RADIUS;
                fallDoc.AddFall(new Point(x, y));
            }

            ++generateFall;
            fallDoc.Move(Width);
            Invalidate(true);
        }
```
Горната функција се извршува секогаш кога тајмерот ќе изврши едно отчукување, и во нејзе се извршува генерирањето на нови колачиња. Поставена е променлива што се вика module која во почетокот на функцијата има вредност 10. Во if условите се проверува дали производството надминува 2, 5, 7, 10 или пак 30 колачиња во секунда. Во зависност од колкаво е производството, се поставува вредноста на module на помали вредности, соодветно од производството (колку поголемо производство, толку помала вредност на module). Потоа, со променливата GenerateFall, која со секое отчукување на тајмерот се инкрементира за 1, се проверува колкав е остатокот кога ќе се подели со module. Секогаш кога остатокот ќе биде еднаков на 0, влегува во дел од кодот кој генерира ново колаче. На пример, ако вредноста на module е 10, ќе се генерира еднаш во 10 отчукувања, додека ако module е 2, ќе паѓа колаче на секој парен број отчукување. Со ова се симулира засилување на дождот од колачиња, кој расте со производството. 

## 5. Слики од играта

Почетен екран<br/>

![Почетен екран](https://i.imgur.com/QXYYx9Y.png "Почетен екран")

Играње на играта<br/>

![Игра](https://i.imgur.com/JScdC4U.png "Играње")

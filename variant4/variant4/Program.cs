﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace variant4
{
    class Program
    {
        public static void Task1()
        {
            Console.WriteLine("task1");
            string s = "80296667766 80297767 80293333333 ";
            Regex reg = new Regex(@"8029\d{7}\W+");
            MatchCollection matches = reg.Matches(s);
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }
        }
        public static void Task2()
        {
            Console.WriteLine("task2");
            string s = "Трагедия Пушкина «Моцарт и Сальери» занимает всего десять страниц. О чем она? О зависти или о том, что «гений и злодейство – две вещи несовместные»? Есть ли оправдание Сальери, который, по версии Пушкина, отравил Моцарта? История предумышленного убийства рассказывается самим преступником: и Моцарта, и все происходящее мы видим глазами Сальери. Пьеса начинается с его монолога: «Все говорят: нет правды на земле. Но правды нет и выше». Это похоже на речь обвиняемого.Оказывается, убийство задумано давно, готово и орудие – «последний дар моей Изоры». Но кто такая Изора? Где целых восемнадцать лет Сальери хранил яд – в пузырьке? Поэт Арсений Тарковский считал, что яд был в перстне: «Ты безумна, Изора, безумна и зла. Ты кому подарила свой перстень с отравой ?» Что за Черный человек приходил к Моцарту заказать «Реквием» и почему в трактире Моцарту кажется, что он(или она ?) где - то рядом? Тарковский полагал, что это Изора «за дверью трактирной тихонько ждала...» Не было ли сговора между ней и Сальери? Перед нами «теоретическое преступление», то есть совершенное ради идеи. «Нет, никогда я зависти не знал», – говорит Сальери. Настоящий завистник не признает гениальности соперника, а Сальери не сомневается в величии Моцарта, но верит, что его смерть принесет человечеству благо.";
            Regex reg = new Regex(@"[а-яА-Я]{0,}");
            MatchCollection matches = reg.Matches(s);
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Console.ReadKey();
        }
    }
}

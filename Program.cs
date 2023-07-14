using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int noc, nos;
            //Console.WriteLine("Enter Number of Classes");
            //noc = int.Parse(Console.ReadLine());
            //string[][] students = new string[noc][];
            //for (int i = 0; i < noc; i++)
            //{
            //    Console.WriteLine("Enter Number of Students in Class " + (i + 1));
            //    nos = int.Parse(Console.ReadLine());
            //    students[i]=new string[nos];
            //    for(int j = 0; j < nos; j++)
            //    {
            //        Console.WriteLine($"Enter Student {j+1}\'s name");
            //        students[i][j] = Console.ReadLine();
            //    }
            //}
            //for(int i = 0;i < students.Length; i++)
            //{
            //    Console.WriteLine($"Students List of Class {i+1}");
            //    Console.WriteLine("******************************");
            //    for (int j = 0;j < students[i].Length; j++)
            //    {
            //        Console.WriteLine(students[i][j]);
            //    }
            //    Console.WriteLine("******************************");
            //}
            //Console.ReadKey();

            //Console.WriteLine("Welcome to Collection!!!");
            //ClassName objectName=new ClassName();
            //objectName.MemberName
            //objectName.PropertyName
            //objectName.MethodName
            //ArrayList arrayList = new ArrayList
            //{
            //    "Sam",
            //    "Ravi",
            //    "Amit"
            //};
            //Console.WriteLine("Number of element in array List are:\t " + arrayList.Count);
            //Console.WriteLine("Capacity of Array List is: \t " + arrayList.Capacity);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //arrayList.Add("Naga");
            //arrayList.Add("Sai");
            //Console.WriteLine("After adding two elements in array list");
            //Console.WriteLine("Number of elements in array list are:\t"+arrayList.Count);
            //Console.WriteLine("Capacity of array list is:\t"+arrayList.Capacity);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //arrayList.Add("Ram");
            //arrayList.Add("Pavan");
            //arrayList.Add("siddhu");
            //Console.WriteLine("After adding 8 elements in array list");
            //Console.WriteLine("Number of elements in array list are:\t"+arrayList.Count);
            //Console.WriteLine("Capacity of array list is :\t"+arrayList.Capacity);
            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //arrayList.Add("Srinu");
            //Console.WriteLine("After adding one more in array list");
            //Console.WriteLine("Number of elements in array list are:\t"+arrayList.Count);
            //Console.WriteLine("capacity of array list is \t:"+arrayList.Capacity);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //arrayList.Sort();
            //Console.WriteLine("**Sorted Array list**");
            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Reverse the list");
            //arrayList.Reverse();
            //Console.WriteLine("Sorted Array list in Desc****");
            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            /* ArrayList myList = new ArrayList { 12, 45, 38, 11 };
             Console.WriteLine("Number List");
             foreach (int i in myList) 
             { Console.WriteLine(i); }
             myList.Reverse();
             Console.WriteLine("* Reverse number list *");
             foreach(int i in myList)
             { Console.WriteLine(i); }
             myList.Sort();
             Console.WriteLine("* Sort number list***");
             foreach (int i in myList)
             {
                 Console.WriteLine(i);
             }
             myList.RemoveAt(3);
             Console.WriteLine("After removing from index 3");
             foreach (int i in myList)
             {
                 Console.WriteLine(i);
             }
             myList.Remove(45);
             Console.WriteLine("After removing 45");
             foreach (int i in myList)
             { 
             Console.WriteLine(i);
             }  */


            /*   ArrayList hardwareList = new ArrayList();
                 hardwareList.Add("CD");
                 hardwareList.Add("Printer");
                 hardwareList.Add("KeyBoard");
                 hardwareList.Add("Mouse");
                 hardwareList.Add("Network Card");
                 Console.WriteLine("Initial HardWare List");
                 for (int i = 0; i < hardwareList.Count; i++) 
                 {
                     Console.WriteLine(hardwareList[i]);
                 }
                 Console.WriteLine("Enter item to search & update");
                 string searchItem = Console.ReadLine();
                 int index=hardwareList.IndexOf(searchItem);
                 if (index == -1)
                 {
                     Console.WriteLine("No such item {searchitem} exit in hardware list");

                 }
                 else
                 {
                     Console.WriteLine("Enter update item");
                     hardwareList[index] = Console.ReadLine();
                     Console.WriteLine("Update hardwarelist is as follows!!!");
                     for(int i = 0;i < hardwareList.Count;i++) 
                     {
                         Console.WriteLine(hardwareList[i]);
                     }
                 }
                 Console.ReadKey();    
               string newItem;
               Console.WriteLine("Enter new item");
               newItem = Console.ReadLine();
               hardwareList.Add(newItem);
               Console.WriteLine("List after adding new hardware");
               for (int i = 0; i < hardwareList.Count; i++) 
               {
                   Console.WriteLine(hardwareList[i]);
               }
               Console.ReadKey();  */

            Hashtable hardware = new Hashtable() { { 1, "Compact Disc" }, { 2, "DVD" }, { 3, "keyboard" }, { 4, "mouse" } };
            Console.WriteLine("List of keys");
            foreach (var k in hardware.Keys)
            { Console.WriteLine(k); }
            Console.WriteLine("List of values");
            foreach (var v in hardware.Values)
            { Console.WriteLine(v); }
            Console.WriteLine("Hardware key \t Name of Hardware");
            foreach (var k in hardware.Keys)
            {
                Console.WriteLine(k + "\t\t" + hardware[k]);
            }
            Console.ReadKey();
        }
    }
}

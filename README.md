# project 1
Описание решения:
Задаю изначальный массив
string[]array={"hello","244 ","33  ","bobro","333 ","2255","4444","   2"};
Задаю счетчики
int i= 0;
В count в конце цикла будет число элементов в массиве, содержащих три и менее символов
int count =0;
while(i<array.Length){
    if(array[i].Length<4){count++;}
    i++;}
Оператор If нужен для случая когда элементов, содержащих три и менее символов в массиве нет
if(count==0){Console.WriteLine("[]");}
else{
i=0;
Создание “заготовки” итогового массива с необходимым количеством элементов
string[]finalarray=new string[count+1];
count=0;
Цикл для формирования итогового массива
 со всеми элементами из изначального массива, содержащими 3 и менее символов
while(i<array.Length){
    if(array[i].Length<4){
        finalarray[count]=array[i];
        count++;}
    i++;}
i=0;
Команда для того чтобы вывод массива начинался с [
Console.Write("[");
Цикл для вывода элементов итогового массива кроме последнего с учетом пунктуации
while(i<finalarray.Length-2){
    Console.Write('"');
    Console.Write(finalarray[i]);
    Console.Write('"'+", ");
    i++;}
Команда для вывода массива без , после последнего элемента массива и для заканчивания вывода массива знаком ]
Console.Write('"'+finalarray[i]+'"'+"]");}

Блок-схема
![qZQSt_lI8gg](https://github.com/AlexandrMyasoedov/project1/assets/147836108/9a36ec12-5bc8-4b6b-bbee-1730980a3e58)


﻿string[]array={"hello","244 ","33  ","bobro","333 ","2255","4444","   2"};
int i= 0;
int count =0;
while(i<array.Length){
    if(array[i].Length<4){count++;}
    i++;}
i=0;
string[]finalarray=new string[count+1];
count=0;
while(i<array.Length){
    if(array[i].Length<4){
        finalarray[count]=array[i];
        count++;}
    i++;}

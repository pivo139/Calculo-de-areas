﻿using System;
class Program {
 public int multiplicar(int a , int b){
   int total= a * b;
   return total;
}

  public static void Main(string[]args){
    int areQuad, areaRet, lado, ladoMenor, ladoMaior, ba, altura, areaTri;
    Program exemplo = new Program();

    lado = 4;
    areQuad = exemplo.multiplicar(lado, lado);
    Console.WriteLine("O resultado da área do quadrado é: " + areQuad);

    ladoMaior = 5;
    ladoMenor = 4;
    areaRet = exemplo.multiplicar(ladoMaior,ladoMenor);
    Console.WriteLine("O resultado da área do retângulo é: "+ areaRet);

    ba = 10;
    altura = 8;
    areaTri = exemplo.multiplicar(ba,altura)/2;
    Console.WriteLine("O resultado da área do triângulo é: " + areaTri);
      
   }
  }
﻿namespace Day_6_efcore.Exceptions;
public class NotFoundException : Exception
{
public NotFoundException(int id) : base($"id si :{id}, olan tablonun verisi yok")
   {

   }

}

public class BusinessException: Exception
{

}
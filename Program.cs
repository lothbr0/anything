﻿using System;

public class Group
{
    public string GroupName()
    {
        return "TATA";
    }
}
public class CompanyFirst : Group
{
    public string CompanyName()
    {
        return " TCS";
    }
}
public class CompanySecond : Group
{
    public string CompanyName()
    {
        return "Tata Neo";
    }
}
public class CompanyThrid : Group
{
    public string CompanyName()
    {
        return "Tata Power";
    }
}
class groupist
{
    public static void Main(string[] args)  

    {
        CompanyFirst first = new CompanyFirst();
        Console.WriteLine(first.CompanyName() + "  " + first.GroupName());
        CompanySecond second = new CompanySecond();
        Console.WriteLine(second.CompanyName() + "  " + first.GroupName());
        CompanyThrid third = new CompanyThrid();
        Console.WriteLine(third.CompanyName() + "  " + first.GroupName());

    }
}
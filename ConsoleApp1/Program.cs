﻿using ConsoleApp.Model;
using ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        StringRequest stringRequest = new StringRequest()
        {
            N = 3,
            Strings = new List<string>()
            {
                "kkkjjffg5",
                "gxtjtmtywr",
                "hnlnxiupgt",
            }
        };
        try
        {
            foreach (var item in SortingOperationsHelper.SortingOperations(stringRequest))
            {
                Console.WriteLine($"Value: {item}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
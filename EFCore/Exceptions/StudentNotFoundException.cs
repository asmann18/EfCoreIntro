﻿namespace EFCore.Exceptions;

public class StudentNotFoundException:Exception
{

    public StudentNotFoundException():base("Student not found!.")
    {
            
    }
}

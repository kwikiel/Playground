using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

public class GradeSchool
{
    private readonly SortedList<string, int> _students = new SortedList<string, int>();
    public void Add(string student, int grade) => _students.Add(student,grade);

    public IEnumerable<string> Roster() =>
        from student in _students
        orderby student.Key, student.Value
        select student.Key;

    public IEnumerable<string> Grade(int grade) =>
        from student in _students
        orderby student.Value, student.Key
        where student.Value == grade
        select student.Key;
}
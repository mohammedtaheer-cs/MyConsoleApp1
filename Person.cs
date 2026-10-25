public class Person
{
    public int ID {get; set;}
    public string FarstName {get; set;}  = string.Empty;  
    public string LastName {get; set;}  = string.Empty;  
    public int Age 
    {
        get
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var age = today.Year - DateOfBirth.Year;
            if(DateOfBirth > today.AddYears(-age))
            {
                --age;
            }
            return age;
        }
    }
     public DateOnly DateOfBirth {get; set;}
     public string Nationality {get; set;}  = string.Empty;  
     public string PlaceOfBirth {get; set;}  = string.Empty;  
     public string Email {get; set;}  = string.Empty;  

}

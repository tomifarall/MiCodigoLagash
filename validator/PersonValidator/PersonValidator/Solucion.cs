using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PersonRepository.Interfaces;
using PersonRepository.Entities;
using System.Linq.Expressions;

class Solucion : IPersonRepositoryBasic , IPersonRepositoryAdvanced , IValidatorExpert
{
    public List<Person> People { get; set;}

    /* +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++  
        ++                                                                                ++
        ++                            BASIC SOLUTION                                      ++
        ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/ 

    private bool EmailValido(string email)
    {
        return EmailValidator.IsValidEmail(email);
    }

    public void Add(Person person)
    {   
        if (person.Age<=0 || !EmailValido(person.Email)) return;  
        foreach (Person persona in People){
            if (person.Id == persona.Id){
                return;
            }
        }
        People.Add(person);
    }

    public void Delete(int id) {
        People.RemoveAll(p => p.Id == id); 
    }

    public int GetCountRangeAges(int min, int max)
    {
       List<Person> Personas= People.FindAll(persona => (min<= persona.Age) && (persona.Age <= max));
       return Personas.Count(); 
    }

    public List<Person> GetFiltered(string name, int age, string email)
    {
           List <Person> Personas= People;     
            if ( name!= null && name!="" ){
              Personas= Personas.FindAll(persona => persona.Name == name); 
            }
            if ( age !=0 ){
               Personas= Personas.FindAll( persona => persona.Age == age);
            }
            if ( email != null && email!= ""){
               Personas= Personas.FindAll(persona =>  persona.Email.Contains(email));
            }
            return Personas; 
    }

    public Person GetPerson(int Id)
    {
        return People.Find( persona => persona.Id == Id);
    }

    public void Update(Person person){
        if (person.Age <=0 || !EmailValido(person.Email)) return;
        foreach (Person persona in People){
            if (persona.Id == person.Id){
                persona.Name = person.Name;
                persona.Age = person.Age;
                persona.Email = person.Email;
            }

        }
    }


 /* +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++  
    ++                                                                                 ++
    ++                            ADVANCE SOLUTION                                     ++
    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/

    bool EsNombreCapitalizado( string nombre) {
        foreach( string parteNombre in nombre.Split()){
            if ( !char.IsUpper(parteNombre, 0)) return false;
        }
        return true;
    }
    public int[] GetNotCapitalizedIds()
    {
        var NoCapitalizadas = People.Where(persona => !EsNombreCapitalizado(persona.Name));
        int[] Ids= new int[NoCapitalizadas.Count()];
        foreach(Person Persona in NoCapitalizadas){
            Ids.Append(Persona.Id);
        }
        return Ids;
    }


    private int GetCantNombres(string nombre){
        return nombre.Split().Count();
    }

    private List<String> GetValue(Dictionary <int,String[]> Dict , int key){
        List <String> value= new List <String>();
        String[] valor= null;
        if (!Dict.TryGetValue(key, out valor )) return value;
        return valor.ToList();
    }
    public Dictionary<int, string[]> GroupEmailByNameCount()
    {   
        Dictionary <int,String[]> Emails = new Dictionary<int,String[]>(); 
        foreach( Person persona in People){
            int CantNombres= GetCantNombres(persona.Name);
            var Valor= GetValue(Emails,CantNombres);
            Valor.Add(persona.Email);
            Emails[CantNombres] = Valor.ToArray();
        }
        return Emails; 
        
    }
      /*  public Dictionary<int, string[]> GroupEmailByNameCount1()
    {   
        Dictionary <int,String[]> Emails = new Dictionary<int,String[]>(); 
        foreach( Person persona in People){
            
            int CantNombres= GetCantNombres(persona.Name);
            if (Emails.TryGetValue(CantNombres, out Valor)){
                 Valor.Append(persona.Email);
                 Emails[CantNombres] = Valor;
            }
            else{
                Emails.Add(CantNombres,new String[])
            }
        }
        return Emails; 
        
    }*/



/*  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++  
    ++                                                                                ++
    ++                              EXPERT SOLUTION                                   ++
    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ */
   
    public bool Run(Person person, Expression<Func<Person, bool>> validation)
    {
        var Func=validation.Compile();
        return Func(person);
    }
}
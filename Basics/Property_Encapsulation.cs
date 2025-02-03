using System;
class phone{
    private string password;
    public string PWD{set{password = value;}} // encapsulation
    private bool isvalid = false;
    public bool Isvalid{
        get{
            return  isvalid; // readonly prperty
        }
    }
    private string Things;
    public string things{. // read and write property
        set{
            Things = value;
        }
        get{
            return Things;
        }
    }
    
    public void isvalidfnc(){
        if(password == "Key"){
            isvalid = true;
        }
    }
}
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    phone p = new phone();
    p.PWD = "Key";
    p.isvalidfnc();
    if(p.Isvalid){
        p.things = "wahtsapp";
    }
    Console.WriteLine(p.things);
  }
}



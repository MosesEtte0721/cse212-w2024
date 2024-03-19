using System;
using System.Collections.Generic;


public class Properties 
{
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public string place{get; set;}
    public double mag{get; set;}
    // public long time{get; set;}
    // public long updated{get; set;}
    
    // public string title{get; set;}
    // public string type{get; set;}

}

public class  Geometry
{
    public string type{get; set;}
    public List<double> coordinates{get; set;}
    public string id{get; set;}
    public string status{get; set;}
}

public class Features
{
    // public string type { get; set; }
    public Properties properties { get; set; }
    public Geometry geometry { get; set; }

    
}



public class FeatureCollection
{
    public List<Features> features {get; set;} 
}


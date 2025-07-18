using System.Collections.Generic;

using System.Text.Json.Serialization;


public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    public List<Feature> features { get; set; }

}
    // Create additional classes as necessary
    public class Feature
    {
        public Properties properties { get; set; }
    }

public class Properties
{
    public double? mag { get; set; }
    public string place { get; set; }
}


using System;
using System.Text.RegularExpressions;
using System.Drawing;

public class Map
{
    // set Variables for the Map Class
    private double _mapVersionID;
    private string _mapName;
    private string _mapDescription;
    private List<Chemical> _mapChemicals = new List<Chemical>();
    private double _mapScale;
    private string _mapImageLocationan;
    //protected Image _mapImage;
    private Person _HSEManager = new Person();
    private List<XYZInformation> _locationInfo = new List<XYZInformation>();
    
    //Image _siteImage = new Bitmap(image);

    public Map()
    {
        _mapChemicals = new List<Chemical>();
        _locationInfo = new List<XYZInformation>();
        _HSEManager = new Person();
    }


    public void LoadMaps()
    {
        //check for file if it does not exist return if it does exist load information
    }

    public void CreateMap()
    {
        //cuild a map through entering the necessary information

    }

    public void EditMap()
    {
        // change entries of a map
    }

    public void SaveMap()
    {
        // save the maps to a file
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemical_Release_Pathing
{
    public class Map
    {
        //private double _mapVersionID;
        private string _mapName;
        private string _mapDescription;
        private List<string> _mapChemicalNames;
        private double _mapScale;
        private string _mapImageLocation;
        private string _HSEManagerName;

/*        public double GetMapVersionID()
        {
            return _mapVersionID;
        }

        public void SetMapVersionID(double mapVersionID)
        {
            _mapVersionID = mapVersionID;
        }*/

        public string GetMapName()
        {
            return _mapName;
        }

        public void SetMapName(string mapName)
        {
            _mapName = mapName;
        }

        public string GetMapDescription()
        {
            return _mapDescription;
        }

        public void SetMapDescription(string mapDescription)
        {
            _mapDescription = mapDescription;
        }

        public List<string> GetMapChemicalNames()
        {
            return _mapChemicalNames;
        }

        public void SetMapChemicalNames(List<string> mapChemicalNames)
        {
            _mapChemicalNames = mapChemicalNames;
        }

        public double GetMapScale()
        {
            return _mapScale;
        }

        public void SetMapScale(double mapScale)
        {
            _mapScale = mapScale;
        }

        public string GetMapImageLocation()
        {
            return _mapImageLocation;
        }

        public void SetMapImageLocation(string mapImageLocation)
        {
            _mapImageLocation = mapImageLocation;
        }

        public string GetHSEManagerName()
        {
            return _HSEManagerName;
        }

        public void SetHSEManagerName(string HSEManagerName)
        {
            _HSEManagerName = HSEManagerName;
        }
    }
}

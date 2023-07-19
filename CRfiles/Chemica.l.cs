using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemical_Release_Pathing
{
    public class Chemical
    {

        //
        // set Variables for the Chemical Class
        private string _chemicalName;
        private double _specificGravity;
        private int _lethalPPM;
        private int _irritantPPM;
        private string _reaction;
        private string _toxicity;
        private double _vaporPressure;
        private int _flashPoint;
        //private int _storageTemperature;

        // Public methods to get and set the property values
        public string GetChemicalName()
        {
            return _chemicalName;
        }

        public void SetChemicalName(string chemicalName)
        {
            _chemicalName = chemicalName;
        }

        public double GetSpecificGravity()
        {
            return _specificGravity;
        }

        public void SetSpecificGravity(double specificGravity)
        {
            _specificGravity = specificGravity;
        }

        public int GetLethalPPM()
        {
            return _lethalPPM;
        }

        public void SetLethalPPM(int lethalPPM)
        {
            _lethalPPM = lethalPPM;
        }

        public int GetIrritantPPM()
        {
            return _irritantPPM;
        }

        public void SetIrritantPPM(int irritantPPM)
        {
            _irritantPPM = irritantPPM;
        }

        public string GetReaction()
        {
            return _reaction;
        }

        public void SetReaction(string reaction)
        {
            _reaction = reaction;
        }

        public string GetToxicity()
        {
            return _toxicity;
        }

        public void SetToxicity(string toxicity)
        {
            _toxicity = toxicity;
        }

        public double GetVaporPressure()
        {
            return _vaporPressure;
        }

        public void SetVaporPressure(double vaporPressure)
        {
            _vaporPressure = vaporPressure;
        }

        public int GetFlashPoint()
        {
            return _flashPoint;
        }

        public void SetFlashPoint(int flashPoint)
        {
            _flashPoint = flashPoint;
        }

      /*  public int GetStorageTemperature()
        {
            return _storageTemperature;
        }

        public void SetStorageTemperature(int storageTemperature)
        {
            _storageTemperature = storageTemperature;
        }*/


        public Chemical()
        {

        }

    }
}

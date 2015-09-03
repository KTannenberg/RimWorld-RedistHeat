﻿using Verse;

namespace RedistHeat
{
    public class AirNetTicker : MapComponent
    {
        public static bool doneInit;
        //private bool doneLoad;

        //private List<NetSaver> savers = new List<NetSaver>();
        
        public override void MapComponentUpdate()
        {
            if (!doneInit)
            {
                Initialize();
            }
            AirNetManager.AirNetsUpdate();
            AirNetManager.UpdateMapDrawer();
            
            /*
            if (!doneLoad)
            {
                RestoreTemperature();
            }*/
        }


        public override void MapComponentTick()
        {
            if (!doneInit)
            {
                Initialize();
            }
            AirNetManager.AirNetsTick();
        }

        public static void Initialize()
        {
            AirNetGrid.Reinit();
            AirNetManager.Reinit();
            Log.Message( "LT-RH: Initialized RedistHeat." );
            doneInit = true;
        }
    }
}

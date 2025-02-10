using LMS.DAL;
using LMS.MOD;
using System.Collections.Generic;
using System;

namespace LMS.BL
{
    public class VolumeBL
    {
        public static Volume Save(Volume volume, int volumeID = -1)
        {
            try
            {
                volume = VolumeDAL.Save(volume, volumeID);
                return volume;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Volume> Get(int volumeID = -1, string title = "", int journalID = -1)
        {
            try
            {
                List<Volume> volumes = VolumeDAL.Get(volumeID, title, journalID);
                return volumes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Volume GetByID(int volumeID)
        {
            try
            {
                Volume volume = VolumeDAL.GetByID(volumeID);
                return volume;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Volume Deactivate(Volume volume)
        {
            try
            {
                volume = VolumeDAL.Deactivate(volume);
                return volume;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Volume> GetByJournal(int journalID)
        {
            try
            {
                return VolumeDAL.GetByJournal(journalID);
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching volumes by journal: " + ex.Message);
            }
        }
    }
}

using System.Collections.Generic;

namespace KD.Robot
{
    /// <summary>
    /// Main class used for creating new Robots.
    /// </summary>
    public class KDRobotManager
    {
        /// <summary>
        /// Holds data about all created Robots.
        /// </summary>
        private static HashSet<KDRobot> robots = new HashSet<KDRobot>();

        /// <summary>
        /// Private constructor.
        /// </summary>
        private KDRobotManager() { }

        /// <summary>
        /// Returns new Robot.
        /// </summary>
        /// <returns></returns>
        public static KDRobot NewRobot()
        {
            KDRobot robot = new KDRobot();
            robots.Add(robot);
            return robot;
        }
    }
}
/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



namespace RosSharp.RosBridgeClient.MessageTypes.WozniakInterfaces
{
    public class HighlightObjectRequest : Message
    {
        public const string RosMessageName = "wozniak_interfaces/HighlightObject";

        public string target_object { get; set; }
        public string instruction { get; set; }

        public HighlightObjectRequest()
        {
            this.target_object = "";
            this.instruction = "";
        }

        public HighlightObjectRequest(string target_object, string instruction)
        {
            this.target_object = target_object;
            this.instruction = instruction;
        }
    }
}

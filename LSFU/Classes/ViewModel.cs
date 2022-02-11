using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSFU.Classes
{
    class ViewModel
    {
        Topic[] topics = new Topic[7];

        public ViewModel()
        {
            Topic tp1 = new Topic("What is Space?", Properties.Resources.tp1);
            Topic tp2 = new Topic("The Solar System", Properties.Resources.tp2);
            Topic tp3 = new Topic("The Sun", Properties.Resources.tp3);
            Topic tp4 = new Topic("The Earth", Properties.Resources.tp4);
            Topic tp5 = new Topic("Asteriod Belt", Properties.Resources.tp5);
            Topic tp6 = new Topic("Kuiper Belt", Properties.Resources.tp6);
            Topic tp7 = new Topic("Oort Cloud", Properties.Resources.tp7);
            
            topics[0] = tp1;
            topics[1] = tp2;
            topics[2] = tp3;
            topics[3] = tp4;
            topics[4] = tp5;
            topics[5] = tp6;
            topics[6] = tp7;
        }

        public Topic[] getTopics()
        {
            return topics;
        }
    }

    class Topic
    {
        public string Name;
        public string Data;

        public Topic(string topicName, string topicData)
        {
            Name = topicName;
            Data = topicData;
        }
    }
}
